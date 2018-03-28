Public Class MainForm

    Private Sub DashboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmDashboard()
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub ManageTeamToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageTeamToolStripMenuItem.Click
        Dim frm As New frmTeamManagement()
        'frm.MdiParent = Me
        frm.ShowDialog()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        MatchStatus.init()
        If (MatchStatus.Status("match_now") <> "-1") Then
            btnStartNewMatch.Text = "Continue Counting"
        End If
    End Sub

    Private Sub btnStartNewMatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartNewMatch.Click
        If (MatchStatus.Status("match_now") <> "-1") Then
            panelHomeButtons.Visible = False
            Dim frm2 As New frmDashboard()
            frm2.MdiParent = Me
            frm2.Show()
            'panelHomeButtons.Visible = True
        Else
            Dim frm As New frmStartMatch
            If (frm.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                panelHomeButtons.Visible = False
                Dim frm2 As New frmDashboard()
                frm2.MdiParent = Me
                frm2.Show()
                'panelHomeButtons.Visible = True
            End If
        End If
    End Sub

    Private Sub BowlerSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BowlerSummaryToolStripMenuItem.Click
        Dim frm As New frmBowlerSummary()
        frm.ShowDialog()
    End Sub

    
    Private Sub BatsmanSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatsmanSummaryToolStripMenuItem.Click
        Dim frm As New frmBatsmanSummary()
        frm.ShowDialog()
    End Sub

    Private Sub WicketSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WicketSummaryToolStripMenuItem.Click
        Dim frm As New frmWicketSummary()
        frm.ShowDialog()
    End Sub

    Private Sub btnManageTeams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManageTeams.Click
        Dim frm As New frmTeamManagement()
        frm.ShowDialog()

    End Sub

    Private Sub btnViewSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewSummary.Click
        Dim frm As New frmSummary()
        frm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
