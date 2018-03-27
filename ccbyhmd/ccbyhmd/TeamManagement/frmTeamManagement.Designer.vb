<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeamManagement
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
        Me.btnInsertTeam = New System.Windows.Forms.Button()
        Me.dgvTeams = New System.Windows.Forms.DataGridView()
        Me.btnRemoveTeam = New System.Windows.Forms.Button()
        Me.dgvPlayers = New System.Windows.Forms.DataGridView()
        Me.btnRemovePlayer = New System.Windows.Forms.Button()
        Me.btnInsertPlayer = New System.Windows.Forms.Button()
        Me.btnEditPlayer = New System.Windows.Forms.Button()
        CType(Me.dgvTeams, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPlayers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInsertTeam
        '
        Me.btnInsertTeam.Location = New System.Drawing.Point(13, 305)
        Me.btnInsertTeam.Name = "btnInsertTeam"
        Me.btnInsertTeam.Size = New System.Drawing.Size(76, 23)
        Me.btnInsertTeam.TabIndex = 0
        Me.btnInsertTeam.Text = "Add Team"
        Me.btnInsertTeam.UseVisualStyleBackColor = True
        '
        'dgvTeams
        '
        Me.dgvTeams.AllowUserToAddRows = False
        Me.dgvTeams.AllowUserToDeleteRows = False
        Me.dgvTeams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvTeams.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvTeams.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTeams.Location = New System.Drawing.Point(13, 13)
        Me.dgvTeams.Name = "dgvTeams"
        Me.dgvTeams.ReadOnly = True
        Me.dgvTeams.RowHeadersVisible = False
        Me.dgvTeams.Size = New System.Drawing.Size(168, 286)
        Me.dgvTeams.TabIndex = 1
        '
        'btnRemoveTeam
        '
        Me.btnRemoveTeam.Location = New System.Drawing.Point(95, 305)
        Me.btnRemoveTeam.Name = "btnRemoveTeam"
        Me.btnRemoveTeam.Size = New System.Drawing.Size(86, 23)
        Me.btnRemoveTeam.TabIndex = 2
        Me.btnRemoveTeam.Text = "Remove Team"
        Me.btnRemoveTeam.UseVisualStyleBackColor = True
        '
        'dgvPlayers
        '
        Me.dgvPlayers.AllowUserToAddRows = False
        Me.dgvPlayers.AllowUserToDeleteRows = False
        Me.dgvPlayers.AllowUserToResizeRows = False
        Me.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlayers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPlayers.Location = New System.Drawing.Point(188, 13)
        Me.dgvPlayers.Name = "dgvPlayers"
        Me.dgvPlayers.ReadOnly = True
        Me.dgvPlayers.Size = New System.Drawing.Size(512, 286)
        Me.dgvPlayers.TabIndex = 3
        '
        'btnRemovePlayer
        '
        Me.btnRemovePlayer.Location = New System.Drawing.Point(602, 305)
        Me.btnRemovePlayer.Name = "btnRemovePlayer"
        Me.btnRemovePlayer.Size = New System.Drawing.Size(98, 23)
        Me.btnRemovePlayer.TabIndex = 4
        Me.btnRemovePlayer.Text = "Remove Player"
        Me.btnRemovePlayer.UseVisualStyleBackColor = True
        '
        'btnInsertPlayer
        '
        Me.btnInsertPlayer.Location = New System.Drawing.Point(441, 305)
        Me.btnInsertPlayer.Name = "btnInsertPlayer"
        Me.btnInsertPlayer.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertPlayer.TabIndex = 5
        Me.btnInsertPlayer.Text = "Add Player"
        Me.btnInsertPlayer.UseVisualStyleBackColor = True
        '
        'btnEditPlayer
        '
        Me.btnEditPlayer.Location = New System.Drawing.Point(522, 305)
        Me.btnEditPlayer.Name = "btnEditPlayer"
        Me.btnEditPlayer.Size = New System.Drawing.Size(75, 23)
        Me.btnEditPlayer.TabIndex = 6
        Me.btnEditPlayer.Text = "Edit Player"
        Me.btnEditPlayer.UseVisualStyleBackColor = True
        '
        'frmTeamManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 407)
        Me.Controls.Add(Me.btnEditPlayer)
        Me.Controls.Add(Me.btnInsertPlayer)
        Me.Controls.Add(Me.btnRemovePlayer)
        Me.Controls.Add(Me.dgvPlayers)
        Me.Controls.Add(Me.btnRemoveTeam)
        Me.Controls.Add(Me.dgvTeams)
        Me.Controls.Add(Me.btnInsertTeam)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTeamManagement"
        Me.Text = "Team Management"
        CType(Me.dgvTeams, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPlayers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInsertTeam As System.Windows.Forms.Button
    Friend WithEvents dgvTeams As System.Windows.Forms.DataGridView
    Friend WithEvents btnRemoveTeam As System.Windows.Forms.Button
    Friend WithEvents dgvPlayers As System.Windows.Forms.DataGridView
    Friend WithEvents btnRemovePlayer As System.Windows.Forms.Button
    Friend WithEvents btnInsertPlayer As System.Windows.Forms.Button
    Friend WithEvents btnEditPlayer As System.Windows.Forms.Button
End Class
