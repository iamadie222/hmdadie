Public Class dialogChangeInning
    Dim dbc As New DbConnection()
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
    Function ValidateForm() As Boolean
        If (comboOnStrikeBatsman.SelectedValue = comboOffStrikeBatsman.SelectedValue) Then
            MsgBox("Select Different On and Off strike batsman")
            Return False

        End If
        Return True
    End Function

    Private Sub btnStartInning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartInning.Click
        If (ValidateForm()) Then
            MatchStatus.Status("player_ball") = comboBowler.SelectedValue
            MatchStatus.Status("player_bat1") = comboOnStrikeBatsman.SelectedValue
            MatchStatus.Status("player_bat2") = comboOffStrikeBatsman.SelectedValue
            MatchStatus.Status("ball_now") = (MatchStatus.Status("overs_now")) * 6
            MatchStatus.Status("inning") = "2"
            MatchStatus.update()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub dialogChangeInning_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblBatingTeam.Text = dbc.GetTeamName(MatchStatus.Status("team2"))
        lblBowlingTeam.Text = dbc.GetTeamName(MatchStatus.Status("team1"))
        LoadPlayerBatting(MatchStatus.Status("team2"))
        LoadPlayerBowling(MatchStatus.Status("team1"))
    End Sub
End Class