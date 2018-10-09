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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVeranstaltung))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BsEvents = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsJuFla = New JuFla_vb.DtsJuFla()
        Me.BtSave = New System.Windows.Forms.Button()
        Me.EventIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbnahmeortDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbnahmedatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbnahmeleiterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LandkreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsJuFla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EventIDDataGridViewTextBoxColumn, Me.AbnahmeortDataGridViewTextBoxColumn, Me.AbnahmedatumDataGridViewTextBoxColumn, Me.AbnahmeleiterDataGridViewTextBoxColumn, Me.LandDataGridViewTextBoxColumn, Me.LandkreisDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BsEvents
        Me.DataGridView1.Location = New System.Drawing.Point(21, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(832, 473)
        Me.DataGridView1.TabIndex = 12
        '
        'BsEvents
        '
        Me.BsEvents.DataMember = "TblEvents"
        Me.BsEvents.DataSource = Me.DtsJuFla
        '
        'DtsJuFla
        '
        Me.DtsJuFla.DataSetName = "DtsJuFla"
        Me.DtsJuFla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtSave
        '
        Me.BtSave.Image = Global.JuFla_vb.My.Resources.Resources.Ico_checked
        Me.BtSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtSave.Location = New System.Drawing.Point(881, 451)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(90, 34)
        Me.BtSave.TabIndex = 10
        Me.BtSave.Text = "Schließen"
        Me.BtSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtSave.UseVisualStyleBackColor = True
        '
        'EventIDDataGridViewTextBoxColumn
        '
        Me.EventIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EventIDDataGridViewTextBoxColumn.DataPropertyName = "EventID"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.EventIDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.EventIDDataGridViewTextBoxColumn.DividerWidth = 5
        Me.EventIDDataGridViewTextBoxColumn.HeaderText = "EventID"
        Me.EventIDDataGridViewTextBoxColumn.Name = "EventIDDataGridViewTextBoxColumn"
        Me.EventIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.EventIDDataGridViewTextBoxColumn.ToolTipText = "Wird automatisch generiert!"
        Me.EventIDDataGridViewTextBoxColumn.Width = 76
        '
        'AbnahmeortDataGridViewTextBoxColumn
        '
        Me.AbnahmeortDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AbnahmeortDataGridViewTextBoxColumn.DataPropertyName = "Abnahmeort"
        Me.AbnahmeortDataGridViewTextBoxColumn.HeaderText = "Abnahmeort"
        Me.AbnahmeortDataGridViewTextBoxColumn.Name = "AbnahmeortDataGridViewTextBoxColumn"
        '
        'AbnahmedatumDataGridViewTextBoxColumn
        '
        Me.AbnahmedatumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AbnahmedatumDataGridViewTextBoxColumn.DataPropertyName = "Abnahmedatum"
        Me.AbnahmedatumDataGridViewTextBoxColumn.HeaderText = "Abnahmedatum"
        Me.AbnahmedatumDataGridViewTextBoxColumn.Name = "AbnahmedatumDataGridViewTextBoxColumn"
        '
        'AbnahmeleiterDataGridViewTextBoxColumn
        '
        Me.AbnahmeleiterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AbnahmeleiterDataGridViewTextBoxColumn.DataPropertyName = "Abnahmeleiter"
        Me.AbnahmeleiterDataGridViewTextBoxColumn.HeaderText = "Abnahmeleiter"
        Me.AbnahmeleiterDataGridViewTextBoxColumn.Name = "AbnahmeleiterDataGridViewTextBoxColumn"
        '
        'LandDataGridViewTextBoxColumn
        '
        Me.LandDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LandDataGridViewTextBoxColumn.DataPropertyName = "Land"
        Me.LandDataGridViewTextBoxColumn.HeaderText = "Land"
        Me.LandDataGridViewTextBoxColumn.Name = "LandDataGridViewTextBoxColumn"
        '
        'LandkreisDataGridViewTextBoxColumn
        '
        Me.LandkreisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LandkreisDataGridViewTextBoxColumn.DataPropertyName = "Landkreis"
        Me.LandkreisDataGridViewTextBoxColumn.HeaderText = "Landkreis"
        Me.LandkreisDataGridViewTextBoxColumn.Name = "LandkreisDataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'FrmVeranstaltung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 497)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmVeranstaltung"
        Me.Text = "Veranstaltungsdaten"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsEvents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsJuFla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtSave As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BsEvents As BindingSource
    Friend WithEvents DtsJuFla As DtsJuFla
    Friend WithEvents EventIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbnahmeortDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbnahmedatumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbnahmeleiterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LandkreisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
