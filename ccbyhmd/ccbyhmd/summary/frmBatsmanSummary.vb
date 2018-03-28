﻿Public Class frmBatsmanSummary
    Dim dbc As New DbConnection()
    Dim ds As New DataSet()
    Private Sub frmBatsmanSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbc.FillDs("select * from matchs", ds, "matchs")
        comboSelectMatch.DataSource = ds.Tables("matchs")
        comboSelectMatch.DisplayMember = "team1"
        comboSelectMatch.ValueMember = "id"
    End Sub
    Private Sub comboSelectMatch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboSelectMatch.SelectionChangeCommitted
        Dim dr = ds.Tables("matchs").Select("id=" + CStr(comboSelectMatch.SelectedValue))
        lblTeam1.Text = dbc.GetTeamName(dr(0)("team1"))
        lblTeam2.Text = dbc.GetTeamName(dr(0)("team2"))
        Dim overs As Integer = dr(0)("overs")
        Try
            ds.Tables("players1").Clear()
            ds.Tables("players2").Clear()
        Catch ex As Exception

        End Try
        dbc.FillDs("select (select player_name from players where id=match_log.player_bat1) as Player,count(player_bat1) as BallPlayed ,sum(score) as Runs from match_log where match_id=" & comboSelectMatch.SelectedValue & " and ball_no < " & (overs * 6) & " group by player_bat1", ds, "players1")
        dgvTeam1.DataSource = ds.Tables("players1")

        dbc.FillDs("select (select player_name from players where id=match_log.player_bat1) as Player,count(player_bat1) as BallPlayed ,sum(score) as Runs from match_log where match_id=" & comboSelectMatch.SelectedValue & " and ball_no > " & (overs * 6) & " group by player_bat1", ds, "players2")
        dgvTeam2.DataSource = ds.Tables("players2")
    End Sub
End Class