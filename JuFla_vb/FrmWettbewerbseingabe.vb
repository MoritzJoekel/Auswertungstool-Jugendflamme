Public Class FrmWettbewerbseingabe
    Private Sub TiMain_Tick(sender As Object, e As EventArgs) Handles TiMain.Tick
        If Not CbJuFla2Member.Text = "" And Not CbJuFla3Member.Text = "" Then

            Try
                If CheckJuFla(2) = True Then
                    LbStatus.Text = "BESTANDEN"
                    LbStatus.BackColor = Color.LightGreen
                    CbJuFla2Bestanden.Checked = True
                    BsJuFla2Member.Current(10) = True
                ElseIf CheckJuFla(2) = False Then
                    LbStatus.Text = "NICHT BESTANDEN"
                    LbStatus.BackColor = Color.Red
                    CbJuFla2Bestanden.Checked = False
                    BsJuFla2Member.Current(10) = False
                End If

                If CheckJuFla(3) = True Then
                    LbJuFla3Bestanden.Text = "BESTANDEN"
                    LbJuFla3Bestanden.BackColor = Color.LightGreen
                    CbJuFla3finished.Checked = True
                    BsJuFla3Member.Current(10) = True
                ElseIf CheckJuFla(3) = False Then
                    LbJuFla3Bestanden.Text = "NICHT BESTANDEN"
                    LbJuFla3Bestanden.BackColor = Color.Red
                    CbJuFla3finished.Checked = False
                    BsJuFla3Member.Current(10) = False
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub FrmWettbewerbseingabe_Load(sender As Object, e As EventArgs) Handles Me.Load

        TiMain.Start()
    End Sub

    Private Sub BtJuFla2ckeck_Click(sender As Object, e As EventArgs) Handles BtJuFla2ckeck.Click
        DtsJuFla.WriteXml(FrmMain.DataStream)
        FrmMain.RefreshData()
    End Sub

    ''' <summary>
    ''' Überprüft, ob Bedingungen erfüllt sind. Wenn ja wird finished in der Datenbank auf True gesetzt
    ''' </summary>
    ''' <param name="Stufe">Unterscheidung ob JuFla2 oder JuFla3 (2//3)</param>
    ''' <returns></returns>
    Private Function CheckJuFla(Stufe As Integer)
        If Stufe = 2 Then
            Dim ValJuFla2FwPrak As Integer

            Select Case TbJuFla2ValFwPrak.Text
                Case 1
                    ValJuFla2FwPrak = 50
                Case 2
                    ValJuFla2FwPrak = 40
                Case 3
                    ValJuFla2FwPrak = 30
                Case 4
                    ValJuFla2FwPrak = 20
                Case 5
                    ValJuFla2FwPrak = 10
                Case 6
                    ValJuFla2FwPrak = 0
            End Select

            If TbJuFla2ValFwPrak.Text <> "" Or TbJuFla2ValFwTheorie.Text <> "" Then
                Dim ValJuFla2Theorie As Integer = TbJuFla2ValFwTheorie.Text
                If (ValJuFla2FwPrak + ValJuFla2Theorie) >= 50 And CbJuFla2ValSport.Checked = True Then
                    Return True
                Else
                    Return False
                End If
            End If

        ElseIf Stufe = 3 Then
            Dim ValJuFla3EhAufgabe As Integer
            Select Case TbJuFla3ValEhAufgabe.Text
                Case 1
                    ValJuFla3EhAufgabe = 50
                Case 2
                    ValJuFla3EhAufgabe = 40
                Case 3
                    ValJuFla3EhAufgabe = 30
                Case 4
                    ValJuFla3EhAufgabe = 20
                Case 5
                    ValJuFla3EhAufgabe = 10
                Case 6
                    ValJuFla3EhAufgabe = 0
            End Select

            Dim ValJuFla3FwTechnik As Integer
            Select Case TbJuFla3FwTechnik.Text
                Case 1
                    ValJuFla3FwTechnik = 50
                Case 2
                    ValJuFla3FwTechnik = 40
                Case 3
                    ValJuFla3FwTechnik = 30
                Case 4
                    ValJuFla3FwTechnik = 20
                Case 5
                    ValJuFla3FwTechnik = 10
                Case 6
                    ValJuFla3FwTechnik = 0
            End Select

            Dim ValJuFla3Praesentation As Integer
            Select Case TbJuFla3ValPraesentation.Text
                Case 1
                    ValJuFla3Praesentation = 50
                Case 2
                    ValJuFla3Praesentation = 40
                Case 3
                    ValJuFla3Praesentation = 30
                Case 4
                    ValJuFla3Praesentation = 20
                Case 5
                    ValJuFla3Praesentation = 10
                Case 6
                    ValJuFla3Praesentation = 0
            End Select
            Dim ValJuFla3NachweisEH As Boolean = CbJuFla3NachweisEh.Checked

            If TbJuFla3ValEhAufgabe.Text <> "" Or TbJuFla3FwTechnik.Text <> "" Or TbJuFla3ValPraesentation.Text <> "" Then

                If (ValJuFla3EhAufgabe + ValJuFla3FwTechnik + ValJuFla3Praesentation) >= 50 And CbJuFla3NachweisEh.Checked = True Then
                    Return True
                Else
                    Return False
                End If
            End If

        End If

    End Function

    Private Sub BtJuFla3Check_Click(sender As Object, e As EventArgs) Handles BtJuFla3Check.Click
        DtsJuFla.WriteXml(FrmMain.DataStream)
        FrmMain.RefreshData()
    End Sub
End Class