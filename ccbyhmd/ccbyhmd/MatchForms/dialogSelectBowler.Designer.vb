<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialogSelectBowler
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
        Me.comboSelectBowler = New System.Windows.Forms.ComboBox()
        Me.btnSelectBowler = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'comboSelectBowler
        '
        Me.comboSelectBowler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboSelectBowler.FormattingEnabled = True
        Me.comboSelectBowler.Location = New System.Drawing.Point(47, 29)
        Me.comboSelectBowler.Name = "comboSelectBowler"
        Me.comboSelectBowler.Size = New System.Drawing.Size(253, 21)
        Me.comboSelectBowler.TabIndex = 3
        '
        'btnSelectBowler
        '
        Me.btnSelectBowler.Location = New System.Drawing.Point(47, 74)
        Me.btnSelectBowler.Name = "btnSelectBowler"
        Me.btnSelectBowler.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectBowler.TabIndex = 2
        Me.btnSelectBowler.Text = "Select Bowler"
        Me.btnSelectBowler.UseVisualStyleBackColor = True
        '
        'dialogSelectBowler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 177)
        Me.Controls.Add(Me.comboSelectBowler)
        Me.Controls.Add(Me.btnSelectBowler)
        Me.Name = "dialogSelectBowler"
        Me.Text = "Select Bowler"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents comboSelectBowler As System.Windows.Forms.ComboBox
    Friend WithEvents btnSelectBowler As System.Windows.Forms.Button
End Class
