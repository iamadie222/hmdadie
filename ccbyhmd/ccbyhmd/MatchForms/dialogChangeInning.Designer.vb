<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialogChangeInning
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.comboBowler = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.comboOnStrikeBatsman = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.comboOffStrikeBatsman = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblBatingTeam = New System.Windows.Forms.Label()
        Me.lblBowlingTeam = New System.Windows.Forms.Label()
        Me.btnStartInning = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblBowlingTeam)
        Me.GroupBox2.Controls.Add(Me.comboBowler)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(593, 100)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bowling Team"
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
        Me.Label4.Size = New System.Drawing.Size(102, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Bowling Team"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblBatingTeam)
        Me.GroupBox1.Controls.Add(Me.comboOnStrikeBatsman)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.comboOffStrikeBatsman)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(593, 100)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Batting Team"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Batting Team"
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
        'comboOffStrikeBatsman
        '
        Me.comboOffStrikeBatsman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboOffStrikeBatsman.FormattingEnabled = True
        Me.comboOffStrikeBatsman.Location = New System.Drawing.Point(400, 44)
        Me.comboOffStrikeBatsman.Name = "comboOffStrikeBatsman"
        Me.comboOffStrikeBatsman.Size = New System.Drawing.Size(175, 21)
        Me.comboOffStrikeBatsman.TabIndex = 8
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
        'lblBatingTeam
        '
        Me.lblBatingTeam.AutoSize = True
        Me.lblBatingTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBatingTeam.ForeColor = System.Drawing.Color.DimGray
        Me.lblBatingTeam.Location = New System.Drawing.Point(15, 44)
        Me.lblBatingTeam.Name = "lblBatingTeam"
        Me.lblBatingTeam.Size = New System.Drawing.Size(63, 20)
        Me.lblBatingTeam.TabIndex = 9
        Me.lblBatingTeam.Text = "Label2"
        '
        'lblBowlingTeam
        '
        Me.lblBowlingTeam.AutoSize = True
        Me.lblBowlingTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBowlingTeam.ForeColor = System.Drawing.Color.DimGray
        Me.lblBowlingTeam.Location = New System.Drawing.Point(15, 38)
        Me.lblBowlingTeam.Name = "lblBowlingTeam"
        Me.lblBowlingTeam.Size = New System.Drawing.Size(63, 20)
        Me.lblBowlingTeam.TabIndex = 11
        Me.lblBowlingTeam.Text = "Label7"
        '
        'btnStartInning
        '
        Me.btnStartInning.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartInning.Location = New System.Drawing.Point(216, 249)
        Me.btnStartInning.Name = "btnStartInning"
        Me.btnStartInning.Size = New System.Drawing.Size(175, 42)
        Me.btnStartInning.TabIndex = 16
        Me.btnStartInning.Text = "Start"
        Me.btnStartInning.UseVisualStyleBackColor = True
        '
        'dialogChangeInning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 317)
        Me.Controls.Add(Me.btnStartInning)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "dialogChangeInning"
        Me.Text = "dialogChangeInning"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents comboBowler As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents comboOnStrikeBatsman As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents comboOffStrikeBatsman As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblBowlingTeam As System.Windows.Forms.Label
    Friend WithEvents lblBatingTeam As System.Windows.Forms.Label
    Friend WithEvents btnStartInning As System.Windows.Forms.Button
End Class
