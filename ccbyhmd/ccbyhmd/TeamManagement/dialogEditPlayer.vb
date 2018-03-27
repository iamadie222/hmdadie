Public Class dialogEditPlayer
    Dim currentTeam As String
    Dim playerName As String
    Dim playerType As String
    Dim playerId As String
    Dim dbc As New DbConnection()
    Public Sub New(ByVal teamId As String, ByVal playerId As String, ByVal playerName As String, ByVal playerType As String)
        currentTeam = teamId
        Me.playerName = playerName
        Me.playerId = playerId
        Me.playerType = playerType
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub dialogEditPlayer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbPlayerName.Text = playerName
        If (playerType = "Batsman") Then
            comboPlayerType.SelectedIndex = 0
        ElseIf (playerType = "Bowler") Then
            comboPlayerType.SelectedIndex = 1
        Else
            comboPlayerType.SelectedIndex = 2
        End If



    End Sub

    
    Private Sub btnEditPlayerUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPlayerUpdate.Click
        Dim playerName As String = tbPlayerName.Text
        Dim pt(2) As String
        pt(0) = "bat"
        pt(1) = "ball"
        pt(2) = "all"
        Dim playerType As String = pt(comboPlayerType.SelectedIndex)
        'MsgBox(currentTeam + " " + playerName + " " + playerType + " " + playerId)
        Dim res As Integer = dbc.UpdatePlayers(playerId, playerName, playerType, currentTeam)
        If (res = 1) Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub btnEditPlayerCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPlayerCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class