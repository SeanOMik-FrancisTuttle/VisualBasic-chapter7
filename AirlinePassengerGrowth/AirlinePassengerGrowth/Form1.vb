' Program Name: Airlines Passenger Growth
' Author:       Sean Ervin
' Date:         9/12/2019
' Purpose:      Computes the next ten years of passengers that will fly on planes, or a 
'               specified year given by the user.

Public Class Form1
    ' This was the amount of passengers in the year 2017.
    Dim int2017Passengers As Long = 3800000000
    ' This was the calculated yearly growth.
    Dim decYearlyGrowth As Decimal = 0.069

    Private Sub BtnGrowth_Click(sender As Object, e As EventArgs) Handles btnGrowth.Click
        ' This executes a sub procedure to get the next ten years passengers and puts it to the list.
        GetTenYearGrowth()
    End Sub

    Private Sub GetTenYearGrowth()
        ' This gets the next ten years growth and inputs it to the list.

        lstGrowth.Items.Clear()
        Dim intLastYearPass As Long = int2017Passengers
        For i As Integer = 1 To 10
            intLastYearPass += intLastYearPass * decYearlyGrowth
            lstGrowth.Items.Add("Year " & i & ": " & intLastYearPass.ToString())
        Next
    End Sub


    Private Sub BtnYear_Click(sender As Object, e As EventArgs) Handles btnYear.Click
        ' This validates the years text and if its valid, then it shows the inputed year's passgener count.
        If ValidiateYearText() Then
            GetYearGrowth()
        End If
    End Sub

    Private Sub GetYearGrowth()
        ' This gets a specific years amount of passengers.
        Dim intLastYearPass As Long = int2017Passengers
        For i As Integer = 1 To Convert.ToInt32(mtxtYear.Text)
            intLastYearPass += intLastYearPass * decYearlyGrowth
        Next

        ' Display the text
        lblYear.Text = "Year " & Convert.ToInt32(mtxtYear.Text) & ": " & intLastYearPass.ToString()
    End Sub

    Private Function ValidiateYearText() As Boolean
        ' This validiates the text to make sure it is a number and is in the next 10 years.
        Try
            Dim intYear As Integer = Convert.ToInt32(mtxtYear.Text)
            ' Check if in the next 10 years
            If (intYear > 0 And intYear <= 10) Then
                Return True
            Else
                MsgBox("Enter a number for a year in the next 10 years", , "Error")
                Return False
            End If
        Catch ex As Exception
            MsgBox("Enter a number for a year in the next 10 years", , "Error")
            Return False
        End Try
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Wait for two seconds to show the splash screen
        Threading.Thread.Sleep(2000)
    End Sub
End Class
