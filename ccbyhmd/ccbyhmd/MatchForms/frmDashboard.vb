Public Class frmDashboard
    Dim dbc As New DbConnection()
    Dim ds As New DataSet
    Private Sub frmDashboard_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MatchStatus.update()
    End Sub

    Private Sub frmDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbc.FillDs("select * from teams where id in(" + MatchStatus.Status("team1") + "," + MatchStatus.Status("team2") + ")", ds, "teams")
        dbc.FillDs("select * from players where team_id in (" + MatchStatus.Status("team1") + "," + MatchStatus.Status("team2") + ")", ds, "players")

        ReloadMatchStatus()
    End Sub

    Sub ReloadMatchStatus()
        lblBatingTeam.Text = ds.Tables("teams").Select("id = " + MatchStatus.Status("team1") + "")(0)("team_name")
        lblBowlingTeam.Text = ds.Tables("teams").Select("id = " + MatchStatus.Status("team2") + "")(0)("team_name")
        lblOnStrikeBatsman.Text = ds.Tables("players").Select("id = " + MatchStatus.Status("player_bat1") + "")(0)("player_name")
        lblOffStrikeBatsman.Text = ds.Tables("players").Select("id = " + MatchStatus.Status("player_bat2") + "")(0)("player_name")
        lblBowler.Text = ds.Tables("players").Select("id = " + MatchStatus.Status("player_ball") + "")(0)("player_name")
        lblRuns.Text = dbc.getRuns(MatchStatus.Status("match_now"), MatchStatus.Status("team1"))
        lblWickets.Text = dbc.getWicketCount(MatchStatus.Status("match_now"), "")
        Dim ballno As String = MatchStatus.Status("ball_now")
        If (Val(ballno) Mod 6 = 0) Then
            If (dialogSelectBowler.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                ReloadMatchStatus()
            End If
        End If
        lblOvers.Text = OverFromBall(ballno) & "(" & MatchStatus.Status("ball_now") & ")"
        radioNormalBall.Checked = True
        '.Text = dbc.GetTeamName(MatchStatus.Status("team1"))
    End Sub

    Private Sub btnRun0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun0.Click
        CountRun(0)
        ReloadMatchStatus()
    End Sub

   

    Private Sub btnRun1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun1.Click
        CountRun(1)
        ReloadMatchStatus()
    End Sub

    Private Sub btnRun2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun2.Click
        CountRun(2)
        ReloadMatchStatus()
    End Sub

    Private Sub btnRun3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun3.Click
        CountRun(3)
        ReloadMatchStatus()
    End Sub

    Private Sub btnRun4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun4.Click
        CountRun(4)
        ReloadMatchStatus()
    End Sub

    Private Sub btnRun6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun6.Click
        CountRun(6)
        ReloadMatchStatus()
    End Sub
    Sub CountRun(ByVal score As String)
        Dim ballno As String = MatchStatus.Status("ball_now")
        Dim nextBallNo As String = Val(MatchStatus.Status("ball_now")) + 1
        Dim ballType As String = getBallType()
        If (ballType <> "normal") Then
            score = Val(score) + 1
            nextBallNo = ballno
        End If
        Dim wicket As String = 0
        Dim str As String = "insert into match_log(match_id,ball_no,ball_type,player_bat1,player_bat2,player_ball,score,wicket)" & _
            "VALUES (" + MatchStatus.Status("match_now") + "," + ballno + ",'" + ballType + "'," & _
            MatchStatus.Status("player_bat1") + "," + MatchStatus.Status("player_bat2") + "," + MatchStatus.Status("player_ball") & _
            "," + score + "," + wicket + ")"
        dbc.CountRun(str)
        MatchStatus.Status("ball_now") = nextBallNo
        'MsgBox(str)
    End Sub
    Function getBallType() As String
        If (radioNoball.Checked) Then
            Return "no"
        ElseIf (radioWiedBall.Checked) Then
            Return "wide"
        End If
        Return "normal"
    End Function

    Function OverFromBall(ByVal ball As String) As String
        Dim dl As Integer = Val(ball)
        Dim str As String = Math.Floor(dl / 6) & "." & CStr(dl Mod 6)
        Return str
    End Function

End Class