﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageTeamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.btnStartNewMatch = New System.Windows.Forms.Button()
        Me.btnManageTeams = New System.Windows.Forms.Button()
        Me.btnViewSummary = New System.Windows.Forms.Button()
        Me.panelHomeButtons = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.panelHomeButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.TeamToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(736, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem})
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'TeamToolStripMenuItem
        '
        Me.TeamToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageTeamToolStripMenuItem})
        Me.TeamToolStripMenuItem.Name = "TeamToolStripMenuItem"
        Me.TeamToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.TeamToolStripMenuItem.Text = "Team"
        '
        'ManageTeamToolStripMenuItem
        '
        Me.ManageTeamToolStripMenuItem.Name = "ManageTeamToolStripMenuItem"
        Me.ManageTeamToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ManageTeamToolStripMenuItem.Text = "Manage Team"
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.White
        Me.lblMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.Location = New System.Drawing.Point(26, 11)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(683, 73)
        Me.lblMain.TabIndex = 5
        Me.lblMain.Text = "Cricket Score Counter"
        '
        'btnStartNewMatch
        '
        Me.btnStartNewMatch.Location = New System.Drawing.Point(170, 114)
        Me.btnStartNewMatch.Name = "btnStartNewMatch"
        Me.btnStartNewMatch.Size = New System.Drawing.Size(357, 71)
        Me.btnStartNewMatch.TabIndex = 7
        Me.btnStartNewMatch.Text = "Start New Match"
        Me.btnStartNewMatch.UseVisualStyleBackColor = True
        '
        'btnManageTeams
        '
        Me.btnManageTeams.Location = New System.Drawing.Point(170, 192)
        Me.btnManageTeams.Name = "btnManageTeams"
        Me.btnManageTeams.Size = New System.Drawing.Size(357, 71)
        Me.btnManageTeams.TabIndex = 8
        Me.btnManageTeams.Text = "Manage Teams"
        Me.btnManageTeams.UseVisualStyleBackColor = True
        '
        'btnViewSummary
        '
        Me.btnViewSummary.Location = New System.Drawing.Point(170, 270)
        Me.btnViewSummary.Name = "btnViewSummary"
        Me.btnViewSummary.Size = New System.Drawing.Size(357, 78)
        Me.btnViewSummary.TabIndex = 9
        Me.btnViewSummary.Text = "View Summary"
        Me.btnViewSummary.UseVisualStyleBackColor = True
        '
        'panelHomeButtons
        '
        Me.panelHomeButtons.BackColor = System.Drawing.Color.Transparent
        Me.panelHomeButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelHomeButtons.Controls.Add(Me.lblMain)
        Me.panelHomeButtons.Controls.Add(Me.btnViewSummary)
        Me.panelHomeButtons.Controls.Add(Me.btnStartNewMatch)
        Me.panelHomeButtons.Controls.Add(Me.btnManageTeams)
        Me.panelHomeButtons.Location = New System.Drawing.Point(0, 27)
        Me.panelHomeButtons.Name = "panelHomeButtons"
        Me.panelHomeButtons.Size = New System.Drawing.Size(736, 527)
        Me.panelHomeButtons.TabIndex = 11
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._1_cricket_ball_on_grass_richard_thomas
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(736, 555)
        Me.Controls.Add(Me.panelHomeButtons)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Cricket Score Counter"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.panelHomeButtons.ResumeLayout(False)
        Me.panelHomeButtons.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DashboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageTeamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents btnStartNewMatch As System.Windows.Forms.Button
    Friend WithEvents btnManageTeams As System.Windows.Forms.Button
    Friend WithEvents btnViewSummary As System.Windows.Forms.Button
    Friend WithEvents panelHomeButtons As System.Windows.Forms.Panel

End Class