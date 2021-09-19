Imports System.Drawing.Printing
Imports System.Reflection

Public Class Form3
    Private MouseLelfDown As Boolean = False
    Private MousePoint As Point
    Private Sub Form1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            MouseLelfDown = True
            MousePoint = e.Location
        Else
            MouseLelfDown = False
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        MouseLelfDown = False
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If MouseLelfDown Then
            Dim g As Graphics = Graphics.FromHwnd(Me.Handle)
            g.DrawLine(New Pen(color:=My.Settings.color, My.Settings.wight), MousePoint, e.Location)
            MousePoint = e.Location
        End If
    End Sub
    Private Sub ЖирныйШрифтToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЖирныйШрифтToolStripMenuItem.Click
        If FontDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.SelectionFont = FontDialog1.Font
        End If
    End Sub

    Private Sub ТаблицаToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MsgBox("Чтобы вставить таблицу в ваш документ - скопируйте таблицу, либо переместите файл с таблицой на документ.")
    End Sub

    Private Sub КартинкаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КартинкаToolStripMenuItem.Click
        MsgBox("Скопируйте картинку и вставьте её в ваш документ.")

    End Sub

    Private Sub СохранитьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СохранитьToolStripMenuItem.Click
        SaveFileDialog1.Filter = ".rtf | (.rtf | .doc | (.doc"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub СохранитьКакToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СохранитьКакToolStripMenuItem.Click
        SaveFileDialog1.Filter = ".rtf | (.rtf | .doc | (.doc"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName)
        End If
    End Sub


    Private Sub ПечатьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПечатьToolStripMenuItem.Click
        If PrintDialog1.ShowDialog() = DialogResult.OK Then

            Try
                Dim printdoc As New PrintDocument
                AddHandler printdoc.PrintPage, AddressOf Me.PrintText
                printdoc.Print()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub PrintText(ByVal sender As Object, ByVal ev As PrintPageEventArgs)


        Dim rect As New Rectangle(50, 75, 750, 1000)
        ev.Graphics.DrawString(RichTextBox1.Text, New Font("Courier New", 11, FontStyle.Regular), Brushes.Black, rect)
        ev.HasMorePages = False
    End Sub

    Private Sub ЗакрытьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗакрытьToolStripMenuItem.Click
        End
    End Sub

    Private Sub ДатаИВремяToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДатаИВремяToolStripMenuItem.Click
        RichTextBox1.Text += DateAndTime.Now
    End Sub

    Private Sub СимволToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СимволToolStripMenuItem.Click
        MsgBox("Сейчас будет запущена программа ""Таблица символов""")
        Process.Start("charmap.exe")
    End Sub

    Private Sub ВырезатьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВырезатьToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub ВставитьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВставитьToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub КопироватьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КопироватьToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub ЦветШрифтаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЦветШрифтаToolStripMenuItem.Click
        MsgBox("Вы также можете поменять цвет шрифта в ""Настройках шрифта""")
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.SelectionColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub YMPDOCUMENTCREATE10ПрограммаДляНаписанияДокументовYMPCOMPANYToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub YmpcogithubioYMPCOMPANYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YmpcogithubioYMPCOMPANYToolStripMenuItem.Click
        Process.Start("https://ymp-co.github.io/YMP_COMPANY")
    End Sub

    Private Sub ПоискToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПоискToolStripMenuItem.Click
        RichTextBox1.FindForm.ShowDialog()
    End Sub

    Private Sub ПоискИЗаменаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПоискИЗаменаToolStripMenuItem.Click
        RichTextBox1.FindForm.ShowDialog()
    End Sub

    Private Sub ОткрытьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьToolStripMenuItem.Click
        If OpenFileDialog2.ShowDialog = DialogResult.OK Then
            RichTextBox1.LoadFile(OpenFileDialog2.FileName)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
#Disable Warning BC42025 ' Доступ общего члена, члена константы, члена перечисления или вложенного типа с помощью экземпляра
        My.Settings.color = BackColor.Pink
#Enable Warning BC42025 ' Доступ общего члена, члена константы, члена перечисления или вложенного типа с помощью экземпляра

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
#Disable Warning BC42025 ' Доступ общего члена, члена константы, члена перечисления или вложенного типа с помощью экземпляра
        My.Settings.color = BackColor.Orange
#Enable Warning BC42025 ' Доступ общего члена, члена константы, члена перечисления или вложенного типа с помощью экземпляра

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
#Disable Warning BC42025 ' Доступ общего члена, члена константы, члена перечисления или вложенного типа с помощью экземпляра
        My.Settings.color = BackColor.Lime
#Enable Warning BC42025 ' Доступ общего члена, члена константы, члена перечисления или вложенного типа с помощью экземпляра
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
#Disable Warning BC42025 ' Доступ общего члена, члена константы, члена перечисления или вложенного типа с помощью экземпляра
        My.Settings.color = BackColor.Green
#Enable Warning BC42025 ' Доступ общего члена, члена константы, члена перечисления или вложенного типа с помощью экземпляра
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
#Disable Warning BC42025 ' Доступ общего члена, члена константы, члена перечисления или вложенного типа с помощью экземпляра
        My.Settings.color = BackColor.Blue
#Enable Warning BC42025 ' Доступ общего члена, члена константы, члена перечисления или вложенного типа с помощью экземпляра
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
#Disable Warning BC42025 ' Доступ общего члена, члена константы, члена перечисления или вложенного типа с помощью экземпляра
        My.Settings.color = BackColor.Purple
#Enable Warning BC42025 ' Доступ общего члена, члена константы, члена перечисления или вложенного типа с помощью экземпляра
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
#Disable Warning BC42025 ' Доступ общего члена, члена константы, члена перечисления или вложенного типа с помощью экземпляра
        My.Settings.color = BackColor.Purple
#Enable Warning BC42025 ' Доступ общего члена, члена константы, члена перечисления или вложенного типа с помощью экземпляра
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
#Disable Warning BC42025 ' Доступ общего члена, члена константы, члена перечисления или вложенного типа с помощью экземпляра
        My.Settings.color = BackColor.Pink
#Enable Warning BC42025 ' Доступ общего члена, члена константы, члена перечисления или вложенного типа с помощью экземпляра
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
#Disable Warning BC42025 ' Доступ общего члена, члена константы, члена перечисления или вложенного типа с помощью экземпляра
        My.Settings.color = BackColor.White
#Enable Warning BC42025 ' Доступ общего члена, члена константы, члена перечисления или вложенного типа с помощью экземпляра
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub YMPDOCUMENTCREATEПрограммаДляНаписанияПростыхДокументовВерсия10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YMPDOCUMENTCREATEПрограммаДляНаписанияПростыхДокументовВерсия10ToolStripMenuItem.Click

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) 
        Panel1.Hide()
    End Sub
End Class