Imports System.DateTime

Public Class Form1

    'Dim substring() = DateString.Split("-")
    'Dim StringMonth = substring(0)
    'Dim StringDay = substring(1)

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        MessageBox.Show("Date not saved. Exiting", "")
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calDate.MinDate = DateString
        If Not My.Settings.strDate = "" Then
            frmCountdown.Show()
            frmCountdown.Focus()
            Me.Close()
        End If
    End Sub

    Private Sub calDate_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calDate.DateChanged
        calDate.SelectionEnd = calDate.SelectionStart
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        My.Settings.strDate = calDate.SelectionStart
        frmCountdown.Show()
        frmCountdown.Focus()
        Me.Close()
        My.Settings.Save()
    End Sub
End Class
