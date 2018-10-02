Imports JuFla_vb.DtsJuFla
Imports DGVPrinterHelper
Public Class FrmUebersicht_Mannschaften

    Private Sub StartlisteStufe3DruckenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartlisteStufe3DruckenToolStripMenuItem.Click
        Dim printer As DGVPrinter = New DGVPrinter With {
            .Title = "Jugendflamme Stufe 3",
            .SubTitle = "Startliste",
            .PorportionalColumns = True,
            .Footer = System.DateTime.Now.ToString
            }
        printer.PrintDataGridView(DgvJuFla3Mannschaften)
    End Sub

    Private Sub StartlisteStufe2DruckenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartlisteStufe2DruckenToolStripMenuItem.Click
        Dim printer As DGVPrinter = New DGVPrinter With {
            .Title = "Jugendflamme Stufe 2",
            .SubTitle = "Startliste",
            .PorportionalColumns = True,
            .Footer = System.DateTime.Now.ToString
        }
        printer.PrintDataGridView(DgvJuFla2Mannschaften)
    End Sub

    Private Sub FensterSchließenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FensterSchließenToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class