Public Class frmKaraokeNight

    Private _decSongPrice As Decimal = 2.99D
    Private _decHourPrice As Decimal = 8.99D

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Shows the splash screen for 3 seconds and calls the clear method
        Threading.Thread.Sleep(3000)
        ClearForm()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Now we're just calling the clear method instead of the btnclick event each time
        ClearForm()
    End Sub

    Private Sub ClearForm()
        'Clears the form and resets the combobox to the default and makes lbls and buttons invisible as appropriate
        lblKaraokeType.Visible = False
        txtUserInput.Visible = False
        txtUserInput.Clear()
        btnTotal.Visible = False
        lblTotal.Visible = False
        btnClear.Visible = False
        cboKaraokeChoice.Text = "Customize Your Karaoke Night"
        cboKaraokeChoice.Focus()
    End Sub

    Private Sub cboKaraokeChoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKaraokeChoice.SelectedIndexChanged
        txtUserInput.Clear()

        Select Case cboKaraokeChoice.SelectedIndex
            Case 0
                KaraokeBySong()
            Case 1
                KaraokeByHour()
            Case Else
                MsgBox("Please make a Karaoke Type Selection",, "Invalid Chioce")
        End Select
    End Sub

    Private Sub KaraokeBySong()
        'Sets the form up to reflect the user's choice of Karaoke Songs
        lblKaraokeType.Text = "Number of Karaoke songs"
        lblKaraokeType.Visible = True
        txtUserInput.Visible = True
        btnClear.Visible = True
        btnTotal.Visible = True
        txtUserInput.Focus()
    End Sub

    Private Sub KaraokeByHour()
        'Sets the form up to reflect the user's choice of Karaoke by Hour
        lblKaraokeType.Text = "Number of hours for Karaoke room"
        lblKaraokeType.Visible = True
        txtUserInput.Visible = True
        btnClear.Visible = True
        btnTotal.Visible = True
        txtUserInput.Focus()
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim decTotalCost As Decimal
        Dim intUserValue As Integer

        If (ValidateUserInput()) Then
            intUserValue = Convert.ToInt32(txtUserInput.Text)
            Select Case cboKaraokeChoice.SelectedIndex
                Case 0
                    decTotalCost = SongCost(intUserValue)
                Case 1
                    decTotalCost = RoomCost(intUserValue)
            End Select

            lblTotal.Visible = True
            lblTotal.Text = "Total Cost of Karaoke Night - $" + decTotalCost.ToString("F2")
            txtUserInput.Focus()
        End If
    End Sub

    Private Function SongCost(ByVal intSongNumber As Integer) As Decimal
        'Determines total cost by song
        Dim decTotalCost As Decimal
        decTotalCost = intSongNumber * _decSongPrice
        Return decTotalCost
    End Function

    Private Function RoomCost(ByVal intRoomNumber As Integer) As Decimal
        'Determines total cost by hour
        Dim decTotalCost As Decimal
        decTotalCost = intRoomNumber * _decHourPrice
        Return decTotalCost
    End Function

    Private Function ValidateUserInput() As Boolean
        'Validates the user input and gives appropriate error messages
        Dim intUserNumber As Integer

        Try
            intUserNumber = Convert.ToInt32(txtUserInput.Text)

            If intUserNumber > 0D Then
                Return True
            Else
                MsgBox("Please enter a positive number",, "Invalid Input")
            End If
        Catch ex As FormatException
            MsgBox("Please enter a valid number (Greater than 0)",, "Invalid Input")
        Catch ex As OverflowException
            MsgBox("The number entered is too large.  Please try again",, "Input overflow")
        Catch ex As SystemException
            MsgBox("Input is invalid.  Please try again",, "Error")
        End Try

        txtUserInput.Focus()
        txtUserInput.Clear()
        Return False
    End Function
End Class
