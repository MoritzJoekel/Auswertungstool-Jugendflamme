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
        Me.TbAbnahmedatum = New System.Windows.Forms.TextBox()
        Me.BsEvents = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsJuFla = New JuFla_vb.DtsJuFla()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtJuFla2Import = New System.Windows.Forms.Button()
        Me.BtJuFla2PrintMember = New System.Windows.Forms.Button()
        Me.BtJuFla2AddMember = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbJuFla2AnzMember = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbRoJuFla2Startnummer = New System.Windows.Forms.TextBox()
        Me.BsJuFla2EventsMannschaften = New System.Windows.Forms.BindingSource(Me.components)
        Me.DgvJuFla2Member = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartnummerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.CmsJuFla2Member = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CmsJuFla2RemoveMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.BsJuFla2MannschaftenMember = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbJuFla2Ort = New System.Windows.Forms.ComboBox()
        Me.TpJuFla3 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DgvJuFla3Member = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VornameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeschlechtDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeburtsdatumDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AusweisnummerDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValFwTechnikDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValEhAufgabeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValPraesentationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValEhNachweisDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FinishedDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ComboNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmsJuFla3Member = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CmsJuFla3RemoveMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.BsJuFla3MannschaftenMember = New System.Windows.Forms.BindingSource(Me.components)
        Me.BsJuFla3EventsMannschaften = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtJuFla3Import = New System.Windows.Forms.Button()
        Me.BtJuFla3PrintMember = New System.Windows.Forms.Button()
        Me.BtJuFla3AddMember = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbJuFla3AnzBewerber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbJuFla3Startnummer = New System.Windows.Forms.TextBox()
        Me.CbJuFla3Mannschaft = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TiMain = New System.Windows.Forms.Timer(Me.components)
        Me.DtsJuFla1 = New JuFla_vb.DtsJuFla()
        Me.NiMain = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TtMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.MsMain.SuspendLayout()
        Me.TcMain.SuspendLayout()
        Me.TpJuFla2.SuspendLayout()
        CType(Me.BsEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsJuFla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsJuFla2EventsMannschaften, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvJuFla2Member, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsJuFla2Member.SuspendLayout()
        CType(Me.BsJuFla2MannschaftenMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpJuFla3.SuspendLayout()
        CType(Me.DgvJuFla3Member, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsJuFla3Member.SuspendLayout()
        CType(Me.BsJuFla3MannschaftenMember, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsJuFla3EventsMannschaften, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsJuFla1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.StartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsVeranstaltungsdaten, Me.MsDtsLeeren})
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
        Me.MsUpload.Size = New System.Drawing.Size(197, 22)
        Me.MsUpload.Text = "Push Datenbank to FTP"
        Me.MsUpload.ToolTipText = "Läd den aktuellen Datenbestand zum Server"
        '
        'MsDownload
        '
        Me.MsDownload.Image = Global.JuFla_vb.My.Resources.Resources.download
        Me.MsDownload.Name = "MsDownload"
        Me.MsDownload.Size = New System.Drawing.Size(197, 22)
        Me.MsDownload.Text = "Fetch Server-DB"
        Me.MsDownload.ToolTipText = "Läd Server-Datenbank herunter"
        '
        'MsExport
        '
        Me.MsExport.Image = Global.JuFla_vb.My.Resources.Resources.export
        Me.MsExport.Name = "MsExport"
        Me.MsExport.Size = New System.Drawing.Size(197, 22)
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
        Me.TcMain.Controls.Add(Me.TpJuFla2)
        Me.TcMain.Controls.Add(Me.TpJuFla3)
        Me.TcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TcMain.Location = New System.Drawing.Point(0, 27)
        Me.TcMain.Name = "TcMain"
        Me.TcMain.SelectedIndex = 0
        Me.TcMain.Size = New System.Drawing.Size(1190, 561)
        Me.TcMain.TabIndex = 1
        '
        'TpJuFla2
        '
        Me.TpJuFla2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TpJuFla2.Controls.Add(Me.TbAbnahmedatum)
        Me.TpJuFla2.Controls.Add(Me.Label7)
        Me.TpJuFla2.Controls.Add(Me.BtJuFla2Import)
        Me.TpJuFla2.Controls.Add(Me.BtJuFla2PrintMember)
        Me.TpJuFla2.Controls.Add(Me.BtJuFla2AddMember)
        Me.TpJuFla2.Controls.Add(Me.Label3)
        Me.TpJuFla2.Controls.Add(Me.TbJuFla2AnzMember)
        Me.TpJuFla2.Controls.Add(Me.Label2)
        Me.TpJuFla2.Controls.Add(Me.TbRoJuFla2Startnummer)
        Me.TpJuFla2.Controls.Add(Me.DgvJuFla2Member)
        Me.TpJuFla2.Controls.Add(Me.Label1)
        Me.TpJuFla2.Controls.Add(Me.CbJuFla2Ort)
        Me.TpJuFla2.Location = New System.Drawing.Point(4, 22)
        Me.TpJuFla2.Name = "TpJuFla2"
        Me.TpJuFla2.Padding = New System.Windows.Forms.Padding(3)
        Me.TpJuFla2.Size = New System.Drawing.Size(1182, 535)
        Me.TpJuFla2.TabIndex = 0
        Me.TpJuFla2.Text = "Jugendflamme Stufe 2"
        '
        'TbAbnahmedatum
        '
        Me.TbAbnahmedatum.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbAbnahmedatum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BsEvents, "Abnahmedatum", True))
        Me.TbAbnahmedatum.Location = New System.Drawing.Point(1072, 19)
        Me.TbAbnahmedatum.Name = "TbAbnahmedatum"
        Me.TbAbnahmedatum.ReadOnly = True
        Me.TbAbnahmedatum.Size = New System.Drawing.Size(85, 20)
        Me.TbAbnahmedatum.TabIndex = 16
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
        'TbRoJuFla2Startnummer
        '
        Me.TbRoJuFla2Startnummer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BsJuFla2EventsMannschaften, "Startnummer", True))
        Me.TbRoJuFla2Startnummer.Location = New System.Drawing.Point(90, 53)
        Me.TbRoJuFla2Startnummer.Name = "TbRoJuFla2Startnummer"
        Me.TbRoJuFla2Startnummer.ReadOnly = True
        Me.TbRoJuFla2Startnummer.Size = New System.Drawing.Size(110, 20)
        Me.TbRoJuFla2Startnummer.TabIndex = 7
        Me.TtMain.SetToolTip(Me.TbRoJuFla2Startnummer, "Startnummer der ausgewählten Mannschaft")
        '
        'BsJuFla2EventsMannschaften
        '
        Me.BsJuFla2EventsMannschaften.DataMember = "TblEvents_TblJuFla2Mannschaften"
        Me.BsJuFla2EventsMannschaften.DataSource = Me.BsEvents
        '
        'DgvJuFla2Member
        '
        Me.DgvJuFla2Member.AllowUserToAddRows = False
        Me.DgvJuFla2Member.AllowUserToDeleteRows = False
        Me.DgvJuFla2Member.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvJuFla2Member.AutoGenerateColumns = False
        Me.DgvJuFla2Member.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgvJuFla2Member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvJuFla2Member.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.StartnummerDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.VornameDataGridViewTextBoxColumn, Me.GeschlechtDataGridViewTextBoxColumn, Me.GeburtsdatumDataGridViewTextBoxColumn, Me.AusweisnummerDataGridViewTextBoxColumn, Me.ValFwPrakDataGridViewTextBoxColumn, Me.ValFwTheorieDataGridViewTextBoxColumn, Me.ValSportDataGridViewCheckBoxColumn, Me.FinishedDataGridViewCheckBoxColumn, Me.ComboNameDataGridViewTextBoxColumn})
        Me.DgvJuFla2Member.ContextMenuStrip = Me.CmsJuFla2Member
        Me.DgvJuFla2Member.DataSource = Me.BsJuFla2MannschaftenMember
        Me.DgvJuFla2Member.Location = New System.Drawing.Point(11, 87)
        Me.DgvJuFla2Member.Name = "DgvJuFla2Member"
        Me.DgvJuFla2Member.Size = New System.Drawing.Size(1146, 427)
        Me.DgvJuFla2Member.TabIndex = 5
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
        Me.StartnummerDataGridViewTextBoxColumn.Visible = False
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
        Me.AusweisnummerDataGridViewTextBoxColumn.ToolTipText = "DJF-Ausweisnummer des Bewerbers"
        '
        'ValFwPrakDataGridViewTextBoxColumn
        '
        Me.ValFwPrakDataGridViewTextBoxColumn.DataPropertyName = "ValFwPrak"
        Me.ValFwPrakDataGridViewTextBoxColumn.HeaderText = "FW-Praxis"
        Me.ValFwPrakDataGridViewTextBoxColumn.Name = "ValFwPrakDataGridViewTextBoxColumn"
        Me.ValFwPrakDataGridViewTextBoxColumn.ToolTipText = "Schulnote (1-6)"
        '
        'ValFwTheorieDataGridViewTextBoxColumn
        '
        Me.ValFwTheorieDataGridViewTextBoxColumn.DataPropertyName = "ValFwTheorie"
        Me.ValFwTheorieDataGridViewTextBoxColumn.HeaderText = "FW-Theorie"
        Me.ValFwTheorieDataGridViewTextBoxColumn.Name = "ValFwTheorieDataGridViewTextBoxColumn"
        Me.ValFwTheorieDataGridViewTextBoxColumn.ToolTipText = "9 Geräte a` 5 Pkt. (0-50 Pkt)"
        '
        'ValSportDataGridViewCheckBoxColumn
        '
        Me.ValSportDataGridViewCheckBoxColumn.DataPropertyName = "ValSport"
        Me.ValSportDataGridViewCheckBoxColumn.HeaderText = "Sport und Spiel"
        Me.ValSportDataGridViewCheckBoxColumn.Name = "ValSportDataGridViewCheckBoxColumn"
        Me.ValSportDataGridViewCheckBoxColumn.ToolTipText = "Sport und Spiel (Bestanden Ja/Nein)"
        '
        'FinishedDataGridViewCheckBoxColumn
        '
        Me.FinishedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FinishedDataGridViewCheckBoxColumn.DataPropertyName = "finished"
        Me.FinishedDataGridViewCheckBoxColumn.HeaderText = "Bestanden"
        Me.FinishedDataGridViewCheckBoxColumn.Name = "FinishedDataGridViewCheckBoxColumn"
        Me.FinishedDataGridViewCheckBoxColumn.ToolTipText = "Bewerber hat die Jugendflamme Stufe 2 bestanden (Ja/Nein)"
        '
        'ComboNameDataGridViewTextBoxColumn
        '
        Me.ComboNameDataGridViewTextBoxColumn.DataPropertyName = "ComboName"
        Me.ComboNameDataGridViewTextBoxColumn.HeaderText = "ComboName"
        Me.ComboNameDataGridViewTextBoxColumn.Name = "ComboNameDataGridViewTextBoxColumn"
        Me.ComboNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ComboNameDataGridViewTextBoxColumn.Visible = False
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
        'BsJuFla2MannschaftenMember
        '
        Me.BsJuFla2MannschaftenMember.DataMember = "TblJuFla2Mannschaften_TblJuFla2Member"
        Me.BsJuFla2MannschaftenMember.DataSource = Me.BsJuFla2EventsMannschaften
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
        Me.CbJuFla2Ort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BsJuFla2EventsMannschaften, "Ort", True))
        Me.CbJuFla2Ort.DataSource = Me.BsJuFla2EventsMannschaften
        Me.CbJuFla2Ort.DisplayMember = "Ort"
        Me.CbJuFla2Ort.FormattingEnabled = True
        Me.CbJuFla2Ort.Location = New System.Drawing.Point(90, 19)
        Me.CbJuFla2Ort.Name = "CbJuFla2Ort"
        Me.CbJuFla2Ort.Size = New System.Drawing.Size(292, 21)
        Me.CbJuFla2Ort.TabIndex = 0
        Me.TtMain.SetToolTip(Me.CbJuFla2Ort, "Mannschaft innerhalb der Jugendflamme Stufe 2 auswählen")
        '
        'TpJuFla3
        '
        Me.TpJuFla3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TpJuFla3.Controls.Add(Me.Label8)
        Me.TpJuFla3.Controls.Add(Me.DgvJuFla3Member)
        Me.TpJuFla3.Controls.Add(Me.BtJuFla3Import)
        Me.TpJuFla3.Controls.Add(Me.BtJuFla3PrintMember)
        Me.TpJuFla3.Controls.Add(Me.BtJuFla3AddMember)
        Me.TpJuFla3.Controls.Add(Me.Label5)
        Me.TpJuFla3.Controls.Add(Me.TbJuFla3AnzBewerber)
        Me.TpJuFla3.Controls.Add(Me.Label6)
        Me.TpJuFla3.Controls.Add(Me.TbJuFla3Startnummer)
        Me.TpJuFla3.Controls.Add(Me.CbJuFla3Mannschaft)
        Me.TpJuFla3.Controls.Add(Me.Label4)
        Me.TpJuFla3.Location = New System.Drawing.Point(4, 22)
        Me.TpJuFla3.Name = "TpJuFla3"
        Me.TpJuFla3.Padding = New System.Windows.Forms.Padding(3)
        Me.TpJuFla3.Size = New System.Drawing.Size(1182, 535)
        Me.TpJuFla3.TabIndex = 1
        Me.TpJuFla3.Text = "Jugendflamme Stufe 3"
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
        'DgvJuFla3Member
        '
        Me.DgvJuFla3Member.AllowUserToAddRows = False
        Me.DgvJuFla3Member.AllowUserToDeleteRows = False
        Me.DgvJuFla3Member.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvJuFla3Member.AutoGenerateColumns = False
        Me.DgvJuFla3Member.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgvJuFla3Member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvJuFla3Member.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn1, Me.VornameDataGridViewTextBoxColumn1, Me.GeschlechtDataGridViewTextBoxColumn1, Me.GeburtsdatumDataGridViewTextBoxColumn1, Me.AusweisnummerDataGridViewTextBoxColumn1, Me.ValFwTechnikDataGridViewTextBoxColumn, Me.ValEhAufgabeDataGridViewTextBoxColumn, Me.ValPraesentationDataGridViewTextBoxColumn, Me.ValEhNachweisDataGridViewCheckBoxColumn, Me.FinishedDataGridViewCheckBoxColumn1, Me.ComboNameDataGridViewTextBoxColumn1})
        Me.DgvJuFla3Member.ContextMenuStrip = Me.CmsJuFla3Member
        Me.DgvJuFla3Member.DataSource = Me.BsJuFla3MannschaftenMember
        Me.DgvJuFla3Member.Location = New System.Drawing.Point(11, 100)
        Me.DgvJuFla3Member.Name = "DgvJuFla3Member"
        Me.DgvJuFla3Member.Size = New System.Drawing.Size(1146, 418)
        Me.DgvJuFla3Member.TabIndex = 18
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
        Me.ValFwTechnikDataGridViewTextBoxColumn.ToolTipText = "Schulnote (1-6)"
        '
        'ValEhAufgabeDataGridViewTextBoxColumn
        '
        Me.ValEhAufgabeDataGridViewTextBoxColumn.DataPropertyName = "ValEhAufgabe"
        Me.ValEhAufgabeDataGridViewTextBoxColumn.HeaderText = "EH-Aufgabe"
        Me.ValEhAufgabeDataGridViewTextBoxColumn.Name = "ValEhAufgabeDataGridViewTextBoxColumn"
        Me.ValEhAufgabeDataGridViewTextBoxColumn.ToolTipText = "Schulnote (1-6)"
        '
        'ValPraesentationDataGridViewTextBoxColumn
        '
        Me.ValPraesentationDataGridViewTextBoxColumn.DataPropertyName = "ValPraesentation"
        Me.ValPraesentationDataGridViewTextBoxColumn.HeaderText = "Präsentation"
        Me.ValPraesentationDataGridViewTextBoxColumn.Name = "ValPraesentationDataGridViewTextBoxColumn"
        Me.ValPraesentationDataGridViewTextBoxColumn.ToolTipText = "Schulnote (1-6)"
        '
        'ValEhNachweisDataGridViewCheckBoxColumn
        '
        Me.ValEhNachweisDataGridViewCheckBoxColumn.DataPropertyName = "ValEhNachweis"
        Me.ValEhNachweisDataGridViewCheckBoxColumn.HeaderText = "EH-Nachweis"
        Me.ValEhNachweisDataGridViewCheckBoxColumn.Name = "ValEhNachweisDataGridViewCheckBoxColumn"
        Me.ValEhNachweisDataGridViewCheckBoxColumn.ToolTipText = "Teilnahme an 9UE EH-Kurs Ja/Nein"
        '
        'FinishedDataGridViewCheckBoxColumn1
        '
        Me.FinishedDataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FinishedDataGridViewCheckBoxColumn1.DataPropertyName = "finished"
        Me.FinishedDataGridViewCheckBoxColumn1.HeaderText = "Bestanden"
        Me.FinishedDataGridViewCheckBoxColumn1.Name = "FinishedDataGridViewCheckBoxColumn1"
        Me.FinishedDataGridViewCheckBoxColumn1.ToolTipText = "Bewerber hat die Jugendflamme Stufe 3 bestanden Ja/Nein"
        '
        'ComboNameDataGridViewTextBoxColumn1
        '
        Me.ComboNameDataGridViewTextBoxColumn1.DataPropertyName = "ComboName"
        Me.ComboNameDataGridViewTextBoxColumn1.HeaderText = "ComboName"
        Me.ComboNameDataGridViewTextBoxColumn1.Name = "ComboNameDataGridViewTextBoxColumn1"
        Me.ComboNameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ComboNameDataGridViewTextBoxColumn1.Visible = False
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
        'BsJuFla3MannschaftenMember
        '
        Me.BsJuFla3MannschaftenMember.DataMember = "TblJuFla3Mannschaften_TblJuFla3Member"
        Me.BsJuFla3MannschaftenMember.DataSource = Me.BsJuFla3EventsMannschaften
        '
        'BsJuFla3EventsMannschaften
        '
        Me.BsJuFla3EventsMannschaften.DataMember = "TblEvents_TblJuFla3Mannschaften"
        Me.BsJuFla3EventsMannschaften.DataSource = Me.BsEvents
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
        'TbJuFla3Startnummer
        '
        Me.TbJuFla3Startnummer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BsJuFla3EventsMannschaften, "Startnummer", True))
        Me.TbJuFla3Startnummer.Location = New System.Drawing.Point(90, 56)
        Me.TbJuFla3Startnummer.Name = "TbJuFla3Startnummer"
        Me.TbJuFla3Startnummer.ReadOnly = True
        Me.TbJuFla3Startnummer.Size = New System.Drawing.Size(110, 20)
        Me.TbJuFla3Startnummer.TabIndex = 11
        Me.TtMain.SetToolTip(Me.TbJuFla3Startnummer, "Startnummer der ausgewählten Mannschaft")
        '
        'CbJuFla3Mannschaft
        '
        Me.CbJuFla3Mannschaft.DataSource = Me.BsJuFla3EventsMannschaften
        Me.CbJuFla3Mannschaft.DisplayMember = "Ort"
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
        'TiMain
        '
        Me.TiMain.Interval = 1000
        '
        'DtsJuFla1
        '
        Me.DtsJuFla1.DataSetName = "DtsJuFla"
        Me.DtsJuFla1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Label9.Text = "© Moritz Jökel, 2018"
        '
        'TtMain
        '
        Me.TtMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TtMain.ToolTipTitle = "Jugendflamme der DJF"
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
        CType(Me.BsEvents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsJuFla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsJuFla2EventsMannschaften, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvJuFla2Member, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsJuFla2Member.ResumeLayout(False)
        CType(Me.BsJuFla2MannschaftenMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpJuFla3.ResumeLayout(False)
        Me.TpJuFla3.PerformLayout()
        CType(Me.DgvJuFla3Member, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsJuFla3Member.ResumeLayout(False)
        CType(Me.BsJuFla3MannschaftenMember, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsJuFla3EventsMannschaften, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsJuFla1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvJuFla2Member As DataGridView
    Friend WithEvents MannschaftenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsJuFla2AddMannschaft As ToolStripMenuItem
    Friend WithEvents MsJuFla3AddMannschaft As ToolStripMenuItem
    Friend WithEvents MsUebersichtMannschaften As ToolStripMenuItem
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
    Friend WithEvents CmsJuFla3Member As ContextMenuStrip
    Friend WithEvents DtsJuFla1 As DtsJuFla
    Friend WithEvents BtJuFla3AddMember As Button
    Friend WithEvents BtJuFla2PrintMember As Button
    Friend WithEvents BtJuFla3PrintMember As Button
    Friend WithEvents BtJuFla2Import As Button
    Friend WithEvents BtJuFla3Import As Button
    Friend WithEvents CmsJuFla3RemoveMember As ToolStripMenuItem
    Friend WithEvents DgvJuFla3Member As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MsCbVeranstaltung As ToolStripComboBox
    Friend WithEvents BsEvents As BindingSource
    Friend WithEvents BsJuFla2EventsMannschaften As BindingSource
    Friend WithEvents BsJuFla2MannschaftenMember As BindingSource
    Friend WithEvents BsJuFla3MannschaftenMember As BindingSource
    Friend WithEvents BsJuFla3EventsMannschaften As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartnummerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
    Friend WithEvents NameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents VornameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GeschlechtDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GeburtsdatumDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AusweisnummerDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ValFwTechnikDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValEhAufgabeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValPraesentationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValEhNachweisDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FinishedDataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents ComboNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
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
    Friend WithEvents TbAbnahmedatum As TextBox
    Friend WithEvents MsPrintJuFla2 As ToolStripMenuItem
    Friend WithEvents MsPrintJuFla3 As ToolStripMenuItem
End Class
