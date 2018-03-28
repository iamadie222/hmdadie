Public Class frmStartMatch
    Dim dbc As New DbConnection()
    Dim ht As New Hashtable
    Private Sub frmStartMatch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsTeams As New DataSet
        Dim dsTeams2 As New DataSet
        Dim teamStr As String = "select * from teams where id in(select team_id from players group by team_id having count(team_id)=11)"
        dbc.FillDs(teamStr, dsTeams, "teams")
        dbc.FillDs(teamStr, dsTeams2, "teams")
        comboBattingTeam.DataSource = dsTeams.Tables("teams")
        comboBattingTeam.DisplayMember = "team_name"
        comboBattingTeam.ValueMember = "id"
        comboBattingTeam.SelectedIndex = -1

        comboBowlingTeam.DataSource = dsTeams2.Tables("teams")
        comboBowlingTeam.DisplayMember = "team_name"
        comboBowlingTeam.ValueMember = "id"
        comboBowlingTeam.SelectedIndex = -1
    End Sub

    Private Sub btnStartMatchNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartMatchNow.Click

        If (ValidateForm()) Then

            MatchStatus.Status("player_ball") = comboBowler.SelectedValue
            MatchStatus.Status("player_bat1") = comboOnStrikeBatsman.SelectedValue
            MatchStatus.Status("player_bat2") = comboOffStrikeBatsman.SelectedValue
            MatchStatus.Status("team1") = comboBattingTeam.SelectedValue
            MatchStatus.Status("team2") = comboBowlingTeam.SelectedValue
            MatchStatus.Status("match_now") = dbc.InsertNewmatch(MatchStatus.Status("team1"), MatchStatus.Status("team2"), tbMatchOvers.Text)
            MatchStatus.Status("ball_now") = "0"
            MatchStatus.Status("overs_now") = tbMatchOvers.Text
            MatchStatus.Status("inning") = "1"
            MatchStatus.update()
            Me.DialogResult = Windows.Forms.DialogResult.OK

        End If

    End Sub

    Private Sub comboBattingTeam_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBattingTeam.SelectionChangeCommitted
        LoadPlayerBatting(comboBattingTeam.SelectedValue)
    End Sub



    Sub LoadPlayerBatting(ByVal id As String)
        Dim ds As New DataSet
        Dim ds2 As New DataSet
        dbc.FillDs("select * from players where team_id=" + id + " order by player_type desc", ds, "players")
        dbc.FillDs("select * from players where team_id=" + id + " order by player_type desc", ds2, "players")
        comboOnStrikeBatsman.DataSource = ds.Tables("players")
        comboOnStrikeBatsman.DisplayMember = "player_name"
        comboOnStrikeBatsman.ValueMember = "id"

        comboOffStrikeBatsman.DataSource = ds2.Tables("players")
        comboOffStrikeBatsman.DisplayMember = "player_name"
        comboOffStrikeBatsman.ValueMember = "id"
    End Sub

    Sub LoadPlayerBowling(ByVal id As String)
        Dim ds As New DataSet
        dbc.FillDs("select * from players where team_id=" + id + " order by player_type desc", ds, "players")
        comboBowler.DataSource = ds.Tables("players")
        comboBowler.DisplayMember = "player_name"
        comboBowler.ValueMember = "id"
    End Sub

    Private Sub comboBowlingTeam_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBowlingTeam.SelectionChangeCommitted
        LoadPlayerBowling(comboBowlingTeam.SelectedValue)
    End Sub

    Function ValidateForm() As Boolean
        If (comboBattingTeam.SelectedIndex = -1) Then
            MsgBox("Please Select Batting Team")
            Return False
        ElseIf (comboBowlingTeam.SelectedIndex = -1) Then
            MsgBox("Please Select Bowling Team")
            Return False
        ElseIf (comboBattingTeam.SelectedValue = comboBowlingTeam.SelectedValue) Then
            MsgBox("Please Select Tow Different Teams")
            Return False
        ElseIf (comboOnStrikeBatsman.SelectedValue = comboOffStrikeBatsman.SelectedValue) Then
            MsgBox("Select Different On and Off strike batsman")
            Return False
        ElseIf (tbMatchOvers.Text = vbNullString) Then
            MsgBox("Enter match Overs")
            Return False
        End If
        Return True
    End Function


End Class