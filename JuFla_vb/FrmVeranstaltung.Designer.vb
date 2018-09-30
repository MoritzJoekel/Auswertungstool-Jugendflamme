<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVeranstaltung
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DpDatum = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbAbnahmeleiter = New System.Windows.Forms.TextBox()
        Me.TbOrt = New System.Windows.Forms.TextBox()
        Me.TbLandkreis = New System.Windows.Forms.TextBox()
        Me.TbBundesland = New System.Windows.Forms.TextBox()
        Me.BtSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Veranstaltungsdatum"
        '
        'DpDatum
        '
        Me.DpDatum.Location = New System.Drawing.Point(139, 20)
        Me.DpDatum.Name = "DpDatum"
        Me.DpDatum.Size = New System.Drawing.Size(200, 20)
        Me.DpDatum.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Bundesland"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Landkreis"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Veranstaltungsort"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Abnahmeleiter"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TbAbnahmeleiter
        '
        Me.TbAbnahmeleiter.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.JuFla_vb.My.MySettings.Default, "RsAbnahmeleiter", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TbAbnahmeleiter.Location = New System.Drawing.Point(139, 298)
        Me.TbAbnahmeleiter.Name = "TbAbnahmeleiter"
        Me.TbAbnahmeleiter.Size = New System.Drawing.Size(200, 20)
        Me.TbAbnahmeleiter.TabIndex = 9
        Me.TbAbnahmeleiter.Text = Global.JuFla_vb.My.MySettings.Default.RsAbnahmeleiter
        '
        'TbOrt
        '
        Me.TbOrt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.JuFla_vb.My.MySettings.Default, "RsOrt", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TbOrt.Location = New System.Drawing.Point(139, 182)
        Me.TbOrt.Name = "TbOrt"
        Me.TbOrt.Size = New System.Drawing.Size(200, 20)
        Me.TbOrt.TabIndex = 7
        Me.TbOrt.Text = Global.JuFla_vb.My.MySettings.Default.RsOrt
        '
        'TbLandkreis
        '
        Me.TbLandkreis.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.JuFla_vb.My.MySettings.Default, "RsLandkreis", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TbLandkreis.Location = New System.Drawing.Point(139, 126)
        Me.TbLandkreis.Name = "TbLandkreis"
        Me.TbLandkreis.Size = New System.Drawing.Size(200, 20)
        Me.TbLandkreis.TabIndex = 5
        Me.TbLandkreis.Text = Global.JuFla_vb.My.MySettings.Default.RsLandkreis
        '
        'TbBundesland
        '
        Me.TbBundesland.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.JuFla_vb.My.MySettings.Default, "RsBundesland", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TbBundesland.Location = New System.Drawing.Point(139, 71)
        Me.TbBundesland.Name = "TbBundesland"
        Me.TbBundesland.Size = New System.Drawing.Size(200, 20)
        Me.TbBundesland.TabIndex = 3
        Me.TbBundesland.Text = Global.JuFla_vb.My.MySettings.Default.RsBundesland
        '
        'BtSave
        '
        Me.BtSave.Image = Global.JuFla_vb.My.Resources.Resources.icon_checked
        Me.BtSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtSave.Location = New System.Drawing.Point(221, 424)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(148, 34)
        Me.BtSave.TabIndex = 10
        Me.BtSave.Text = "Veranstaltung erstellen"
        Me.BtSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtSave.UseVisualStyleBackColor = True
        '
        'FrmVeranstaltung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 480)
        Me.Controls.Add(Me.BtSave)
        Me.Controls.Add(Me.TbAbnahmeleiter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TbOrt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TbLandkreis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbBundesland)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DpDatum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmVeranstaltung"
        Me.Text = "FrmVeranstaltung"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DpDatum As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TbBundesland As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbLandkreis As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbOrt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbAbnahmeleiter As TextBox
    Friend WithEvents BtSave As Button
End Class
