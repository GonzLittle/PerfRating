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
    Public Sub Saverating()
        If bunifuddown1.selectedIndex = 0 Then
            MessageBox.Show("Jan to June")
        ElseIf bunifuddown1.selectedIndex = 1 Then
            MessageBox.Show("July to Dec")
        End If
    End Sub
    Public Sub ValidateData()
        If bunifutb1.Text.Trim = "" Or bunifutb2.Text.Trim = "" Or bunifutb3.Text.Trim = "" Or bunifutb4.Text.Trim = "" Then
            CustomDialog.ShowDialog()
        End If
    End Sub
#End Region
    'For Textboxes alone
#Region "Bunifu Textboxes"
    Private Sub bunifuddown1_onItemSelected(sender As Object, e As EventArgs) Handles bunifuddown1.onItemSelected
        Saverating()
    End Sub
    Private Sub bunifutb1_KeyDown(sender As Object, e As KeyEventArgs) Handles bunifutb1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Loadpicture()
        End If
    End Sub
    Private Sub bunifutb2_KeyDown(sender As Object, e As KeyEventArgs) Handles bunifutb2.KeyDown
        Try
            Dim _rate As Integer = bunifutb2.Text.Trim
            If _rate < 2 And _rate >= 0 Then
                bunifutb3.Text = "Poor"
            ElseIf _rate < 3 And _rate >= 2 Then
                bunifutb3.Text = "Unsatisfactory"
            ElseIf _rate < 4 And _rate >= 3 Then
                bunifutb3.Text = "Satisfactory"
            ElseIf _rate < 5 And _rate >= 4 Then
                bunifutb3.Text = "Very Satisfactory"
            ElseIf _rate = 5 Then
                bunifutb3.Text = "Outstanding"
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        ValidateData()
    End Sub
#End Region
End Class