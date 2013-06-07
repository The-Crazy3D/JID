Public Class Writer
    Public Shared Sub Write(ByVal Text As String)
        Main.SFD.ShowDialog()
        If Not Main.SFD.FileName = "" Then
            Dim writer As New IO.StreamWriter(Main.SFD.FileName)
            writer.WriteLine(Text)
            writer.Close()
        End If
    End Sub
End Class
