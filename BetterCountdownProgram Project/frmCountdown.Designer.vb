<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCountdown
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCountdown))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDaysDate = New System.Windows.Forms.Label()
        Me.bgwUpdater = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Days Until Selected Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Selected Date:"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(12, 99)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(102, 23)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "Select New Date"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 99)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDate.Location = New System.Drawing.Point(172, 21)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(100, 23)
        Me.lblDate.TabIndex = 5
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDaysDate
        '
        Me.lblDaysDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDaysDate.Location = New System.Drawing.Point(172, 58)
        Me.lblDaysDate.Name = "lblDaysDate"
        Me.lblDaysDate.Size = New System.Drawing.Size(100, 23)
        Me.lblDaysDate.TabIndex = 6
        Me.lblDaysDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bgwUpdater
        '
        '
        'frmCountdown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 134)
        Me.Controls.Add(Me.lblDaysDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCountdown"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Count Down"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblDaysDate As Label
    Friend WithEvents bgwUpdater As System.ComponentModel.BackgroundWorker
End Class
