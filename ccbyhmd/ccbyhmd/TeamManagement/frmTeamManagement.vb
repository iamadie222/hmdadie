Imports System.Data.OleDb
Imports WindowsApplication1.DbConnection
Public Class frmTeamManagement
    Dim dsTeam As New DataSet()
    Dim dbc As New DbConnection()
    Dim daTeams As OleDbDataAdapter
    
    Private Sub GetTeamFromUser()
        Dim myNum As String
        Try
            myNum = InputBox("Please Enter Team Name: ")
            dbc.InsertIntoTeams(myNum)
            loadTeams()
        Catch e As Exception
            MsgBox(e.Message())
        End Try

    End Sub
    Private Sub loadTeams()
        Try
            dsTeam.Tables("teams").Clear()
        Catch ex As Exception

        End Try
        daTeams.Fill(dsTeam, "teams")
        dgvTeams.DataSource = dsTeam.Tables("teams")
        dgvTeams.ClearSelection()
        dgvTeams.Columns(1).MinimumWidth = 130
        dgvTeams.Columns(0).MinimumWidth = 50
        dgvTeams.Columns(0).Width = 50
        dgvTeams.Columns(1).HeaderText = "Team Name"
        dgvTeams.Columns(0).HeaderText = "No."

    End Sub
    Sub loadPlayers(ByVal team_id As String)
        Try
            dsTeam.Tables("players").Clear()
        Catch ex As Exception
        End Try
        dbc.FillDs("select * from players where team_id=" + team_id + " order by player_type desc", dsTeam, "players")
        dgvPlayers.DataSource = dsTeam.Tables("players")
        dgvPlayers.Columns(3).Visible = False
        dgvPlayers.Columns(0).Visible = False
        dgvPlayers.Columns(1).MinimumWidth = 250
        dgvPlayers.Columns(2).MinimumWidth = 220
        dgvPlayers.Columns(0).HeaderText = "ID"
        dgvPlayers.Columns(1).HeaderText = "Player Name"
        dgvPlayers.Columns(2).HeaderText = "Player Type"
        dgvPlayers.ClearSelection()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertTeam.Click
        GetTeamFromUser()
    End Sub
    Private Sub TeamManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        daTeams = dbc.RunSql("select id,team_name as TeamName from teams")
        loadTeams()
    End Sub
    Private Sub dgvTeams_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTeams.CellClick
        Try
            dgvTeams.Rows(e.RowIndex).Selected = True

            loadPlayers(dgvTeams.Rows(e.RowIndex).Cells("id").Value)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgvPlayers_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPlayers.CellClick
        Try
            sender.Rows(e.RowIndex).Selected = True
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TeamManagement_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        dgvTeams.ClearSelection()
        dgvTeams.Columns("TeamName").Width = 200
        dgvTeams.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvTeams.AllowUserToResizeRows = False
    End Sub

    Private Sub btnRemovePlayer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemovePlayer.Click
        If (dgvPlayers.SelectedRows.Count <> 1) Then
            MsgBox("Please Select Player")
            Return
        End If
        Dim rowNum = dgvPlayers.CurrentRow.Cells("id").Value
        Dim teamId = dgvPlayers.CurrentRow.Cells("team_id").Value
        Dim res As Integer = dbc.RemoveFromPlayers(rowNum)
        If (res = 1) Then
            loadPlayers(teamId)
        End If
    End Sub

    Private Sub btnRemoveTeam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveTeam.Click
        Try
            If (dgvTeams.SelectedRows.Count <= 0) Then
                MsgBox("Please Select Team To Remove")
                Return
            End If
            Dim rowNum = dgvTeams.CurrentRow.Cells("id").Value
            dbc.DeleteFromTeams(rowNum)
            loadTeams()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnInsertPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertPlayer.Click
        If (dgvTeams.SelectedRows.Count <> 1) Then
            MsgBox("Please Select One Team")
            Return
        End If
        If (dgvPlayers.Rows.Count >= 11) Then
            MsgBox("One Team Can only have 11 Players")
            Return
        End If
        Dim rowNum = dgvTeams.CurrentRow.Cells("id").Value
        Dim dialog As New dialogInsertPlayer(rowNum)
        If (dialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            loadPlayers(rowNum)
        End If

    End Sub

    Private Sub dgvPlayers_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvPlayers.RowsAdded
        For i As Integer = e.RowIndex To e.RowIndex + e.RowCount - 1
            dgvPlayers.Rows(i).Cells.Item("player_type").Value = CricketCounter.getPlayerTypeString(dgvPlayers.Rows(i).Cells.Item("player_type").Value)
        Next

    End Sub
    Private Sub btnEditPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPlayer.Click
        If (dgvPlayers.SelectedRows.Count <> 1) Then
            MsgBox("Please Select Player")
            Return
        End If
        Dim rowNum = dgvPlayers.CurrentRow.Cells("id").Value
        Dim dialog As New dialogEditPlayer(dgvPlayers.CurrentRow.Cells("team_id").Value, rowNum, dgvPlayers.CurrentRow.Cells("player_name").Value, dgvPlayers.CurrentRow.Cells("player_type").Value)
        If (dialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            loadPlayers(dgvPlayers.CurrentRow.Cells("team_id").Value)
        End If
    End Sub
End Class