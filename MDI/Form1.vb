Public Class Form1
    Inherits System.Windows.Forms.Form
    Private Counter As Integer = 1

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Timer1.Enabled = True
        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As MenuItem
    Friend WithEvents MenuItem6 As MenuItem
    Friend WithEvents MenuItem7 As MenuItem
    Friend WithEvents MenuItem8 As MenuItem
    Friend WithEvents MenuItem9 As MenuItem
    Friend WithEvents MenuItem10 As MenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem8, Me.MenuItem6, Me.MenuItem7})
        Me.MenuItem1.Text = "Файл"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.Text = "Новый"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 1
        Me.MenuItem8.Text = "Редактировать"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 2
        Me.MenuItem6.Text = "Закрыть"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 3
        Me.MenuItem7.Text = "Выйти"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem9, Me.MenuItem10})
        Me.MenuItem2.Text = "Окна"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.MergeType = System.Windows.Forms.MenuMerge.Replace
        Me.MenuItem3.Text = "Отобразить выделенный текст"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.MdiList = True
        Me.MenuItem4.Text = "Список окон"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 0
        Me.MenuItem9.Text = "Свернуть все"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 1
        Me.MenuItem10.Text = "Развернуть все"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 372)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(629, 26)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(629, 398)
        Me.Controls.Add(Me.StatusStrip1)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDI-приложение "
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim ас As Form2 = ActiveMdiChild
        If ас IsNot Nothing Then
            MenuItem6.Enabled = True
            MenuItem8.Enabled = True
        End If
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click

    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Dim ас As Form2 = ActiveMdiChild
        If Not ас Is Nothing Then MsgBox(ас.TextBox1.SelectedText)
    End Sub



    Private Sub MenuItem5_Click_1(sender As Object, e As EventArgs) Handles MenuItem5.Click
        Dim NewMdiChild As Form2 = New Form2
        NewMdiChild.Text = "Окно " + Counter.ToString
        Counter = Counter + 1
        NewMdiChild.MdiParent = Me
        NewMdiChild.Visible = True
        MenuItem6.Enabled = True
        MenuItem8.Enabled = True
    End Sub

    Private Sub MenuItem7_Click(sender As Object, e As EventArgs) Handles MenuItem7.Click
        Me.Close()
    End Sub

    Private Sub MenuItem6_Click(sender As Object, e As EventArgs) Handles MenuItem6.Click
        Dim ас As Form2 = ActiveMdiChild
        If ас IsNot Nothing Then ас.Close()

        Dim ас1 As Form2 = ActiveMdiChild
        If ас1 Is Nothing Then
            MenuItem6.Enabled = False
            MenuItem8.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuItem6.Enabled = False
        MenuItem8.Enabled = False
        'ToolStripStatusLabel1.Text = Convert.ToString(Date.Now)
    End Sub

    Private Sub MenuItem8_Click(sender As Object, e As EventArgs) Handles MenuItem8.Click
        Dim ас As Form2 = ActiveMdiChild
        If ас IsNot Nothing Then
            ас.Text = InputBox("Старое имя окна: " & ас.Text, "Введите новое имя", "Новое имя для окна")
        End If
    End Sub

    Private Sub MenuItem9_Click(sender As Object, e As EventArgs) Handles MenuItem9.Click
        Dim i As Integer
        For i = 0 To UBound(MdiChildren)
            MdiChildren(i).WindowState = FormWindowState.Minimized
        Next i
    End Sub

    Private Sub MenuItem10_Click(sender As Object, e As EventArgs) Handles MenuItem10.Click
        Dim i As Integer
        For i = 0 To UBound(MdiChildren)
            MdiChildren(i).WindowState = FormWindowState.Normal
        Next i
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = Date.Now.ToString("MM.dd.yyyy, HH.mm.ss")
    End Sub
End Class
