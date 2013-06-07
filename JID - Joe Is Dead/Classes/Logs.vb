Module LogsWriter
    Private Delegate Sub LogsDelegate(ByVal Message As String, ByVal Color As Color)
    Public M As Main
    Private Sub AddMessage(ByVal Message As String, ByVal Color As Color)
        M.Logs.AppendText(Message & vbCrLf)
        M.Logs.SelectionStart = Main.Logs.Find(Message, RichTextBoxFinds.Reverse)
        M.Logs.SelectionColor = Color
        M.Logs.DeselectAll()
        M.Logs.ScrollToCaret()
    End Sub
    Public Sub Info(ByVal Message As String)
        M.Invoke(New LogsDelegate(AddressOf AddMessage), Message, Color.Green)
    End Sub
    Public Sub Note(ByVal Message As String)
        M.Invoke(New LogsDelegate(AddressOf AddMessage), Message, Color.Blue)
    End Sub
    Public Sub Erreur(ByVal Message As String)
        M.Invoke(New LogsDelegate(AddressOf AddMessage), Message, Color.Red)
    End Sub
End Module
