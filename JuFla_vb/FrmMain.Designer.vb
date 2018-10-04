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
        Me.MsVeranstaltungsdaten = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsDtsLeeren = New System.Windows.Forms.ToolStripMenuItem()
        Me.MannschaftenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsJuFla2AddMannschaft = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsJuFla3AddMannschaft = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsUebersichtMannschaften = New System.Windows.Forms.ToolStripMenuItem()
        Me.WettbewerbToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsWettbewerbseingabe = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.CmsJuFla2Member = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CmsJuFla2RemoveMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DgvJuFla2Mannschaften = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartnummerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbJuFla2Ort = New System.Windows.Forms.ComboBox()
        Me.TpJuFla3 = New System.Windows.Forms.TabPage()
        Me.BtJuFla3Import = New System.Windows.Forms.Button()
        Me.BtJuFla3PrintMember = New System.Windows.Forms.Button()
        Me.BtJuFla3AddMember = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbJuFla3AnzBewerber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbJuFla3Startnummer = New System.Windows.Forms.TextBox()
        Me.BsJuFla3Mannschaften = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbJuFla3Mannschaft = New System.Windows.Forms.ComboBox()
        Me.DgvJuFla3Member = New System.Windows.Forms.DataGridView()
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
        Me.CmsJuFla3Member = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CmsJuFla3RemoveMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.BsJuFla3Member = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DgvJuFla3Mannschaften = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartnummerDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiMain = New System.Windows.Forms.Timer(Me.components)
        Me.DtsJuFla1 = New JuFla_vb.DtsJuFla()
        Me.BsJuFla2Member = New System.Windows.Forms.BindingSource(Me.components)
        Me.MsMain.SuspendLayout()
        Me.TcMain.SuspendLayout()
        Me.TpJuFla2.SuspendLayout()
        CType(Me.BsJuFla2Mannschaften, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsJuFla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvJuFla2Member, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsJuFla2Member.SuspendLayout()
        CType(Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvJuFla2Mannschaften, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpJuFla3.SuspendLayout()
        CType(Me.BsJuFla3Mannschaften, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvJuFla3Member, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsJuFla3Member.SuspendLayout()
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
        Me.StartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsVeranstaltungsdaten, Me.MsDtsLeeren})
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'MsVeranstaltungsdaten
        '
        Me.MsVeranstaltungsdaten.Name = "MsVeranstaltungsdaten"
        Me.MsVeranstaltungsdaten.Size = New System.Drawing.Size(181, 22)
        Me.MsVeranstaltungsdaten.Text = "Veranstaltungsdaten"
        '
        'MsDtsLeeren
        '
        Me.MsDtsLeeren.Name = "MsDtsLeeren"
        Me.MsDtsLeeren.Size = New System.Drawing.Size(181, 22)
        Me.MsDtsLeeren.Text = "Datenbank leeren"
        '
        'MannschaftenToolStripMenuItem
        '
        Me.MannschaftenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsJuFla2AddMannschaft, Me.MsJuFla3AddMannschaft, Me.MsUebersichtMannschaften})
        Me.MannschaftenToolStripMenuItem.Name = "MannschaftenToolStripMenuItem"
        Me.MannschaftenToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.MannschaftenToolStripMenuItem.Text = "Mannschaften"
        '
        'MsJuFla2AddMannschaft
        '
        Me.MsJuFla2AddMannschaft.Name = "MsJuFla2AddMannschaft"
        Me.MsJuFla2AddMannschaft.Size = New System.Drawing.Size(239, 22)
        Me.MsJuFla2AddMannschaft.Text = "Mannschaft Stufe 2 hinzufügen"
        '
        'MsJuFla3AddMannschaft
        '
        Me.MsJuFla3AddMannschaft.Name = "MsJuFla3AddMannschaft"
        Me.MsJuFla3AddMannschaft.Size = New System.Drawing.Size(239, 22)
        Me.MsJuFla3AddMannschaft.Text = "Mannschaft Stufe 3 hinzufügen"
        '
        'MsUebersichtMannschaften
        '
        Me.MsUebersichtMannschaften.Name = "MsUebersichtMannschaften"
        Me.MsUebersichtMannschaften.Size = New System.Drawing.Size(239, 22)
        Me.MsUebersichtMannschaften.Text = "Übersicht Mannschaften"
        '
        'WettbewerbToolStripMenuItem
        '
        Me.WettbewerbToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsWettbewerbseingabe})
        Me.WettbewerbToolStripMenuItem.Name = "WettbewerbToolStripMenuItem"
        Me.WettbewerbToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.WettbewerbToolStripMenuItem.Text = "Wettbewerb"
        '
        'MsWettbewerbseingabe
        '
        Me.MsWettbewerbseingabe.Name = "MsWettbewerbseingabe"
        Me.MsWettbewerbseingabe.Size = New System.Drawing.Size(185, 22)
        Me.MsWettbewerbseingabe.Text = "Wettbewerbseingabe"
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
        Me.BtJuFla2Import.Image = Global.JuFla_vb.My.Resources.Resources.icon
        Me.BtJuFla2Import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtJuFla2Import.Location = New System.Drawing.Point(620, 34)
        Me.BtJuFla2Import.Name = "BtJuFla2Import"
        Me.BtJuFla2Import.Size = New System.Drawing.Size(72, 39)
        Me.BtJuFla2Import.TabIndex = 14
        Me.BtJuFla2Import.Text = "Import"
        Me.BtJuFla2Import.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label3.Location = New System.Drawing.Point(221, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Bewerber:"
        '
        'TbJuFla2AnzMember
        '
        Me.TbJuFla2AnzMember.Location = New System.Drawing.Point(282, 53)
        Me.TbJuFla2AnzMember.Name = "TbJuFla2AnzMember"
        Me.TbJuFla2AnzMember.ReadOnly = True
        Me.TbJuFla2AnzMember.Size = New System.Drawing.Size(100, 20)
        Me.TbJuFla2AnzMember.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Startnummer"
        '
        'TbRoJuFla2Startnummer
        '
        Me.TbRoJuFla2Startnummer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BsJuFla2Mannschaften, "Startnummer", True))
        Me.TbRoJuFla2Startnummer.Location = New System.Drawing.Point(90, 53)
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
        Me.DgvJuFla2Member.ContextMenuStrip = Me.CmsJuFla2Member
        Me.DgvJuFla2Member.DataSource = Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource
        Me.DgvJuFla2Member.Location = New System.Drawing.Point(11, 87)
        Me.DgvJuFla2Member.Name = "DgvJuFla2Member"
        Me.DgvJuFla2Member.Size = New System.Drawing.Size(1086, 407)
        Me.DgvJuFla2Member.TabIndex = 5
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
        Me.StartnummerDataGridViewTextBoxColumn1.Visible = False
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'VornameDataGridViewTextBoxColumn
        '
        Me.VornameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.VornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname"
        Me.VornameDataGridViewTextBoxColumn.HeaderText = "Vorname"
        Me.VornameDataGridViewTextBoxColumn.Name = "VornameDataGridViewTextBoxColumn"
        '
        'GeschlechtDataGridViewTextBoxColumn
        '
        Me.GeschlechtDataGridViewTextBoxColumn.DataPropertyName = "Geschlecht"
        Me.GeschlechtDataGridViewTextBoxColumn.HeaderText = "Geschlecht"
        Me.GeschlechtDataGridViewTextBoxColumn.Name = "GeschlechtDataGridViewTextBoxColumn"
        '
        'GeburtsdatumDataGridViewTextBoxColumn
        '
        Me.GeburtsdatumDataGridViewTextBoxColumn.DataPropertyName = "Geburtsdatum"
        Me.GeburtsdatumDataGridViewTextBoxColumn.HeaderText = "Geburtsdatum"
        Me.GeburtsdatumDataGridViewTextBoxColumn.Name = "GeburtsdatumDataGridViewTextBoxColumn"
        '
        'AusweisnummerDataGridViewTextBoxColumn
        '
        Me.AusweisnummerDataGridViewTextBoxColumn.DataPropertyName = "Ausweisnummer"
        Me.AusweisnummerDataGridViewTextBoxColumn.HeaderText = "Ausweisnummer"
        Me.AusweisnummerDataGridViewTextBoxColumn.Name = "AusweisnummerDataGridViewTextBoxColumn"
        '
        'ValFwPrakDataGridViewTextBoxColumn
        '
        Me.ValFwPrakDataGridViewTextBoxColumn.DataPropertyName = "ValFwPrak"
        Me.ValFwPrakDataGridViewTextBoxColumn.HeaderText = "FW-Praxis"
        Me.ValFwPrakDataGridViewTextBoxColumn.Name = "ValFwPrakDataGridViewTextBoxColumn"
        '
        'ValFwTheorieDataGridViewTextBoxColumn
        '
        Me.ValFwTheorieDataGridViewTextBoxColumn.DataPropertyName = "ValFwTheorie"
        Me.ValFwTheorieDataGridViewTextBoxColumn.HeaderText = "FW-Theorie"
        Me.ValFwTheorieDataGridViewTextBoxColumn.Name = "ValFwTheorieDataGridViewTextBoxColumn"
        '
        'ValSportDataGridViewCheckBoxColumn
        '
        Me.ValSportDataGridViewCheckBoxColumn.DataPropertyName = "ValSport"
        Me.ValSportDataGridViewCheckBoxColumn.HeaderText = "Sportnachweis"
        Me.ValSportDataGridViewCheckBoxColumn.Name = "ValSportDataGridViewCheckBoxColumn"
        '
        'FinishedDataGridViewCheckBoxColumn
        '
        Me.FinishedDataGridViewCheckBoxColumn.DataPropertyName = "finished"
        Me.FinishedDataGridViewCheckBoxColumn.HeaderText = "Bestanden"
        Me.FinishedDataGridViewCheckBoxColumn.Name = "FinishedDataGridViewCheckBoxColumn"
        '
        'CmsJuFla2Member
        '
        Me.CmsJuFla2Member.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmsJuFla2RemoveMember})
        Me.CmsJuFla2Member.Name = "CmsJuFla2Teilnehmer"
        Me.CmsJuFla2Member.Size = New System.Drawing.Size(188, 26)
        '
        'CmsJuFla2RemoveMember
        '
        Me.CmsJuFla2RemoveMember.Name = "CmsJuFla2RemoveMember"
        Me.CmsJuFla2RemoveMember.Size = New System.Drawing.Size(187, 22)
        Me.CmsJuFla2RemoveMember.Text = "Teilnehmer entfernen"
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
        Me.DgvJuFla2Mannschaften.Location = New System.Drawing.Point(955, -7)
        Me.DgvJuFla2Mannschaften.Name = "DgvJuFla2Mannschaften"
        Me.DgvJuFla2Mannschaften.Size = New System.Drawing.Size(150, 59)
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
        Me.Label1.Location = New System.Drawing.Point(8, 22)
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
        Me.CbJuFla2Ort.Location = New System.Drawing.Point(90, 19)
        Me.CbJuFla2Ort.Name = "CbJuFla2Ort"
        Me.CbJuFla2Ort.Size = New System.Drawing.Size(292, 21)
        Me.CbJuFla2Ort.TabIndex = 0
        '
        'TpJuFla3
        '
        Me.TpJuFla3.Controls.Add(Me.BtJuFla3Import)
        Me.TpJuFla3.Controls.Add(Me.BtJuFla3PrintMember)
        Me.TpJuFla3.Controls.Add(Me.BtJuFla3AddMember)
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
        'BtJuFla3Import
        '
        Me.BtJuFla3Import.Image = Global.JuFla_vb.My.Resources.Resources.icon
        Me.BtJuFla3Import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtJuFla3Import.Location = New System.Drawing.Point(617, 37)
        Me.BtJuFla3Import.Name = "BtJuFla3Import"
        Me.BtJuFla3Import.Size = New System.Drawing.Size(73, 39)
        Me.BtJuFla3Import.TabIndex = 17
        Me.BtJuFla3Import.Text = "Import"
        Me.BtJuFla3Import.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtJuFla3Import.UseVisualStyleBackColor = True
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
        'BtJuFla3AddMember
        '
        Me.BtJuFla3AddMember.Image = Global.JuFla_vb.My.Resources.Resources.add
        Me.BtJuFla3AddMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtJuFla3AddMember.Location = New System.Drawing.Point(400, 37)
        Me.BtJuFla3AddMember.Name = "BtJuFla3AddMember"
        Me.BtJuFla3AddMember.Size = New System.Drawing.Size(97, 39)
        Me.BtJuFla3AddMember.TabIndex = 15
        Me.BtJuFla3AddMember.Text = "Teilnehmer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hinzufügen"
        Me.BtJuFla3AddMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtJuFla3AddMember.UseVisualStyleBackColor = True
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
        Me.DgvJuFla3Member.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StartnummerDataGridViewTextBoxColumn3, Me.NameDataGridViewTextBoxColumn1, Me.VornameDataGridViewTextBoxColumn1, Me.GeschlechtDataGridViewTextBoxColumn1, Me.GeburtsdatumDataGridViewTextBoxColumn1, Me.AusweisnummerDataGridViewTextBoxColumn1, Me.ValFwTechnikDataGridViewTextBoxColumn, Me.ValEhAufgabeDataGridViewTextBoxColumn, Me.ValPraesentationDataGridViewCheckBoxColumn, Me.ValEhNachweisDataGridViewCheckBoxColumn, Me.FinishedDataGridViewCheckBoxColumn1, Me.ComboNameDataGridViewTextBoxColumn})
        Me.DgvJuFla3Member.ContextMenuStrip = Me.CmsJuFla3Member
        Me.DgvJuFla3Member.DataSource = Me.BsJuFla3Member
        Me.DgvJuFla3Member.Location = New System.Drawing.Point(11, 89)
        Me.DgvJuFla3Member.Name = "DgvJuFla3Member"
        Me.DgvJuFla3Member.Size = New System.Drawing.Size(1143, 411)
        Me.DgvJuFla3Member.TabIndex = 2
        '
        'StartnummerDataGridViewTextBoxColumn3
        '
        Me.StartnummerDataGridViewTextBoxColumn3.DataPropertyName = "Startnummer"
        Me.StartnummerDataGridViewTextBoxColumn3.HeaderText = "Startnummer"
        Me.StartnummerDataGridViewTextBoxColumn3.Name = "StartnummerDataGridViewTextBoxColumn3"
        Me.StartnummerDataGridViewTextBoxColumn3.Visible = False
        '
        'NameDataGridViewTextBoxColumn1
        '
        Me.NameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn1.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn1.Name = "NameDataGridViewTextBoxColumn1"
        '
        'VornameDataGridViewTextBoxColumn1
        '
        Me.VornameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.VornameDataGridViewTextBoxColumn1.DataPropertyName = "Vorname"
        Me.VornameDataGridViewTextBoxColumn1.HeaderText = "Vorname"
        Me.VornameDataGridViewTextBoxColumn1.Name = "VornameDataGridViewTextBoxColumn1"
        '
        'GeschlechtDataGridViewTextBoxColumn1
        '
        Me.GeschlechtDataGridViewTextBoxColumn1.DataPropertyName = "Geschlecht"
        Me.GeschlechtDataGridViewTextBoxColumn1.HeaderText = "Geschlecht"
        Me.GeschlechtDataGridViewTextBoxColumn1.Name = "GeschlechtDataGridViewTextBoxColumn1"
        '
        'GeburtsdatumDataGridViewTextBoxColumn1
        '
        Me.GeburtsdatumDataGridViewTextBoxColumn1.DataPropertyName = "Geburtsdatum"
        Me.GeburtsdatumDataGridViewTextBoxColumn1.HeaderText = "Geburtsdatum"
        Me.GeburtsdatumDataGridViewTextBoxColumn1.Name = "GeburtsdatumDataGridViewTextBoxColumn1"
        '
        'AusweisnummerDataGridViewTextBoxColumn1
        '
        Me.AusweisnummerDataGridViewTextBoxColumn1.DataPropertyName = "Ausweisnummer"
        Me.AusweisnummerDataGridViewTextBoxColumn1.HeaderText = "Ausweisnummer"
        Me.AusweisnummerDataGridViewTextBoxColumn1.Name = "AusweisnummerDataGridViewTextBoxColumn1"
        '
        'ValFwTechnikDataGridViewTextBoxColumn
        '
        Me.ValFwTechnikDataGridViewTextBoxColumn.DataPropertyName = "ValFwTechnik"
        Me.ValFwTechnikDataGridViewTextBoxColumn.HeaderText = "FW-Technik"
        Me.ValFwTechnikDataGridViewTextBoxColumn.Name = "ValFwTechnikDataGridViewTextBoxColumn"
        '
        'ValEhAufgabeDataGridViewTextBoxColumn
        '
        Me.ValEhAufgabeDataGridViewTextBoxColumn.DataPropertyName = "ValEhAufgabe"
        Me.ValEhAufgabeDataGridViewTextBoxColumn.HeaderText = "EH-Aufgabe"
        Me.ValEhAufgabeDataGridViewTextBoxColumn.Name = "ValEhAufgabeDataGridViewTextBoxColumn"
        '
        'ValPraesentationDataGridViewCheckBoxColumn
        '
        Me.ValPraesentationDataGridViewCheckBoxColumn.DataPropertyName = "ValPraesentation"
        Me.ValPraesentationDataGridViewCheckBoxColumn.HeaderText = "Präsentation"
        Me.ValPraesentationDataGridViewCheckBoxColumn.Name = "ValPraesentationDataGridViewCheckBoxColumn"
        Me.ValPraesentationDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ValPraesentationDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ValEhNachweisDataGridViewCheckBoxColumn
        '
        Me.ValEhNachweisDataGridViewCheckBoxColumn.DataPropertyName = "ValEhNachweis"
        Me.ValEhNachweisDataGridViewCheckBoxColumn.HeaderText = "EH-Nachweis"
        Me.ValEhNachweisDataGridViewCheckBoxColumn.Name = "ValEhNachweisDataGridViewCheckBoxColumn"
        '
        'FinishedDataGridViewCheckBoxColumn1
        '
        Me.FinishedDataGridViewCheckBoxColumn1.DataPropertyName = "finished"
        Me.FinishedDataGridViewCheckBoxColumn1.HeaderText = "Bestanden"
        Me.FinishedDataGridViewCheckBoxColumn1.Name = "FinishedDataGridViewCheckBoxColumn1"
        '
        'ComboNameDataGridViewTextBoxColumn
        '
        Me.ComboNameDataGridViewTextBoxColumn.DataPropertyName = "ComboName"
        Me.ComboNameDataGridViewTextBoxColumn.HeaderText = "ComboName"
        Me.ComboNameDataGridViewTextBoxColumn.Name = "ComboNameDataGridViewTextBoxColumn"
        Me.ComboNameDataGridViewTextBoxColumn.Visible = False
        '
        'CmsJuFla3Member
        '
        Me.CmsJuFla3Member.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmsJuFla3RemoveMember})
        Me.CmsJuFla3Member.Name = "CmsJuFla3Member"
        Me.CmsJuFla3Member.Size = New System.Drawing.Size(188, 26)
        '
        'CmsJuFla3RemoveMember
        '
        Me.CmsJuFla3RemoveMember.Name = "CmsJuFla3RemoveMember"
        Me.CmsJuFla3RemoveMember.Size = New System.Drawing.Size(187, 22)
        Me.CmsJuFla3RemoveMember.Text = "Teilnehmer entfernen"
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
        'DtsJuFla1
        '
        Me.DtsJuFla1.DataSetName = "DtsJuFla"
        Me.DtsJuFla1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BsJuFla2Member
        '
        Me.BsJuFla2Member.DataMember = "TblJuFla2Mannschaften_TblJuFla2Member"
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
        Me.CmsJuFla2Member.ResumeLayout(False)
        CType(Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvJuFla2Mannschaften, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpJuFla3.ResumeLayout(False)
        Me.TpJuFla3.PerformLayout()
        CType(Me.BsJuFla3Mannschaften, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvJuFla3Member, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsJuFla3Member.ResumeLayout(False)
        CType(Me.BsJuFla3Member, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvJuFla3Mannschaften, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsJuFla1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsJuFla2Member, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MsMain As MenuStrip
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsVeranstaltungsdaten As ToolStripMenuItem
    Friend WithEvents TcMain As TabControl
    Friend WithEvents TpJuFla2 As TabPage
    Friend WithEvents TpJuFla3 As TabPage
    Friend WithEvents CbJuFla2Ort As ComboBox
    Friend WithEvents DtsJuFla As DtsJuFla
    Friend WithEvents DgvJuFla2Mannschaften As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvJuFla2Member As DataGridView
    Friend WithEvents MannschaftenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsJuFla2AddMannschaft As ToolStripMenuItem
    Friend WithEvents MsJuFla3AddMannschaft As ToolStripMenuItem
    Friend WithEvents MsUebersichtMannschaften As ToolStripMenuItem
    Friend WithEvents DgvJuFla3Mannschaften As DataGridView
    Friend WithEvents TbRoJuFla2Startnummer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbJuFla2AnzMember As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TiMain As Timer
    Friend WithEvents WettbewerbToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsWettbewerbseingabe As ToolStripMenuItem
    Friend WithEvents BtJuFla2AddMember As Button
    Friend WithEvents MsDtsLeeren As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents CmsJuFla2Member As ContextMenuStrip
    Friend WithEvents CmsJuFla2RemoveMember As ToolStripMenuItem
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
    Friend WithEvents BtJuFla3AddMember As Button
    Friend WithEvents BtJuFla2PrintMember As Button
    Friend WithEvents BtJuFla3PrintMember As Button
    Friend WithEvents BtJuFla2Import As Button
    Friend WithEvents BtJuFla3Import As Button
    Friend WithEvents CmsJuFla3RemoveMember As ToolStripMenuItem
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
End Class
