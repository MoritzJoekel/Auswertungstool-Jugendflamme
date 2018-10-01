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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbJuFla2Member = New System.Windows.Forms.ComboBox()
        Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BsJuFla2Mannschaften = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsJuFla = New JuFla_vb.DtsJuFla()
        Me.CbJuFla2Mannschaft = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GbJuFla2PData = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GbJuFla2Wettbewerb = New System.Windows.Forms.GroupBox()
        Me.TbValFwPrak = New System.Windows.Forms.TextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsJuFla2Mannschaften, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsJuFla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbJuFla2PData.SuspendLayout()
        Me.GbJuFla2Wettbewerb.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.GbJuFla2Wettbewerb)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GbJuFla2PData)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CbJuFla2Member)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CbJuFla2Mannschaft)
        Me.SplitContainer1.Size = New System.Drawing.Size(918, 518)
        Me.SplitContainer1.SplitterDistance = 476
        Me.SplitContainer1.TabIndex = 0
        Me.SplitContainer1.TabStop = False
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
        Me.CbJuFla2Member.DataSource = Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource
        Me.CbJuFla2Member.DisplayMember = "ComboName"
        Me.CbJuFla2Member.FormattingEnabled = True
        Me.CbJuFla2Member.Location = New System.Drawing.Point(97, 88)
        Me.CbJuFla2Member.Name = "CbJuFla2Member"
        Me.CbJuFla2Member.Size = New System.Drawing.Size(228, 21)
        Me.CbJuFla2Member.TabIndex = 1
        '
        'TblJuFla2MannschaftenTblJuFla2MemberBindingSource
        '
        Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource.DataMember = "TblJuFla2Mannschaften_TblJuFla2Member"
        Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource.DataSource = Me.BsJuFla2Mannschaften
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
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource, "Geburtsdatum", True))
        Me.TextBox1.Location = New System.Drawing.Point(6, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
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
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource, "Geschlecht", True))
        Me.TextBox2.Location = New System.Drawing.Point(136, 39)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(116, 20)
        Me.TextBox2.TabIndex = 6
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
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource, "Ausweisnummer", True))
        Me.TextBox3.Location = New System.Drawing.Point(277, 39)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(116, 20)
        Me.TextBox3.TabIndex = 8
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
        'GbJuFla2Wettbewerb
        '
        Me.GbJuFla2Wettbewerb.Controls.Add(Me.TbValFwPrak)
        Me.GbJuFla2Wettbewerb.Location = New System.Drawing.Point(6, 227)
        Me.GbJuFla2Wettbewerb.Name = "GbJuFla2Wettbewerb"
        Me.GbJuFla2Wettbewerb.Size = New System.Drawing.Size(415, 208)
        Me.GbJuFla2Wettbewerb.TabIndex = 11
        Me.GbJuFla2Wettbewerb.TabStop = False
        Me.GbJuFla2Wettbewerb.Text = "Wettbewerbsdaten"
        '
        'TbValFwPrak
        '
        Me.TbValFwPrak.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource, "ValFwPrak", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"))
        Me.TbValFwPrak.Location = New System.Drawing.Point(9, 39)
        Me.TbValFwPrak.Name = "TbValFwPrak"
        Me.TbValFwPrak.Size = New System.Drawing.Size(130, 20)
        Me.TbValFwPrak.TabIndex = 0
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
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.TblJuFla2MannschaftenTblJuFla2MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsJuFla2Mannschaften, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsJuFla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbJuFla2PData.ResumeLayout(False)
        Me.GbJuFla2PData.PerformLayout()
        Me.GbJuFla2Wettbewerb.ResumeLayout(False)
        Me.GbJuFla2Wettbewerb.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CbJuFla2Member As ComboBox
    Friend WithEvents CbJuFla2Mannschaft As ComboBox
    Friend WithEvents DtsJuFla As DtsJuFla
    Friend WithEvents BsJuFla2Mannschaften As BindingSource
    Friend WithEvents TblJuFla2MannschaftenTblJuFla2MemberBindingSource As BindingSource
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GbJuFla2PData As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GbJuFla2Wettbewerb As GroupBox
    Friend WithEvents TbValFwPrak As TextBox
End Class
