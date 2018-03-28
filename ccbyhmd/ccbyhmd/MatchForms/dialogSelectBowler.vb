Public Class dialogSelectBowler
    Private ds As New DataSet()
    Private team_id As String
    Dim dbc As New DbConnection()
    Public Sub New(ByVal team_id As String)
        Me.team_id = team_id
        InitializeComponent()
    End Sub

    Private Sub dialogSelectBowler_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dbc.FillDs("select * from players where team_id=" + team_id + " and id not in(select TOP 1 player_ball from match_log order by id desc)", ds, "players")
        comboSelectBowler.DataSource = ds.Tables("players")
        comboSelectBowler.ValueMember = "id"
        comboSelectBowler.DisplayMember = "player_name"
    End Sub

    Private Sub btnSelectBowler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectBowler.Click
        MatchStatus.Status("player_ball") = comboSelectBowler.SelectedValue
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub
End Class