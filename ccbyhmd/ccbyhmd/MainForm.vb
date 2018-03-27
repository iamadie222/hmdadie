Public Class MainForm

    Private Sub DashboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DashboardToolStripMenuItem.Click

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
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

        If (MatchStatus.Status("match_now") <> vbNullString) Then
            btnStartNewMatch.Text = "Continue Counting"
        End If
    End Sub

    Private Sub btnStartNewMatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartNewMatch.Click
        If (MatchStatus.Status("match_now") <> vbNullString) Then
            panelHomeButtons.Visible = False
            Dim frm2 As New frmDashboard()
            frm2.MdiParent = Me
            frm2.Show()
        Else
            Dim frm As New frmStartMatch
            If (frm.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                panelHomeButtons.Visible = False
                Dim frm2 As New frmDashboard()
                frm2.MdiParent = Me
                frm2.Show()
            End If
        End If
    End Sub
End Class
