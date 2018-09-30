Public Class FrmVeranstaltung
    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        My.Settings.Save()
        FrmMain.FrmMain_Load(Nothing, Nothing)
        Me.Close()
    End Sub
End Class