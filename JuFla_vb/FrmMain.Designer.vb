<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MsMain = New System.Windows.Forms.MenuStrip()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VeranstaltungsdatenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankLeerenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MannschaftenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MannschaftStufe2HinzufügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportVonExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MannschaftStufe3HinzufügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜbersichtMannschaftenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WettbewerbToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WettbewerbseingabeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TcMain = New System.Windows.Forms.TabControl()
        Me.TpJuFla2 = New System.Windows.Forms.TabPage()
        Me.BtJuFla2Import = New System.Windows.Forms.Button()
        Me.BtJuFla2PrintMember = New System.Windows.Forms.Button()
        Me.BtJuFla2AddMember = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbJuFla2AnzMember = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbRoJuFla2Startnummer = New System.Windows.Forms.TextBox()
        Me.BsJuFla2Mannschaften = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsJuFla = New JuFla_vb.DtsJuFla()
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
        Me.CmsJuFla2Teilnehmer = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TeilnehmerEntfernenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DgvJuFla2Mannschaften = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartnummerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbJuFla2Ort = New System.Windows.Forms.ComboBox()
        Me.TpJuFla3 = New System.Windows.Forms.TabPage()
        Me.BtJuFla3PrintMember = New System.Windows.Forms.Button()
        Me.BtJuFla3AddTn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbJuFla3AnzBewerber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbJuFla3Startnummer = New System.Windows.Forms.TextBox()
        Me.BsJuFla3Mannschaften = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbJuFla3Mannschaft = New System.Windows.Forms.ComboBox()
        Me.DgvJuFla3Member = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartnummerDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VornameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeschlechtDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeburtsdatumDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AusweisnummerDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValFwTechnikDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValEhAufgabeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValPraesentationDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValEhNachweisDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FinishedDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ComboNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BsJuFla3Member = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DgvJuFla3Mannschaften = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartnummerDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiMain = New System.Windows.Forms.Timer(Me.components)
        Me.CmsJuFla3Member = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DtsJuFla1 = New JuFla_vb.DtsJuFla()
        Me.BsJuFla2Member = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MsMain.SuspendLayout()
        Me.TcMain.SuspendLayout()
        Me.TpJuFla2.SuspendLayout()
        CType(Me.BsJuFla2Mannschaften, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsJuFla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvJuFla2Member, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsJuFla2Teilnehmer.SuspendLayout()
        CType(Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvJuFla2Mannschaften, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpJuFla3.SuspendLayout()
        CType(Me.BsJuFla3Mannschaften, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvJuFla3Member, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsJuFla3Member, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvJuFla3Mannschaften, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsJuFla1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsJuFla2Member, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MsMain
        '
        Me.MsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.MannschaftenToolStripMenuItem, Me.WettbewerbToolStripMenuItem})
        Me.MsMain.Location = New System.Drawing.Point(0, 0)
        Me.MsMain.Name = "MsMain"
        Me.MsMain.Size = New System.Drawing.Size(1190, 24)
        Me.MsMain.TabIndex = 0
        Me.MsMain.Text = "MenuStrip1"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VeranstaltungsdatenToolStripMenuItem, Me.DatenbankLeerenToolStripMenuItem})
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
        'DatenbankLeerenToolStripMenuItem
        '
        Me.DatenbankLeerenToolStripMenuItem.Name = "DatenbankLeerenToolStripMenuItem"
        Me.DatenbankLeerenToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.DatenbankLeerenToolStripMenuItem.Text = "Datenbank leeren"
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
        Me.MannschaftStufe2HinzufügenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportVonExcelToolStripMenuItem})
        Me.MannschaftStufe2HinzufügenToolStripMenuItem.Name = "MannschaftStufe2HinzufügenToolStripMenuItem"
        Me.MannschaftStufe2HinzufügenToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.MannschaftStufe2HinzufügenToolStripMenuItem.Text = "Mannschaft Stufe 2 hinzufügen"
        '
        'ImportVonExcelToolStripMenuItem
        '
        Me.ImportVonExcelToolStripMenuItem.Name = "ImportVonExcelToolStripMenuItem"
        Me.ImportVonExcelToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ImportVonExcelToolStripMenuItem.Text = "Import von Excel"
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
        Me.TcMain.Size = New System.Drawing.Size(1190, 564)
        Me.TcMain.TabIndex = 1
        '
        'TpJuFla2
        '
        Me.TpJuFla2.Controls.Add(Me.BtJuFla2Import)
        Me.TpJuFla2.Controls.Add(Me.BtJuFla2PrintMember)
        Me.TpJuFla2.Controls.Add(Me.BtJuFla2AddMember)
        Me.TpJuFla2.Controls.Add(Me.Label3)
        Me.TpJuFla2.Controls.Add(Me.TbJuFla2AnzMember)
        Me.TpJuFla2.Controls.Add(Me.Label2)
        Me.TpJuFla2.Controls.Add(Me.TbRoJuFla2Startnummer)
        Me.TpJuFla2.Controls.Add(Me.DgvJuFla2Member)
        Me.TpJuFla2.Controls.Add(Me.DgvJuFla2Mannschaften)
        Me.TpJuFla2.Controls.Add(Me.Label1)
        Me.TpJuFla2.Controls.Add(Me.CbJuFla2Ort)
        Me.TpJuFla2.Location = New System.Drawing.Point(4, 22)
        Me.TpJuFla2.Name = "TpJuFla2"
        Me.TpJuFla2.Padding = New System.Windows.Forms.Padding(3)
        Me.TpJuFla2.Size = New System.Drawing.Size(1182, 538)
        Me.TpJuFla2.TabIndex = 0
        Me.TpJuFla2.Text = "Jugendflamme Stufe 2"
        Me.TpJuFla2.UseVisualStyleBackColor = True
        '
        'BtJuFla2Import
        '
        Me.BtJuFla2Import.Location = New System.Drawing.Point(403, 6)
        Me.BtJuFla2Import.Name = "BtJuFla2Import"
        Me.BtJuFla2Import.Size = New System.Drawing.Size(97, 23)
        Me.BtJuFla2Import.TabIndex = 14
        Me.BtJuFla2Import.Text = "Import"
        Me.BtJuFla2Import.UseVisualStyleBackColor = True
        '
        'BtJuFla2PrintMember
        '
        Me.BtJuFla2PrintMember.Image = Global.JuFla_vb.My.Resources.Resources.printing_tool
        Me.BtJuFla2PrintMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtJuFla2PrintMember.Location = New System.Drawing.Point(506, 34)
        Me.BtJuFla2PrintMember.Name = "BtJuFla2PrintMember"
        Me.BtJuFla2PrintMember.Size = New System.Drawing.Size(108, 39)
        Me.BtJuFla2PrintMember.TabIndex = 12
        Me.BtJuFla2PrintMember.Text = "Bewerberliste" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "drucken"
        Me.BtJuFla2PrintMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtJuFla2PrintMember.UseVisualStyleBackColor = True
        '
        'BtJuFla2AddMember
        '
        Me.BtJuFla2AddMember.Image = Global.JuFla_vb.My.Resources.Resources.add
        Me.BtJuFla2AddMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtJuFla2AddMember.Location = New System.Drawing.Point(403, 34)
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
        'DgvJuFla2Member
        '
        Me.DgvJuFla2Member.AllowUserToAddRows = False
        Me.DgvJuFla2Member.AllowUserToDeleteRows = False
        Me.DgvJuFla2Member.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvJuFla2Member.AutoGenerateColumns = False
        Me.DgvJuFla2Member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvJuFla2Member.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.StartnummerDataGridViewTextBoxColumn1, Me.NameDataGridViewTextBoxColumn, Me.VornameDataGridViewTextBoxColumn, Me.GeschlechtDataGridViewTextBoxColumn, Me.GeburtsdatumDataGridViewTextBoxColumn, Me.AusweisnummerDataGridViewTextBoxColumn, Me.ValFwPrakDataGridViewTextBoxColumn, Me.ValFwTheorieDataGridViewTextBoxColumn, Me.ValSportDataGridViewCheckBoxColumn, Me.FinishedDataGridViewCheckBoxColumn})
        Me.DgvJuFla2Member.ContextMenuStrip = Me.CmsJuFla2Teilnehmer
        Me.DgvJuFla2Member.DataSource = Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource
        Me.DgvJuFla2Member.Location = New System.Drawing.Point(11, 87)
        Me.DgvJuFla2Member.Name = "DgvJuFla2Member"
        Me.DgvJuFla2Member.ReadOnly = True
        Me.DgvJuFla2Member.Size = New System.Drawing.Size(1086, 407)
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
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VornameDataGridViewTextBoxColumn
        '
        Me.VornameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
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
        Me.ValFwPrakDataGridViewTextBoxColumn.HeaderText = "FW-Praxis"
        Me.ValFwPrakDataGridViewTextBoxColumn.Name = "ValFwPrakDataGridViewTextBoxColumn"
        Me.ValFwPrakDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValFwTheorieDataGridViewTextBoxColumn
        '
        Me.ValFwTheorieDataGridViewTextBoxColumn.DataPropertyName = "ValFwTheorie"
        Me.ValFwTheorieDataGridViewTextBoxColumn.HeaderText = "FW-Theorie"
        Me.ValFwTheorieDataGridViewTextBoxColumn.Name = "ValFwTheorieDataGridViewTextBoxColumn"
        Me.ValFwTheorieDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValSportDataGridViewCheckBoxColumn
        '
        Me.ValSportDataGridViewCheckBoxColumn.DataPropertyName = "ValSport"
        Me.ValSportDataGridViewCheckBoxColumn.HeaderText = "Sportnachweis"
        Me.ValSportDataGridViewCheckBoxColumn.Name = "ValSportDataGridViewCheckBoxColumn"
        Me.ValSportDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'FinishedDataGridViewCheckBoxColumn
        '
        Me.FinishedDataGridViewCheckBoxColumn.DataPropertyName = "finished"
        Me.FinishedDataGridViewCheckBoxColumn.HeaderText = "Bestanden"
        Me.FinishedDataGridViewCheckBoxColumn.Name = "FinishedDataGridViewCheckBoxColumn"
        Me.FinishedDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'CmsJuFla2Teilnehmer
        '
        Me.CmsJuFla2Teilnehmer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeilnehmerEntfernenToolStripMenuItem})
        Me.CmsJuFla2Teilnehmer.Name = "CmsJuFla2Teilnehmer"
        Me.CmsJuFla2Teilnehmer.Size = New System.Drawing.Size(188, 26)
        '
        'TeilnehmerEntfernenToolStripMenuItem
        '
        Me.TeilnehmerEntfernenToolStripMenuItem.Name = "TeilnehmerEntfernenToolStripMenuItem"
        Me.TeilnehmerEntfernenToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.TeilnehmerEntfernenToolStripMenuItem.Text = "Teilnehmer entfernen"
        '
        'TblJuFla2MannschaftenTblJuFla2MemberBindingSource
        '
        Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource.DataMember = "TblJuFla2Mannschaften_TblJuFla2Member"
        Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource.DataSource = Me.BsJuFla2Mannschaften
        '
        'DgvJuFla2Mannschaften
        '
        Me.DgvJuFla2Mannschaften.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvJuFla2Mannschaften.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.StartnummerDataGridViewTextBoxColumn, Me.OrtDataGridViewTextBoxColumn})
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
        Me.TpJuFla3.Controls.Add(Me.Button1)
        Me.TpJuFla3.Controls.Add(Me.BtJuFla3PrintMember)
        Me.TpJuFla3.Controls.Add(Me.BtJuFla3AddTn)
        Me.TpJuFla3.Controls.Add(Me.Label5)
        Me.TpJuFla3.Controls.Add(Me.TbJuFla3AnzBewerber)
        Me.TpJuFla3.Controls.Add(Me.Label6)
        Me.TpJuFla3.Controls.Add(Me.TbJuFla3Startnummer)
        Me.TpJuFla3.Controls.Add(Me.CbJuFla3Mannschaft)
        Me.TpJuFla3.Controls.Add(Me.DgvJuFla3Member)
        Me.TpJuFla3.Controls.Add(Me.Label4)
        Me.TpJuFla3.Controls.Add(Me.DgvJuFla3Mannschaften)
        Me.TpJuFla3.Location = New System.Drawing.Point(4, 22)
        Me.TpJuFla3.Name = "TpJuFla3"
        Me.TpJuFla3.Padding = New System.Windows.Forms.Padding(3)
        Me.TpJuFla3.Size = New System.Drawing.Size(1182, 538)
        Me.TpJuFla3.TabIndex = 1
        Me.TpJuFla3.Text = "Jugendflamme Stufe 3"
        Me.TpJuFla3.UseVisualStyleBackColor = True
        '
        'BtJuFla3PrintMember
        '
        Me.BtJuFla3PrintMember.Image = Global.JuFla_vb.My.Resources.Resources.printing_tool
        Me.BtJuFla3PrintMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtJuFla3PrintMember.Location = New System.Drawing.Point(503, 37)
        Me.BtJuFla3PrintMember.Name = "BtJuFla3PrintMember"
        Me.BtJuFla3PrintMember.Size = New System.Drawing.Size(108, 39)
        Me.BtJuFla3PrintMember.TabIndex = 16
        Me.BtJuFla3PrintMember.Text = "Bewerberliste" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "drucken"
        Me.BtJuFla3PrintMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtJuFla3PrintMember.UseVisualStyleBackColor = True
        '
        'BtJuFla3AddTn
        '
        Me.BtJuFla3AddTn.Image = Global.JuFla_vb.My.Resources.Resources.add
        Me.BtJuFla3AddTn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtJuFla3AddTn.Location = New System.Drawing.Point(400, 37)
        Me.BtJuFla3AddTn.Name = "BtJuFla3AddTn"
        Me.BtJuFla3AddTn.Size = New System.Drawing.Size(97, 39)
        Me.BtJuFla3AddTn.TabIndex = 15
        Me.BtJuFla3AddTn.Text = "Teilnehmer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hinzufügen"
        Me.BtJuFla3AddTn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtJuFla3AddTn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(216, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Bewerber:"
        '
        'TbJuFla3AnzBewerber
        '
        Me.TbJuFla3AnzBewerber.Location = New System.Drawing.Point(282, 56)
        Me.TbJuFla3AnzBewerber.Name = "TbJuFla3AnzBewerber"
        Me.TbJuFla3AnzBewerber.ReadOnly = True
        Me.TbJuFla3AnzBewerber.Size = New System.Drawing.Size(100, 20)
        Me.TbJuFla3AnzBewerber.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Startnummer"
        '
        'TbJuFla3Startnummer
        '
        Me.TbJuFla3Startnummer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BsJuFla3Mannschaften, "Startnummer", True))
        Me.TbJuFla3Startnummer.Location = New System.Drawing.Point(90, 56)
        Me.TbJuFla3Startnummer.Name = "TbJuFla3Startnummer"
        Me.TbJuFla3Startnummer.ReadOnly = True
        Me.TbJuFla3Startnummer.Size = New System.Drawing.Size(110, 20)
        Me.TbJuFla3Startnummer.TabIndex = 11
        '
        'BsJuFla3Mannschaften
        '
        Me.BsJuFla3Mannschaften.DataMember = "TblJuFla3Mannschaften"
        Me.BsJuFla3Mannschaften.DataSource = Me.DtsJuFla
        '
        'CbJuFla3Mannschaft
        '
        Me.CbJuFla3Mannschaft.DataSource = Me.BsJuFla3Mannschaften
        Me.CbJuFla3Mannschaft.DisplayMember = "Ort"
        Me.CbJuFla3Mannschaft.FormattingEnabled = True
        Me.CbJuFla3Mannschaft.Location = New System.Drawing.Point(90, 19)
        Me.CbJuFla3Mannschaft.Name = "CbJuFla3Mannschaft"
        Me.CbJuFla3Mannschaft.Size = New System.Drawing.Size(292, 21)
        Me.CbJuFla3Mannschaft.TabIndex = 3
        '
        'DgvJuFla3Member
        '
        Me.DgvJuFla3Member.AllowUserToAddRows = False
        Me.DgvJuFla3Member.AllowUserToDeleteRows = False
        Me.DgvJuFla3Member.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvJuFla3Member.AutoGenerateColumns = False
        Me.DgvJuFla3Member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvJuFla3Member.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn3, Me.StartnummerDataGridViewTextBoxColumn3, Me.NameDataGridViewTextBoxColumn1, Me.VornameDataGridViewTextBoxColumn1, Me.GeschlechtDataGridViewTextBoxColumn1, Me.GeburtsdatumDataGridViewTextBoxColumn1, Me.AusweisnummerDataGridViewTextBoxColumn1, Me.ValFwTechnikDataGridViewTextBoxColumn, Me.ValEhAufgabeDataGridViewTextBoxColumn, Me.ValPraesentationDataGridViewCheckBoxColumn, Me.ValEhNachweisDataGridViewCheckBoxColumn, Me.FinishedDataGridViewCheckBoxColumn1, Me.ComboNameDataGridViewTextBoxColumn})
        Me.DgvJuFla3Member.DataSource = Me.BsJuFla3Member
        Me.DgvJuFla3Member.Location = New System.Drawing.Point(11, 89)
        Me.DgvJuFla3Member.Name = "DgvJuFla3Member"
        Me.DgvJuFla3Member.ReadOnly = True
        Me.DgvJuFla3Member.Size = New System.Drawing.Size(1143, 411)
        Me.DgvJuFla3Member.TabIndex = 2
        '
        'IDDataGridViewTextBoxColumn3
        '
        Me.IDDataGridViewTextBoxColumn3.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn3.Name = "IDDataGridViewTextBoxColumn3"
        Me.IDDataGridViewTextBoxColumn3.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn3.Visible = False
        '
        'StartnummerDataGridViewTextBoxColumn3
        '
        Me.StartnummerDataGridViewTextBoxColumn3.DataPropertyName = "Startnummer"
        Me.StartnummerDataGridViewTextBoxColumn3.HeaderText = "Startnummer"
        Me.StartnummerDataGridViewTextBoxColumn3.Name = "StartnummerDataGridViewTextBoxColumn3"
        Me.StartnummerDataGridViewTextBoxColumn3.ReadOnly = True
        Me.StartnummerDataGridViewTextBoxColumn3.Visible = False
        '
        'NameDataGridViewTextBoxColumn1
        '
        Me.NameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn1.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn1.Name = "NameDataGridViewTextBoxColumn1"
        Me.NameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'VornameDataGridViewTextBoxColumn1
        '
        Me.VornameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.VornameDataGridViewTextBoxColumn1.DataPropertyName = "Vorname"
        Me.VornameDataGridViewTextBoxColumn1.HeaderText = "Vorname"
        Me.VornameDataGridViewTextBoxColumn1.Name = "VornameDataGridViewTextBoxColumn1"
        Me.VornameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'GeschlechtDataGridViewTextBoxColumn1
        '
        Me.GeschlechtDataGridViewTextBoxColumn1.DataPropertyName = "Geschlecht"
        Me.GeschlechtDataGridViewTextBoxColumn1.HeaderText = "Geschlecht"
        Me.GeschlechtDataGridViewTextBoxColumn1.Name = "GeschlechtDataGridViewTextBoxColumn1"
        Me.GeschlechtDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'GeburtsdatumDataGridViewTextBoxColumn1
        '
        Me.GeburtsdatumDataGridViewTextBoxColumn1.DataPropertyName = "Geburtsdatum"
        Me.GeburtsdatumDataGridViewTextBoxColumn1.HeaderText = "Geburtsdatum"
        Me.GeburtsdatumDataGridViewTextBoxColumn1.Name = "GeburtsdatumDataGridViewTextBoxColumn1"
        Me.GeburtsdatumDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'AusweisnummerDataGridViewTextBoxColumn1
        '
        Me.AusweisnummerDataGridViewTextBoxColumn1.DataPropertyName = "Ausweisnummer"
        Me.AusweisnummerDataGridViewTextBoxColumn1.HeaderText = "Ausweisnummer"
        Me.AusweisnummerDataGridViewTextBoxColumn1.Name = "AusweisnummerDataGridViewTextBoxColumn1"
        Me.AusweisnummerDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ValFwTechnikDataGridViewTextBoxColumn
        '
        Me.ValFwTechnikDataGridViewTextBoxColumn.DataPropertyName = "ValFwTechnik"
        Me.ValFwTechnikDataGridViewTextBoxColumn.HeaderText = "FW-Technik"
        Me.ValFwTechnikDataGridViewTextBoxColumn.Name = "ValFwTechnikDataGridViewTextBoxColumn"
        Me.ValFwTechnikDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValEhAufgabeDataGridViewTextBoxColumn
        '
        Me.ValEhAufgabeDataGridViewTextBoxColumn.DataPropertyName = "ValEhAufgabe"
        Me.ValEhAufgabeDataGridViewTextBoxColumn.HeaderText = "EH-Aufgabe"
        Me.ValEhAufgabeDataGridViewTextBoxColumn.Name = "ValEhAufgabeDataGridViewTextBoxColumn"
        Me.ValEhAufgabeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValPraesentationDataGridViewCheckBoxColumn
        '
        Me.ValPraesentationDataGridViewCheckBoxColumn.DataPropertyName = "ValPraesentation"
        Me.ValPraesentationDataGridViewCheckBoxColumn.HeaderText = "Präsentation"
        Me.ValPraesentationDataGridViewCheckBoxColumn.Name = "ValPraesentationDataGridViewCheckBoxColumn"
        Me.ValPraesentationDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ValPraesentationDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ValPraesentationDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ValEhNachweisDataGridViewCheckBoxColumn
        '
        Me.ValEhNachweisDataGridViewCheckBoxColumn.DataPropertyName = "ValEhNachweis"
        Me.ValEhNachweisDataGridViewCheckBoxColumn.HeaderText = "EH-Nachweis"
        Me.ValEhNachweisDataGridViewCheckBoxColumn.Name = "ValEhNachweisDataGridViewCheckBoxColumn"
        Me.ValEhNachweisDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'FinishedDataGridViewCheckBoxColumn1
        '
        Me.FinishedDataGridViewCheckBoxColumn1.DataPropertyName = "finished"
        Me.FinishedDataGridViewCheckBoxColumn1.HeaderText = "Bestanden"
        Me.FinishedDataGridViewCheckBoxColumn1.Name = "FinishedDataGridViewCheckBoxColumn1"
        Me.FinishedDataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'ComboNameDataGridViewTextBoxColumn
        '
        Me.ComboNameDataGridViewTextBoxColumn.DataPropertyName = "ComboName"
        Me.ComboNameDataGridViewTextBoxColumn.HeaderText = "ComboName"
        Me.ComboNameDataGridViewTextBoxColumn.Name = "ComboNameDataGridViewTextBoxColumn"
        Me.ComboNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ComboNameDataGridViewTextBoxColumn.Visible = False
        '
        'BsJuFla3Member
        '
        Me.BsJuFla3Member.DataMember = "TblJuFla3Mannschaften_TblJuFla3Member"
        Me.BsJuFla3Member.DataSource = Me.BsJuFla3Mannschaften
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Mannschaft:"
        '
        'DgvJuFla3Mannschaften
        '
        Me.DgvJuFla3Mannschaften.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvJuFla3Mannschaften.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn2, Me.StartnummerDataGridViewTextBoxColumn2, Me.OrtDataGridViewTextBoxColumn1})
        Me.DgvJuFla3Mannschaften.Location = New System.Drawing.Point(818, 6)
        Me.DgvJuFla3Mannschaften.Name = "DgvJuFla3Mannschaften"
        Me.DgvJuFla3Mannschaften.Size = New System.Drawing.Size(323, 94)
        Me.DgvJuFla3Mannschaften.TabIndex = 0
        Me.DgvJuFla3Mannschaften.Visible = False
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
        'TiMain
        '
        '
        'CmsJuFla3Member
        '
        Me.CmsJuFla3Member.Name = "CmsJuFla3Member"
        Me.CmsJuFla3Member.Size = New System.Drawing.Size(61, 4)
        '
        'DtsJuFla1
        '
        Me.DtsJuFla1.DataSetName = "DtsJuFla"
        Me.DtsJuFla1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BsJuFla2Member
        '
        Me.BsJuFla2Member.DataMember = "TblJuFla2Mannschaften_TblJuFla2Member"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(400, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Import"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 588)
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
        Me.CmsJuFla2Teilnehmer.ResumeLayout(False)
        CType(Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvJuFla2Mannschaften, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpJuFla3.ResumeLayout(False)
        Me.TpJuFla3.PerformLayout()
        CType(Me.BsJuFla3Mannschaften, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvJuFla3Member, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsJuFla3Member, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvJuFla3Mannschaften, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsJuFla1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsJuFla2Member, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ÜbersichtMannschaftenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DgvJuFla3Mannschaften As DataGridView
    Friend WithEvents TbRoJuFla2Startnummer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbJuFla2AnzMember As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TiMain As Timer
    Friend WithEvents WettbewerbToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WettbewerbseingabeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtJuFla2AddMember As Button
    Friend WithEvents DatenbankLeerenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents CmsJuFla2Teilnehmer As ContextMenuStrip
    Friend WithEvents TeilnehmerEntfernenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents TbJuFla3AnzBewerber As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbJuFla3Startnummer As TextBox
    Friend WithEvents CbJuFla3Mannschaft As ComboBox
    Friend WithEvents DgvJuFla3Member As DataGridView
    Friend WithEvents CmsJuFla3Member As ContextMenuStrip
    Friend WithEvents DtsJuFla1 As DtsJuFla
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartnummerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Public WithEvents BsJuFla2Mannschaften As BindingSource
    Friend WithEvents BsJuFla3Member As BindingSource
    Friend WithEvents BsJuFla3Mannschaften As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents StartnummerDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Public WithEvents BsJuFla2Member As BindingSource
    Friend WithEvents TblJuFla2MannschaftenTblJuFla2MemberBindingSource As BindingSource
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
    Friend WithEvents BtJuFla3AddTn As Button
    Friend WithEvents BtJuFla2PrintMember As Button
    Friend WithEvents BtJuFla3PrintMember As Button
    Friend WithEvents IDDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents StartnummerDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents VornameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GeschlechtDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GeburtsdatumDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AusweisnummerDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ValFwTechnikDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValEhAufgabeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValPraesentationDataGridViewCheckBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValEhNachweisDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FinishedDataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents ComboNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImportVonExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtJuFla2Import As Button
    Friend WithEvents Button1 As Button
End Class
