﻿Imports System.ComponentModel

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
        TiMain.Start()
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
        TiMain.Stop()
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
        FrmUebersicht_Mannschaften.BsJuFla2Mannschaften.DataSource = Me.DtsJuFla.TblJuFla2Mannschaften
        FrmUebersicht_Mannschaften.BsJuFla3Mannschaften.DataSource = Me.DtsJuFla.TblJuFla3Mannschaften
        FrmUebersicht_Mannschaften.ShowDialog(Me)
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

    Private Sub TiMain_Tick(sender As Object, e As EventArgs) Handles TiMain.Tick
        TbJuFla2AnzMember.Text = DgvJuFla2Member.Rows.Count
    End Sub

    Private Sub WettbewerbseingabeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WettbewerbseingabeToolStripMenuItem.Click
        FrmWettbewerbseingabe.BsJuFla2Mannschaften.DataSource = Me.DtsJuFla.TblJuFla2Mannschaften
        FrmWettbewerbseingabe.ShowDialog(Me)
    End Sub

    Private Sub BtJuFla2AddMember_Click(sender As Object, e As EventArgs) Handles BtJuFla2AddMember.Click
        Dim sn As Integer = TbRoJuFla2Startnummer.Text
        Dim Name As String = InputBox("Name des Bewerbers", , "undefined")
        Dim Vorname As String = InputBox("Vorname des Bewerbers",, "undefinded")
        Dim Geschlecht As String = InputBox("Geschlecht des Bewerbers (m = männlich / w = weiblich",, "undefined")
        Dim Geburtsdatum As Date = InputBox("Geburtsdatum des Bewerbers (dd-mm-YYYY)",, "01.01.1900")
        Dim Ausweisnummer As Integer = InputBox("Ausweisnummer des Bewerbers",, "0")

        DtsJuFla.TblJuFla2Member.Rows.Add(Nothing, sn, Name, Vorname, Geschlecht, Geburtsdatum, Ausweisnummer, Nothing, Nothing, Nothing, Nothing, Name + ", " + Vorname)
    End Sub
End Class
