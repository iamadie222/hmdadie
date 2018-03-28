<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWicketSummary
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
        Me.lblTeam2 = New System.Windows.Forms.Label()
        Me.lblTeam1 = New System.Windows.Forms.Label()
        Me.dgvTeam2 = New System.Windows.Forms.DataGridView()
        Me.dgvTeam1 = New System.Windows.Forms.DataGridView()
        Me.comboSelectMatch = New System.Windows.Forms.ComboBox()
        CType(Me.dgvTeam2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTeam1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTeam2
        '
        Me.lblTeam2.AutoSize = True
        Me.lblTeam2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam2.Location = New System.Drawing.Point(367, 57)
        Me.lblTeam2.Name = "lblTeam2"
        Me.lblTeam2.Size = New System.Drawing.Size(15, 24)
        Me.lblTeam2.TabIndex = 14
        Me.lblTeam2.Text = " "
        '
        'lblTeam1
        '
        Me.lblTeam1.AutoSize = True
        Me.lblTeam1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam1.Location = New System.Drawing.Point(18, 57)
        Me.lblTeam1.Name = "lblTeam1"
        Me.lblTeam1.Size = New System.Drawing.Size(15, 24)
        Me.lblTeam1.TabIndex = 13
        Me.lblTeam1.Text = " "
        '
        'dgvTeam2
        '
        Me.dgvTeam2.AllowUserToAddRows = False
        Me.dgvTeam2.AllowUserToDeleteRows = False
        Me.dgvTeam2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeam2.Location = New System.Drawing.Point(9, 84)
        Me.dgvTeam2.Name = "dgvTeam2"
        Me.dgvTeam2.ReadOnly = True
        Me.dgvTeam2.Size = New System.Drawing.Size(345, 351)
        Me.dgvTeam2.TabIndex = 12
        '
        'dgvTeam1
        '
        Me.dgvTeam1.AllowUserToAddRows = False
        Me.dgvTeam1.AllowUserToDeleteRows = False
        Me.dgvTeam1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeam1.Location = New System.Drawing.Point(371, 84)
        Me.dgvTeam1.Name = "dgvTeam1"
        Me.dgvTeam1.ReadOnly = True
        Me.dgvTeam1.Size = New System.Drawing.Size(337, 351)
        Me.dgvTeam1.TabIndex = 11
        '
        'comboSelectMatch
        '
        Me.comboSelectMatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboSelectMatch.FormattingEnabled = True
        Me.comboSelectMatch.Location = New System.Drawing.Point(9, 15)
        Me.comboSelectMatch.Name = "comboSelectMatch"
        Me.comboSelectMatch.Size = New System.Drawing.Size(477, 21)
        Me.comboSelectMatch.TabIndex = 10
        '
        'frmWicketSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 450)
        Me.Controls.Add(Me.lblTeam2)
        Me.Controls.Add(Me.lblTeam1)
        Me.Controls.Add(Me.dgvTeam2)
        Me.Controls.Add(Me.dgvTeam1)
        Me.Controls.Add(Me.comboSelectMatch)
        Me.Name = "frmWicketSummary"
        Me.Text = "Wicket Summary"
        CType(Me.dgvTeam2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTeam1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTeam2 As System.Windows.Forms.Label
    Friend WithEvents lblTeam1 As System.Windows.Forms.Label
    Friend WithEvents dgvTeam2 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvTeam1 As System.Windows.Forms.DataGridView
    Friend WithEvents comboSelectMatch As System.Windows.Forms.ComboBox
End Class
