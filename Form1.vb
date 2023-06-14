Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Button1_Click(ByVal sender As Object, e As EventArgs) HandleButton1.Click
        Dim user As String = txtid.Text
        Dim password As String = txtpassword.Text



    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            txtpassword.UseSystemPasswordChar = False
        Else
            CheckBox1.Checked = True
            txtpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

End Class
