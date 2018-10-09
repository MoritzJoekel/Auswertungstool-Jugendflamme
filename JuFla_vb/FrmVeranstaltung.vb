Public Class FrmVeranstaltung
    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        My.Settings.Save()
        FrmMain.Init(False)
        Me.Close()
    End Sub

End Class