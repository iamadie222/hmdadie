Public Class CricketCounter
    Public Shared Function PlayerTypeList() As ArrayList
        Dim typeList As New ArrayList()
        typeList.Add(New PlayerType("bat", "Batsman"))
        typeList.Add(New PlayerType("ball", "Bowler"))
        typeList.Add(New PlayerType("all", "All Rounder"))
        Return typeList
    End Function
    Public Shared Function getPlayerTypeString(ByVal str As String) As String
        If (str = "bat") Then
            Return "Batsman"
        ElseIf (str = "ball") Then
            Return "Bowler"
        Else
            Return "All Rounder"
        End If
        Return 0
    End Function
    Public Shared Function getPlayerStringType(ByVal str As String) As String
        If (str = "Batsman") Then
            Return "bat"
        ElseIf (str = "Bowler") Then
            Return "ball"
        Else
            Return "all"
        End If
        Return 0
    End Function

End Class
Class PlayerType
    Public typeText As String
    Public typeLabel As String
    Sub New(ByVal t As String, ByVal l As String)
        typeText = t
        typeLabel = l
    End Sub
End Class