<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.MsMain = New System.Windows.Forms.MenuStrip()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VeranstaltungsdatenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MannschaftenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MannschaftStufe2HinzufügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MannschaftStufe3HinzufügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜbersichtMannschaftenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WettbewerbToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WettbewerbseingabeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TcMain = New System.Windows.Forms.TabControl()
        Me.TpJuFla2 = New System.Windows.Forms.TabPage()
        Me.BtJuFla2AddMember = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbJuFla2AnzMember = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbRoJuFla2Startnummer = New System.Windows.Forms.TextBox()
        Me.BsJuFla2Mannschaften = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsJuFla = New JuFla_vb.DtsJuFla()
        Me.BtJuFla2Mannschaftloeschen = New System.Windows.Forms.Button()
        Me.DgvJuFla2Member = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartnummerDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VornameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeschlechtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeburtsdatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AusweisnummerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValFwPrakDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValFwTheorieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValSportDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FinishedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BsJuFla2Member = New System.Windows.Forms.BindingSource(Me.components)
        Me.DgvJuFla2Mannschaften = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartnummerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbJuFla2Ort = New System.Windows.Forms.ComboBox()
        Me.TpJuFla3 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartnummerDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BsJuFla3Mannschaften = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiMain = New System.Windows.Forms.Timer(Me.components)
        Me.MsMain.SuspendLayout()
        Me.TcMain.SuspendLayout()
        Me.TpJuFla2.SuspendLayout()
        CType(Me.BsJuFla2Mannschaften, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsJuFla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvJuFla2Member, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsJuFla2Member, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvJuFla2Mannschaften, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpJuFla3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsJuFla3Mannschaften, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MsMain
        '
        Me.MsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.MannschaftenToolStripMenuItem, Me.WettbewerbToolStripMenuItem})
        Me.MsMain.Location = New System.Drawing.Point(0, 0)
        Me.MsMain.Name = "MsMain"
        Me.MsMain.Size = New System.Drawing.Size(1170, 24)
        Me.MsMain.TabIndex = 0
        Me.MsMain.Text = "MenuStrip1"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VeranstaltungsdatenToolStripMenuItem})
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'VeranstaltungsdatenToolStripMenuItem
        '
        Me.VeranstaltungsdatenToolStripMenuItem.Name = "VeranstaltungsdatenToolStripMenuItem"
        Me.VeranstaltungsdatenToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.VeranstaltungsdatenToolStripMenuItem.Text = "Veranstaltungsdaten"
        '
        'MannschaftenToolStripMenuItem
        '
        Me.MannschaftenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MannschaftStufe2HinzufügenToolStripMenuItem, Me.MannschaftStufe3HinzufügenToolStripMenuItem, Me.ÜbersichtMannschaftenToolStripMenuItem})
        Me.MannschaftenToolStripMenuItem.Name = "MannschaftenToolStripMenuItem"
        Me.MannschaftenToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.MannschaftenToolStripMenuItem.Text = "Mannschaften"
        '
        'MannschaftStufe2HinzufügenToolStripMenuItem
        '
        Me.MannschaftStufe2HinzufügenToolStripMenuItem.Name = "MannschaftStufe2HinzufügenToolStripMenuItem"
        Me.MannschaftStufe2HinzufügenToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.MannschaftStufe2HinzufügenToolStripMenuItem.Text = "Mannschaft Stufe 2 hinzufügen"
        '
        'MannschaftStufe3HinzufügenToolStripMenuItem
        '
        Me.MannschaftStufe3HinzufügenToolStripMenuItem.Name = "MannschaftStufe3HinzufügenToolStripMenuItem"
        Me.MannschaftStufe3HinzufügenToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.MannschaftStufe3HinzufügenToolStripMenuItem.Text = "Mannschaft Stufe 3 hinzufügen"
        '
        'ÜbersichtMannschaftenToolStripMenuItem
        '
        Me.ÜbersichtMannschaftenToolStripMenuItem.Name = "ÜbersichtMannschaftenToolStripMenuItem"
        Me.ÜbersichtMannschaftenToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.ÜbersichtMannschaftenToolStripMenuItem.Text = "Übersicht Mannschaften"
        '
        'WettbewerbToolStripMenuItem
        '
        Me.WettbewerbToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WettbewerbseingabeToolStripMenuItem})
        Me.WettbewerbToolStripMenuItem.Name = "WettbewerbToolStripMenuItem"
        Me.WettbewerbToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.WettbewerbToolStripMenuItem.Text = "Wettbewerb"
        '
        'WettbewerbseingabeToolStripMenuItem
        '
        Me.WettbewerbseingabeToolStripMenuItem.Name = "WettbewerbseingabeToolStripMenuItem"
        Me.WettbewerbseingabeToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.WettbewerbseingabeToolStripMenuItem.Text = "Wettbewerbseingabe"
        '
        'TcMain
        '
        Me.TcMain.Controls.Add(Me.TpJuFla2)
        Me.TcMain.Controls.Add(Me.TpJuFla3)
        Me.TcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TcMain.Location = New System.Drawing.Point(0, 24)
        Me.TcMain.Name = "TcMain"
        Me.TcMain.SelectedIndex = 0
        Me.TcMain.Size = New System.Drawing.Size(1170, 612)
        Me.TcMain.TabIndex = 1
        '
        'TpJuFla2
        '
        Me.TpJuFla2.Controls.Add(Me.BtJuFla2AddMember)
        Me.TpJuFla2.Controls.Add(Me.Label3)
        Me.TpJuFla2.Controls.Add(Me.TbJuFla2AnzMember)
        Me.TpJuFla2.Controls.Add(Me.Label2)
        Me.TpJuFla2.Controls.Add(Me.TbRoJuFla2Startnummer)
        Me.TpJuFla2.Controls.Add(Me.BtJuFla2Mannschaftloeschen)
        Me.TpJuFla2.Controls.Add(Me.DgvJuFla2Member)
        Me.TpJuFla2.Controls.Add(Me.DgvJuFla2Mannschaften)
        Me.TpJuFla2.Controls.Add(Me.Label1)
        Me.TpJuFla2.Controls.Add(Me.CbJuFla2Ort)
        Me.TpJuFla2.Location = New System.Drawing.Point(4, 22)
        Me.TpJuFla2.Name = "TpJuFla2"
        Me.TpJuFla2.Padding = New System.Windows.Forms.Padding(3)
        Me.TpJuFla2.Size = New System.Drawing.Size(1162, 586)
        Me.TpJuFla2.TabIndex = 0
        Me.TpJuFla2.Text = "Jugendflamme Stufe 2"
        Me.TpJuFla2.UseVisualStyleBackColor = True
        '
        'BtJuFla2AddMember
        '
        Me.BtJuFla2AddMember.Image = Global.JuFla_vb.My.Resources.Resources.add
        Me.BtJuFla2AddMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtJuFla2AddMember.Location = New System.Drawing.Point(978, 424)
        Me.BtJuFla2AddMember.Name = "BtJuFla2AddMember"
        Me.BtJuFla2AddMember.Size = New System.Drawing.Size(97, 39)
        Me.BtJuFla2AddMember.TabIndex = 11
        Me.BtJuFla2AddMember.Text = "Teilnehmer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hinzufügen"
        Me.BtJuFla2AddMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtJuFla2AddMember.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(216, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Bewerber:"
        '
        'TbJuFla2AnzMember
        '
        Me.TbJuFla2AnzMember.Location = New System.Drawing.Point(282, 61)
        Me.TbJuFla2AnzMember.Name = "TbJuFla2AnzMember"
        Me.TbJuFla2AnzMember.ReadOnly = True
        Me.TbJuFla2AnzMember.Size = New System.Drawing.Size(100, 20)
        Me.TbJuFla2AnzMember.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Startnummer"
        '
        'TbRoJuFla2Startnummer
        '
        Me.TbRoJuFla2Startnummer.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BsJuFla2Mannschaften, "Startnummer", True))
        Me.TbRoJuFla2Startnummer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BsJuFla2Mannschaften, "Startnummer", True))
        Me.TbRoJuFla2Startnummer.Location = New System.Drawing.Point(90, 61)
        Me.TbRoJuFla2Startnummer.Name = "TbRoJuFla2Startnummer"
        Me.TbRoJuFla2Startnummer.ReadOnly = True
        Me.TbRoJuFla2Startnummer.Size = New System.Drawing.Size(110, 20)
        Me.TbRoJuFla2Startnummer.TabIndex = 7
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
        'BtJuFla2Mannschaftloeschen
        '
        Me.BtJuFla2Mannschaftloeschen.Image = Global.JuFla_vb.My.Resources.Resources.delete
        Me.BtJuFla2Mannschaftloeschen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtJuFla2Mannschaftloeschen.Location = New System.Drawing.Point(417, 34)
        Me.BtJuFla2Mannschaftloeschen.Name = "BtJuFla2Mannschaftloeschen"
        Me.BtJuFla2Mannschaftloeschen.Size = New System.Drawing.Size(138, 43)
        Me.BtJuFla2Mannschaftloeschen.TabIndex = 6
        Me.BtJuFla2Mannschaftloeschen.Text = "Mannschaft löschen"
        Me.BtJuFla2Mannschaftloeschen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtJuFla2Mannschaftloeschen.UseVisualStyleBackColor = True
        '
        'DgvJuFla2Member
        '
        Me.DgvJuFla2Member.AllowUserToAddRows = False
        Me.DgvJuFla2Member.AllowUserToDeleteRows = False
        Me.DgvJuFla2Member.AutoGenerateColumns = False
        Me.DgvJuFla2Member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvJuFla2Member.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.StartnummerDataGridViewTextBoxColumn1, Me.NameDataGridViewTextBoxColumn, Me.VornameDataGridViewTextBoxColumn, Me.GeschlechtDataGridViewTextBoxColumn, Me.GeburtsdatumDataGridViewTextBoxColumn, Me.AusweisnummerDataGridViewTextBoxColumn, Me.ValFwPrakDataGridViewTextBoxColumn, Me.ValFwTheorieDataGridViewTextBoxColumn, Me.ValSportDataGridViewCheckBoxColumn, Me.FinishedDataGridViewCheckBoxColumn})
        Me.DgvJuFla2Member.DataSource = Me.BsJuFla2Member
        Me.DgvJuFla2Member.Location = New System.Drawing.Point(11, 87)
        Me.DgvJuFla2Member.Name = "DgvJuFla2Member"
        Me.DgvJuFla2Member.ReadOnly = True
        Me.DgvJuFla2Member.Size = New System.Drawing.Size(960, 376)
        Me.DgvJuFla2Member.TabIndex = 5
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn1.Visible = False
        '
        'StartnummerDataGridViewTextBoxColumn1
        '
        Me.StartnummerDataGridViewTextBoxColumn1.DataPropertyName = "Startnummer"
        Me.StartnummerDataGridViewTextBoxColumn1.HeaderText = "Startnummer"
        Me.StartnummerDataGridViewTextBoxColumn1.Name = "StartnummerDataGridViewTextBoxColumn1"
        Me.StartnummerDataGridViewTextBoxColumn1.ReadOnly = True
        Me.StartnummerDataGridViewTextBoxColumn1.Visible = False
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VornameDataGridViewTextBoxColumn
        '
        Me.VornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname"
        Me.VornameDataGridViewTextBoxColumn.HeaderText = "Vorname"
        Me.VornameDataGridViewTextBoxColumn.Name = "VornameDataGridViewTextBoxColumn"
        Me.VornameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GeschlechtDataGridViewTextBoxColumn
        '
        Me.GeschlechtDataGridViewTextBoxColumn.DataPropertyName = "Geschlecht"
        Me.GeschlechtDataGridViewTextBoxColumn.HeaderText = "Geschlecht"
        Me.GeschlechtDataGridViewTextBoxColumn.Name = "GeschlechtDataGridViewTextBoxColumn"
        Me.GeschlechtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GeburtsdatumDataGridViewTextBoxColumn
        '
        Me.GeburtsdatumDataGridViewTextBoxColumn.DataPropertyName = "Geburtsdatum"
        Me.GeburtsdatumDataGridViewTextBoxColumn.HeaderText = "Geburtsdatum"
        Me.GeburtsdatumDataGridViewTextBoxColumn.Name = "GeburtsdatumDataGridViewTextBoxColumn"
        Me.GeburtsdatumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AusweisnummerDataGridViewTextBoxColumn
        '
        Me.AusweisnummerDataGridViewTextBoxColumn.DataPropertyName = "Ausweisnummer"
        Me.AusweisnummerDataGridViewTextBoxColumn.HeaderText = "Ausweisnummer"
        Me.AusweisnummerDataGridViewTextBoxColumn.Name = "AusweisnummerDataGridViewTextBoxColumn"
        Me.AusweisnummerDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValFwPrakDataGridViewTextBoxColumn
        '
        Me.ValFwPrakDataGridViewTextBoxColumn.DataPropertyName = "ValFwPrak"
        Me.ValFwPrakDataGridViewTextBoxColumn.HeaderText = "ValFwPrak"
        Me.ValFwPrakDataGridViewTextBoxColumn.Name = "ValFwPrakDataGridViewTextBoxColumn"
        Me.ValFwPrakDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValFwTheorieDataGridViewTextBoxColumn
        '
        Me.ValFwTheorieDataGridViewTextBoxColumn.DataPropertyName = "ValFwTheorie"
        Me.ValFwTheorieDataGridViewTextBoxColumn.HeaderText = "ValFwTheorie"
        Me.ValFwTheorieDataGridViewTextBoxColumn.Name = "ValFwTheorieDataGridViewTextBoxColumn"
        Me.ValFwTheorieDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValSportDataGridViewCheckBoxColumn
        '
        Me.ValSportDataGridViewCheckBoxColumn.DataPropertyName = "ValSport"
        Me.ValSportDataGridViewCheckBoxColumn.HeaderText = "ValSport"
        Me.ValSportDataGridViewCheckBoxColumn.Name = "ValSportDataGridViewCheckBoxColumn"
        Me.ValSportDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'FinishedDataGridViewCheckBoxColumn
        '
        Me.FinishedDataGridViewCheckBoxColumn.DataPropertyName = "finished"
        Me.FinishedDataGridViewCheckBoxColumn.HeaderText = "finished"
        Me.FinishedDataGridViewCheckBoxColumn.Name = "FinishedDataGridViewCheckBoxColumn"
        Me.FinishedDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'BsJuFla2Member
        '
        Me.BsJuFla2Member.DataMember = "TblJuFla2Mannschaften_TblJuFla2Member"
        Me.BsJuFla2Member.DataSource = Me.BsJuFla2Mannschaften
        '
        'DgvJuFla2Mannschaften
        '
        Me.DgvJuFla2Mannschaften.AutoGenerateColumns = False
        Me.DgvJuFla2Mannschaften.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvJuFla2Mannschaften.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.StartnummerDataGridViewTextBoxColumn, Me.OrtDataGridViewTextBoxColumn})
        Me.DgvJuFla2Mannschaften.DataSource = Me.BsJuFla2Mannschaften
        Me.DgvJuFla2Mannschaften.Location = New System.Drawing.Point(632, -7)
        Me.DgvJuFla2Mannschaften.Name = "DgvJuFla2Mannschaften"
        Me.DgvJuFla2Mannschaften.Size = New System.Drawing.Size(473, 57)
        Me.DgvJuFla2Mannschaften.TabIndex = 4
        Me.DgvJuFla2Mannschaften.Visible = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mannschaft"
        '
        'CbJuFla2Ort
        '
        Me.CbJuFla2Ort.DataSource = Me.BsJuFla2Mannschaften
        Me.CbJuFla2Ort.DisplayMember = "Ort"
        Me.CbJuFla2Ort.FormattingEnabled = True
        Me.CbJuFla2Ort.Location = New System.Drawing.Point(90, 34)
        Me.CbJuFla2Ort.Name = "CbJuFla2Ort"
        Me.CbJuFla2Ort.Size = New System.Drawing.Size(292, 21)
        Me.CbJuFla2Ort.TabIndex = 0
        '
        'TpJuFla3
        '
        Me.TpJuFla3.Controls.Add(Me.DataGridView1)
        Me.TpJuFla3.Location = New System.Drawing.Point(4, 22)
        Me.TpJuFla3.Name = "TpJuFla3"
        Me.TpJuFla3.Padding = New System.Windows.Forms.Padding(3)
        Me.TpJuFla3.Size = New System.Drawing.Size(1162, 586)
        Me.TpJuFla3.TabIndex = 1
        Me.TpJuFla3.Text = "Jugendflamme Stufe 3"
        Me.TpJuFla3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn2, Me.StartnummerDataGridViewTextBoxColumn2, Me.OrtDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.BsJuFla3Mannschaften
        Me.DataGridView1.Location = New System.Drawing.Point(151, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(618, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
        '
        'StartnummerDataGridViewTextBoxColumn2
        '
        Me.StartnummerDataGridViewTextBoxColumn2.DataPropertyName = "Startnummer"
        Me.StartnummerDataGridViewTextBoxColumn2.HeaderText = "Startnummer"
        Me.StartnummerDataGridViewTextBoxColumn2.Name = "StartnummerDataGridViewTextBoxColumn2"
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
        'TiMain
        '
        Me.TiMain.Interval = 10
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1170, 636)
        Me.Controls.Add(Me.TcMain)
        Me.Controls.Add(Me.MsMain)
        Me.MainMenuStrip = Me.MsMain
        Me.Name = "FrmMain"
        Me.Text = "Jugendflamme - KEINE VERANSTALTUNG"
        Me.MsMain.ResumeLayout(False)
        Me.MsMain.PerformLayout()
        Me.TcMain.ResumeLayout(False)
        Me.TpJuFla2.ResumeLayout(False)
        Me.TpJuFla2.PerformLayout()
        CType(Me.BsJuFla2Mannschaften, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsJuFla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvJuFla2Member, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsJuFla2Member, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvJuFla2Mannschaften, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpJuFla3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsJuFla3Mannschaften, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MsMain As MenuStrip
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VeranstaltungsdatenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TcMain As TabControl
    Friend WithEvents TpJuFla2 As TabPage
    Friend WithEvents TpJuFla3 As TabPage
    Friend WithEvents CbJuFla2Ort As ComboBox
    Friend WithEvents DtsJuFla As DtsJuFla
    Friend WithEvents DgvJuFla2Mannschaften As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvJuFla2Member As DataGridView
    Friend WithEvents MannschaftenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MannschaftStufe2HinzufügenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MannschaftStufe3HinzufügenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtJuFla2Mannschaftloeschen As Button
    Friend WithEvents ÜbersichtMannschaftenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents StartnummerDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BsJuFla3Mannschaften As BindingSource
    Friend WithEvents TbRoJuFla2Startnummer As TextBox
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StartnummerDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VornameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GeschlechtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GeburtsdatumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AusweisnummerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValFwPrakDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValFwTheorieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValSportDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FinishedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartnummerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents TbJuFla2AnzMember As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TiMain As Timer
    Friend WithEvents WettbewerbToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WettbewerbseingabeToolStripMenuItem As ToolStripMenuItem
    Public WithEvents BsJuFla2Mannschaften As BindingSource
    Public WithEvents BsJuFla2Member As BindingSource
    Friend WithEvents BtJuFla2AddMember As Button
End Class
