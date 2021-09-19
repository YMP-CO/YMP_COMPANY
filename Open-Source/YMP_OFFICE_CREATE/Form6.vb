Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form3.ShowDialog()
    End Sub

    Private Sub YMPDOCUMENTCREATEПрограммаДляНаписанияПростыхДокументовВерсия10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YMPDOCUMENTCREATEПрограммаДляНаписанияПростыхДокументовВерсия10ToolStripMenuItem.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.BackColor = Color.Black
        RichTextBox1.ForeColor = Color.White
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ОткрытьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьToolStripMenuItem.Click
        If OpenFileDialog2.ShowDialog = DialogResult.OK Then
            RichTextBox1.LoadFile(OpenFileDialog2.FileName)
        End If
    End Sub

    Private Sub ЗакрытьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗакрытьToolStripMenuItem.Click
        End
    End Sub
End Class