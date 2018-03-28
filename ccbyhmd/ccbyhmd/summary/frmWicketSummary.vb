Public Class frmWicketSummary
    Dim dbc As New DbConnection()
    Dim ds As New DataSet()

    Function WicketString(ByVal num As String) As String
        If (num = "1") Then
            Return "Bold"
        ElseIf (num = "2") Then
            Return "Run Now"
        ElseIf (num = "3") Then
            Return "Catch Out"
        End If
        Return ""
    End Function

    Private Sub frmWicketSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbc.FillDs("select id,team1,team2,overs,id&'. '&(select team_name from teams where id=matchs.team1)&' VS '&(select team_name from teams where id=matchs.team2)&' on '&match_date as teamNames from matchs", ds, "matchs")
        comboSelectMatch.DataSource = ds.Tables("matchs")
        comboSelectMatch.DisplayMember = "teamNames"
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
        dbc.FillDs("select (select player_name from players where id=match_log.player_bat1) as Batsman,(select player_name from players where id=match_log.player_ball)as Bowler,(select wicket_value from wicket_type where wicket_num=match_log.wicket) as WicketType  from match_log where match_id=" & comboSelectMatch.SelectedValue & " and ball_no > " & (overs * 6) & " and not wicket=0", ds, "players1")
        dgvTeam1.DataSource = ds.Tables("players1")

        dbc.FillDs("select (select player_name from players where id=match_log.player_bat1) as Batsman,(select player_name from players where id=match_log.player_ball)as Bowler,(select wicket_value from wicket_type where wicket_num=match_log.wicket) as WicketType  from match_log where match_id=" & comboSelectMatch.SelectedValue & " and ball_no < " & (overs * 6) & " and not wicket=0", ds, "players2")
        dgvTeam2.DataSource = ds.Tables("players2")
    End Sub

    Private Sub dgvTeam1_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvTeam1.RowsAdded
        For i As Integer = e.RowIndex To e.RowIndex + e.RowCount - 1
            ' dgvTeam1.Columns(dgvTeam1.Rows(i).Cells.Item("wicket").ColumnIndex).ValueType = GetType(String)
            'dgvTeam1.Rows(i).Cells.Item("wicket").Value = WicketString(dgvTeam1.Rows(i).Cells.Item("wicket").Value)
        Next
    End Sub
End Class