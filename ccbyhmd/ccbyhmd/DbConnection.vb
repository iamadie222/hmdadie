Imports System.Data.OleDb
Public Class DbConnection
    Private conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\hamid\Documents\projeccts\hmdadie\ccbyhmd\ccbyhmdDb.accdb")
    Private cmd As New OleDbCommand()
    Private da As New OleDbDataAdapter(cmd)


    Sub New()
        cmd.Connection = conn
    End Sub

    Public Function RunSql(ByVal str As String) As OleDbDataAdapter
        Dim cmd2 As New OleDbCommand()
        cmd2.Connection = conn
        cmd2.CommandText = str
        Return New OleDbDataAdapter(cmd2)
    End Function
    Public Sub FillDs(ByVal str As String, ByRef ds As DataSet, ByVal tableName As String)
        cmd.Connection = conn
        cmd.CommandText = str
        da.SelectCommand = cmd
        da.Fill(ds, tableName)
    End Sub
    Public Sub InsertIntoTeams(ByVal teamName As String)
        conn.Open()
        cmd.CommandText = "insert into teams(team_name) values ('" + teamName + "')"
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Sub DeleteFromTeams(ByVal id As String)
        conn.Open()
        cmd.CommandText = "delete from teams where id = " + id
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Function InsertIntoPlayers(ByVal pName As String, ByVal pType As String, ByVal teamId As String)
        conn.Open()
        cmd.CommandText = "insert into players(player_name,player_type,team_id) values ('" + pName + "','" + pType + "'," + teamId + ")"
        Dim cnt = cmd.ExecuteNonQuery()
        conn.Close()
        Return cnt
    End Function

    Function RemoveFromPlayers(ByVal id As String) As Integer
        conn.Open()
        cmd.CommandText = "delete from players where id = " + id
        Dim cnt = cmd.ExecuteNonQuery()
        conn.Close()
        Return cnt
    End Function

    Function UpdatePlayers(ByVal id As String, ByVal pName As String, ByVal pType As String, ByVal teamId As String)
        conn.Open()
        cmd.CommandText = "update players set player_name='" + pName + "',player_type='" + pType + "',team_id=" + teamId + " where id=" + id
        Dim cnt = cmd.ExecuteNonQuery()
        conn.Close()
        Return cnt
    End Function


    Function InsertNewmatch(ByVal team1 As String, ByVal team2 As String, ByVal overs As String) As Integer
        conn.Open()
        cmd.CommandText = "insert into matchs (team1,team2,overs) values ('" + team1 + "','" + team2 + "'," + overs + ")"
        Dim cnt = cmd.ExecuteNonQuery()
        If (cnt = 1) Then
            cmd.CommandText = "select max(id) from matchs"
            Return cmd.ExecuteScalar()
        End If
        conn.Close()

        Return 0
    End Function

    Function GetPlayerName(ByVal id As String) As String
        conn.Open()
        cmd.CommandText = "select player_name from players where id=" + id
        Dim temp = cmd.ExecuteScalar()
        conn.Close()
        Return temp
    End Function
    Function GetTeamName(ByVal id As String) As String
        conn.Open()
        cmd.CommandText = "select team_name from teams where id=" + id
        Dim temp = cmd.ExecuteScalar()
        conn.Close()
        Return temp
    End Function


    Function execute(ByVal str As String) As Integer
        conn.Open()
        cmd.CommandText = str
        Dim cnt = cmd.ExecuteNonQuery()
        conn.Close()
        Return cnt
    End Function


    Function getRuns(ByVal match_id As String, ByVal team_id As String) As String
        conn.Open()

        cmd.CommandText = "select sum(score) from match_log where match_id=" + match_id
        'MsgBox("select sum(score) from match_log where match_id=" + match_id + " and team1=" + team_id)
        Try
            Dim temp As String = "0"
            temp = cmd.ExecuteScalar()
            Return temp
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Return "0"
    End Function
    Function getWicketCount(ByVal match_id As String, ByVal team_id As String) As String
        conn.Open()

        cmd.CommandText = "select count(wicket) from match_log where not wicket=0 and match_id=" + match_id
        Try
            Dim temp As String = "0"
            temp = cmd.ExecuteScalar()
            Return temp
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Return "0"
    End Function


    Function CountRun(ByVal queryStr As String) As Integer
        conn.Open()
        cmd.CommandText = queryStr
        Dim cnt = cmd.ExecuteNonQuery()
        conn.Close()
        Return cnt

    End Function


End Class
