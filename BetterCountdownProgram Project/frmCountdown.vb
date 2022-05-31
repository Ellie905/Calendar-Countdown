Imports System.DateTime

Public Class frmCountdown
    Dim DaysUntil As String
    Dim WeeksUnitl As String
    Dim EndDate As Date = My.Settings.strDate
    Dim StartDate As Date = DateString
    Private Sub frmCountdown_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Close()
        bgwUpdater.RunWorkerAsync()
        lblDate.Text = My.Settings.strDate
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        My.Settings.strDate = ""
        Form1.Show()
        Form1.Focus()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub bgwUpdater_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwUpdater.DoWork
        CheckForIllegalCrossThreadCalls = False
        Do
            lblDaysDate.Text = DateDiff(DateInterval.Day, StartDate, EndDate)
            If My.Settings.strDate.Replace("/", "-") = DateString Then
                MessageBox.Show("The date you set has been reached. The program will now close.", "Count Down")
                My.Settings.strDate = ""
                Me.Close()
            End If
            System.Threading.Thread.Sleep(10000)
        Loop
    End Sub
End Class