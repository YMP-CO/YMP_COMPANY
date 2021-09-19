Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ReoGridControl1.CreateWorksheet(2)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ReoGridControl1.Undo()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ReoGridControl1.Redo()
    End Sub

    Private Sub ФайлToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ФайлToolStripMenuItem.Click

    End Sub

    Private Sub СохранитьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СохранитьToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog Then
            ReoGridControl1.Save(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub СохранитьКакToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СохранитьКакToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog Then
            ReoGridControl1.Save(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub ОткрытьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog Then
            ReoGridControl1.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub ЗакрытьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗакрытьToolStripMenuItem.Click
        End
    End Sub

    Private Sub ЖирныйШрифтToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If FontDialog1.ShowDialog = DialogResult.OK Then
            ReoGridControl1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub ЦветШрифтаToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If FontDialog1.ShowDialog = DialogResult.OK Then
            ReoGridControl1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub СимволToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СимволToolStripMenuItem.Click
        MsgBox("Сейчас будет запущена программа ""Таблица символов""")
        Process.Start("charmap.exe")
    End Sub


    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Hide()
    End Sub
End Class