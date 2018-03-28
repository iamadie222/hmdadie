<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialogSelectBatsman
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
        Me.btnSelectBatsman = New System.Windows.Forms.Button()
        Me.comboSelectBatsman = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnSelectBatsman
        '
        Me.btnSelectBatsman.Location = New System.Drawing.Point(87, 79)
        Me.btnSelectBatsman.Name = "btnSelectBatsman"
        Me.btnSelectBatsman.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectBatsman.TabIndex = 0
        Me.btnSelectBatsman.Text = "Select Batsman"
        Me.btnSelectBatsman.UseVisualStyleBackColor = True
        '
        'comboSelectBatsman
        '
        Me.comboSelectBatsman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboSelectBatsman.FormattingEnabled = True
        Me.comboSelectBatsman.Location = New System.Drawing.Point(87, 34)
        Me.comboSelectBatsman.Name = "comboSelectBatsman"
        Me.comboSelectBatsman.Size = New System.Drawing.Size(253, 21)
        Me.comboSelectBatsman.TabIndex = 1
        '
        'dialogSelectBatsman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 154)
        Me.Controls.Add(Me.comboSelectBatsman)
        Me.Controls.Add(Me.btnSelectBatsman)
        Me.Name = "dialogSelectBatsman"
        Me.Text = "Select Batsman"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSelectBatsman As System.Windows.Forms.Button
    Friend WithEvents comboSelectBatsman As System.Windows.Forms.ComboBox
End Class
