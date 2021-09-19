Public Class Form4
    Private MouseLelfDown As Boolean = False
    Private MousePoint As Point
    Public _scale As Double
    Dim g As System.Drawing.Graphics
    Dim paintmode As Boolean = False
    Dim x As Integer
    Dim texture As Image
    Private Sub YMPPICTUREVIEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YMPPICTUREVIEWToolStripMenuItem.Click

    End Sub

    Private Sub ОткрытьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьToolStripMenuItem.Click
        Using ofd As OpenFileDialog = New OpenFileDialog

            With ofd
                .Filter = "Bitmap|*.bmp|Jpeg|*.jpg;*.jpeg|PNG|*.png|All Images|*.bmp;*.jpg;*.jpeg;*.png"
                .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
                .Multiselect = False
                .RestoreDirectory = True
                .ShowHelp = False
                .Title = "Background Image"
            End With

            If ofd.ShowDialog = DialogResult.OK Then
                Me.BackgroundImage = New Bitmap(ofd.FileName)
            End If

        End Using

    End Sub

    Private Sub ЗакрытьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗакрытьToolStripMenuItem.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Settings.color = BackColor.DarkRed
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        My.Settings.color = BackColor.OrangeRed
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        My.Settings.color = BackColor.PaleGoldenrod
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        My.Settings.color = BackColor.SaddleBrown
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        My.Settings.color = BackColor.IndianRed
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        My.Settings.color = BackColor.White
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Settings.color = BackColor.Black
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Settings.color = BackColor.LightBlue
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Settings.color = BackColor.LightGreen
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.color = BackColor.LightBlue
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            My.Settings.color = ColorDialog1.Color
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Form4_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            MouseLelfDown = True
            MousePoint = e.Location
        Else
            MouseLelfDown = False
        End If
    End Sub


    Private Sub Form4_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        MouseLelfDown = False
    End Sub

    Private Sub Form4_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If MouseLelfDown Then
            Dim g As Graphics = Graphics.FromHwnd(Me.Handle)
            g.DrawLine(New Pen(color:=My.Settings.color, My.Settings.wight), MousePoint, e.Location)
            MousePoint = e.Location
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        My.Settings.wight = TrackBar1.Value
    End Sub

    Private Sub ToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        MsgBox("Что-бы сохранить картинку - сделайте скриншот!")
    End Sub


    Private Sub Picturebox1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If paintmode = True Then
            g = System.Drawing.Graphics.FromImage(Me.BackgroundImage)
            g.DrawImage(texture, e.X * x, e.Y * x)
            Me.Refresh()

        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        MsgBox("1.Нажать ctrl+Shift+esc, чтобы вызвать системное приложение по созданию скриншотов
2.Выбрать область картинки
3.Сохранить")
    End Sub
End Class