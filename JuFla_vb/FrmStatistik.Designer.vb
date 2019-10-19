<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStatistik
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DtsJuFla = New JuFla_vb.DtsJuFla()
        Me.TblEventsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtStatistik = New System.Windows.Forms.Button()
        CType(Me.DtsJuFla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEventsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TblEventsBindingSource
        Me.ComboBox1.DisplayMember = "EventID"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(94, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(363, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'DtsJuFla
        '
        Me.DtsJuFla.DataSetName = "DtsJuFla"
        Me.DtsJuFla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblEventsBindingSource
        '
        Me.TblEventsBindingSource.DataMember = "TblEvents"
        Me.TblEventsBindingSource.DataSource = Me.DtsJuFla
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Veranstaltung:"
        '
        'BtStatistik
        '
        Me.BtStatistik.Location = New System.Drawing.Point(94, 76)
        Me.BtStatistik.Name = "BtStatistik"
        Me.BtStatistik.Size = New System.Drawing.Size(246, 40)
        Me.BtStatistik.TabIndex = 2
        Me.BtStatistik.Text = "Statistik!"
        Me.BtStatistik.UseVisualStyleBackColor = True
        '
        'FrmStatistik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 551)
        Me.Controls.Add(Me.BtStatistik)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "FrmStatistik"
        Me.Text = "Statistik"
        CType(Me.DtsJuFla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEventsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TblEventsBindingSource As BindingSource
    Friend WithEvents DtsJuFla As DtsJuFla
    Friend WithEvents Label1 As Label
    Friend WithEvents BtStatistik As Button
End Class
