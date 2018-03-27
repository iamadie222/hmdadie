<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStartMatch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboBattingTeam = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.comboOnStrikeBatsman = New System.Windows.Forms.ComboBox()
        Me.comboOffStrikeBatsman = New System.Windows.Forms.ComboBox()
        Me.comboBowlingTeam = New System.Windows.Forms.ComboBox()
        Me.comboBowler = New System.Windows.Forms.ComboBox()
        Me.tbMatchOvers = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnStartMatchNow = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Batting Team"
        '
        'comboBattingTeam
        '
        Me.comboBattingTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBattingTeam.FormattingEnabled = True
        Me.comboBattingTeam.Location = New System.Drawing.Point(9, 45)
        Me.comboBattingTeam.Name = "comboBattingTeam"
        Me.comboBattingTeam.Size = New System.Drawing.Size(152, 21)
        Me.comboBattingTeam.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Match Overs"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(183, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Select Bowler"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Select Bowling Team"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(397, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Select Off Strike Batsman"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(183, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Select On Strike Batsman"
        '
        'comboOnStrikeBatsman
        '
        Me.comboOnStrikeBatsman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboOnStrikeBatsman.FormattingEnabled = True
        Me.comboOnStrikeBatsman.Location = New System.Drawing.Point(186, 45)
        Me.comboOnStrikeBatsman.Name = "comboOnStrikeBatsman"
        Me.comboOnStrikeBatsman.Size = New System.Drawing.Size(175, 21)
        Me.comboOnStrikeBatsman.TabIndex = 7
        '
        'comboOffStrikeBatsman
        '
        Me.comboOffStrikeBatsman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboOffStrikeBatsman.FormattingEnabled = True
        Me.comboOffStrikeBatsman.Location = New System.Drawing.Point(400, 44)
        Me.comboOffStrikeBatsman.Name = "comboOffStrikeBatsman"
        Me.comboOffStrikeBatsman.Size = New System.Drawing.Size(175, 21)
        Me.comboOffStrikeBatsman.TabIndex = 8
        '
        'comboBowlingTeam
        '
        Me.comboBowlingTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBowlingTeam.FormattingEnabled = True
        Me.comboBowlingTeam.Location = New System.Drawing.Point(7, 38)
        Me.comboBowlingTeam.Name = "comboBowlingTeam"
        Me.comboBowlingTeam.Size = New System.Drawing.Size(152, 21)
        Me.comboBowlingTeam.TabIndex = 9
        '
        'comboBowler
        '
        Me.comboBowler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBowler.FormattingEnabled = True
        Me.comboBowler.Location = New System.Drawing.Point(186, 37)
        Me.comboBowler.Name = "comboBowler"
        Me.comboBowler.Size = New System.Drawing.Size(175, 21)
        Me.comboBowler.TabIndex = 10
        '
        'tbMatchOvers
        '
        Me.tbMatchOvers.Location = New System.Drawing.Point(6, 37)
        Me.tbMatchOvers.Name = "tbMatchOvers"
        Me.tbMatchOvers.Size = New System.Drawing.Size(153, 20)
        Me.tbMatchOvers.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.comboOnStrikeBatsman)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.comboBattingTeam)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.comboOffStrikeBatsman)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(593, 100)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Batting Team"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.comboBowler)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.comboBowlingTeam)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(593, 100)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bowling Team"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.tbMatchOvers)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 228)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(593, 100)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        '
        'btnStartMatchNow
        '
        Me.btnStartMatchNow.Location = New System.Drawing.Point(202, 372)
        Me.btnStartMatchNow.Name = "btnStartMatchNow"
        Me.btnStartMatchNow.Size = New System.Drawing.Size(219, 56)
        Me.btnStartMatchNow.TabIndex = 15
        Me.btnStartMatchNow.Text = "Start Match"
        Me.btnStartMatchNow.UseVisualStyleBackColor = True
        '
        'frmStartMatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 486)
        Me.Controls.Add(Me.btnStartMatchNow)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmStartMatch"
        Me.Text = "fromStartMatch"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents comboBattingTeam As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents comboOnStrikeBatsman As System.Windows.Forms.ComboBox
    Friend WithEvents comboOffStrikeBatsman As System.Windows.Forms.ComboBox
    Friend WithEvents comboBowlingTeam As System.Windows.Forms.ComboBox
    Friend WithEvents comboBowler As System.Windows.Forms.ComboBox
    Friend WithEvents tbMatchOvers As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnStartMatchNow As System.Windows.Forms.Button
End Class
