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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MsMain = New System.Windows.Forms.MenuStrip()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsVeranstaltungsdaten = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsDtsLeeren = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsStatistik = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsUpload = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsDownload = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.MannschaftenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsJuFla2AddMannschaft = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsJuFla3AddMannschaft = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsUebersichtMannschaften = New System.Windows.Forms.ToolStripMenuItem()
        Me.WettbewerbToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsWettbewerbseingabe = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsWettbInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsCbVeranstaltung = New System.Windows.Forms.ToolStripComboBox()
        Me.BewerberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsJuFla2AddMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsJuFla3AddMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsPrintJuFla2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsPrintJuFla3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TcMain = New System.Windows.Forms.TabControl()
        Me.TpJuFla2 = New System.Windows.Forms.TabPage()
        Me.TbJuFla2Startnummer = New System.Windows.Forms.TextBox()
        Me.DgvJuFla2Member = New System.Windows.Forms.DataGridView()
        Me.CbJuFla2Mannschaft = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtJuFla2Import = New System.Windows.Forms.Button()
        Me.BtJuFla2PrintMember = New System.Windows.Forms.Button()
        Me.BtJuFla2AddMember = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbJuFla2AnzMember = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TpJuFla3 = New System.Windows.Forms.TabPage()
        Me.TbJuFla3Startnummer = New System.Windows.Forms.TextBox()
        Me.DgvJuFla3Member = New System.Windows.Forms.DataGridView()
        Me.DtsJuFla = New JuFla_vb.DtsJuFla()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtJuFla3Import = New System.Windows.Forms.Button()
        Me.BtJuFla3PrintMember = New System.Windows.Forms.Button()
        Me.BtJuFla3AddMember = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbJuFla3AnzBewerber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbJuFla3Mannschaft = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmsJuFla2Member = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CmsJuFla2RemoveMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmsJuFla3Member = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CmsJuFla3RemoveMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiMain = New System.Windows.Forms.Timer(Me.components)
        Me.NiMain = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TtMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.TblJuFla2MannschaftenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblJuFla3MannschaftenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BsEvents = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEventsTblJuFla2MannschaftenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEventsTblJuFla3MannschaftenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblJuFla3MannschaftenTblJuFla3MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MannschaftsIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VornameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeschlechtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeburtsdatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AusweisnummerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValFwPrakDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValFwTheorieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValSportDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FinishedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ComboNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MannschaftsIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VornameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeschlechtDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeburtsdatumDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AusweisnummerDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValFwTechnikDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValEhAufgabeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValPraesentationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinishedDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ValEhNachweisDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ComboNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MsMain.SuspendLayout()
        Me.TcMain.SuspendLayout()
        Me.TpJuFla2.SuspendLayout()
        CType(Me.DgvJuFla2Member, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpJuFla3.SuspendLayout()
        CType(Me.DgvJuFla3Member, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsJuFla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsJuFla2Member.SuspendLayout()
        Me.CmsJuFla3Member.SuspendLayout()
        CType(Me.TblJuFla2MannschaftenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJuFla3MannschaftenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEventsTblJuFla2MannschaftenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEventsTblJuFla3MannschaftenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJuFla3MannschaftenTblJuFla3MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MsMain
        '
        Me.MsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.DatenbankToolStripMenuItem, Me.MannschaftenToolStripMenuItem, Me.WettbewerbToolStripMenuItem, Me.MsCbVeranstaltung, Me.BewerberToolStripMenuItem})
        Me.MsMain.Location = New System.Drawing.Point(0, 0)
        Me.MsMain.Name = "MsMain"
        Me.MsMain.Size = New System.Drawing.Size(1190, 27)
        Me.MsMain.TabIndex = 0
        Me.MsMain.Text = "MenuStrip1"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsVeranstaltungsdaten, Me.MsDtsLeeren, Me.MsStatistik})
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(43, 23)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'MsVeranstaltungsdaten
        '
        Me.MsVeranstaltungsdaten.Image = Global.JuFla_vb.My.Resources.Resources._event
        Me.MsVeranstaltungsdaten.Name = "MsVeranstaltungsdaten"
        Me.MsVeranstaltungsdaten.Size = New System.Drawing.Size(181, 22)
        Me.MsVeranstaltungsdaten.Text = "Veranstaltungsdaten"
        Me.MsVeranstaltungsdaten.ToolTipText = "Zeigt eine Übersicht aller Veranstaltungen an"
        '
        'MsDtsLeeren
        '
        Me.MsDtsLeeren.Image = Global.JuFla_vb.My.Resources.Resources.delete_rubbish
        Me.MsDtsLeeren.Name = "MsDtsLeeren"
        Me.MsDtsLeeren.Size = New System.Drawing.Size(181, 22)
        Me.MsDtsLeeren.Text = "Datenbank leeren"
        Me.MsDtsLeeren.ToolTipText = "Leert die aktuelle Datenbank und legt eine Sicherungsdatei an"
        '
        'MsStatistik
        '
        Me.MsStatistik.Image = Global.JuFla_vb.My.Resources.Resources.pie_chart
        Me.MsStatistik.Name = "MsStatistik"
        Me.MsStatistik.Size = New System.Drawing.Size(181, 22)
        Me.MsStatistik.Text = "Statistik"
        '
        'DatenbankToolStripMenuItem
        '
        Me.DatenbankToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsUpload, Me.MsDownload, Me.MsExport})
        Me.DatenbankToolStripMenuItem.Name = "DatenbankToolStripMenuItem"
        Me.DatenbankToolStripMenuItem.Size = New System.Drawing.Size(76, 23)
        Me.DatenbankToolStripMenuItem.Text = "Datenbank"
        '
        'MsUpload
        '
        Me.MsUpload.Image = Global.JuFla_vb.My.Resources.Resources.upload
        Me.MsUpload.Name = "MsUpload"
        Me.MsUpload.Size = New System.Drawing.Size(196, 22)
        Me.MsUpload.Text = "Push Datenbank to FTP"
        Me.MsUpload.ToolTipText = "Läd den aktuellen Datenbestand zum Server"
        '
        'MsDownload
        '
        Me.MsDownload.Image = Global.JuFla_vb.My.Resources.Resources.download
        Me.MsDownload.Name = "MsDownload"
        Me.MsDownload.Size = New System.Drawing.Size(196, 22)
        Me.MsDownload.Text = "Fetch Server-DB"
        Me.MsDownload.ToolTipText = "Läd Server-Datenbank herunter"
        '
        'MsExport
        '
        Me.MsExport.Image = Global.JuFla_vb.My.Resources.Resources.export
        Me.MsExport.Name = "MsExport"
        Me.MsExport.Size = New System.Drawing.Size(196, 22)
        Me.MsExport.Text = "Export"
        Me.MsExport.ToolTipText = "Exportiert die Datenbank im XML-Format "
        '
        'MannschaftenToolStripMenuItem
        '
        Me.MannschaftenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsJuFla2AddMannschaft, Me.MsJuFla3AddMannschaft, Me.MsUebersichtMannschaften})
        Me.MannschaftenToolStripMenuItem.Name = "MannschaftenToolStripMenuItem"
        Me.MannschaftenToolStripMenuItem.Size = New System.Drawing.Size(95, 23)
        Me.MannschaftenToolStripMenuItem.Text = "Mannschaften"
        '
        'MsJuFla2AddMannschaft
        '
        Me.MsJuFla2AddMannschaft.Image = Global.JuFla_vb.My.Resources.Resources.Ico_add
        Me.MsJuFla2AddMannschaft.Name = "MsJuFla2AddMannschaft"
        Me.MsJuFla2AddMannschaft.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.MsJuFla2AddMannschaft.Size = New System.Drawing.Size(258, 22)
        Me.MsJuFla2AddMannschaft.Text = "Mannschaft Stufe 2 hinzufügen"
        Me.MsJuFla2AddMannschaft.ToolTipText = "Fügt eine Mannschaft zur Jugendflamme Stufe 2 hinzu"
        '
        'MsJuFla3AddMannschaft
        '
        Me.MsJuFla3AddMannschaft.Image = Global.JuFla_vb.My.Resources.Resources.Ico_add
        Me.MsJuFla3AddMannschaft.Name = "MsJuFla3AddMannschaft"
        Me.MsJuFla3AddMannschaft.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.MsJuFla3AddMannschaft.Size = New System.Drawing.Size(258, 22)
        Me.MsJuFla3AddMannschaft.Text = "Mannschaft Stufe 3 hinzufügen"
        Me.MsJuFla3AddMannschaft.ToolTipText = "Fügt eine Mannschaft zur Jugendflamme Stufe 2 hinzu"
        '
        'MsUebersichtMannschaften
        '
        Me.MsUebersichtMannschaften.Image = Global.JuFla_vb.My.Resources.Resources.information
        Me.MsUebersichtMannschaften.Name = "MsUebersichtMannschaften"
        Me.MsUebersichtMannschaften.Size = New System.Drawing.Size(258, 22)
        Me.MsUebersichtMannschaften.Text = "Übersicht Mannschaften"
        Me.MsUebersichtMannschaften.ToolTipText = "Zeigt eine Übersicht aller Mannschaften des akuellen Events an"
        '
        'WettbewerbToolStripMenuItem
        '
        Me.WettbewerbToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsWettbewerbseingabe, Me.MsWettbInfo})
        Me.WettbewerbToolStripMenuItem.Name = "WettbewerbToolStripMenuItem"
        Me.WettbewerbToolStripMenuItem.Size = New System.Drawing.Size(83, 23)
        Me.WettbewerbToolStripMenuItem.Text = "Wettbewerb"
        '
        'MsWettbewerbseingabe
        '
        Me.MsWettbewerbseingabe.Image = Global.JuFla_vb.My.Resources.Resources.edit
        Me.MsWettbewerbseingabe.Name = "MsWettbewerbseingabe"
        Me.MsWettbewerbseingabe.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.MsWettbewerbseingabe.Size = New System.Drawing.Size(204, 22)
        Me.MsWettbewerbseingabe.Text = "Wettbewerbseingabe"
        Me.MsWettbewerbseingabe.ToolTipText = "Öffnet die Eingabemaske zur Wettbewerbseingabe"
        '
        'MsWettbInfo
        '
        Me.MsWettbInfo.Enabled = False
        Me.MsWettbInfo.Image = Global.JuFla_vb.My.Resources.Resources.information
        Me.MsWettbInfo.Name = "MsWettbInfo"
        Me.MsWettbInfo.Size = New System.Drawing.Size(204, 22)
        Me.MsWettbInfo.Text = "Wettbewerbsinfo"
        Me.MsWettbInfo.ToolTipText = "BETA!"
        '
        'MsCbVeranstaltung
        '
        Me.MsCbVeranstaltung.Name = "MsCbVeranstaltung"
        Me.MsCbVeranstaltung.Size = New System.Drawing.Size(121, 23)
        Me.MsCbVeranstaltung.Text = "Veranstaltung"
        Me.MsCbVeranstaltung.ToolTipText = "Veranstaltung nach Veranstaltungs-ID"
        '
        'BewerberToolStripMenuItem
        '
        Me.BewerberToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsJuFla2AddMember, Me.MsJuFla3AddMember, Me.MsPrintJuFla2, Me.MsPrintJuFla3})
        Me.BewerberToolStripMenuItem.Name = "BewerberToolStripMenuItem"
        Me.BewerberToolStripMenuItem.Size = New System.Drawing.Size(68, 23)
        Me.BewerberToolStripMenuItem.Text = "Bewerber"
        Me.BewerberToolStripMenuItem.Visible = False
        '
        'MsJuFla2AddMember
        '
        Me.MsJuFla2AddMember.Name = "MsJuFla2AddMember"
        Me.MsJuFla2AddMember.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.MsJuFla2AddMember.Size = New System.Drawing.Size(206, 22)
        Me.MsJuFla2AddMember.Text = "Add Bewerber Stufe 2"
        '
        'MsJuFla3AddMember
        '
        Me.MsJuFla3AddMember.Name = "MsJuFla3AddMember"
        Me.MsJuFla3AddMember.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.MsJuFla3AddMember.Size = New System.Drawing.Size(206, 22)
        Me.MsJuFla3AddMember.Text = "Add Bewerber Stufe 3"
        '
        'MsPrintJuFla2
        '
        Me.MsPrintJuFla2.Name = "MsPrintJuFla2"
        Me.MsPrintJuFla2.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.MsPrintJuFla2.Size = New System.Drawing.Size(206, 22)
        Me.MsPrintJuFla2.Text = "Print BW-List JuFla2"
        '
        'MsPrintJuFla3
        '
        Me.MsPrintJuFla3.Name = "MsPrintJuFla3"
        Me.MsPrintJuFla3.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.MsPrintJuFla3.Size = New System.Drawing.Size(206, 22)
        Me.MsPrintJuFla3.Text = "Print BW-List JuFla3"
        '
        'TcMain
        '
        Me.TcMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TcMain.Controls.Add(Me.TpJuFla2)
        Me.TcMain.Controls.Add(Me.TpJuFla3)
        Me.TcMain.Location = New System.Drawing.Point(0, 27)
        Me.TcMain.Name = "TcMain"
        Me.TcMain.SelectedIndex = 0
        Me.TcMain.Size = New System.Drawing.Size(1190, 561)
        Me.TcMain.TabIndex = 1
        '
        'TpJuFla2
        '
        Me.TpJuFla2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TpJuFla2.Controls.Add(Me.TbJuFla2Startnummer)
        Me.TpJuFla2.Controls.Add(Me.DgvJuFla2Member)
        Me.TpJuFla2.Controls.Add(Me.CbJuFla2Mannschaft)
        Me.TpJuFla2.Controls.Add(Me.Label7)
        Me.TpJuFla2.Controls.Add(Me.BtJuFla2Import)
        Me.TpJuFla2.Controls.Add(Me.BtJuFla2PrintMember)
        Me.TpJuFla2.Controls.Add(Me.BtJuFla2AddMember)
        Me.TpJuFla2.Controls.Add(Me.Label3)
        Me.TpJuFla2.Controls.Add(Me.TbJuFla2AnzMember)
        Me.TpJuFla2.Controls.Add(Me.Label2)
        Me.TpJuFla2.Controls.Add(Me.Label1)
        Me.TpJuFla2.Location = New System.Drawing.Point(4, 22)
        Me.TpJuFla2.Name = "TpJuFla2"
        Me.TpJuFla2.Padding = New System.Windows.Forms.Padding(3)
        Me.TpJuFla2.Size = New System.Drawing.Size(1182, 535)
        Me.TpJuFla2.TabIndex = 0
        Me.TpJuFla2.Text = "Jugendflamme Stufe 2"
        '
        'TbJuFla2Startnummer
        '
        Me.TbJuFla2Startnummer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEventsTblJuFla2MannschaftenBindingSource, "Startnummer", True))
        Me.TbJuFla2Startnummer.Location = New System.Drawing.Point(90, 53)
        Me.TbJuFla2Startnummer.Name = "TbJuFla2Startnummer"
        Me.TbJuFla2Startnummer.ReadOnly = True
        Me.TbJuFla2Startnummer.Size = New System.Drawing.Size(100, 20)
        Me.TbJuFla2Startnummer.TabIndex = 19
        Me.TtMain.SetToolTip(Me.TbJuFla2Startnummer, "Anzahl der Bewerber der ausgewählten Mannschaft der Jugendflamme Stufe 2")
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
        Me.DgvJuFla2Member.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.MannschaftsIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.VornameDataGridViewTextBoxColumn, Me.GeschlechtDataGridViewTextBoxColumn, Me.GeburtsdatumDataGridViewTextBoxColumn, Me.AusweisnummerDataGridViewTextBoxColumn, Me.ValFwPrakDataGridViewTextBoxColumn, Me.ValFwTheorieDataGridViewTextBoxColumn, Me.ValSportDataGridViewCheckBoxColumn, Me.FinishedDataGridViewCheckBoxColumn, Me.ComboNameDataGridViewTextBoxColumn})
        Me.DgvJuFla2Member.DataSource = Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource
        Me.DgvJuFla2Member.Location = New System.Drawing.Point(11, 90)
        Me.DgvJuFla2Member.Name = "DgvJuFla2Member"
        Me.DgvJuFla2Member.ReadOnly = True
        Me.DgvJuFla2Member.Size = New System.Drawing.Size(1146, 421)
        Me.DgvJuFla2Member.TabIndex = 18
        '
        'CbJuFla2Mannschaft
        '
        Me.CbJuFla2Mannschaft.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblJuFla2MannschaftenBindingSource, "Ort", True))
        Me.CbJuFla2Mannschaft.DataSource = Me.TblEventsTblJuFla2MannschaftenBindingSource
        Me.CbJuFla2Mannschaft.DisplayMember = "Ort"
        Me.CbJuFla2Mannschaft.FormattingEnabled = True
        Me.CbJuFla2Mannschaft.Location = New System.Drawing.Point(90, 18)
        Me.CbJuFla2Mannschaft.Name = "CbJuFla2Mannschaft"
        Me.CbJuFla2Mannschaft.Size = New System.Drawing.Size(292, 21)
        Me.CbJuFla2Mannschaft.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(708, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(449, 29)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "JUGENDFLAMME DER DJF STUFE 2"
        '
        'BtJuFla2Import
        '
        Me.BtJuFla2Import.Image = Global.JuFla_vb.My.Resources.Resources.Ico_excel
        Me.BtJuFla2Import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtJuFla2Import.Location = New System.Drawing.Point(630, 34)
        Me.BtJuFla2Import.Name = "BtJuFla2Import"
        Me.BtJuFla2Import.Size = New System.Drawing.Size(72, 39)
        Me.BtJuFla2Import.TabIndex = 14
        Me.BtJuFla2Import.Text = "Import"
        Me.BtJuFla2Import.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtJuFla2Import.UseVisualStyleBackColor = True
        '
        'BtJuFla2PrintMember
        '
        Me.BtJuFla2PrintMember.Image = Global.JuFla_vb.My.Resources.Resources.Ico_print
        Me.BtJuFla2PrintMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtJuFla2PrintMember.Location = New System.Drawing.Point(516, 34)
        Me.BtJuFla2PrintMember.Name = "BtJuFla2PrintMember"
        Me.BtJuFla2PrintMember.Size = New System.Drawing.Size(108, 39)
        Me.BtJuFla2PrintMember.TabIndex = 12
        Me.BtJuFla2PrintMember.Text = "Bewerberliste" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "drucken (F10)"
        Me.BtJuFla2PrintMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtJuFla2PrintMember.UseVisualStyleBackColor = True
        '
        'BtJuFla2AddMember
        '
        Me.BtJuFla2AddMember.Image = Global.JuFla_vb.My.Resources.Resources.Ico_add
        Me.BtJuFla2AddMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtJuFla2AddMember.Location = New System.Drawing.Point(399, 34)
        Me.BtJuFla2AddMember.Name = "BtJuFla2AddMember"
        Me.BtJuFla2AddMember.Size = New System.Drawing.Size(111, 39)
        Me.BtJuFla2AddMember.TabIndex = 11
        Me.BtJuFla2AddMember.Text = "Bewerber " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hinzufügen (F6)"
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
        Me.TtMain.SetToolTip(Me.TbJuFla2AnzMember, "Anzahl der Bewerber der ausgewählten Mannschaft der Jugendflamme Stufe 2")
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mannschaft"
        '
        'TpJuFla3
        '
        Me.TpJuFla3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TpJuFla3.Controls.Add(Me.TbJuFla3Startnummer)
        Me.TpJuFla3.Controls.Add(Me.DgvJuFla3Member)
        Me.TpJuFla3.Controls.Add(Me.Label8)
        Me.TpJuFla3.Controls.Add(Me.BtJuFla3Import)
        Me.TpJuFla3.Controls.Add(Me.BtJuFla3PrintMember)
        Me.TpJuFla3.Controls.Add(Me.BtJuFla3AddMember)
        Me.TpJuFla3.Controls.Add(Me.Label5)
        Me.TpJuFla3.Controls.Add(Me.TbJuFla3AnzBewerber)
        Me.TpJuFla3.Controls.Add(Me.Label6)
        Me.TpJuFla3.Controls.Add(Me.CbJuFla3Mannschaft)
        Me.TpJuFla3.Controls.Add(Me.Label4)
        Me.TpJuFla3.Location = New System.Drawing.Point(4, 22)
        Me.TpJuFla3.Name = "TpJuFla3"
        Me.TpJuFla3.Padding = New System.Windows.Forms.Padding(3)
        Me.TpJuFla3.Size = New System.Drawing.Size(1182, 535)
        Me.TpJuFla3.TabIndex = 1
        Me.TpJuFla3.Text = "Jugendflamme Stufe 3"
        '
        'TbJuFla3Startnummer
        '
        Me.TbJuFla3Startnummer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEventsTblJuFla3MannschaftenBindingSource, "Startnummer", True))
        Me.TbJuFla3Startnummer.Location = New System.Drawing.Point(90, 56)
        Me.TbJuFla3Startnummer.Name = "TbJuFla3Startnummer"
        Me.TbJuFla3Startnummer.ReadOnly = True
        Me.TbJuFla3Startnummer.Size = New System.Drawing.Size(100, 20)
        Me.TbJuFla3Startnummer.TabIndex = 21
        Me.TtMain.SetToolTip(Me.TbJuFla3Startnummer, "Anzahl der Bewerber der ausgewählten Mannschaft der Jugendflamme Stufe 3")
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
        Me.DgvJuFla3Member.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.MannschaftsIDDataGridViewTextBoxColumn1, Me.NameDataGridViewTextBoxColumn1, Me.VornameDataGridViewTextBoxColumn1, Me.GeschlechtDataGridViewTextBoxColumn1, Me.GeburtsdatumDataGridViewTextBoxColumn1, Me.AusweisnummerDataGridViewTextBoxColumn1, Me.ValFwTechnikDataGridViewTextBoxColumn, Me.ValEhAufgabeDataGridViewTextBoxColumn, Me.ValPraesentationDataGridViewTextBoxColumn, Me.FinishedDataGridViewCheckBoxColumn1, Me.ValEhNachweisDataGridViewCheckBoxColumn, Me.ComboNameDataGridViewTextBoxColumn1})
        Me.DgvJuFla3Member.DataSource = Me.TblJuFla3MannschaftenTblJuFla3MemberBindingSource
        Me.DgvJuFla3Member.Location = New System.Drawing.Point(14, 86)
        Me.DgvJuFla3Member.Name = "DgvJuFla3Member"
        Me.DgvJuFla3Member.ReadOnly = True
        Me.DgvJuFla3Member.Size = New System.Drawing.Size(1142, 426)
        Me.DgvJuFla3Member.TabIndex = 20
        '
        'DtsJuFla
        '
        Me.DtsJuFla.DataSetName = "DtsJuFla"
        Me.DtsJuFla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(708, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(449, 29)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "JUGENDFLAMME DER DJF STUFE 3"
        '
        'BtJuFla3Import
        '
        Me.BtJuFla3Import.Image = Global.JuFla_vb.My.Resources.Resources.Ico_excel
        Me.BtJuFla3Import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtJuFla3Import.Location = New System.Drawing.Point(629, 37)
        Me.BtJuFla3Import.Name = "BtJuFla3Import"
        Me.BtJuFla3Import.Size = New System.Drawing.Size(73, 39)
        Me.BtJuFla3Import.TabIndex = 17
        Me.BtJuFla3Import.Text = "Import"
        Me.BtJuFla3Import.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtJuFla3Import.UseVisualStyleBackColor = True
        '
        'BtJuFla3PrintMember
        '
        Me.BtJuFla3PrintMember.Image = Global.JuFla_vb.My.Resources.Resources.Ico_print
        Me.BtJuFla3PrintMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtJuFla3PrintMember.Location = New System.Drawing.Point(515, 37)
        Me.BtJuFla3PrintMember.Name = "BtJuFla3PrintMember"
        Me.BtJuFla3PrintMember.Size = New System.Drawing.Size(108, 39)
        Me.BtJuFla3PrintMember.TabIndex = 16
        Me.BtJuFla3PrintMember.Text = "Bewerberliste" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "drucken (F11)"
        Me.BtJuFla3PrintMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtJuFla3PrintMember.UseVisualStyleBackColor = True
        '
        'BtJuFla3AddMember
        '
        Me.BtJuFla3AddMember.Image = Global.JuFla_vb.My.Resources.Resources.Ico_add
        Me.BtJuFla3AddMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtJuFla3AddMember.Location = New System.Drawing.Point(399, 37)
        Me.BtJuFla3AddMember.Name = "BtJuFla3AddMember"
        Me.BtJuFla3AddMember.Size = New System.Drawing.Size(110, 39)
        Me.BtJuFla3AddMember.TabIndex = 15
        Me.BtJuFla3AddMember.Text = "Bewerber " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hinzufügen (F7)"
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
        Me.TtMain.SetToolTip(Me.TbJuFla3AnzBewerber, "Anzahl der Bewerber der ausgewählten Mannschaft der Jugendflamme Stufe 3")
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
        'CbJuFla3Mannschaft
        '
        Me.CbJuFla3Mannschaft.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblJuFla3MannschaftenBindingSource, "Ort", True))
        Me.CbJuFla3Mannschaft.DataSource = Me.TblEventsTblJuFla3MannschaftenBindingSource
        Me.CbJuFla3Mannschaft.FormattingEnabled = True
        Me.CbJuFla3Mannschaft.Location = New System.Drawing.Point(90, 19)
        Me.CbJuFla3Mannschaft.Name = "CbJuFla3Mannschaft"
        Me.CbJuFla3Mannschaft.Size = New System.Drawing.Size(292, 21)
        Me.CbJuFla3Mannschaft.TabIndex = 3
        Me.TtMain.SetToolTip(Me.CbJuFla3Mannschaft, "Mannschaft innerhalb der Jugendflamme Stufe 3 auswählen")
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
        'CmsJuFla2Member
        '
        Me.CmsJuFla2Member.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmsJuFla2RemoveMember})
        Me.CmsJuFla2Member.Name = "CmsJuFla2Teilnehmer"
        Me.CmsJuFla2Member.Size = New System.Drawing.Size(187, 26)
        '
        'CmsJuFla2RemoveMember
        '
        Me.CmsJuFla2RemoveMember.Name = "CmsJuFla2RemoveMember"
        Me.CmsJuFla2RemoveMember.Size = New System.Drawing.Size(186, 22)
        Me.CmsJuFla2RemoveMember.Text = "Teilnehmer entfernen"
        '
        'CmsJuFla3Member
        '
        Me.CmsJuFla3Member.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmsJuFla3RemoveMember})
        Me.CmsJuFla3Member.Name = "CmsJuFla3Member"
        Me.CmsJuFla3Member.Size = New System.Drawing.Size(187, 26)
        '
        'CmsJuFla3RemoveMember
        '
        Me.CmsJuFla3RemoveMember.Name = "CmsJuFla3RemoveMember"
        Me.CmsJuFla3RemoveMember.Size = New System.Drawing.Size(186, 22)
        Me.CmsJuFla3RemoveMember.Text = "Teilnehmer entfernen"
        '
        'TiMain
        '
        Me.TiMain.Interval = 1000
        '
        'NiMain
        '
        Me.NiMain.BalloonTipTitle = "Jugendflamme"
        Me.NiMain.Icon = CType(resources.GetObject("NiMain.Icon"), System.Drawing.Icon)
        Me.NiMain.Text = "Auswertungstool Jugendflamme"
        Me.NiMain.Visible = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label9.Location = New System.Drawing.Point(1085, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "© Moritz Jökel, 2019"
        '
        'TtMain
        '
        Me.TtMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TtMain.ToolTipTitle = "Jugendflamme der DJF"
        '
        'TblJuFla2MannschaftenBindingSource
        '
        Me.TblJuFla2MannschaftenBindingSource.DataMember = "TblJuFla2Mannschaften"
        Me.TblJuFla2MannschaftenBindingSource.DataSource = Me.DtsJuFla
        '
        'TblJuFla3MannschaftenBindingSource
        '
        Me.TblJuFla3MannschaftenBindingSource.DataMember = "TblJuFla3Mannschaften"
        Me.TblJuFla3MannschaftenBindingSource.DataSource = Me.DtsJuFla
        '
        'BsEvents
        '
        Me.BsEvents.DataMember = "TblEvents"
        Me.BsEvents.DataSource = Me.DtsJuFla
        '
        'TblEventsTblJuFla2MannschaftenBindingSource
        '
        Me.TblEventsTblJuFla2MannschaftenBindingSource.DataMember = "TblEvents_TblJuFla2Mannschaften"
        Me.TblEventsTblJuFla2MannschaftenBindingSource.DataSource = Me.BsEvents
        '
        'TblEventsTblJuFla3MannschaftenBindingSource
        '
        Me.TblEventsTblJuFla3MannschaftenBindingSource.DataMember = "TblEvents_TblJuFla3Mannschaften"
        Me.TblEventsTblJuFla3MannschaftenBindingSource.DataSource = Me.BsEvents
        '
        'TblJuFla2MannschaftenTblJuFla2MemberBindingSource
        '
        Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource.DataMember = "TblJuFla2Mannschaften_TblJuFla2Member"
        Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource.DataSource = Me.TblEventsTblJuFla2MannschaftenBindingSource
        '
        'TblJuFla3MannschaftenTblJuFla3MemberBindingSource
        '
        Me.TblJuFla3MannschaftenTblJuFla3MemberBindingSource.DataMember = "TblJuFla3Mannschaften_TblJuFla3Member"
        Me.TblJuFla3MannschaftenTblJuFla3MemberBindingSource.DataSource = Me.TblEventsTblJuFla3MannschaftenBindingSource
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'MannschaftsIDDataGridViewTextBoxColumn
        '
        Me.MannschaftsIDDataGridViewTextBoxColumn.DataPropertyName = "MannschaftsID"
        Me.MannschaftsIDDataGridViewTextBoxColumn.HeaderText = "MannschaftsID"
        Me.MannschaftsIDDataGridViewTextBoxColumn.Name = "MannschaftsIDDataGridViewTextBoxColumn"
        Me.MannschaftsIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MannschaftsIDDataGridViewTextBoxColumn.Visible = False
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
        Me.ValFwPrakDataGridViewTextBoxColumn.HeaderText = "FwPraxis"
        Me.ValFwPrakDataGridViewTextBoxColumn.Name = "ValFwPrakDataGridViewTextBoxColumn"
        Me.ValFwPrakDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValFwTheorieDataGridViewTextBoxColumn
        '
        Me.ValFwTheorieDataGridViewTextBoxColumn.DataPropertyName = "ValFwTheorie"
        Me.ValFwTheorieDataGridViewTextBoxColumn.HeaderText = "FwTheorie"
        Me.ValFwTheorieDataGridViewTextBoxColumn.Name = "ValFwTheorieDataGridViewTextBoxColumn"
        Me.ValFwTheorieDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValSportDataGridViewCheckBoxColumn
        '
        Me.ValSportDataGridViewCheckBoxColumn.DataPropertyName = "ValSport"
        Me.ValSportDataGridViewCheckBoxColumn.HeaderText = "Sport/Spiel"
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
        'ComboNameDataGridViewTextBoxColumn
        '
        Me.ComboNameDataGridViewTextBoxColumn.DataPropertyName = "ComboName"
        Me.ComboNameDataGridViewTextBoxColumn.HeaderText = "ComboName"
        Me.ComboNameDataGridViewTextBoxColumn.Name = "ComboNameDataGridViewTextBoxColumn"
        Me.ComboNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ComboNameDataGridViewTextBoxColumn.Visible = False
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn1.Visible = False
        '
        'MannschaftsIDDataGridViewTextBoxColumn1
        '
        Me.MannschaftsIDDataGridViewTextBoxColumn1.DataPropertyName = "MannschaftsID"
        Me.MannschaftsIDDataGridViewTextBoxColumn1.HeaderText = "MannschaftsID"
        Me.MannschaftsIDDataGridViewTextBoxColumn1.Name = "MannschaftsIDDataGridViewTextBoxColumn1"
        Me.MannschaftsIDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MannschaftsIDDataGridViewTextBoxColumn1.Visible = False
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
        Me.ValFwTechnikDataGridViewTextBoxColumn.HeaderText = "FwTechnik"
        Me.ValFwTechnikDataGridViewTextBoxColumn.Name = "ValFwTechnikDataGridViewTextBoxColumn"
        Me.ValFwTechnikDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValEhAufgabeDataGridViewTextBoxColumn
        '
        Me.ValEhAufgabeDataGridViewTextBoxColumn.DataPropertyName = "ValEhAufgabe"
        Me.ValEhAufgabeDataGridViewTextBoxColumn.HeaderText = "EhAufgabe"
        Me.ValEhAufgabeDataGridViewTextBoxColumn.Name = "ValEhAufgabeDataGridViewTextBoxColumn"
        Me.ValEhAufgabeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValPraesentationDataGridViewTextBoxColumn
        '
        Me.ValPraesentationDataGridViewTextBoxColumn.DataPropertyName = "ValPraesentation"
        Me.ValPraesentationDataGridViewTextBoxColumn.HeaderText = "Präsentation"
        Me.ValPraesentationDataGridViewTextBoxColumn.Name = "ValPraesentationDataGridViewTextBoxColumn"
        Me.ValPraesentationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FinishedDataGridViewCheckBoxColumn1
        '
        Me.FinishedDataGridViewCheckBoxColumn1.DataPropertyName = "finished"
        Me.FinishedDataGridViewCheckBoxColumn1.HeaderText = "Bestanden"
        Me.FinishedDataGridViewCheckBoxColumn1.Name = "FinishedDataGridViewCheckBoxColumn1"
        Me.FinishedDataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'ValEhNachweisDataGridViewCheckBoxColumn
        '
        Me.ValEhNachweisDataGridViewCheckBoxColumn.DataPropertyName = "ValEhNachweis"
        Me.ValEhNachweisDataGridViewCheckBoxColumn.HeaderText = "EH-Nachweis"
        Me.ValEhNachweisDataGridViewCheckBoxColumn.Name = "ValEhNachweisDataGridViewCheckBoxColumn"
        Me.ValEhNachweisDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ComboNameDataGridViewTextBoxColumn1
        '
        Me.ComboNameDataGridViewTextBoxColumn1.DataPropertyName = "ComboName"
        Me.ComboNameDataGridViewTextBoxColumn1.HeaderText = "ComboName"
        Me.ComboNameDataGridViewTextBoxColumn1.Name = "ComboNameDataGridViewTextBoxColumn1"
        Me.ComboNameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ComboNameDataGridViewTextBoxColumn1.Visible = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 588)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TcMain)
        Me.Controls.Add(Me.MsMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MsMain
        Me.Name = "FrmMain"
        Me.Text = "Auswertungstool Jugendflamme Landkreis Fulda"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MsMain.ResumeLayout(False)
        Me.MsMain.PerformLayout()
        Me.TcMain.ResumeLayout(False)
        Me.TpJuFla2.ResumeLayout(False)
        Me.TpJuFla2.PerformLayout()
        CType(Me.DgvJuFla2Member, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpJuFla3.ResumeLayout(False)
        Me.TpJuFla3.PerformLayout()
        CType(Me.DgvJuFla3Member, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsJuFla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsJuFla2Member.ResumeLayout(False)
        Me.CmsJuFla3Member.ResumeLayout(False)
        CType(Me.TblJuFla2MannschaftenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJuFla3MannschaftenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsEvents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEventsTblJuFla2MannschaftenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEventsTblJuFla3MannschaftenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJuFla3MannschaftenTblJuFla3MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MsMain As MenuStrip
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsVeranstaltungsdaten As ToolStripMenuItem
    Friend WithEvents TcMain As TabControl
    Friend WithEvents TpJuFla2 As TabPage
    Friend WithEvents TpJuFla3 As TabPage
    Friend WithEvents DtsJuFla As DtsJuFla
    Friend WithEvents Label1 As Label
    Friend WithEvents MannschaftenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsJuFla2AddMannschaft As ToolStripMenuItem
    Friend WithEvents MsJuFla3AddMannschaft As ToolStripMenuItem
    Friend WithEvents MsUebersichtMannschaften As ToolStripMenuItem
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
    Friend WithEvents CmsJuFla3Member As ContextMenuStrip
    Friend WithEvents BtJuFla3AddMember As Button
    Friend WithEvents BtJuFla2PrintMember As Button
    Friend WithEvents BtJuFla3PrintMember As Button
    Friend WithEvents BtJuFla2Import As Button
    Friend WithEvents BtJuFla3Import As Button
    Friend WithEvents CmsJuFla3RemoveMember As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MsCbVeranstaltung As ToolStripComboBox
    Friend WithEvents NiMain As NotifyIcon
    Friend WithEvents DatenbankToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsUpload As ToolStripMenuItem
    Friend WithEvents MsDownload As ToolStripMenuItem
    Friend WithEvents MsWettbInfo As ToolStripMenuItem
    Friend WithEvents MsExport As ToolStripMenuItem
    Friend WithEvents Label9 As Label
    Friend WithEvents TtMain As ToolTip
    Friend WithEvents BewerberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsJuFla2AddMember As ToolStripMenuItem
    Friend WithEvents MsJuFla3AddMember As ToolStripMenuItem
    Friend WithEvents MsPrintJuFla2 As ToolStripMenuItem
    Friend WithEvents MsPrintJuFla3 As ToolStripMenuItem
    Friend WithEvents CbJuFla3Mannschaft As ComboBox
    Friend WithEvents CbJuFla2Mannschaft As ComboBox
    Friend WithEvents MsStatistik As ToolStripMenuItem
    Friend WithEvents DgvJuFla2Member As DataGridView
    Friend WithEvents StartnummerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DgvJuFla3Member As DataGridView
    Friend WithEvents TbJuFla2Startnummer As TextBox
    Friend WithEvents TbJuFla3Startnummer As TextBox
    Friend WithEvents TblJuFla2MannschaftenBindingSource As BindingSource
    Friend WithEvents TblJuFla3MannschaftenBindingSource As BindingSource
    Friend WithEvents BsEvents As BindingSource
    Friend WithEvents TblEventsTblJuFla2MannschaftenBindingSource As BindingSource
    Friend WithEvents TblEventsTblJuFla3MannschaftenBindingSource As BindingSource
    Friend WithEvents TblJuFla2MannschaftenTblJuFla2MemberBindingSource As BindingSource
    Friend WithEvents TblJuFla3MannschaftenTblJuFla3MemberBindingSource As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MannschaftsIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VornameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GeschlechtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GeburtsdatumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AusweisnummerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValFwPrakDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValFwTheorieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValSportDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FinishedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ComboNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MannschaftsIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents VornameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GeschlechtDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GeburtsdatumDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AusweisnummerDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ValFwTechnikDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValEhAufgabeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValPraesentationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FinishedDataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents ValEhNachweisDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ComboNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
