Public Class frmDashboard
    Dim dbc As New DbConnection()
    Dim ds As New DataSet
    Dim isWicket As Boolean

    Private Sub frmDashboard_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MatchStatus.update()
    End Sub

    Private Sub frmDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
    End Sub

    Sub formLoad()
        dbc.FillDs("select * from matchs where id=" + MatchStatus.Status("match_now"), ds, "matchs")
        If (MatchStatus.Status("inning") = "2") Then
            MatchStatus.Status("team1") = ds.Tables("matchs").Rows(0)("team2")
            MatchStatus.Status("team2") = ds.Tables("matchs").Rows(0)("team1")
        End If
        dbc.FillDs("select * from teams where id in(" + MatchStatus.Status("team1") + "," + MatchStatus.Status("team2") + ")", ds, "teams")
        dbc.FillDs("select * from players where team_id in (" + MatchStatus.Status("team1") + "," + MatchStatus.Status("team2") + ")", ds, "players")
        ReloadMatchStatus()
    End Sub


    Sub ReloadMatchStatus()
        Dim wicketCount As String = dbc.getWicketCount(MatchStatus.Status("match_now"), "")
        Dim ballno As String = MatchStatus.Status("ball_now")

        
        If (Val(ballno) >= Val(MatchStatus.Status("overs_now")) * 6 Or Val(wicketCount) >= 9) Then
            If (MatchStatus.Status("inning") = "1") Then
                Dim frm As New dialogChangeInning()
                If (frm.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                    formLoad()
                End If
            ElseIf (MatchStatus.Status("inning") = "2") Then
                Dim bno1 As String = (Val(MatchStatus.Status("inning")) * Val(MatchStatus.Status("overs_now")) * 6) - (Val(MatchStatus.Status("overs_now")) * 6)
                If (Val(ballno) >= Val(MatchStatus.Status("inning")) * Val(MatchStatus.Status("overs_now")) * 6) Then
                    dbc.execute("update status set status_value = '-1'")
                    MatchStatus.init()
                    MsgBox("match Finished")
                    Me.Close()
                    Return
                End If

            End If
        End If
        If (isWicket) Then
            Dim frm As New dialogSelectBatsman()
            If (frm.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                isWicket = False
            End If
        End If
        
        If (Val(ballno) Mod 6 = 0 And Not (Val(ballno) = Val(MatchStatus.Status("overs_now")) * 6 Or Val(ballno) = 0)) Then
            Dim frm As New dialogSelectBowler(MatchStatus.Status("team2"))
            If (frm.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                Dim temp As String
                temp = MatchStatus.Status("player_bat1")
                MatchStatus.Status("player_bat1") = MatchStatus.Status("player_bat2")
                MatchStatus.Status("player_bat2") = temp
            End If
        End If

        Dim p1Score As String = dbc.getTotalRunsOfPlayer(MatchStatus.Status("player_bat1"), MatchStatus.Status("match_now"))
        Dim p2Score As String = dbc.getTotalRunsOfPlayer(MatchStatus.Status("player_bat2"), MatchStatus.Status("match_now"))
        lblBatingTeam.Text = ds.Tables("teams").Select("id = " + MatchStatus.Status("team1") + "")(0)("team_name")
        lblBowlingTeam.Text = ds.Tables("teams").Select("id = " + MatchStatus.Status("team2") + "")(0)("team_name")
        lblOnStrikeBatsman.Text = ds.Tables("players").Select("id = " + MatchStatus.Status("player_bat1") + "")(0)("player_name") & "(" + p1Score + ")"
        lblOffStrikeBatsman.Text = ds.Tables("players").Select("id = " + MatchStatus.Status("player_bat2") + "")(0)("player_name") & "(" + p2Score + ")"
        lblBowler.Text = ds.Tables("players").Select("id = " + MatchStatus.Status("player_ball") + "")(0)("player_name")
        lblRuns.Text = dbc.getRuns(MatchStatus.Status("match_now"), MatchStatus.Status("team1"))
        lblWickets.Text = wicketCount



        Dim bno As String = (Val(MatchStatus.Status("inning")) * Val(MatchStatus.Status("overs_now")) * 6) - (Val(MatchStatus.Status("overs_now")) * 6)
        lblOvers.Text = OverFromBall(Val(ballno) - bno) & "(" & Val(ballno) - bno & ")"
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
    Private Sub btnBold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBold.Click
        CountRun(6, "1")
        ReloadMatchStatus()
    End Sub

    Private Sub btnRunOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRunOut.Click
        CountRun(6, "2")
        ReloadMatchStatus()
    End Sub

    Private Sub btnCatchOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCatchOut.Click
        CountRun(6, "3")
        ReloadMatchStatus()
    End Sub
    Sub CountRun(ByVal score As String, Optional ByVal wicket As String = "0")
        Dim ballno As String = MatchStatus.Status("ball_now")
        Dim nextBallNo As String = Val(MatchStatus.Status("ball_now")) + 1
        Dim ballType As String = getBallType()
        If (wicket <> "0") Then
            isWicket = True
        Else
            
        End If
        If (ballType <> "normal") Then
            score = Val(score) + 1
            nextBallNo = ballno
        End If

        Dim str As String = "insert into match_log(match_id,ball_no,ball_type,player_bat1,player_bat2,player_ball,score,wicket)" & _
            "VALUES (" + MatchStatus.Status("match_now") + "," + ballno + ",'" + ballType + "'," & _
            MatchStatus.Status("player_bat1") + "," + MatchStatus.Status("player_bat2") + "," + MatchStatus.Status("player_ball") & _
            "," + score + "," + wicket + ")"
        dbc.CountRun(str)
        If (wicket <> "0") Then
            isWicket = True
        Else
            If (score = "1" Or score = "3") Then
                Dim temp As String
                temp = MatchStatus.Status("player_bat1")
                MatchStatus.Status("player_bat1") = MatchStatus.Status("player_bat2")
                MatchStatus.Status("player_bat2") = temp
            End If
        End If
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

    Sub CountWicket(ByVal wicket_type As String)
        
    End Sub

    
End Class