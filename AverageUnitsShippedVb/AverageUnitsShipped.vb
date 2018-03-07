'/****************************** Module Header ******************************\
'Module Name : AverageUnitsShipped.vb
'Project: Lab 1 average units shipped
'Copyright (c) Kevin Astilla
'Date Modified: January , 2018

'the program is created to store a weeks worth of history in an array then
'is later used to calculate the average units in the week
'it consists of buttons that will calculate, reset and exit the program

'THIS CODE And INFORMATION Is PROVIDED "AS IS" WITHOUT WARRANTY Of ANY KIND,
'EITHER EXPRESSED Or IMPLIED, INCLUDING BUT Not LIMITED To THE IMPLIED
'WARRANTIES OF MERCHANTABILITY And/Or FITNESS FOR A PARTICULAR PURPOSE.
'\*****************************************************************

Option Strict On
Public Class frmAverageUnitsShipped
    Private Const daysInAWeek As Integer = 7
    Dim unitPerDay(6) As Integer
    Dim unitAverage As Double
    Dim day As Integer = 1


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'the method closes the form
        Close()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'everytime we call the button we create a variable where we will
        'temporarily assign the input after the validation
        Dim unitEntered As Integer


        If (tbUnitsEntered.Text Is Nothing) Then
            MessageBox.Show("Please enter number of units.")
        ElseIf (Not Integer.TryParse(tbUnitsEntered.Text, unitEntered)) Then
            MessageBox.Show("Units Cannot be stored as fraction.")
        ElseIf (unitEntered < 0 Or unitEntered > 1000) Then
            MessageBox.Show("Units stored can only be between 0 to 1000.")
        Else
            'the value then is assigned to an array and is added as an item
            'in the lisbox lstWeekUnits
            unitPerDay(day - 1) = unitEntered
            lstWeekUnits.Items.Add(unitEntered)

            'the textbox is then cleared for the next input and is focused
            tbUnitsEntered.ResetText()
            tbUnitsEntered.Focus()


            day += 1

        End If
        tbUnitsEntered.Focus()



        'if our counter "day" is greater than 7 then we've hit the one week
        'and we move forward with the calculation, if not then we increment by 1
        'we also disable the textbox to prevent further inputs

        If (day > daysInAWeek) Then
            tbUnitsEntered.Enabled = False
            btnEnter.Enabled = True

            For index As Integer = 0 To 6
                unitAverage += unitPerDay(index) / unitPerDay.Length()
            Next


            lblWeekAverage.Text = "Average per day: " + unitAverage.ToString("N2")
        Else
            lblDayDisplay.Text = "Day" + day.ToString
        End If

        'we update the lblDayDisplay with the day we would like to store in our array


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'reassign starting variables to both day and unit per day array
        day = 1
        Array.Clear(unitPerDay, 0, 6)
        'restart the labels and listbox
        tbUnitsEntered.Text = ""
        lblDayDisplay.Text = "Day" + day.ToString
        lblWeekAverage.ResetText()
        lstWeekUnits.Items.Clear()
        'enable the textbox and focus on it
        tbUnitsEntered.Enabled = True
        tbUnitsEntered.Focus()
        btnEnter.Enabled = True
    End Sub
End Class
