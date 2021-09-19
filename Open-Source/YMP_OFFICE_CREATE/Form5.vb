Public Class Form5
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then

            My.Settings.color_phone = ColorDialog1.Color


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        My.Settings.CPC = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        My.Settings.CPC = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        My.Settings.HelpButton = True
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        My.Settings.CPC2 = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        My.Settings.CPC2 = False
    End Sub

    Private Sub MetroToggle1_CheckedChanged(sender As Object, e As EventArgs) Handles MetroToggle1.CheckedChanged
        If MetroToggle1.Checked = True Then
            My.Settings.CPC = True
        Else
            My.Settings.CPC = False
        End If
    End Sub
End Class