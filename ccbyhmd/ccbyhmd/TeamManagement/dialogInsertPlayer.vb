Public Class dialogInsertPlayer
    Dim dbc As New DbConnection()
    Dim currentTeam As String
    Public Sub New(ByVal teamId As String)
        currentTeam = teamId
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnDialogInsertPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDialogInsertPlayer.Click
        Dim playerName As String = tbPlayerName.Text
        Dim playerType As String = "bat"
        If (rbBwoler.Checked) Then
            playerType = "ball"
        ElseIf (rbAllRounder.Checked) Then
            playerType = "all"
        End If
        'MsgBox(currentTeam + " " + playerName + " " + playerType)
        If (String.IsNullOrEmpty(playerName)) Then
            MsgBox("Enter Player Name First")
            Return
        End If
        Dim res As Integer = dbc.InsertIntoPlayers(playerName, playerType, currentTeam)
        If (res = 1) Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub btnInsertPlayerCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertPlayerCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class