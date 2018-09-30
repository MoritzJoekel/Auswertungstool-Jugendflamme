Imports System.ComponentModel

Public Class FrmMain
    Public HomeStream As String = Application.UserAppDataPath
    Public DataSteam As String = HomeStream + "\JuFla_Data.xml"
    Private Sub VeranstaltungsdatenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VeranstaltungsdatenToolStripMenuItem.Click
        FrmVeranstaltung.Show()
    End Sub
    ''' <summary>
    ''' Wird beim Laden der Anwendung aufgerufen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Init(True)
    End Sub
    Public Sub Init(LoadDb As Boolean)
        If LoadDb = False Then
            Me.Text = "Jugendflamme - Landkreis " & My.Settings.RsLandkreis & " in " & My.Settings.RsOrt
        ElseIf LoadDb = True Then
            Me.Text = "Jugendflamme - Landkreis " & My.Settings.RsLandkreis & " in " & My.Settings.RsOrt
            Try
                DtsJuFla.ReadXml(DataSteam)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub FrmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            DtsJuFla.WriteXml(DataSteam)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MannschaftStufe2HinzufügenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MannschaftStufe2HinzufügenToolStripMenuItem.Click
        Dim Startnummer As Integer = InputBox("Startnummer: (0 = Nummer wird automatisch generiert)", , 0)
        Dim Ort As String = InputBox("Ort: (Ort-Ortsteil)")

        If Startnummer = 0 Then
            Startnummer = DtsJuFla.TblJuFla2Mannschaften.Compute("Max(Startnummer)", Nothing) + 1
        End If
        Try
            DtsJuFla.TblJuFla2Mannschaften.Rows.Add(Nothing, Startnummer, Ort)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtJuFla2Mannschaftloeschen_Click(sender As Object, e As EventArgs) Handles BtJuFla2Mannschaftloeschen.Click
        Try
            For Each row As DataGridViewRow In DgvJuFla2Mannschaften.SelectedCells
                DgvJuFla2Mannschaften.Rows.Remove(row)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ÜbersichtMannschaftenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÜbersichtMannschaftenToolStripMenuItem.Click
        FrmUebersicht_Mannschaften.Show()
    End Sub

    Private Sub MannschaftStufe3HinzufügenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MannschaftStufe3HinzufügenToolStripMenuItem.Click
        Dim Startnummer As Integer = InputBox("Startnummer: (0 = Nummer wird automatisch generiert)", , 0)
        Dim Ort As String = InputBox("Ort: (Ort-Ortsteil)")

        If Startnummer = 0 Then
            If DtsJuFla.TblJuFla3Mannschaften.Compute("Max(Startnummer)", Nothing) IsNot DBNull.Value Then
                Startnummer = DtsJuFla.TblJuFla3Mannschaften.Compute("Max(Startnummer)", Nothing) + 1
            Else
                Startnummer = 1
            End If
        End If
            Try
            DtsJuFla.TblJuFla3Mannschaften.Rows.Add(Nothing, Startnummer, Ort)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
