<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialogInsertPlayer
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
        Me.btnDialogInsertPlayer = New System.Windows.Forms.Button()
        Me.tbPlayerName = New System.Windows.Forms.TextBox()
        Me.lblPlayerType = New System.Windows.Forms.Label()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbBatsman = New System.Windows.Forms.RadioButton()
        Me.rbBwoler = New System.Windows.Forms.RadioButton()
        Me.rbAllRounder = New System.Windows.Forms.RadioButton()
        Me.btnInsertPlayerCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDialogInsertPlayer
        '
        Me.btnDialogInsertPlayer.Location = New System.Drawing.Point(23, 186)
        Me.btnDialogInsertPlayer.Name = "btnDialogInsertPlayer"
        Me.btnDialogInsertPlayer.Size = New System.Drawing.Size(75, 23)
        Me.btnDialogInsertPlayer.TabIndex = 9
        Me.btnDialogInsertPlayer.Text = "Add Player"
        Me.btnDialogInsertPlayer.UseVisualStyleBackColor = True
        '
        'tbPlayerName
        '
        Me.tbPlayerName.Location = New System.Drawing.Point(128, 19)
        Me.tbPlayerName.Name = "tbPlayerName"
        Me.tbPlayerName.Size = New System.Drawing.Size(174, 20)
        Me.tbPlayerName.TabIndex = 7
        '
        'lblPlayerType
        '
        Me.lblPlayerType.AutoSize = True
        Me.lblPlayerType.Location = New System.Drawing.Point(8, 54)
        Me.lblPlayerType.Name = "lblPlayerType"
        Me.lblPlayerType.Size = New System.Drawing.Size(90, 13)
        Me.lblPlayerType.TabIndex = 6
        Me.lblPlayerType.Text = "SelectPlayerType"
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Location = New System.Drawing.Point(8, 19)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(95, 13)
        Me.lblPlayerName.TabIndex = 5
        Me.lblPlayerName.Text = "Enter Player Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbAllRounder)
        Me.GroupBox1.Controls.Add(Me.rbBwoler)
        Me.GroupBox1.Controls.Add(Me.rbBatsman)
        Me.GroupBox1.Location = New System.Drawing.Point(128, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(139, 112)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Player Type"
        '
        'rbBatsman
        '
        Me.rbBatsman.AutoSize = True
        Me.rbBatsman.Checked = True
        Me.rbBatsman.Location = New System.Drawing.Point(7, 20)
        Me.rbBatsman.Name = "rbBatsman"
        Me.rbBatsman.Size = New System.Drawing.Size(66, 17)
        Me.rbBatsman.TabIndex = 0
        Me.rbBatsman.TabStop = True
        Me.rbBatsman.Text = "Batsman"
        Me.rbBatsman.UseVisualStyleBackColor = True
        '
        'rbBwoler
        '
        Me.rbBwoler.AutoSize = True
        Me.rbBwoler.Location = New System.Drawing.Point(7, 44)
        Me.rbBwoler.Name = "rbBwoler"
        Me.rbBwoler.Size = New System.Drawing.Size(57, 17)
        Me.rbBwoler.TabIndex = 1
        Me.rbBwoler.Text = "Bowler"
        Me.rbBwoler.UseVisualStyleBackColor = True
        '
        'rbAllRounder
        '
        Me.rbAllRounder.AutoSize = True
        Me.rbAllRounder.Location = New System.Drawing.Point(7, 68)
        Me.rbAllRounder.Name = "rbAllRounder"
        Me.rbAllRounder.Size = New System.Drawing.Size(80, 17)
        Me.rbAllRounder.TabIndex = 2
        Me.rbAllRounder.Text = "All Rounder"
        Me.rbAllRounder.UseVisualStyleBackColor = True
        '
        'btnInsertPlayerCancel
        '
        Me.btnInsertPlayerCancel.Location = New System.Drawing.Point(158, 186)
        Me.btnInsertPlayerCancel.Name = "btnInsertPlayerCancel"
        Me.btnInsertPlayerCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertPlayerCancel.TabIndex = 11
        Me.btnInsertPlayerCancel.Text = "Cancel"
        Me.btnInsertPlayerCancel.UseVisualStyleBackColor = True
        '
        'dialogInsertPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 336)
        Me.Controls.Add(Me.btnInsertPlayerCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDialogInsertPlayer)
        Me.Controls.Add(Me.tbPlayerName)
        Me.Controls.Add(Me.lblPlayerType)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Name = "dialogInsertPlayer"
        Me.Text = "dialogInsertPlayer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDialogInsertPlayer As System.Windows.Forms.Button
    Friend WithEvents tbPlayerName As System.Windows.Forms.TextBox
    Friend WithEvents lblPlayerType As System.Windows.Forms.Label
    Friend WithEvents lblPlayerName As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbAllRounder As System.Windows.Forms.RadioButton
    Friend WithEvents rbBwoler As System.Windows.Forms.RadioButton
    Friend WithEvents rbBatsman As System.Windows.Forms.RadioButton
    Friend WithEvents btnInsertPlayerCancel As System.Windows.Forms.Button
End Class
