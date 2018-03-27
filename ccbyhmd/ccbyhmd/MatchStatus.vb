Public Class MatchStatus
    Private Shared st As New Hashtable
    Shared fetched As Boolean
    Shared Sub init()
        Dim dbc As New DbConnection()
        Dim ds As New DataSet
        dbc.FillDs("select * from status", ds, "status")
        For i = 0 To ds.Tables("status").Rows.Count - 1

            st(ds.Tables("status").Rows(i)("status_name")) = ds.Tables("status").Rows(i)("status_value")
        Next
    End Sub

    Public Shared Sub update()
        Dim dbc As New DbConnection()
        Dim tempstr As String
        For i = 0 To st.Keys.Count - 1
            tempstr = "update status set status_value='" + st.Item(st.Keys(i)) + "' where status_name='" + st.Keys(i) + "'"
            dbc.execute(tempstr)
            'MsgBox("update status set status_value='" + st.Keys(i) + "' where status_name='" + st.Item(st.Keys(i)) + "'")
        Next

    End Sub



    Public Shared Property Status(ByVal nm As String) As String
        Get
            Return st.Item(nm)
        End Get
        Set(ByVal value As String)
            st.Item(nm) = value
        End Set
    End Property



    Public Shared Property NewProperty() As String
        Get
            Return ""
        End Get
        Set(ByVal value As String)

        End Set
    End Property

End Class
