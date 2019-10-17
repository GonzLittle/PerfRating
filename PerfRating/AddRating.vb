Imports System.Data.OleDb
Public Class AddRating
    Private Sub AddRating_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        Loadpicture()
        bunifutb1.Select()

    End Sub

#Region "Functions"
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
    'Public Sub Saverating()
    '    If bunifuddown1.selectedIndex = 0 Then
    '        MessageBox.Show("Jan to June")
    '    ElseIf bunifuddown1.selectedIndex = 1 Then
    '        MessageBox.Show("July to Dec")
    '    End If
    'End Sub
    Public Sub ValidateData()
        If bunifutb1.Text.Trim = "" Or TextBox1.Text.Trim = "" Or bunifutb4.Text.Trim = "" Then
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
    Private Sub bunifutb2_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        ValidateData()
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