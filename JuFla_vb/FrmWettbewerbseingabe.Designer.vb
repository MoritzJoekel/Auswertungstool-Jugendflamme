<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWettbewerbseingabe
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
        Me.BtJuFla2ckeck = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CbJuFla2Bestanden = New System.Windows.Forms.CheckBox()
        Me.BsJuFla2Member = New System.Windows.Forms.BindingSource(Me.components)
        Me.BsJuFla2Mannschaften = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsJuFla = New JuFla_vb.DtsJuFla()
        Me.LbStatus = New System.Windows.Forms.Label()
        Me.GbJuFla2Wettbewerb = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CbJuFla2ValSport = New System.Windows.Forms.CheckBox()
        Me.TbJuFla2ValFwTheorie = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbJuFla2ValFwPrak = New System.Windows.Forms.TextBox()
        Me.GbJuFla2PData = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbJuFla2Member = New System.Windows.Forms.ComboBox()
        Me.CbJuFla2Mannschaft = New System.Windows.Forms.ComboBox()
        Me.CbJuFla3finished = New System.Windows.Forms.CheckBox()
        Me.LbJuFla3Bestanden = New System.Windows.Forms.Label()
        Me.BtJuFla3Check = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TbJuFla3ValPraesentation = New System.Windows.Forms.TextBox()
        Me.BsJuFla3Member = New System.Windows.Forms.BindingSource(Me.components)
        Me.BsJuFla3Mannschaften = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CbJuFla3NachweisEh = New System.Windows.Forms.CheckBox()
        Me.TbJuFla3FwTechnik = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TbJuFla3ValEhAufgabe = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CbJuFla3Mannschaften = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TiMain = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.BsJuFla2Member, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsJuFla2Mannschaften, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsJuFla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbJuFla2Wettbewerb.SuspendLayout()
        Me.GbJuFla2PData.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BsJuFla3Member, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsJuFla3Mannschaften, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtJuFla2ckeck)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CbJuFla2Bestanden)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LbStatus)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GbJuFla2Wettbewerb)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GbJuFla2PData)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CbJuFla2Member)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CbJuFla2Mannschaft)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CbJuFla3finished)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LbJuFla3Bestanden)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtJuFla3Check)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ComboBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CbJuFla3Mannschaften)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label15)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label13)
        Me.SplitContainer1.Size = New System.Drawing.Size(918, 518)
        Me.SplitContainer1.SplitterDistance = 476
        Me.SplitContainer1.TabIndex = 0
        Me.SplitContainer1.TabStop = False
        '
        'BtJuFla2ckeck
        '
        Me.BtJuFla2ckeck.Image = Global.JuFla_vb.My.Resources.Resources.icon_checked
        Me.BtJuFla2ckeck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtJuFla2ckeck.Location = New System.Drawing.Point(6, 456)
        Me.BtJuFla2ckeck.Name = "BtJuFla2ckeck"
        Me.BtJuFla2ckeck.Size = New System.Drawing.Size(106, 32)
        Me.BtJuFla2ckeck.TabIndex = 15
        Me.BtJuFla2ckeck.Text = "Übernehmen"
        Me.BtJuFla2ckeck.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtJuFla2ckeck.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(233, 20)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "JUGENDFLAMME STUFE 2"
        '
        'CbJuFla2Bestanden
        '
        Me.CbJuFla2Bestanden.AutoSize = True
        Me.CbJuFla2Bestanden.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BsJuFla2Member, "finished", True))
        Me.CbJuFla2Bestanden.Location = New System.Drawing.Point(12, 414)
        Me.CbJuFla2Bestanden.Name = "CbJuFla2Bestanden"
        Me.CbJuFla2Bestanden.Size = New System.Drawing.Size(62, 17)
        Me.CbJuFla2Bestanden.TabIndex = 13
        Me.CbJuFla2Bestanden.TabStop = False
        Me.CbJuFla2Bestanden.Text = "finished"
        Me.CbJuFla2Bestanden.UseVisualStyleBackColor = True
        Me.CbJuFla2Bestanden.Visible = False
        '
        'BsJuFla2Member
        '
        Me.BsJuFla2Member.DataMember = "TblJuFla2Mannschaften_TblJuFla2Member"
        Me.BsJuFla2Member.DataSource = Me.BsJuFla2Mannschaften
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
        'LbStatus
        '
        Me.LbStatus.AutoSize = True
        Me.LbStatus.BackColor = System.Drawing.Color.Orange
        Me.LbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbStatus.Location = New System.Drawing.Point(7, 370)
        Me.LbStatus.Name = "LbStatus"
        Me.LbStatus.Size = New System.Drawing.Size(230, 25)
        Me.LbStatus.TabIndex = 12
        Me.LbStatus.Text = "Bewerber auswählen"
        '
        'GbJuFla2Wettbewerb
        '
        Me.GbJuFla2Wettbewerb.Controls.Add(Me.Label10)
        Me.GbJuFla2Wettbewerb.Controls.Add(Me.Label9)
        Me.GbJuFla2Wettbewerb.Controls.Add(Me.CbJuFla2ValSport)
        Me.GbJuFla2Wettbewerb.Controls.Add(Me.TbJuFla2ValFwTheorie)
        Me.GbJuFla2Wettbewerb.Controls.Add(Me.Label8)
        Me.GbJuFla2Wettbewerb.Controls.Add(Me.Label7)
        Me.GbJuFla2Wettbewerb.Controls.Add(Me.TbJuFla2ValFwPrak)
        Me.GbJuFla2Wettbewerb.Location = New System.Drawing.Point(6, 227)
        Me.GbJuFla2Wettbewerb.Name = "GbJuFla2Wettbewerb"
        Me.GbJuFla2Wettbewerb.Size = New System.Drawing.Size(415, 127)
        Me.GbJuFla2Wettbewerb.TabIndex = 11
        Me.GbJuFla2Wettbewerb.TabStop = False
        Me.GbJuFla2Wettbewerb.Text = "Wettbewerbsdaten"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Schulnote 1-6"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(176, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Punktzahl 0-50"
        '
        'CbJuFla2ValSport
        '
        Me.CbJuFla2ValSport.AutoSize = True
        Me.CbJuFla2ValSport.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BsJuFla2Member, "ValSport", True))
        Me.CbJuFla2ValSport.Location = New System.Drawing.Point(6, 91)
        Me.CbJuFla2ValSport.Name = "CbJuFla2ValSport"
        Me.CbJuFla2ValSport.Size = New System.Drawing.Size(98, 17)
        Me.CbJuFla2ValSport.TabIndex = 4
        Me.CbJuFla2ValSport.Text = "Sport und Spiel"
        Me.CbJuFla2ValSport.UseVisualStyleBackColor = True
        '
        'TbJuFla2ValFwTheorie
        '
        Me.TbJuFla2ValFwTheorie.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6"})
        Me.TbJuFla2ValFwTheorie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TbJuFla2ValFwTheorie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TbJuFla2ValFwTheorie.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BsJuFla2Member, "ValFwTheorie", True))
        Me.TbJuFla2ValFwTheorie.Location = New System.Drawing.Point(179, 47)
        Me.TbJuFla2ValFwTheorie.Name = "TbJuFla2ValFwTheorie"
        Me.TbJuFla2ValFwTheorie.Size = New System.Drawing.Size(130, 20)
        Me.TbJuFla2ValFwTheorie.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(176, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Feuerwehr-Theorie"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Feuerwehr-Praxis"
        '
        'TbJuFla2ValFwPrak
        '
        Me.TbJuFla2ValFwPrak.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6"})
        Me.TbJuFla2ValFwPrak.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TbJuFla2ValFwPrak.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TbJuFla2ValFwPrak.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BsJuFla2Member, "ValFwPrak", True))
        Me.TbJuFla2ValFwPrak.Location = New System.Drawing.Point(6, 47)
        Me.TbJuFla2ValFwPrak.Name = "TbJuFla2ValFwPrak"
        Me.TbJuFla2ValFwPrak.Size = New System.Drawing.Size(130, 20)
        Me.TbJuFla2ValFwPrak.TabIndex = 0
        '
        'GbJuFla2PData
        '
        Me.GbJuFla2PData.Controls.Add(Me.Label6)
        Me.GbJuFla2PData.Controls.Add(Me.Label5)
        Me.GbJuFla2PData.Controls.Add(Me.TextBox1)
        Me.GbJuFla2PData.Controls.Add(Me.TextBox3)
        Me.GbJuFla2PData.Controls.Add(Me.Label3)
        Me.GbJuFla2PData.Controls.Add(Me.Label4)
        Me.GbJuFla2PData.Controls.Add(Me.TextBox2)
        Me.GbJuFla2PData.Location = New System.Drawing.Point(6, 126)
        Me.GbJuFla2PData.Name = "GbJuFla2PData"
        Me.GbJuFla2PData.Size = New System.Drawing.Size(415, 83)
        Me.GbJuFla2PData.TabIndex = 10
        Me.GbJuFla2PData.TabStop = False
        Me.GbJuFla2PData.Text = "Persönliche Daten"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Geburtsdatum"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Ausweisnummer"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BsJuFla2Member, "Geburtsdatum", True))
        Me.TextBox1.Location = New System.Drawing.Point(6, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BsJuFla2Member, "Ausweisnummer", True))
        Me.TextBox3.Location = New System.Drawing.Point(277, 39)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(116, 20)
        Me.TextBox3.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-80, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Geburtsdatum"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(133, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Geschlecht"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BsJuFla2Member, "Geschlecht", True))
        Me.TextBox2.Location = New System.Drawing.Point(136, 39)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(116, 20)
        Me.TextBox2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Teilnehmer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mannschaft"
        '
        'CbJuFla2Member
        '
        Me.CbJuFla2Member.DataSource = Me.BsJuFla2Member
        Me.CbJuFla2Member.DisplayMember = "ComboName"
        Me.CbJuFla2Member.FormattingEnabled = True
        Me.CbJuFla2Member.Location = New System.Drawing.Point(97, 88)
        Me.CbJuFla2Member.Name = "CbJuFla2Member"
        Me.CbJuFla2Member.Size = New System.Drawing.Size(228, 21)
        Me.CbJuFla2Member.TabIndex = 1
        '
        'CbJuFla2Mannschaft
        '
        Me.CbJuFla2Mannschaft.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtsJuFla, "TblJuFla2Mannschaften.Ort", True))
        Me.CbJuFla2Mannschaft.DataSource = Me.BsJuFla2Mannschaften
        Me.CbJuFla2Mannschaft.DisplayMember = "Ort"
        Me.CbJuFla2Mannschaft.FormattingEnabled = True
        Me.CbJuFla2Mannschaft.Location = New System.Drawing.Point(97, 38)
        Me.CbJuFla2Mannschaft.Name = "CbJuFla2Mannschaft"
        Me.CbJuFla2Mannschaft.Size = New System.Drawing.Size(228, 21)
        Me.CbJuFla2Mannschaft.TabIndex = 0
        '
        'CbJuFla3finished
        '
        Me.CbJuFla3finished.AutoSize = True
        Me.CbJuFla3finished.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BsJuFla2Member, "finished", True))
        Me.CbJuFla3finished.Location = New System.Drawing.Point(338, 422)
        Me.CbJuFla3finished.Name = "CbJuFla3finished"
        Me.CbJuFla3finished.Size = New System.Drawing.Size(62, 17)
        Me.CbJuFla3finished.TabIndex = 24
        Me.CbJuFla3finished.TabStop = False
        Me.CbJuFla3finished.Text = "finished"
        Me.CbJuFla3finished.UseVisualStyleBackColor = True
        Me.CbJuFla3finished.Visible = False
        '
        'LbJuFla3Bestanden
        '
        Me.LbJuFla3Bestanden.AutoSize = True
        Me.LbJuFla3Bestanden.BackColor = System.Drawing.Color.Orange
        Me.LbJuFla3Bestanden.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbJuFla3Bestanden.Location = New System.Drawing.Point(2, 414)
        Me.LbJuFla3Bestanden.Name = "LbJuFla3Bestanden"
        Me.LbJuFla3Bestanden.Size = New System.Drawing.Size(230, 25)
        Me.LbJuFla3Bestanden.TabIndex = 23
        Me.LbJuFla3Bestanden.Text = "Bewerber auswählen"
        '
        'BtJuFla3Check
        '
        Me.BtJuFla3Check.Image = Global.JuFla_vb.My.Resources.Resources.icon_checked
        Me.BtJuFla3Check.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtJuFla3Check.Location = New System.Drawing.Point(7, 456)
        Me.BtJuFla3Check.Name = "BtJuFla3Check"
        Me.BtJuFla3Check.Size = New System.Drawing.Size(106, 32)
        Me.BtJuFla3Check.TabIndex = 22
        Me.BtJuFla3Check.Text = "Übernehmen"
        Me.BtJuFla3Check.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtJuFla3Check.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.TbJuFla3ValPraesentation)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.CbJuFla3NachweisEh)
        Me.GroupBox2.Controls.Add(Me.TbJuFla3FwTechnik)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.TbJuFla3ValEhAufgabe)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 227)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 168)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Wettbewerbsdaten"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(176, 133)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(73, 13)
        Me.Label24.TabIndex = 9
        Me.Label24.Text = "Schulnote 1-6"
        '
        'TbJuFla3ValPraesentation
        '
        Me.TbJuFla3ValPraesentation.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6"})
        Me.TbJuFla3ValPraesentation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TbJuFla3ValPraesentation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TbJuFla3ValPraesentation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BsJuFla3Member, "ValFwTechnik", True))
        Me.TbJuFla3ValPraesentation.Location = New System.Drawing.Point(179, 110)
        Me.TbJuFla3ValPraesentation.Name = "TbJuFla3ValPraesentation"
        Me.TbJuFla3ValPraesentation.Size = New System.Drawing.Size(130, 20)
        Me.TbJuFla3ValPraesentation.TabIndex = 8
        '
        'BsJuFla3Member
        '
        Me.BsJuFla3Member.DataMember = "TblJuFla3Mannschaften_TblJuFla3Member"
        Me.BsJuFla3Member.DataSource = Me.BsJuFla3Mannschaften
        '
        'BsJuFla3Mannschaften
        '
        Me.BsJuFla3Mannschaften.DataMember = "TblJuFla3Mannschaften"
        Me.BsJuFla3Mannschaften.DataSource = Me.DtsJuFla
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(176, 94)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 13)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Präsentation"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 70)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(73, 13)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Schulnote 1-6"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(176, 70)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(73, 13)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Schulnote 1-6"
        '
        'CbJuFla3NachweisEh
        '
        Me.CbJuFla3NachweisEh.AutoSize = True
        Me.CbJuFla3NachweisEh.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BsJuFla3Member, "ValEhNachweis", True))
        Me.CbJuFla3NachweisEh.Location = New System.Drawing.Point(6, 110)
        Me.CbJuFla3NachweisEh.Name = "CbJuFla3NachweisEh"
        Me.CbJuFla3NachweisEh.Size = New System.Drawing.Size(91, 17)
        Me.CbJuFla3NachweisEh.TabIndex = 4
        Me.CbJuFla3NachweisEh.Text = "Nachweis EH"
        Me.CbJuFla3NachweisEh.UseVisualStyleBackColor = True
        '
        'TbJuFla3FwTechnik
        '
        Me.TbJuFla3FwTechnik.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6"})
        Me.TbJuFla3FwTechnik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TbJuFla3FwTechnik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TbJuFla3FwTechnik.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BsJuFla3Member, "ValFwTechnik", True))
        Me.TbJuFla3FwTechnik.Location = New System.Drawing.Point(179, 47)
        Me.TbJuFla3FwTechnik.Name = "TbJuFla3FwTechnik"
        Me.TbJuFla3FwTechnik.Size = New System.Drawing.Size(130, 20)
        Me.TbJuFla3FwTechnik.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(176, 31)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(99, 13)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Feuerwehr-Technik"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(3, 31)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 13)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "EH-Aufgabe"
        '
        'TbJuFla3ValEhAufgabe
        '
        Me.TbJuFla3ValEhAufgabe.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6"})
        Me.TbJuFla3ValEhAufgabe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TbJuFla3ValEhAufgabe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TbJuFla3ValEhAufgabe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BsJuFla3Member, "ValEhAufgabe", True))
        Me.TbJuFla3ValEhAufgabe.Location = New System.Drawing.Point(6, 47)
        Me.TbJuFla3ValEhAufgabe.Name = "TbJuFla3ValEhAufgabe"
        Me.TbJuFla3ValEhAufgabe.Size = New System.Drawing.Size(130, 20)
        Me.TbJuFla3ValEhAufgabe.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 83)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Persönliche Daten"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Geburtsdatum"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(274, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 13)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Ausweisnummer"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BsJuFla3Member, "Geburtsdatum", True))
        Me.TextBox4.Location = New System.Drawing.Point(6, 39)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 4
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BsJuFla3Member, "Ausweisnummer", True))
        Me.TextBox5.Location = New System.Drawing.Point(277, 39)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(116, 20)
        Me.TextBox5.TabIndex = 8
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(-80, 25)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Geburtsdatum"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(133, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 13)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Geschlecht"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BsJuFla3Member, "Geschlecht", True))
        Me.TextBox6.Location = New System.Drawing.Point(136, 39)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(116, 20)
        Me.TextBox6.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtsJuFla, "TblJuFla3Mannschaften.Ort", True))
        Me.ComboBox1.DataSource = Me.BsJuFla3Member
        Me.ComboBox1.DisplayMember = "ComboName"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(102, 88)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(228, 21)
        Me.ComboBox1.TabIndex = 19
        '
        'CbJuFla3Mannschaften
        '
        Me.CbJuFla3Mannschaften.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtsJuFla, "TblJuFla3Mannschaften.Ort", True))
        Me.CbJuFla3Mannschaften.DataSource = Me.BsJuFla3Mannschaften
        Me.CbJuFla3Mannschaften.DisplayMember = "Ort"
        Me.CbJuFla3Mannschaften.FormattingEnabled = True
        Me.CbJuFla3Mannschaften.Location = New System.Drawing.Point(102, 38)
        Me.CbJuFla3Mannschaften.Name = "CbJuFla3Mannschaften"
        Me.CbJuFla3Mannschaften.Size = New System.Drawing.Size(228, 21)
        Me.CbJuFla3Mannschaften.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(4, 91)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Teilnehmer"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Mannschaft"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(233, 20)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "JUGENDFLAMME STUFE 3"
        '
        'TiMain
        '
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 23)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "JUGENDFLAMME STUFE 2"
        '
        'FrmWettbewerbseingabe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 518)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmWettbewerbseingabe"
        Me.Text = "FrmWettbewerbseingabe"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.BsJuFla2Member, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsJuFla2Mannschaften, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsJuFla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbJuFla2Wettbewerb.ResumeLayout(False)
        Me.GbJuFla2Wettbewerb.PerformLayout()
        Me.GbJuFla2PData.ResumeLayout(False)
        Me.GbJuFla2PData.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BsJuFla3Member, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsJuFla3Mannschaften, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CbJuFla2Member As ComboBox
    Friend WithEvents CbJuFla2Mannschaft As ComboBox
    Friend WithEvents DtsJuFla As DtsJuFla
    Friend WithEvents BsJuFla2Mannschaften As BindingSource
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GbJuFla2PData As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GbJuFla2Wettbewerb As GroupBox
    Friend WithEvents TbJuFla2ValFwPrak As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CbJuFla2ValSport As CheckBox
    Friend WithEvents TbJuFla2ValFwTheorie As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LbStatus As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CbJuFla2Bestanden As CheckBox
    Friend WithEvents TiMain As Timer
    Friend WithEvents BtJuFla2ckeck As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CbJuFla3Mannschaften As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BsJuFla3Mannschaften As BindingSource
    Friend WithEvents BsJuFla2Member As BindingSource
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BsJuFla3Member As BindingSource
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents CbJuFla3NachweisEh As CheckBox
    Friend WithEvents TbJuFla3FwTechnik As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents TbJuFla3ValEhAufgabe As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TbJuFla3ValPraesentation As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents CbJuFla3finished As CheckBox
    Friend WithEvents LbJuFla3Bestanden As Label
    Friend WithEvents BtJuFla3Check As Button
End Class
