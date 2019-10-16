Imports System.Data.OleDb
Module dbcon

    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\PerfRating\PerfRatingdb.accdb;"
    Public Myconnection As OleDbConnection
    Public dbda As OleDbDataAdapter
    Public dbds As DataSet
    Public tables As DataTableCollection
    Public source As New BindingSource
    Public command As OleDbCommand
    Public reader As OleDbDataReader
    Public result As Integer
    Public query As String

End Module
