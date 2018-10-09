Imports System.Net
Public Class Network
    Public Shared Function UploadToFTP()
        Try
            Dim serverAddress As String = "ftp://moritzjoekel.bplaced.net/JuFlaUpload.xml"
            Dim dts As DtsJuFla = New DtsJuFla()

            dts.WriteXml(FrmMain.DataStream)
            FrmMain.NiMain.BalloonTipText = "Upload initiiert! Server: " & serverAddress
            FrmMain.NiMain.ShowBalloonTip(2000)

            My.Computer.Network.UploadFile(FrmMain.DataStream, serverAddress, "moritzjoekel_jufla", "Ww5bTjPev6NHL4uZ")
            FrmMain.NiMain.BalloonTipText = "Upload abgeschlossen"
            FrmMain.NiMain.ShowBalloonTip(2000)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Function

    Public Shared Function DownloadFromFTP()
        Try
            Dim dts As DtsJuFla = New DtsJuFla()
            'My.Computer.FileSystem.CopyFile(FrmMain.DataStream, FrmMain.HomeStream + "\JuFla_Data_Backup.xml", True)
            dts.Clear()
            'My.Computer.FileSystem.DeleteFile(FrmMain.HomeStream + "\JuFla_Data_Down.xml")

            Dim serverAddress As String = "ftp://moritzjoekel.bplaced.net/JuFlaUpload.xml"

            FrmMain.NiMain.BalloonTipText = "Download initiiert! Server: " & serverAddress
            FrmMain.NiMain.ShowBalloonTip(2000)

            My.Computer.Network.DownloadFile(serverAddress, FrmMain.HomeStream + "\JuFla_Data_Down.xml", "moritzjoekel_jufla", "Ww5bTjPev6NHL4uZ")
            System.Threading.Thread.Sleep(2000)
            'My.Computer.FileSystem.RenameFile(FrmMain.HomeStream + "\JuFla_Data_Down.xml", "JuFla_Data.xml")
            dts.ReadXml(FrmMain.HomeStream + "\JuFla_Data_Down.xml")
            dts.AcceptChanges()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
End Class
