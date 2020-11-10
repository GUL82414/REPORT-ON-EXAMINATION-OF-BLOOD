Imports System.Data.OleDb

Public Class Form4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
            MsgBox("USER ID AND PASSWORD IS REQUERD")
        End If
        If TextBox1.Text = "GULSHAN" And TextBox2.Text = "12345" Then
            Form1.Show()
            Me.Hide()
        End If

        If TextBox1.Text = "ADMIN" And TextBox2.Text = "12345" Then
            Form1.Show()
            Me.Hide()




        End If

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class