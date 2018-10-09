Imports System.ComponentModel
Imports DGVPrinterHelper
Imports System.Data.OleDb
Imports System.IO

Public Class FrmMain
    Public HomeStream As String = Application.UserAppDataPath ' --> Heimverzeichnis in AppData
    Public DataStream As String = HomeStream + "\JuFla_Data.xml" ' --> Speicherort der XML der Datenbank
    Public TblImport As DataTable ' --> Temporäre DataTable für Import aus Excel

    ''' <summary>
    ''' Ruft FrmVeranstaltungsdaten auf
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MsVeranstaltungsdaten_Show(sender As Object, e As EventArgs) Handles MsVeranstaltungsdaten.Click
        FrmVeranstaltung.BsEvents.DataSource = Me.DtsJuFla.TblEvents
        FrmVeranstaltung.Show(Me)
    End Sub
    ''' <summary>
    ''' Wird beim Laden der Anwendung aufgerufen, startet den Timer und ruft Initialisierung auf
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init(True)
        TiMain.Start()
        MsCbVeranstaltung.ComboBox.DataSource = BsEvents
        MsCbVeranstaltung.ComboBox.DisplayMember = "EventID"

        If MsCbVeranstaltung.ComboBox.Items.Count = 0 Then
            MsVeranstaltungsdaten_Show(Nothing, Nothing)
            MsgBox("Sind keine Veranstaltungsdaten vorhanden! Legen sie eine Veranstaltung an!", MsgBoxStyle.Exclamation)

        End If
    End Sub

    ''' <summary>
    ''' Initialisiert FrmMain, Title passt sich dem Wettbewerb an, wenn LoadDb = True wird die Datenbank aus der XML geladen
    ''' --> Muss Public sein, da sie von Veranstaltungsdaten aufgerufen wird
    ''' </summary>
    ''' <param name="LoadDb">Unterscheidung, ob Datenbank geladen werden soll (True//False)</param>
    Public Sub Init(LoadDb As Boolean)
        If LoadDb = True Then
            Try
                DtsJuFla.ReadXml(DataStream)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Wird beim Schließen des Formulars aufgerufen, schreibt DtsJuFla in XML in den Homestream
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmMain_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        Try
            DtsJuFla.WriteXml(DataStream)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        TiMain.Stop()
    End Sub

    ''' <summary>
    ''' Aktualisiert die Member-Tabellen von FrmMain
    ''' </summary>
    Public Sub RefreshData()
        DgvJuFla2Member.Refresh()
        DgvJuFla3Member.Refresh()
    End Sub

    ''' <summary>
    ''' Fügt eine Mannschaft zum Wettkampf hinzu, Abfrage Startnummer, Ortsbezeichnung
    ''' </summary>
    ''' <param name="Stufe">Unterscheidung ob JuFla2 oder JuFla3 (2//3)</param>
    Private Sub AddMannschaft(Stufe As Integer)
        Try
            Dim Startnummer As Integer = InputBox("Startnummer: (0 = Nummer wird automatisch generiert)", , 0)
            Dim Ort As String = InputBox("Ort: (Ort-Ortsteil)")
            Dim EventID As String = MsCbVeranstaltung.Text

            If Stufe = 2 Then
                If Startnummer = 0 Then
                    If DtsJuFla.TblJuFla2Mannschaften.Compute("Max(Startnummer)", Nothing) Is DBNull.Value Then
                        Startnummer = 1
                    Else
                        Startnummer = DtsJuFla.TblJuFla2Mannschaften.Compute("Max(Startnummer)", Nothing) + 1
                    End If
                End If
                DtsJuFla.TblJuFla2Mannschaften.Rows.Add(Nothing, Startnummer, Ort, EventID)
            ElseIf Stufe = 3 Then
                If Startnummer = 0 Then
                    If DtsJuFla.TblJuFla3Mannschaften.Compute("Max(Startnummer)", Nothing) Is DBNull.Value Then
                        Startnummer = 1
                    Else
                        Startnummer = DtsJuFla.TblJuFla3Mannschaften.Compute("Max(Startnummer)", Nothing) + 1
                    End If
                End If
                DtsJuFla.TblJuFla3Mannschaften.Rows.Add(Nothing, Startnummer, Ort, EventID)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    ''' <summary>
    ''' Ruft die Mannschaftsübersicht auf, übergibt Datenquellen an FrmUebersichtMannschaften
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub UebersichtMannschaften_Show(sender As Object, e As EventArgs) Handles MsUebersichtMannschaften.Click
        FrmUebersicht_Mannschaften.BsJuFla2Mannschaften.DataSource = Me.DtsJuFla.TblJuFla2Mannschaften
        FrmUebersicht_Mannschaften.BsJuFla3Mannschaften.DataSource = Me.DtsJuFla.TblJuFla3Mannschaften
        FrmUebersicht_Mannschaften.ShowDialog(Me)
    End Sub

    ''' <summary>
    ''' Überprüft im 100ms-Interval die Anzahl der Mitglieder einer Mannschaft, aktualisiert DgvMember
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TiMain_Tick(sender As Object, e As EventArgs) Handles TiMain.Tick
        TbJuFla2AnzMember.Text = DgvJuFla2Member.Rows.Count
        TbJuFla3AnzBewerber.Text = DgvJuFla3Member.Rows.Count
    End Sub

    ''' <summary>
    ''' Ruft die Wettbewerbseingabe auf, übergibt Datenquellen an FrmWettbewerbseingabe
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Wettbewerbseingabe_Show(sender As Object, e As EventArgs) Handles MsWettbewerbseingabe.Click
        FrmWettbewerbseingabe.BsJuFla2Mannschaften.DataSource = Me.DtsJuFla.TblJuFla2Mannschaften
        FrmWettbewerbseingabe.BsJuFla3Mannschaften.DataSource = Me.DtsJuFla.TblJuFla3Mannschaften
        FrmWettbewerbseingabe.ShowDialog(Me)
    End Sub

    ''' <summary>
    ''' Leert die aktuelle Datenbank, legt eine Backup-XML an
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DtsJuFla_Clear(sender As Object, e As EventArgs) Handles MsDtsLeeren.Click
        Dim Result As MsgBoxResult = MsgBox("Wollen sie die Datenbank wirklich leeren?? (Backup wird erstellt)", MsgBoxStyle.YesNo)
        If Result = MsgBoxResult.Yes Then
            My.Computer.FileSystem.CopyFile(DataStream, HomeStream + "\JuFla_Data_Backup.xml", True)
            DtsJuFla.Clear()
            My.Computer.FileSystem.DeleteFile(DataStream)
        End If
    End Sub

    ''' <summary>
    ''' Manuelles Hinzufügen von Mitgliedern in die ausgewählte Mannschaft
    ''' </summary>
    ''' <param name="Stufe">Unterscheidung ob JuFla2 oder JuFla3 (2//3)</param>
    Private Sub AddMember(Stufe As Integer)
        If Stufe = 2 Then
            Try
                Dim sn As Integer = TbRoJuFla2Startnummer.Text
                Dim Name As String = InputBox("Name des Bewerbers", , "undefined")
                Dim Vorname As String = InputBox("Vorname des Bewerbers",, "undefinded")
                Dim Geschlecht As String = InputBox("Geschlecht des Bewerbers (m = männlich / w = weiblich",, "undefined")
                Dim Geburtsdatum As Date = InputBox("Geburtsdatum des Bewerbers (dd-mm-YYYY)",, "01.01.1900")
                Dim Ausweisnummer As Integer = InputBox("Ausweisnummer des Bewerbers",, "0")

                DtsJuFla.TblJuFla2Member.Rows.Add(Nothing, sn, Name, Vorname, Geschlecht, Geburtsdatum, Ausweisnummer, 0, 0, False, False, Name + ", " + Vorname)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf Stufe = 3 Then
            Try
                Dim sn As Integer = TbJuFla3Startnummer.Text
                Dim Name As String = InputBox("Name des Bewerbers", , "undefined")
                Dim Vorname As String = InputBox("Vorname des Bewerbers",, "undefinded")
                Dim Geschlecht As String = InputBox("Geschlecht des Bewerbers (m = männlich / w = weiblich",, "undefined")
                Dim Geburtsdatum As Date = InputBox("Geburtsdatum des Bewerbers (dd-mm-YYYY)",, "01.01.1900")
                Dim Ausweisnummer As Integer = InputBox("Ausweisnummer des Bewerbers",, "0")

                DtsJuFla.TblJuFla3Member.Rows.Add(Nothing, sn, Name, Vorname, Geschlecht, Geburtsdatum, Ausweisnummer, 0, 0, 0, False, Name + ", " + Vorname, False)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    ''' <summary>
    ''' Druckt Listen der Member der ausgewählten Mannschaft
    ''' </summary>
    ''' <param name="Stufe">Unterscheidung ob JuFla2 oder JuFla3 (2//3)</param>
    Private Sub PrintMember(Stufe As Integer)
        If Stufe = 2 Then

            Dim printer As DGVPrinter = New DGVPrinter With {
                .Title = "Jugendflamme Stufe 2",
                .SubTitle = "Teilnehmer der Mannschaft: " & CbJuFla2Ort.Text & " (" & TbRoJuFla2Startnummer.Text & ")",
                .KeepRowsTogether = True,
                .Footer = System.DateTime.Now.ToString,
                .PageText = "Anzahl Bewerber: " & TbJuFla2AnzMember.Text,
                .PageNumbers = False,
                .ColumnWidth = DGVPrinter.ColumnWidthSetting.DataWidth
            }
            printer.PrintDataGridView(DgvJuFla2Member)

        ElseIf Stufe = 3 Then

            Dim printer As DGVPrinter = New DGVPrinter With {
                .Title = "Jugendflamme Stufe 3",
                .SubTitle = "Teilnehmer der Mannschaft: " & CbJuFla3Mannschaft.Text & " (" & TbJuFla3Startnummer.Text & ")",
                .Footer = System.DateTime.Now.ToString,
                .PageText = "Anzahl Bewerber: " & TbJuFla3AnzBewerber.Text,
                .PageNumbers = False,
                .ColumnWidth = DGVPrinter.ColumnWidthSetting.DataWidth
            }
            printer.PrintDataGridView(DgvJuFla3Member)
        End If
    End Sub

    ''' <summary>
    ''' Behandelt alle Click-Ereignisse auf FrmMain
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AnyButton_Click(sender As Object, e As EventArgs) Handles BtJuFla2Import.Click, BtJuFla3Import.Click, MsJuFla2AddMannschaft.Click, MsJuFla3AddMannschaft.Click, MsWettbInfo.Click, MsExport.Click,
        BtJuFla2PrintMember.Click, BtJuFla3PrintMember.Click, BtJuFla2AddMember.Click, BtJuFla3AddMember.Click, CmsJuFla2RemoveMember.Click, CmsJuFla3RemoveMember.Click, MsUpload.Click, MsDownload.Click
        Select Case True
            Case sender Is BtJuFla2Import : Import(2)
            Case sender Is BtJuFla3Import : Import(3)
            Case sender Is BtJuFla2PrintMember : PrintMember(2)
            Case sender Is BtJuFla3PrintMember : PrintMember(3)
            Case sender Is BtJuFla2AddMember : AddMember(2)
            Case sender Is BtJuFla3AddMember : AddMember(3)
            Case sender Is CmsJuFla2RemoveMember : RemoveMember(2)
            Case sender Is CmsJuFla3RemoveMember : RemoveMember(3)
            Case sender Is MsJuFla2AddMannschaft : AddMannschaft(2)
            Case sender Is MsJuFla3AddMannschaft : AddMannschaft(3)
            Case sender Is MsUpload : UploadToFTP()
            Case sender Is MsDownload : DownloadFromFTP()
            Case sender Is MsWettbInfo
            Case sender Is MsExport : LocalExport()
        End Select
    End Sub

    ''' <summary>
    ''' Ruft einen FileDialog zum Import auf und importiert Daten aus Excel in die entsprechende Member-Datentabelle
    ''' </summary>
    ''' <param name="Stufe">Unterscheidung ob JuFla2 oder JuFla3 (2//3)</param>
    Public Sub Import(Stufe As Integer)

        ' Dialog zum Auswählen der Excel-Datei aufrufen
        Dim OfdImport As OpenFileDialog = New OpenFileDialog With {
            .Filter = "Excel-Arbeitsmappen|*.xls; *.xlsx"
        }
        OfdImport.ShowDialog()

        Dim sourceFile = OfdImport.FileName
        If sourceFile = "" Then
            Exit Sub
        End If

        ' Konvertierung von Excel zu .CSV
        Dim worksheetName = "Jugendflamme"
        Dim targetFile = HomeStream + "\Import_temp.csv"

        Dim strConn As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & sourceFile & "; Extended Properties=Excel 12.0"
        Dim conn As OleDbConnection
        Dim wrtr As StreamWriter
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter

        ' Neue Verbindung mittels OleDb, CSV schreiben
        Try
            conn = New OleDbConnection(strConn)
            conn.Open()
            cmd = New OleDbCommand("SELECT * FROM [" & worksheetName & "$]", conn) With {
                .CommandType = CommandType.Text
            }
            wrtr = New StreamWriter(targetFile)
            da = New OleDbDataAdapter(cmd)

            TblImport = New DataTable()
            da.Fill(TblImport)

            For x As Integer = 0 To TblImport.Rows.Count - 1
                Dim rowString As String = Nothing
                For y As Integer = 0 To TblImport.Columns.Count - 1
                    rowString &= TblImport.Rows(x)(y).ToString() & ";"
                Next y
                wrtr.WriteLine(rowString)
            Next x


        Catch exc As Exception
            MessageBox.Show(exc.Message)

        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            If wrtr.BaseStream.ToString <> "" Then
                wrtr.Close()
                My.Computer.FileSystem.DeleteFile(targetFile)
            End If
        End Try

        ' Importierte Tabelle manipulieren, auf gewünschte Informationen zuschneiden
        For rowIndex As Integer = 0 To 7
            TblImport.Rows(rowIndex).Delete()
        Next
        Dim TotalRows As Integer = TblImport.Rows.Count

        For rowIndex As Integer = TotalRows - 4 To TotalRows - 1
            TblImport.Rows(rowIndex).Delete()
        Next

        Dim columns As DataColumnCollection = TblImport.Columns
        Dim Totalcolums As Integer = TblImport.Columns.Count
        Dim Data = TblImport

        '9 - Stufe 2 // 10 - Stufe 3
        columns.Remove("F1") ' Entferne (Spalte) laufende Nummer
        columns.Remove("F6") ' Entferne (Spalte) Abnahmedatum

        ' Entferne alle restlichen Spalten
        For columnIndex As Integer = 8 To 18
            columns.Remove("F" & columnIndex)
        Next

        TblImport.AcceptChanges()

        ' Unterscheidung ob für Stufe 2 oder Stufe 3 importiert werden soll
        If Stufe = 2 Then

            ' Durchlaufe alle Zeilen der Tabelle und sortiere Informationen ein
            For Each row As DataRow In TblImport.Rows

                Dim Name As String = row(0)
                Dim Vorname As String = row(1)
                Dim Geschlecht As String = row(2)
                Dim Geburtsdatum As Date = row(3).ToString
                Dim Ausweisnummer As Integer = row(4)

                If ExactAge(Geburtsdatum) < 13 Then
                    MsgBox("Bewerber " & Name & ", " & Vorname & ", geboren am " & Geburtsdatum.ToShortDateString & " ist am Abnahmetag jünger als 13 Jahre, wird nicht als Bewerber erfasst!", MsgBoxStyle.Critical)
                    Continue For
                End If

                ' Erstellt eine neue Row in JuFla2Member in der Datenbank // ComboName wird in Dataset per Expression generiert
                DtsJuFla.TblJuFla2Member.Rows.Add(Nothing, TbRoJuFla2Startnummer.Text, Name, Vorname, Geschlecht, Geburtsdatum, Ausweisnummer, 0, 0, False, False, Nothing)
            Next

        ElseIf Stufe = 3 Then

            ' Durchlaufe alle Zeilen der Tabelle und sortiere Informationen ein
            For Each row As DataRow In TblImport.Rows

                Dim Name As String = row(0)
                Dim Vorname As String = row(1)
                Dim Geschlecht As String = row(2)
                Dim Geburtsdatum As Date = row(3).ToString
                Dim Ausweisnummer As Integer = row(4)

                If ExactAge(Geburtsdatum) < 15 Then
                    MsgBox("Bewerber " & Name & ", " & Vorname & ", geboren am " & Geburtsdatum.ToShortDateString & " ist am Abnahmetag jünger als 15 Jahre, wird nicht als Bewerber erfasst!", MsgBoxStyle.Critical)
                    Continue For
                End If

                ' Erstellt eine neue Row in JuFla3Member in der Datenbank // ComboName wird in Dataset per Expression generiert
                DtsJuFla.TblJuFla3Member.Rows.Add(Nothing, TbJuFla3Startnummer.Text, Name, Vorname, Geschlecht, Geburtsdatum, Ausweisnummer, 0, 0, 0, False, Nothing, False)
            Next
        End If
    End Sub

    ''' <summary>
    ''' Behandelt Context-Menustrip-Ereignis zum Entfernen des ausgewählten Members
    ''' </summary>
    ''' <param name="Stufe">Unterscheidung ob JuFla2 oder JuFla3 (2//3)</param>
    Private Sub RemoveMember(Stufe As Integer)
        If Stufe = 2 Then
            Try
                Dim index As Integer = DgvJuFla2Member.CurrentCell.RowIndex
                Dim result As MsgBoxResult = MsgBox("Bewerber " & DgvJuFla2Member.Rows(index).Cells(2).Value.ToString & " wirklich entfernen?", MsgBoxStyle.YesNo)
                If result = MsgBoxResult.Yes Then
                    DgvJuFla2Member.Rows.RemoveAt(index)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf Stufe = 3 Then

            Try
                Dim index As Integer = DgvJuFla3Member.CurrentCell.RowIndex
                Dim result As MsgBoxResult = MsgBox("Bewerber " & DgvJuFla3Member.Rows(index).Cells(0).Value.ToString & " wirklich entfernen?", MsgBoxStyle.YesNo)
                If result = MsgBoxResult.Yes Then
                    DgvJuFla3Member.Rows.RemoveAt(index)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Berechnet exaktes Alter am Abnahmetag
    ''' </summary>
    ''' <param name="Birthday">Zu prüfendes Geburtsdatum</param>
    ''' <returns>Alter in Jahren</returns>
    Private Function ExactAge(ByVal Birthday As System.DateTime) As Integer
        Dim nMonth As Integer
        Dim nYears As Integer
        Dim Abnahmedatum As Date = TbAbnahmedatum.Text

        ' Alter (Jahre) anhand Monatsdifferenz / 12 ermitteln
        nYears = Math.Floor(DateDiff(DateInterval.Month, Birthday, Abnahmedatum) / 12)

        ' Wenn Geburtsmonat = aktueller Monat
        ' Prüfen, ob Geburstag schon war oder noch kommt
        ' und ggf. das Alter um 1 Jahr verringern
        nMonth = DatePart(DateInterval.Month, Birthday)

        If nMonth = DatePart(DateInterval.Month, Abnahmedatum) Then
            If DatePart(DateInterval.Day, Birthday) > DatePart(DateInterval.Day, Abnahmedatum) Then
                nYears += -1
            End If
        End If

        Return nYears
    End Function

    ''' <summary>
    ''' Exportiert die Datenbank-XML in ein variables Verzeichnis. Ruft einen SaveFileDialog auf
    ''' </summary>
    Private Sub LocalExport()
        Try
            Dim sfd As SaveFileDialog = New SaveFileDialog With {
                .DefaultExt = ".xml",
                .AddExtension = True,
                .FileName = "JuFla_Data_Export_" & DateAndTime.Now.ToShortDateString & ".xml",
                .Filter = "Extensible Markup Language | .xml"
            }

            Dim savepath As String = sfd.FileName()
            Dim result As DialogResult = sfd.ShowDialog()
            If result <> DialogResult.OK Then
                Exit Sub
            End If

            DtsJuFla.WriteXml(savepath)
            NiMain.BalloonTipText = "Datenbank erfolgreich nach " & savepath & " exportiert."
            NiMain.ShowBalloonTip(2000)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Läd die Datenbank-XML vom definierten Server herunter und läd die Db neu
    ''' </summary>
    Private Sub DownloadFromFTP()
        Try
            My.Computer.FileSystem.CopyFile(DataStream, HomeStream + "\JuFla_Data_Backup.xml", True)
            DtsJuFla.Clear()

            If My.Computer.FileSystem.FileExists(HomeStream + "\JuFla_Data_Down.xml") Then
                My.Computer.FileSystem.DeleteFile(HomeStream + "\JuFla_Data_Down.xml")
            End If

            Dim serverAddress As String = "ftp://moritzjoekel.bplaced.net/JuFlaUpload.xml"

            NiMain.BalloonTipText = "Download initiiert! Server: " & serverAddress
            NiMain.ShowBalloonTip(2000)

            My.Computer.Network.DownloadFile(serverAddress, HomeStream + "\JuFla_Data_Down.xml", "moritzjoekel_jufla", "Ww5bTjPev6NHL4uZ")

            System.Threading.Thread.Sleep(2000)

            DtsJuFla.ReadXml(HomeStream + "\JuFla_Data_Down.xml")
            DtsJuFla.AcceptChanges()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Läd die bestehende Datenbank-XML auf einen definierten Server hoch
    ''' </summary>
    Private Sub UploadToFTP()
        Try
            Dim serverAddress As String = "ftp://moritzjoekel.bplaced.net/JuFlaUpload.xml"

            DtsJuFla.WriteXml(DataStream)
            NiMain.BalloonTipText = "Upload initiiert! Server: " & serverAddress
            NiMain.ShowBalloonTip(2000)

            My.Computer.Network.UploadFile(DataStream, serverAddress, "moritzjoekel_jufla", "Ww5bTjPev6NHL4uZ")
            NiMain.BalloonTipText = "Upload abgeschlossen"
            NiMain.ShowBalloonTip(2000)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
End Class