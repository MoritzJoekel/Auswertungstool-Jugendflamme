Imports ClosedXML.Excel
Imports System.Data.OleDb
Imports System.IO

Public Class Import
    Public TblImport As New DataTable

    Public Sub Import_Controller()
        ImportFromExcel()
    End Sub
    Public Sub FormatMember()
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
        columns.Remove("F1")
        columns.Remove("F6")
        For columnIndex As Integer = 8 To 18
            columns.Remove("F" & columnIndex)
        Next
        FrmMain.DgvImport.DataSource = TblImport
        MemberImportJuFla2()
    End Sub

    Private Function ImportFromExcel()
        Dim OfdImport As OpenFileDialog = New OpenFileDialog With {
            .Filter = "Excel-Arbeitsmappen|*.xls; *.xlsx"
        }

        OfdImport.ShowDialog()
        Dim sourceFile = OfdImport.FileName
        Dim worksheetName = "Jugendflamme"
        Dim targetFile = FrmMain.HomeStream + "\Import.csv"

        Dim strConn As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & sourceFile & "; Extended Properties=Excel 12.0"
        Dim conn As OleDbConnection
        Dim wrtr As StreamWriter
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter

        Try
            conn = New OleDbConnection(strConn)
            conn.Open()
            cmd = New OleDbCommand("SELECT * FROM [" & worksheetName & "$]", conn) With {
                .CommandType = CommandType.Text
            }

            wrtr = New StreamWriter(targetFile)
            da = New OleDbDataAdapter(cmd)

            Dim dt As DataTable = New DataTable()

            da.Fill(dt)

            For x As Integer = 0 To dt.Rows.Count - 1
                Dim rowString As String = Nothing
                For y As Integer = 0 To dt.Columns.Count - 1
                    rowString &= dt.Rows(x)(y).ToString() & ";"
                Next y
                wrtr.WriteLine(rowString)
            Next x
            TblImport = dt
        Catch exc As Exception
            MessageBox.Show(exc.Message)

        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            wrtr.Close()
            FormatMember()
        End Try
        Return True

    End Function
    Private Sub MemberImportJuFla2()
        TblImport.AcceptChanges()
        Dim dts As DtsJuFla = New DtsJuFla
        For Each row As DataRow In TblImport.Rows

            Dim Name As String = row(0)
            Dim Vorname As String = row(1)
            Dim Geschlecht As String = row(2)
            Dim Geburtsdatum As Date = "02.01.1900"
            Dim Ausweisnummer As Integer = row(4)

            dts.TblJuFla2Member.Rows.Add(Nothing, FrmMain.TbRoJuFla2Startnummer.Text, Name, Vorname, Geschlecht, Geburtsdatum, Ausweisnummer, 0, 0, False, False, Name & ", " & Vorname)
        Next
    End Sub
End Class