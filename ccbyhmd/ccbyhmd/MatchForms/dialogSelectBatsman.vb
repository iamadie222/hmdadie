Public Class dialogSelectBatsman
    Private ds As New DataSet()
    Dim dbc As New DbConnection()
    Private Sub dialogSelectBatsman_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dbc.FillDs("select * from players where id not in(select distinct player_bat1 from match_log where match_id=" + MatchStatus.Status("match_now") + "  and not wicket=0) and not id=" + MatchStatus.Status("player_bat2") + " and team_id=" + MatchStatus.Status("team1"), ds, "players")
        comboSelectBatsman.DataSource = ds.Tables("players")
        comboSelectBatsman.ValueMember = "id"
        comboSelectBatsman.DisplayMember = "player_name"

    End Sub

    Private Sub btnSelectBatsman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectBatsman.Click
        MatchStatus.Status("player_bat1") = comboSelectBatsman.SelectedValue
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub
End Class