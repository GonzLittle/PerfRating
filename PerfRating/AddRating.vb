Imports System.Data.OleDb
Public Class AddRating
    'Form On Load Task
    Private Sub AddRating_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        Loadpicture()
        bunifutb1.Select()
        Rbtn1.Checked = True
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
        If Rbtn1.Checked = True Then
            Try
                Myconnection = New OleDbConnection(connString)
                Dim InsertQuery As String
                If Myconnection.State = ConnectionState.Open Then
                    Myconnection.Close()
                Else
                    Myconnection.Open()
                    InsertQuery = ("insert into PerfRating ([pers_id], [FirstRating], [FirstRating_adj], [Year]) values (@t1, @t2, @t3, @t4)")
                    Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery, Myconnection)
                    cmd.Parameters.Add(New OleDbParameter("@t1", OleDbType.VarChar, 10, "pers_id"))
                    cmd.Parameters.Add(New OleDbParameter("@t2", OleDbType.VarChar, 10, "FirstRating"))
                    cmd.Parameters.Add(New OleDbParameter("@t3", OleDbType.VarChar, 20, "FirstRating_adj"))
                    cmd.Parameters.Add(New OleDbParameter("@t4", OleDbType.VarChar, 10, "Year"))

                    cmd.Parameters("@t1").Value = bunifutb1.Text.Trim
                    cmd.Parameters("@t2").Value = bunifutb2.Text.Trim
                    cmd.Parameters("@t3").Value = bunifutb3.Text.Trim
                    cmd.Parameters("@t4").Value = bunifutb4.Text.Trim

                    cmd.ExecuteReader()
                    CustomDialog.Messagebtn.Text = "First Semester Rating Saved."
                    CustomDialog.ShowDialog()

                End If
                Myconnection.Close()
            Catch ex As Exception
                CustomDialog.Messagebtn.Text = "Error inserting record."
                CustomDialog.ShowDialog()
            End Try
        ElseIf Rbtn2.Checked = True Then
            Try
                Myconnection = New OleDbConnection(connString)
                Dim InsertQuery As String
                If Myconnection.State = ConnectionState.Open Then
                    Myconnection.Close()
                Else
                    Myconnection.Open()
                    InsertQuery = ("insert into PerfRating ([pers_id], [SecondRating], [SecondRating_adj], [Year]) values (@t1, @t2, @t3, @t4)")
                    Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery, Myconnection)
                    cmd.Parameters.Add(New OleDbParameter("@t1", OleDbType.VarChar, 10, "pers_id"))
                    cmd.Parameters.Add(New OleDbParameter("@t2", OleDbType.VarChar, 10, "SecondRating"))
                    cmd.Parameters.Add(New OleDbParameter("@t3", OleDbType.VarChar, 20, "SecondRating_adj"))
                    cmd.Parameters.Add(New OleDbParameter("@t4", OleDbType.VarChar, 10, "Year"))

                    cmd.Parameters("@t1").Value = bunifutb1.Text.Trim
                    cmd.Parameters("@t2").Value = bunifutb2.Text.Trim
                    cmd.Parameters("@t3").Value = bunifutb3.Text.Trim
                    cmd.Parameters("@t4").Value = bunifutb4.Text.Trim

                    cmd.ExecuteReader()
                    CustomDialog.Messagebtn.Text = "Second Semester Rating Saved."
                    CustomDialog.ShowDialog()
                End If
                Myconnection.Close()
            Catch ex As Exception
                CustomDialog.Messagebtn.Text = "Error inserting record."
                CustomDialog.ShowDialog()
                MsgBox(ex.Message)
            End Try
        Else
            CustomDialog.Messagebtn.Text = ("Select Semester.")
            CustomDialog.ShowDialog()
        End If
    End Sub
    'Check Fields if empty
    Public Sub ValidateData()
        If bunifutb1.Text.Trim = "" Or bunifutb2.Text.Trim = "" Or bunifutb4.Text.Trim = "" Then
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
        MainForm.Showrecord()
    End Sub
    Private Sub TextBox1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles bunifutb2.PreviewKeyDown
        If e.KeyCode = Keys.Tab Then
            Try
                Dim _rate As String = bunifutb2.Text.Trim
                If _rate <= 1.99 And _rate >= 0 Then
                    bunifutb3.Text = "Poor"
                ElseIf _rate <= 2.99 And _rate >= 2 Then
                    bunifutb3.Text = "Unsatisfactory"
                ElseIf _rate <= 3.99 And _rate >= 3 Then
                    bunifutb3.Text = "Satisfactory"
                ElseIf _rate <= 4.99 And _rate >= 4 Then
                    bunifutb3.Text = "Very Satisfactory"
                ElseIf _rate = 5 Then
                    bunifutb3.Text = "Outstanding"
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