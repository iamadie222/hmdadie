<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummary
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
        Me.btnBatsmanSummary = New System.Windows.Forms.Button()
        Me.btnWicketSummary = New System.Windows.Forms.Button()
        Me.btnBowlerSummary = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBatsmanSummary
        '
        Me.btnBatsmanSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatsmanSummary.Location = New System.Drawing.Point(185, 12)
        Me.btnBatsmanSummary.Name = "btnBatsmanSummary"
        Me.btnBatsmanSummary.Size = New System.Drawing.Size(240, 54)
        Me.btnBatsmanSummary.TabIndex = 0
        Me.btnBatsmanSummary.Text = "Batsman Summary"
        Me.btnBatsmanSummary.UseVisualStyleBackColor = True
        '
        'btnWicketSummary
        '
        Me.btnWicketSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWicketSummary.Location = New System.Drawing.Point(185, 132)
        Me.btnWicketSummary.Name = "btnWicketSummary"
        Me.btnWicketSummary.Size = New System.Drawing.Size(240, 54)
        Me.btnWicketSummary.TabIndex = 1
        Me.btnWicketSummary.Text = "Wicket Summary"
        Me.btnWicketSummary.UseVisualStyleBackColor = True
        '
        'btnBowlerSummary
        '
        Me.btnBowlerSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBowlerSummary.Location = New System.Drawing.Point(185, 72)
        Me.btnBowlerSummary.Name = "btnBowlerSummary"
        Me.btnBowlerSummary.Size = New System.Drawing.Size(240, 54)
        Me.btnBowlerSummary.TabIndex = 2
        Me.btnBowlerSummary.Text = "Bowler Summary"
        Me.btnBowlerSummary.UseVisualStyleBackColor = True
        '
        'frmSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 272)
        Me.Controls.Add(Me.btnBowlerSummary)
        Me.Controls.Add(Me.btnWicketSummary)
        Me.Controls.Add(Me.btnBatsmanSummary)
        Me.Name = "frmSummary"
        Me.Text = "Summary"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBatsmanSummary As System.Windows.Forms.Button
    Friend WithEvents btnWicketSummary As System.Windows.Forms.Button
    Friend WithEvents btnBowlerSummary As System.Windows.Forms.Button
End Class
