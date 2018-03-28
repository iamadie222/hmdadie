Public Class frmSummary

    Private Sub btnBatsmanSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatsmanSummary.Click
        Dim frm As New frmBatsmanSummary()
        frm.ShowDialog()
    End Sub

    Private Sub btnBowlerSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBowlerSummary.Click
        Dim frm As New frmBowlerSummary()
        frm.ShowDialog()
    End Sub

    Private Sub btnWicketSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWicketSummary.Click
        Dim frm As New frmWicketSummary()
        frm.ShowDialog()
    End Sub
End Class