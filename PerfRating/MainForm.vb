Imports System.Data.OleDb
Public Class MainForm
    'SHOW RECORD FOR LIVE SEARCH
    Public Sub showname()
        'Dim dba As New OleDbDataAdapter("Select full_name from PerfRating where pers_id Like '%" & _bunifutb1 & "%' order by Year asc", connString)
        '' pers_id='" & searchname & "' 
        'Dim DtSet As New DataSet
        'dba.Fill(DtSet)
        'bunifucd1.DataSource = DtSet.Tables(0).DefaultView
        'bunifucl1.Text = bunifucd1.CurrentRow.Cells(0).Value.ToString
        ''txtcount.Text = CType(bunifucd1.Rows.Count, String)
    End Sub
    Public Sub Showrecord()
        Try
            Dim _bunifutb1 As String = bunifutb1.Text.Trim
            If _bunifutb1 = "" Then
                MessageBox.Show("Invalid Argument")
            ElseIf _bunifutb1.Length < 4 Then
                MessageBox.Show("4 char minimum")
            Else
                'Dim dba As New OleDbDataAdapter("Select * from PerfRating where pers_id Like '%" & _bunifutb1 & "%' or full_name Like '%" & _bunifutb1 & "%' order by dbo_personal.full_name asc", Myconnection)

                Dim dba As New OleDbDataAdapter("Select * from PerfRating where pers_id Like '%" & _bunifutb1 & "%' order by Year asc", connString)
                ' pers_id='" & searchname & "' 
                Dim DtSet As New DataSet
                dba.Fill(DtSet)
                bunifucd1.DataSource = DtSet.Tables(0).DefaultView
                bunifucl1.Text = bunifucd1.CurrentRow.Cells(2).Value.ToString
                'txtcount.Text = CType(bunifucd1.Rows.Count, String)
            End If
            bunifucd1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            bunifucd1.AutoResizeColumns()
            For i = 0 To bunifucd1.Rows.Count - 1
                bunifucd1.Rows(i).Height = 30
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bunifutb1_KeyDown(sender As Object, e As KeyEventArgs) Handles bunifutb1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Showrecord()
            Loadpicture()
        End If
    End Sub
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

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        bunifutb1.Select()

    End Sub
End Class
