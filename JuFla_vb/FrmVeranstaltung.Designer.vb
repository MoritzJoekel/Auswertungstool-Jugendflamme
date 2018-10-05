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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtSave = New System.Windows.Forms.Button()
        Me.TbAbnahmeleiter = New System.Windows.Forms.TextBox()
        Me.TbOrt = New System.Windows.Forms.TextBox()
        Me.TbLandkreis = New System.Windows.Forms.TextBox()
        Me.TbBundesland = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DtsJuFla = New JuFla_vb.DtsJuFla()
        Me.BsEvents = New System.Windows.Forms.BindingSource(Me.components)
        Me.EventIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbnahmeortDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbnahmedatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbnahmeleiterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LandkreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsJuFla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsEvents, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label5.Location = New System.Drawing.Point(13, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Abnahmeleiter"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtSave
        '
        Me.BtSave.Image = Global.JuFla_vb.My.Resources.Resources.icon_checked
        Me.BtSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtSave.Location = New System.Drawing.Point(823, 451)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(148, 34)
        Me.BtSave.TabIndex = 10
        Me.BtSave.Text = "Veranstaltung erstellen"
        Me.BtSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtSave.UseVisualStyleBackColor = True
        '
        'TbAbnahmeleiter
        '
        Me.TbAbnahmeleiter.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.JuFla_vb.My.MySettings.Default, "RsAbnahmeleiter", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TbAbnahmeleiter.Location = New System.Drawing.Point(139, 225)
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
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.JuFla_vb.My.MySettings.Default, "RsDatum", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Location = New System.Drawing.Point(139, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = Global.JuFla_vb.My.MySettings.Default.RsDatum
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EventIDDataGridViewTextBoxColumn, Me.AbnahmeortDataGridViewTextBoxColumn, Me.AbnahmedatumDataGridViewTextBoxColumn, Me.AbnahmeleiterDataGridViewTextBoxColumn, Me.LandDataGridViewTextBoxColumn, Me.LandkreisDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BsEvents
        Me.DataGridView1.Location = New System.Drawing.Point(397, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(559, 395)
        Me.DataGridView1.TabIndex = 12
        '
        'DtsJuFla
        '
        Me.DtsJuFla.DataSetName = "DtsJuFla"
        Me.DtsJuFla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BsEvents
        '
        Me.BsEvents.DataMember = "TblEvents"
        Me.BsEvents.DataSource = Me.DtsJuFla
        '
        'EventIDDataGridViewTextBoxColumn
        '
        Me.EventIDDataGridViewTextBoxColumn.DataPropertyName = "EventID"
        Me.EventIDDataGridViewTextBoxColumn.HeaderText = "EventID"
        Me.EventIDDataGridViewTextBoxColumn.Name = "EventIDDataGridViewTextBoxColumn"
        '
        'AbnahmeortDataGridViewTextBoxColumn
        '
        Me.AbnahmeortDataGridViewTextBoxColumn.DataPropertyName = "Abnahmeort"
        Me.AbnahmeortDataGridViewTextBoxColumn.HeaderText = "Abnahmeort"
        Me.AbnahmeortDataGridViewTextBoxColumn.Name = "AbnahmeortDataGridViewTextBoxColumn"
        '
        'AbnahmedatumDataGridViewTextBoxColumn
        '
        Me.AbnahmedatumDataGridViewTextBoxColumn.DataPropertyName = "Abnahmedatum"
        Me.AbnahmedatumDataGridViewTextBoxColumn.HeaderText = "Abnahmedatum"
        Me.AbnahmedatumDataGridViewTextBoxColumn.Name = "AbnahmedatumDataGridViewTextBoxColumn"
        '
        'AbnahmeleiterDataGridViewTextBoxColumn
        '
        Me.AbnahmeleiterDataGridViewTextBoxColumn.DataPropertyName = "Abnahmeleiter"
        Me.AbnahmeleiterDataGridViewTextBoxColumn.HeaderText = "Abnahmeleiter"
        Me.AbnahmeleiterDataGridViewTextBoxColumn.Name = "AbnahmeleiterDataGridViewTextBoxColumn"
        '
        'LandDataGridViewTextBoxColumn
        '
        Me.LandDataGridViewTextBoxColumn.DataPropertyName = "Land"
        Me.LandDataGridViewTextBoxColumn.HeaderText = "Land"
        Me.LandDataGridViewTextBoxColumn.Name = "LandDataGridViewTextBoxColumn"
        '
        'LandkreisDataGridViewTextBoxColumn
        '
        Me.LandkreisDataGridViewTextBoxColumn.DataPropertyName = "Landkreis"
        Me.LandkreisDataGridViewTextBoxColumn.HeaderText = "Landkreis"
        Me.LandkreisDataGridViewTextBoxColumn.Name = "LandkreisDataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'FrmVeranstaltung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 497)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtSave)
        Me.Controls.Add(Me.TbAbnahmeleiter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TbOrt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TbLandkreis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbBundesland)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmVeranstaltung"
        Me.Text = "FrmVeranstaltung"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsJuFla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsEvents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbBundesland As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbLandkreis As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbOrt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbAbnahmeleiter As TextBox
    Friend WithEvents BtSave As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EventIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbnahmeortDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbnahmedatumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbnahmeleiterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LandkreisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BsEvents As BindingSource
    Friend WithEvents DtsJuFla As DtsJuFla
End Class
