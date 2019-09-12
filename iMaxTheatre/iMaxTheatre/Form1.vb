' Program Name: IMAX Theatre
' Author:       Sean Ervin
' Date:         9/11/2019
' Purpose:      Computed the cost of matinee and evening tickets.

Public Class frmIMAXTheatre
    Private Sub CboLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        ' This event handler allows the user to enter the amount if tickets they need and view the cost

        ' Mkae items visible in the window
        lblTickets.Visible = True
        txtTickets.Visible = True
        btnTicketCost.Visible = True
        btnClear.Visible = True
        ' Set focus on number in tickets box
        txtTickets.Focus()
    End Sub

    Private Sub BtnTicketCost_Click(sender As Object, e As EventArgs) Handles btnTicketCost.Click
        ' This button event handler determines the cost of the the tickets and
        ' displays the cost label

        Dim intTicketAmt As Integer
        Dim intTicketType As Integer = cboType.SelectedIndex
        Dim decTotalCost As Decimal
        Dim blnNumberOfTicketsValid = ValidateNumberOfTickets()

        ' Call a function to ensure the number of tickets is valid

        ' If number of tickets are valid, calculate the cost.
        If (blnNumberOfTicketsValid) Then
            intTicketAmt = Convert.ToInt32(txtTickets.Text)
            Select Case intTicketType
                Case 0
                    decTotalCost = MatineeCost(intTicketAmt)
                Case 1
                    decTotalCost = EveningCost(intTicketAmt)
            End Select
            ' Display the cost of the tickets
            lblCost.Visible = True
            lblCost.Text = decTotalCost.ToString("C") & " for the tickets"
        End If
    End Sub

    Private Function ValidateNumberOfTickets() As Boolean
        ' This procedure validates the value entered for the amount of tickets
        Dim intTicketAmount As Integer
        Dim blnValidityCheck As Boolean = False
        Dim strNumberOfTickets As String = "Please enter the number of tickets you need!"
        Dim strMessageBoxTitle As String = "Error"

        Try
            intTicketAmount = Convert.ToInt32(txtTickets.Text)
            If intTicketAmount > 0 And intTicketAmount <= 20 Then
                blnValidityCheck = True
            Else
                MsgBox(strNumberOfTickets, , strMessageBoxTitle)
                txtTickets.Focus()
                txtTickets.Clear()
            End If
        Catch ex As Exception
            MsgBox(strNumberOfTickets, , strMessageBoxTitle)
            txtTickets.Focus()
            txtTickets.Clear()
        End Try
        Return blnValidityCheck
    End Function

    Private Function MatineeCost(ByVal intAmount) As Decimal
        ' This function calculates the cost of matinee tickets
        Dim decMatineeCost As Decimal = 16D
        Return decMatineeCost * intAmount
    End Function

    Private Function EveningCost(ByVal intAmount) As Decimal
        ' This function calculates the cost of evening tickets
        Dim decEveningCost As Decimal = 27D
        Return decEveningCost * intAmount
    End Function

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' this event handler clears the form and resets the form for reuse when the user clicks the Clear button.
        cboType.Text = "Select Type:"
        txtTickets.Clear()
        lblCost.Text = ""
        lblCost.Text = ""
        lblTickets.Visible = False
        txtTickets.Visible = False
        btnTicketCost.Visible = False
        btnClear.Visible = False
        lblCost.Visible = False
        lblCost.Visible = False
    End Sub

    Private Sub FrmIMAXTheatre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hold the splash screen for 5 seconds
        Threading.Thread.Sleep(4000)
    End Sub
End Class
