<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUebersicht_Mannschaften
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DgvJuFla2Mannschaften = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartnummerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BsJuFla2Mannschaften = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsJuFla = New JuFla_vb.DtsJuFla()
        Me.DgvJuFla3Mannschaften = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartnummerDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BsJuFla3Mannschaften = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartlisteStufe2DruckenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartlisteStufe3DruckenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FensterSchließenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DgvJuFla2Mannschaften, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsJuFla2Mannschaften, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsJuFla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvJuFla3Mannschaften, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsJuFla3Mannschaften, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DgvJuFla2Mannschaften)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DgvJuFla3Mannschaften)
        Me.SplitContainer1.Size = New System.Drawing.Size(776, 544)
        Me.SplitContainer1.SplitterDistance = 396
        Me.SplitContainer1.TabIndex = 0
        '
        'DgvJuFla2Mannschaften
        '
        Me.DgvJuFla2Mannschaften.AutoGenerateColumns = False
        Me.DgvJuFla2Mannschaften.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvJuFla2Mannschaften.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.StartnummerDataGridViewTextBoxColumn, Me.OrtDataGridViewTextBoxColumn})
        Me.DgvJuFla2Mannschaften.DataSource = Me.BsJuFla2Mannschaften
        Me.DgvJuFla2Mannschaften.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvJuFla2Mannschaften.Location = New System.Drawing.Point(0, 0)
        Me.DgvJuFla2Mannschaften.Name = "DgvJuFla2Mannschaften"
        Me.DgvJuFla2Mannschaften.Size = New System.Drawing.Size(396, 544)
        Me.DgvJuFla2Mannschaften.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'StartnummerDataGridViewTextBoxColumn
        '
        Me.StartnummerDataGridViewTextBoxColumn.DataPropertyName = "Startnummer"
        Me.StartnummerDataGridViewTextBoxColumn.HeaderText = "Startnummer"
        Me.StartnummerDataGridViewTextBoxColumn.Name = "StartnummerDataGridViewTextBoxColumn"
        '
        'OrtDataGridViewTextBoxColumn
        '
        Me.OrtDataGridViewTextBoxColumn.DataPropertyName = "Ort"
        Me.OrtDataGridViewTextBoxColumn.HeaderText = "Ort"
        Me.OrtDataGridViewTextBoxColumn.Name = "OrtDataGridViewTextBoxColumn"
        '
        'BsJuFla2Mannschaften
        '
        Me.BsJuFla2Mannschaften.DataMember = "TblJuFla2Mannschaften"
        Me.BsJuFla2Mannschaften.DataSource = Me.DtsJuFla
        '
        'DtsJuFla
        '
        Me.DtsJuFla.DataSetName = "DtsJuFla"
        Me.DtsJuFla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DgvJuFla3Mannschaften
        '
        Me.DgvJuFla3Mannschaften.AutoGenerateColumns = False
        Me.DgvJuFla3Mannschaften.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvJuFla3Mannschaften.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.StartnummerDataGridViewTextBoxColumn1, Me.OrtDataGridViewTextBoxColumn1})
        Me.DgvJuFla3Mannschaften.DataSource = Me.BsJuFla3Mannschaften
        Me.DgvJuFla3Mannschaften.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvJuFla3Mannschaften.Location = New System.Drawing.Point(0, 0)
        Me.DgvJuFla3Mannschaften.Name = "DgvJuFla3Mannschaften"
        Me.DgvJuFla3Mannschaften.Size = New System.Drawing.Size(376, 544)
        Me.DgvJuFla3Mannschaften.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.Visible = False
        '
        'StartnummerDataGridViewTextBoxColumn1
        '
        Me.StartnummerDataGridViewTextBoxColumn1.DataPropertyName = "Startnummer"
        Me.StartnummerDataGridViewTextBoxColumn1.HeaderText = "Startnummer"
        Me.StartnummerDataGridViewTextBoxColumn1.Name = "StartnummerDataGridViewTextBoxColumn1"
        '
        'OrtDataGridViewTextBoxColumn1
        '
        Me.OrtDataGridViewTextBoxColumn1.DataPropertyName = "Ort"
        Me.OrtDataGridViewTextBoxColumn1.HeaderText = "Ort"
        Me.OrtDataGridViewTextBoxColumn1.Name = "OrtDataGridViewTextBoxColumn1"
        '
        'BsJuFla3Mannschaften
        '
        Me.BsJuFla3Mannschaften.DataMember = "TblJuFla3Mannschaften"
        Me.BsJuFla3Mannschaften.DataSource = Me.DtsJuFla
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(776, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartlisteStufe2DruckenToolStripMenuItem, Me.StartlisteStufe3DruckenToolStripMenuItem, Me.FensterSchließenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'StartlisteStufe2DruckenToolStripMenuItem
        '
        Me.StartlisteStufe2DruckenToolStripMenuItem.Name = "StartlisteStufe2DruckenToolStripMenuItem"
        Me.StartlisteStufe2DruckenToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.StartlisteStufe2DruckenToolStripMenuItem.Text = "Startliste Stufe 2 drucken"
        '
        'StartlisteStufe3DruckenToolStripMenuItem
        '
        Me.StartlisteStufe3DruckenToolStripMenuItem.Name = "StartlisteStufe3DruckenToolStripMenuItem"
        Me.StartlisteStufe3DruckenToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.StartlisteStufe3DruckenToolStripMenuItem.Text = "Startliste Stufe 3 drucken"
        '
        'FensterSchließenToolStripMenuItem
        '
        Me.FensterSchließenToolStripMenuItem.Name = "FensterSchließenToolStripMenuItem"
        Me.FensterSchließenToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.FensterSchließenToolStripMenuItem.Text = "Fenster schließen"
        '
        'FrmUebersicht_Mannschaften
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 568)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmUebersicht_Mannschaften"
        Me.Text = "Mannschaftsübersicht"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DgvJuFla2Mannschaften, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsJuFla2Mannschaften, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsJuFla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvJuFla3Mannschaften, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsJuFla3Mannschaften, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents DgvJuFla2Mannschaften As DataGridView
    Friend WithEvents BsJuFla2Mannschaften As BindingSource
    Friend WithEvents DtsJuFla As DtsJuFla
    Friend WithEvents DgvJuFla3Mannschaften As DataGridView
    Friend WithEvents BsJuFla3Mannschaften As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartnummerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StartnummerDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartlisteStufe2DruckenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartlisteStufe3DruckenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FensterSchließenToolStripMenuItem As ToolStripMenuItem
End Class
