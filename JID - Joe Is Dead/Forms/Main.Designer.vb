<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SiteUrl = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Logs = New System.Windows.Forms.RichTextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RecupAdminOnly = New System.Windows.Forms.CheckBox()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.tStop = New JID___Joe_Is_Dead.GButton()
        Me.GButton3 = New JID___Joe_Is_Dead.GButton()
        Me.GButton2 = New JID___Joe_Is_Dead.GButton()
        Me.GButton1 = New JID___Joe_Is_Dead.GButton()
        Me.FutureTheme1 = New JID___Joe_Is_Dead.FutureTheme()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Location = New System.Drawing.Point(0, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(818, 561)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'SiteUrl
        '
        Me.SiteUrl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SiteUrl.Location = New System.Drawing.Point(179, 312)
        Me.SiteUrl.Name = "SiteUrl"
        Me.SiteUrl.Size = New System.Drawing.Size(383, 13)
        Me.SiteUrl.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(565, 305)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 28)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Logs
        '
        Me.Logs.Location = New System.Drawing.Point(3, 6)
        Me.Logs.Name = "Logs"
        Me.Logs.Size = New System.Drawing.Size(442, 211)
        Me.Logs.TabIndex = 4
        Me.Logs.Text = ""
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(176, 339)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(459, 249)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.Logs)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(451, 223)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Logs"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RecupAdminOnly)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(451, 223)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Options"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RecupAdminOnly
        '
        Me.RecupAdminOnly.AutoSize = True
        Me.RecupAdminOnly.Location = New System.Drawing.Point(6, 18)
        Me.RecupAdminOnly.Name = "RecupAdminOnly"
        Me.RecupAdminOnly.Size = New System.Drawing.Size(226, 17)
        Me.RecupAdminOnly.TabIndex = 0
        Me.RecupAdminOnly.Text = "Récupérer Uniquement les comptes admin"
        Me.RecupAdminOnly.UseVisualStyleBackColor = True
        '
        'SFD
        '
        Me.SFD.Filter = "Fichier Log JID|*.txt"
        Me.SFD.Title = "Enregistrer les Logs - JID"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Location = New System.Drawing.Point(605, 301)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'tStop
        '
        Me.tStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.tStop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.tStop.Image = Nothing
        Me.tStop.Location = New System.Drawing.Point(353, 339)
        Me.tStop.Name = "tStop"
        Me.tStop.Size = New System.Drawing.Size(75, 23)
        Me.tStop.TabIndex = 9
        Me.tStop.Text = "Arrêter"
        Me.tStop.Visible = False
        '
        'GButton3
        '
        Me.GButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.GButton3.Image = Nothing
        Me.GButton3.Location = New System.Drawing.Point(560, 339)
        Me.GButton3.Name = "GButton3"
        Me.GButton3.Size = New System.Drawing.Size(75, 23)
        Me.GButton3.TabIndex = 7
        Me.GButton3.Text = "Vider les logs"
        '
        'GButton2
        '
        Me.GButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.GButton2.Image = Nothing
        Me.GButton2.Location = New System.Drawing.Point(427, 339)
        Me.GButton2.Name = "GButton2"
        Me.GButton2.Size = New System.Drawing.Size(134, 23)
        Me.GButton2.TabIndex = 5
        Me.GButton2.Text = "Enregistrer les comptes"
        '
        'GButton1
        '
        Me.GButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GButton1.ForeColor = System.Drawing.Color.Maroon
        Me.GButton1.Image = Nothing
        Me.GButton1.Location = New System.Drawing.Point(792, 0)
        Me.GButton1.Name = "GButton1"
        Me.GButton1.Size = New System.Drawing.Size(26, 22)
        Me.GButton1.TabIndex = 6
        Me.GButton1.Text = "X"
        '
        'FutureTheme1
        '
        Me.FutureTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FutureTheme1.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold)
        Me.FutureTheme1.Location = New System.Drawing.Point(0, 0)
        Me.FutureTheme1.Name = "FutureTheme1"
        Me.FutureTheme1.Size = New System.Drawing.Size(818, 600)
        Me.FutureTheme1.TabIndex = 0
        Me.FutureTheme1.Text = "JID - Joe Is Dead | By Soka & The UnKnØwN"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 600)
        Me.Controls.Add(Me.tStop)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.GButton3)
        Me.Controls.Add(Me.GButton2)
        Me.Controls.Add(Me.GButton1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.SiteUrl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FutureTheme1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JID - Joe Is Dead | By Soka & The UnKnØwN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FutureTheme1 As JID___Joe_Is_Dead.FutureTheme
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SiteUrl As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Logs As System.Windows.Forms.RichTextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents RecupAdminOnly As System.Windows.Forms.CheckBox
    Friend WithEvents GButton1 As JID___Joe_Is_Dead.GButton
    Friend WithEvents GButton2 As JID___Joe_Is_Dead.GButton
    Friend WithEvents GButton3 As JID___Joe_Is_Dead.GButton
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents tStop As JID___Joe_Is_Dead.GButton

End Class
