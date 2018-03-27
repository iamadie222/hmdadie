<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialogEditPlayer
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
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblPlayerType = New System.Windows.Forms.Label()
        Me.tbPlayerName = New System.Windows.Forms.TextBox()
        Me.comboPlayerType = New System.Windows.Forms.ComboBox()
        Me.btnEditPlayerUpdate = New System.Windows.Forms.Button()
        Me.btnEditPlayerCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Location = New System.Drawing.Point(13, 13)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(95, 13)
        Me.lblPlayerName.TabIndex = 0
        Me.lblPlayerName.Text = "Enter Player Name"
        '
        'lblPlayerType
        '
        Me.lblPlayerType.AutoSize = True
        Me.lblPlayerType.Location = New System.Drawing.Point(13, 48)
        Me.lblPlayerType.Name = "lblPlayerType"
        Me.lblPlayerType.Size = New System.Drawing.Size(90, 13)
        Me.lblPlayerType.TabIndex = 1
        Me.lblPlayerType.Text = "SelectPlayerType"
        '
        'tbPlayerName
        '
        Me.tbPlayerName.Location = New System.Drawing.Point(133, 13)
        Me.tbPlayerName.Name = "tbPlayerName"
        Me.tbPlayerName.Size = New System.Drawing.Size(174, 20)
        Me.tbPlayerName.TabIndex = 2
        '
        'comboPlayerType
        '
        Me.comboPlayerType.FormattingEnabled = True
        Me.comboPlayerType.Items.AddRange(New Object() {"Batsman", "Bowler", "AllRounder"})
        Me.comboPlayerType.Location = New System.Drawing.Point(133, 48)
        Me.comboPlayerType.Name = "comboPlayerType"
        Me.comboPlayerType.Size = New System.Drawing.Size(121, 21)
        Me.comboPlayerType.TabIndex = 3
        '
        'btnEditPlayerUpdate
        '
        Me.btnEditPlayerUpdate.Location = New System.Drawing.Point(18, 119)
        Me.btnEditPlayerUpdate.Name = "btnEditPlayerUpdate"
        Me.btnEditPlayerUpdate.Size = New System.Drawing.Size(90, 23)
        Me.btnEditPlayerUpdate.TabIndex = 4
        Me.btnEditPlayerUpdate.Text = "Update Player"
        Me.btnEditPlayerUpdate.UseVisualStyleBackColor = True
        '
        'btnEditPlayerCancel
        '
        Me.btnEditPlayerCancel.Location = New System.Drawing.Point(243, 119)
        Me.btnEditPlayerCancel.Name = "btnEditPlayerCancel"
        Me.btnEditPlayerCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnEditPlayerCancel.TabIndex = 5
        Me.btnEditPlayerCancel.Text = "Cancel"
        Me.btnEditPlayerCancel.UseVisualStyleBackColor = True
        '
        'dialogEditPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 345)
        Me.Controls.Add(Me.btnEditPlayerCancel)
        Me.Controls.Add(Me.btnEditPlayerUpdate)
        Me.Controls.Add(Me.comboPlayerType)
        Me.Controls.Add(Me.tbPlayerName)
        Me.Controls.Add(Me.lblPlayerType)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Name = "dialogEditPlayer"
        Me.Text = "dialogEditPlayer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPlayerName As System.Windows.Forms.Label
    Friend WithEvents lblPlayerType As System.Windows.Forms.Label
    Friend WithEvents tbPlayerName As System.Windows.Forms.TextBox
    Friend WithEvents comboPlayerType As System.Windows.Forms.ComboBox
    Friend WithEvents btnEditPlayerUpdate As System.Windows.Forms.Button
    Friend WithEvents btnEditPlayerCancel As System.Windows.Forms.Button
End Class
