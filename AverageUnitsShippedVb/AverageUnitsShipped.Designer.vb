<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAverageUnitsShipped
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblWeekAverage = New System.Windows.Forms.Label()
        Me.lstWeekUnits = New System.Windows.Forms.ListBox()
        Me.lblDayDisplay = New System.Windows.Forms.Label()
        Me.tbUnitsEntered = New System.Windows.Forms.TextBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(283, 315)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "this button ends the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(189, 315)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "this button resets variables in its default variables")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(89, 315)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "&Enter"
        Me.ToolTip1.SetToolTip(Me.btnEnter, "This button Stores the units entered in the textbox")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblWeekAverage
        '
        Me.lblWeekAverage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblWeekAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeekAverage.Location = New System.Drawing.Point(89, 262)
        Me.lblWeekAverage.Name = "lblWeekAverage"
        Me.lblWeekAverage.Size = New System.Drawing.Size(257, 23)
        Me.lblWeekAverage.TabIndex = 4
        Me.lblWeekAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblWeekAverage, "displays the average of the units entered in a week")
        '
        'lstWeekUnits
        '
        Me.lstWeekUnits.FormattingEnabled = True
        Me.lstWeekUnits.ItemHeight = 16
        Me.lstWeekUnits.Location = New System.Drawing.Point(89, 80)
        Me.lstWeekUnits.Name = "lstWeekUnits"
        Me.lstWeekUnits.Size = New System.Drawing.Size(257, 164)
        Me.lstWeekUnits.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.lstWeekUnits, "displays the history of units entered")
        '
        'lblDayDisplay
        '
        Me.lblDayDisplay.AutoSize = True
        Me.lblDayDisplay.Location = New System.Drawing.Point(291, 46)
        Me.lblDayDisplay.Name = "lblDayDisplay"
        Me.lblDayDisplay.Size = New System.Drawing.Size(45, 17)
        Me.lblDayDisplay.TabIndex = 2
        Me.lblDayDisplay.Text = "&Day 1"
        Me.lblDayDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbUnitsEntered
        '
        Me.tbUnitsEntered.Location = New System.Drawing.Point(164, 46)
        Me.tbUnitsEntered.Name = "tbUnitsEntered"
        Me.tbUnitsEntered.Size = New System.Drawing.Size(100, 22)
        Me.tbUnitsEntered.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.tbUnitsEntered, "textbox to input units for the designated day")
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(105, 46)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(44, 17)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "&Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(444, 405)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblWeekAverage)
        Me.Controls.Add(Me.lstWeekUnits)
        Me.Controls.Add(Me.lblDayDisplay)
        Me.Controls.Add(Me.tbUnitsEntered)
        Me.Controls.Add(Me.lblUnits)
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnExit As Button
    Private WithEvents btnReset As Button
    Private WithEvents btnEnter As Button
    Private WithEvents lblWeekAverage As Label
    Private WithEvents lstWeekUnits As ListBox
    Private WithEvents lblDayDisplay As Label
    Private WithEvents tbUnitsEntered As TextBox
    Private WithEvents lblUnits As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
