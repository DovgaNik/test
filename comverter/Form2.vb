Imports System.IO

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arr As String()
        arr = File.ReadAllLines("history.txt")

        For Each line In arr
            ListBox1.Items.Add(line)
        Next

    End Sub
End Class