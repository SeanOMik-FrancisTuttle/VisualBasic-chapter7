' Program Name: IMAX Theatre
' Author:       Sean Ervin
' Date:         9/11/2019
' Purpose:      Computed the cost of karaoke night depending of the type of renting

Public Class frmKaraokeMusicNight
    Private Sub CboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        ' This event handler allows the user to enter the amount hours or songs they are renting for.

        ' Make items visible in the window

        ' Make a certain label visible depending on the selection
        Select Case cboType.SelectedIndex
            Case 0
                lblSongs.Visible = False
                lblHour.Visible = True
            Case 1
                lblSongs.Visible = True
                lblHour.Visible = False
        End Select

        txtAmount.Visible = True
        btnCost.Visible = True
        btnClear.Visible = True
        ' Set focus on number in amount box
        txtAmount.Focus()
    End Sub

    Private Sub BtnTotalCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        ' This button event handler determines the cost of the the rental and
        ' displays the cost label.

        Dim intAmount As Integer
        Dim intRentalType As Integer = cboType.SelectedIndex
        Dim decTotalCost As Decimal

        ' If amount is valid, calculate the cost.
        If (ValidateAmount()) Then
            intAmount = Convert.ToInt32(txtAmount.Text)
            Select Case intRentalType
                Case 0
                    decTotalCost = HourlyCost(intAmount)
                Case 1
                    decTotalCost = SongCost(intAmount)
            End Select
            ' Display the cost of the rental
            lblCost.Visible = True
            lblCost.Text = "Total Cost Of Karaoke Night - " & decTotalCost.ToString("C")
        End If
    End Sub

    Private Function ValidateAmount() As Boolean
        ' This procedure validates the value entered.
        Dim intAmount As Integer
        Dim blnValidityCheck As Boolean = False
        Dim strNumberOf As String = "Please enter a positive numerical value."
        Dim strMessageBoxTitle As String = "Error"

        Try
            intAmount = Convert.ToInt32(txtAmount.Text)
            If intAmount > 0 Then
                blnValidityCheck = True
            Else
                MsgBox(strNumberOf, , strMessageBoxTitle)
                txtAmount.Focus()
                txtAmount.Clear()
            End If
        Catch ex As Exception
            MsgBox(strNumberOf, , strMessageBoxTitle)
            txtAmount.Focus()
            txtAmount.Clear()
        End Try
        Return blnValidityCheck
    End Function

    Private Function HourlyCost(ByVal intAmount) As Decimal
        ' This function calculates the cost of renting hourly
        Dim decHourlyCost As Decimal = 8.99
        Return decHourlyCost * intAmount
    End Function

    Private Function SongCost(ByVal intAmount) As Decimal
        ' This function calculates the cost of renting for each song
        Dim decSongCost As Decimal = 2.99
        Return decSongCost * intAmount
    End Function

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' this event handler clears the form and resets the form for reuse when the user clicks the Clear button.
        cboType.Text = "Select Rental Type"
        txtAmount.Clear()
        lblCost.Text = ""
        lblHour.Visible = False
        lblSongs.Visible = False
        txtAmount.Visible = False
        btnCost.Visible = False
        btnClear.Visible = False
        lblCost.Visible = False
    End Sub

    Private Sub Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hold the splash screen for 3 seconds
        Threading.Thread.Sleep(3000)
    End Sub
End Class
