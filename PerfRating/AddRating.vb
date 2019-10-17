Imports System.Data.OleDb
Public Class AddRating
    'Form On Load Task
    Private Sub AddRating_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        Loadpicture()
        bunifutb1.Select()
    End Sub
    'For CRUD and Validation Purposes
#Region "Functions"
    'Picture Load
    Public Sub Loadpicture()
        Try
            Dim idno As String = bunifutb1.Text.ToString
            Dim folder As String = "\\pmis_server\pictures"
            Dim filename As String = System.IO.Path.Combine(folder, idno & ".jpg")

            If Not System.IO.File.Exists(filename) Then
                ' file does not exist
                PictureBox1.Image = Nothing
            Else
                PictureBox1.Image = Image.FromFile(filename)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox1.Image = Image.FromFile(filename)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Catch ex As Exception
        End Try
    End Sub
    'Save Rating - Add Rating
    Public Sub Saverating()
        If bunifuddown1.SelectedIndex = 0 Then
            Try
                Myconnection = New OleDbConnection(connString)
                Dim InsertQuery As String
                If Myconnection.State = ConnectionState.Open Then
                    Myconnection.Close()
                Else
                    Myconnection.Open()
                    InsertQuery = ("insert into perfRating (pers_id, Name_emp, FirstRating, FirstRating_adj, Year) values (@t1, @t2, @t3, @t4, @t5)")
                    Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery, Myconnection)
                    cmd.Parameters.Add(New OleDbParameter("@t1", OleDbType.VarChar, 10, "pers_id"))
                    cmd.Parameters.Add(New OleDbParameter("@t2", OleDbType.VarChar, 100, "Name_emp"))
                    cmd.Parameters.Add(New OleDbParameter("@t3", OleDbType.VarChar, 10, "FirstRating"))
                    cmd.Parameters.Add(New OleDbParameter("@t4", OleDbType.VarChar, 50, "FirstRating_adj"))
                    cmd.Parameters.Add(New OleDbParameter("@t5", OleDbType.VarChar, 100, "Year"))


                    'cmd.Parameters("@t1").Value = txt1.Text.Trim
                    'cmd.Parameters("@t2").Value = txt2.Text.Trim
                    'cmd.Parameters("@t3").Value = Txt3.Text.Trim
                    'cmd.Parameters("@t4").Value = txt4.Text.Trim
                    'cmd.Parameters("@t5").Value = txt5.Text.Trim

                    cmd.ExecuteReader()
                    MessageBox.Show(Me, vbCrLf & "Record Saved." & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2017)", "Human Resource Information System", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    Me.Close()
                    'Report.Show()

                End If
                Myconnection.Close()
            Catch ex As Exception
                messagebox.Show(Me, vbCrLf & "Error inserting record!" & vbCrLf & vbCrLf & vbCrLf & "©(PGLU-HRMD Series of 2017)", "Human Resource Information System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'MsgBox(ex.Message)
            End Try
        ElseIf bunifuddown1.SelectedIndex = 1 Then

        End If
    End Sub
    'Check Fields if empty
    Public Sub ValidateData()
        If bunifutb1.Text.Trim = "" Or TextBox1.Text.Trim = "" Or bunifuddown1.Text.Trim = "" Or bunifutb4.Text.Trim = "" Then
            CustomDialog.Messagebtn.Text = "All fields must be provided!"
            CustomDialog.ShowDialog()
        End If
    End Sub

#End Region
    'For Textboxes alone
#Region "Bunifu Textboxes"
    Private Sub bunifuddown1_onItemSelected(sender As Object, e As EventArgs)
        'Saverating()
    End Sub
    Private Sub bunifutb1_KeyDown(sender As Object, e As KeyEventArgs) Handles bunifutb1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Loadpicture()
        End If
    End Sub
    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        ValidateData()
        Saverating()
    End Sub
    Private Sub TextBox1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TextBox1.PreviewKeyDown
        If e.KeyCode = Keys.Tab Then
            Try
                Dim _rate As String = TextBox1.Text.Trim
                If _rate <= 1.99 And _rate >= 0 Then
                    bunifuddown2.Text = "Poor"
                ElseIf _rate <= 2.99 And _rate >= 2 Then
                    bunifuddown2.Text = "Unsatisfactory"
                ElseIf _rate <= 3.99 And _rate >= 3 Then
                    bunifuddown2.Text = "Satisfactory"
                ElseIf _rate <= 4.99 And _rate >= 4 Then
                    bunifuddown2.Text = "Very Satisfactory"
                ElseIf _rate = 5 Then
                    bunifuddown2.Text = "Outstanding"
                Else
                    CustomDialog.Messagebtn.Text = ("Not in Range!")
                    CustomDialog.ShowDialog()
                    CustomDialog.BunifuFlatButton1.Select()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
#End Region
End Class