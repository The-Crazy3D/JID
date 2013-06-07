Imports System.IO
Imports System.Net
Class PostIt
    Public Shared Function DataPost(ByRef data As String, ByRef url As String, Optional ByVal Test As Boolean = False) As String
        Try
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
            request.Method = "POST"
            request.ContentType = "application/x-www-form-urlencoded"
            Dim postData As String = data
            request.ContentLength = postData.Length
            Dim writer As New StreamWriter(request.GetRequestStream(), System.Text.Encoding.ASCII)
            writer.Write(postData)
            writer.Close()
            Dim stream As IO.Stream = request.GetResponse().GetResponseStream()
            Dim reader As New StreamReader(stream)
            Dim response As String = String.Empty
            Dim rd As String = reader.ReadToEnd
            If Test Then
                If rd.Contains("You have an error in your SQL syntax;") Then
                    Return True
                    Exit Function
                Else
                    Return False
                    Exit Function
                End If
            Else
                Return rd
                Exit Function
            End If
        Catch ex As Exception
            Return False
            Exit Function
        End Try
        Return True
    End Function
End Class

