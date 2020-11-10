Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Table1BindingSource.EndEdit()
        Table1TableAdapter.Update(DataSet3.Table1)

        MsgBox("Data hass been Saved")
SaveError:
        Exit Sub


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()

        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("MAA GAYATRI JANCH GHAR", New Font("Arial", 20, FontStyle.Bold), Brushes.Navy, New Point(230, 40))
        e.Graphics.DrawString(Label4.Text, New Font("Arial", 11, FontStyle.Bold), Brushes.Navy, New Point(230, 80))
        e.Graphics.DrawString(Label3.Text, New Font("Arial", 11, FontStyle.Bold), Brushes.Navy, New Point(230, 105))
        e.Graphics.DrawString(Label5.Text, New Font("Arial", 11, FontStyle.Bold), Brushes.Navy, New Point(30, 50))
        e.Graphics.DrawString(Label6.Text, New Font("Arial", 11, FontStyle.Bold), Brushes.Navy, New Point(30, 60))
        e.Graphics.DrawString(Label7.Text, New Font("Monotype Corsiva", 11, FontStyle.Bold), Brushes.Navy, New Point(20, 80))
        e.Graphics.DrawString("============", New Font("Arial", 11, FontStyle.Bold), Brushes.Navy, New Point(27, 65))



        e.Graphics.DrawString("" + Label2.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Navy, New Point(620, 15))

        e.Graphics.DrawString("Date :" + DateTime.Now, New Font("Arial", 12, FontStyle.Italic), Brushes.Black, New Point(630, 180))
        e.Graphics.DrawString("________________________________________________________________________________________________________________________________________________________", New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(0, 200))
        e.Graphics.DrawString(Label8.Text + "         " + TextBox1.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 230))
        e.Graphics.DrawString(Label9.Text + "         " + TextBox2.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(380, 230))
        e.Graphics.DrawString(Label10.Text + "         " + ComboBox2.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 260))
        e.Graphics.DrawString(Label15.Text + "         " + TextBox3.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(530, 230))
        e.Graphics.DrawString(Label12.Text + "   " + DateTimePicker1.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(530, 260))
        e.Graphics.DrawString(Label13.Text + "         " + ComboBox1.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(380, 290))
        e.Graphics.DrawString(Label11.Text + "         " + TextBox4.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 290))
        e.Graphics.DrawString(Label14.Text + "         " + TextBox5.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(185, 260))
        e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(0, 310))
        e.Graphics.DrawString("       " + "TEST NAME" + "                                                    " + "REFERENCE RANGE " + "                                        " + " RESULT ", New Font("Arial", 10, FontStyle.Bold), Brushes.Blue, New Point(35, 350))

        e.Graphics.DrawString("______________________________________________________________________________________________________________________________________________________", New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(0, 360))
        e.Graphics.DrawString("          " + Label19.Text + "                                                            " + Label20.Text + "                                                 " + TextBox6.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 390))
        e.Graphics.DrawString("          " + Label47.Text + "                                             " + Label22.Text + "                                                             " + TextBox7.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 420))
        e.Graphics.DrawString("          " + Label23.Text + "                                                   " + Label27.Text + "                                      " + TextBox8.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 450))
        e.Graphics.DrawString("          " + Label25.Text + "                                                           " + Label26.Text + "                                              " + TextBox9.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 480))

        e.Graphics.DrawString("          " + Label61.Text + "                                            " + Label60.Text + "                                                        " + TextBox25.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 510))
        e.Graphics.DrawString("          " + Label68.Text + "                                               " + Label57.Text + "                                                          " + TextBox24.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 540))
        e.Graphics.DrawString("          " + Label56.Text + "                                                " + Label53.Text + "                                                          " + TextBox23.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 570))
        e.Graphics.DrawString("          " + Label55.Text + "                                                      " + Label54.Text + "                                                             " + TextBox22.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 600))
        e.Graphics.DrawString("          " + Label52.Text + "                                                    " + Label59.Text + "                                                          " + TextBox26.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 630))
        e.Graphics.DrawString("          " + Label42.Text + "                                                        " + Label41.Text + "                                                        " + TextBox16.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 660))
        e.Graphics.DrawString("          " + Label43.Text + "                                                      " + Label44.Text + "                                                        " + TextBox17.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 690))




        e.Graphics.DrawString("          " + Label31.Text + "                                                  " + Label30.Text + "                                                 " + TextBox11.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 870))
        e.Graphics.DrawString("          " + Label33.Text + "                                                      " + Label32.Text + "                                                      " + TextBox12.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 930))
        e.Graphics.DrawString("          " + Label34.Text + "                                                      " + Label35.Text + "                                                      " + TextBox13.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 900))
        e.Graphics.DrawString("          " + Label36.Text + "                                                         " + Label37.Text + "                                                       " + TextBox14.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 955))
        e.Graphics.DrawString("          " + Label38.Text + "                                                  " + Label39.Text + "                                                     " + TextBox15.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 980))
        e.Graphics.DrawString("          " + Label70.Text + "                                                                                                                     " + ComboBox4.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 720))
        e.Graphics.DrawString("          " + Label71.Text + "                                                                                                                                    " + ComboBox3.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 750))
        e.Graphics.DrawString("          " + Label73.Text + "                                                                                                                          " + ComboBox5.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 780))

        e.Graphics.DrawString("          " + Label24.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Blue, New Point(35, 810))

        e.Graphics.DrawString("          " + "------------------------------------", New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 820))

        e.Graphics.DrawString("          " + Label28.Text + "                                                       " + Label29.Text + "                                                " + TextBox10.Text, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(35, 840))

        e.Graphics.DrawString("EXAMINER", New Font("Arial", 10, FontStyle.Bold), Brushes.Black, New Point(630, 1040))



        e.Graphics.DrawImage(PictureBox1.Image, 700, 50, 100, 70)






    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet3.Table1' table. You can move, or remove it, as needed.
        Table1TableAdapter.Fill(Me.DataSet3.Table1)

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Label59_Click(sender As Object, e As EventArgs) Handles Label59.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form2.Show()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Table1BindingSource.AddNew()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Try
            Table1BindingSource.RemoveCurrent()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Table1BindingSource.MoveNext()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Me.Table1BindingSource.MovePrevious()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Table1BindingSource.MoveNext()
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Table1BindingSource.MovePrevious()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
