Public Class Form1

    Dim flipflop As Boolean

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Calc()
    End Sub

    Public Sub Calc()

        Dim Rot As Integer = TrackBar1.Value
        Dim count As Integer = 1
        Dim curr As String
        Dim ch As Char
        Dim con As Integer


        TextBox2.Text = Nothing
        Label1.Text = Rot

        Do Until count = TextBox1.TextLength + 1

            curr = TextBox1.Text
            ch = curr(count - 1)
            con = Asc(ch)

            If CheckBox1.Checked = True Then
                ch = Chr(con - Rot)
            Else
                ch = Chr(con + Rot)
            End If

            TextBox2.Text += ch
            TextBox2.Text.Remove(count - 1)
            count = count + 1

        Loop


    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Calc()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Calc()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim temp As String = TextBox2.Text

        TextBox2.Text = TextBox1.Text
        TextBox1.Text = temp


    End Sub
End Class
