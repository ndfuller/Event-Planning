Public Class GuestsForm

    Dim boolGuestAdded As Boolean = False

    Private Sub GuestsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radGuest1Meal1.Text = strMealOption(0)
        radGuest2Meal1.Text = strMealOption(0)
        radGuest3Meal1.Text = strMealOption(0)
        radGuest4Meal1.Text = strMealOption(0)

        radGuest1Meal2.Text = strMealOption(1)
        radGuest2Meal2.Text = strMealOption(1)
        radGuest3Meal2.Text = strMealOption(1)
        radGuest4Meal2.Text = strMealOption(1)

        radGuest1Meal3.Text = strMealOption(2)
        radGuest2Meal3.Text = strMealOption(2)
        radGuest3Meal3.Text = strMealOption(2)
        radGuest4Meal3.Text = strMealOption(2)

        radGuest1Meal4.Text = strMealOption(3)
        radGuest2Meal4.Text = strMealOption(3)
        radGuest3Meal4.Text = strMealOption(3)
        radGuest4Meal4.Text = strMealOption(3)
    End Sub

    Private Sub btnSelectMeals_Click(sender As Object, e As EventArgs) Handles btnSelectMeals.Click
        If IsName() Then
            If IsStreetAddress() Then
                If IsCityStateZip() Then
                    If IsTelephone() Then
                        If IsGuests() Then
                            If txtGuestsAttending.Text = "1" Then
                                gbGuest1Meal.Visible = True
                            ElseIf txtGuestsAttending.Text = "2" Then
                                gbGuest1Meal.Visible = True
                                gbGuest2Meal.Visible = True
                            ElseIf txtGuestsAttending.Text = "3" Then
                                gbGuest1Meal.Visible = True
                                gbGuest2Meal.Visible = True
                                gbGuest3Meal.Visible = True
                            Else
                                gbGuest1Meal.Visible = True
                                gbGuest2Meal.Visible = True
                                gbGuest3Meal.Visible = True
                                gbGuest4Meal.Visible = True
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
        txtName.Focus()
    End Sub

    Sub ClearForm()
        'hide check boxes
        gbGuest1Meal.Visible = False
        gbGuest2Meal.Visible = False
        gbGuest3Meal.Visible = False
        gbGuest4Meal.Visible = False

        'make all radio buttons unchecked
        radGuest1Meal1.Checked = False
        radGuest2Meal1.Checked = False
        radGuest3Meal1.Checked = False
        radGuest4Meal1.Checked = False
        radGuest1Meal2.Checked = False
        radGuest2Meal2.Checked = False
        radGuest3Meal2.Checked = False
        radGuest4Meal2.Checked = False
        radGuest1Meal3.Checked = False
        radGuest2Meal3.Checked = False
        radGuest3Meal3.Checked = False
        radGuest4Meal3.Checked = False
        radGuest1Meal4.Checked = False
        radGuest2Meal4.Checked = False
        radGuest3Meal4.Checked = False
        radGuest4Meal4.Checked = False

        'clear text boxes
        txtName.Text = String.Empty
        txtStreetAddress.Text = String.Empty
        txtCityStateZip.Text = String.Empty
        txtTelephone.Text = String.Empty
        txtGuestsAttending.Text = String.Empty
    End Sub

    Private Sub btnAddGuest_Click(sender As Object, e As EventArgs) Handles btnAddGuest.Click
        If IsGuest1MealSelected() Then
            If IsGuest2MealSelected() Then
                If IsGuest3MealSelected() Then
                    If IsGuest4MealSelected() Then
                        Try
                            If intIndex > 0 Then
                                ReDim Preserve strName(intIndex)
                                ReDim Preserve strStreetAddress(intIndex)
                                ReDim Preserve strCityStateZip(intIndex)
                                ReDim Preserve strTelephone(intIndex)
                                ReDim Preserve intGuests(intIndex)
                            End If

                            strName(intIndex) = txtName.Text
                            strStreetAddress(intIndex) = txtStreetAddress.Text
                            strCityStateZip(intIndex) = txtCityStateZip.Text
                            strTelephone(intIndex) = txtTelephone.Text
                            intGuests(intIndex) = CInt(txtGuestsAttending.Text)

                            MealSelection()
                            intIndex += 1
                            MessageBox.Show("Guest Added")
                            ClearForm()
                            txtName.Focus()
                        Catch
                            MessageBox.Show("Guest was not added to the list.")
                            ClearForm()
                            txtName.Focus()
                        End Try

                    End If
                End If
            End If
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Sub MealSelection()
        If radGuest1Meal1.Checked = True Then
            intMealCounter(0) += 1
        End If
        If radGuest2Meal1.Checked = True Then
            intMealCounter(0) += 1
        End If
        If radGuest3Meal1.Checked = True Then
            intMealCounter(0) += 1
        End If
        If radGuest4Meal1.Checked = True Then
            intMealCounter(0) += 1
        End If
        If radGuest1Meal2.Checked = True Then
            intMealCounter(1) += 1
        End If
        If radGuest2Meal2.Checked = True Then
            intMealCounter(1) += 1
        End If
        If radGuest3Meal2.Checked = True Then
            intMealCounter(1) += 1
        End If
        If radGuest4Meal2.Checked = True Then
            intMealCounter(1) += 1
        End If
        If radGuest1Meal3.Checked = True Then
            intMealCounter(2) += 1
        End If
        If radGuest2Meal3.Checked = True Then
            intMealCounter(2) += 1
        End If
        If radGuest3Meal3.Checked = True Then
            intMealCounter(2) += 1
        End If
        If radGuest4Meal3.Checked = True Then
            intMealCounter(2) += 1
        End If
        If radGuest1Meal4.Checked = True Then
            intMealCounter(3) += 1
        End If
        If radGuest2Meal4.Checked = True Then
            intMealCounter(3) += 1
        End If
        If radGuest3Meal4.Checked = True Then
            intMealCounter(3) += 1
        End If
        If radGuest4Meal4.Checked = True Then
            intMealCounter(3) += 1
        End If
    End Sub

    Function IsName() As Boolean
        If (txtName.Text = String.Empty) Then
            MessageBox.Show("Please enter a name.")
            txtName.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Function IsStreetAddress() As Boolean
        If (txtStreetAddress.Text = String.Empty) Then
            MessageBox.Show("Please enter a street address.")
            txtStreetAddress.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Function IsCityStateZip() As Boolean
        If (txtCityStateZip.Text = String.Empty) Then
            MessageBox.Show("Please enter a city, state, and zip code.")
            txtCityStateZip.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Function IsTelephone() As Boolean
        If (txtTelephone.Text = String.Empty) Then
            MessageBox.Show("Please enter a telephone number.")
            txtTelephone.Focus()
            Return False
        Else
            Return True
        End If
    End Function


    Function IsGuests() As Boolean
        Try
            If (txtGuestsAttending.Text = String.Empty) Then

                MessageBox.Show("Please enter the number of guests.")
                txtGuestsAttending.Focus()
                Return False
            ElseIf (CInt(txtGuestsAttending.Text) < 1 Or CInt(txtGuestsAttending.Text) > 4) Then
                MessageBox.Show("Each group is limited to 4 guests.")
                txtGuestsAttending.Text = String.Empty
                txtGuestsAttending.Focus()
                Return False
            Else
                Return True
            End If
        Catch
            MessageBox.Show("Please enter an integer number.")
            txtGuestsAttending.Text = String.Empty
            txtGuestsAttending.Focus()
            Return False
        End Try
    End Function

    Function IsGuest1MealSelected() As Boolean
        If gbGuest1Meal.Visible = True Then
            If radGuest1Meal1.Checked = True Then
                Return True
            ElseIf radGuest1Meal2.Checked = True Then
                Return True
            ElseIf radGuest1Meal3.Checked = True Then
                Return True
            ElseIf radGuest1Meal4.Checked = True Then
                Return True
            Else
                MessageBox.Show("Please select a meal for guest 1.")
                Return False
            End If
        Else
            Return True
        End If
    End Function

    Function IsGuest2MealSelected() As Boolean
        If gbGuest2Meal.Visible = True Then
            If radGuest2Meal1.Checked = True Then
                Return True
            ElseIf radGuest2Meal2.Checked = True Then
                Return True
            ElseIf radGuest2Meal3.Checked = True Then
                Return True
            ElseIf radGuest2Meal4.Checked = True Then
                Return True
            Else
                MessageBox.Show("Please select a meal for guest 2.")
                Return False
            End If
        Else
            Return True
        End If
    End Function

    Function IsGuest3MealSelected() As Boolean
        If gbGuest3Meal.Visible = True Then
            If radGuest3Meal1.Checked = True Then
                Return True
            ElseIf radGuest3Meal2.Checked = True Then
                Return True
            ElseIf radGuest3Meal3.Checked = True Then
                Return True
            ElseIf radGuest3Meal4.Checked = True Then
                Return True
            Else
                MessageBox.Show("Please select a meal for guest 3.")
                Return False
            End If
        Else
            Return True
        End If
    End Function


    Function IsGuest4MealSelected() As Boolean
        If gbGuest4Meal.Visible = True Then
            If radGuest4Meal1.Checked = True Then
                Return True
            ElseIf radGuest4Meal2.Checked = True Then
                Return True
            ElseIf radGuest4Meal3.Checked = True Then
                Return True
            ElseIf radGuest4Meal4.Checked = True Then
                Return True
            Else
                MessageBox.Show("Please select a meal for guest 4.")
                Return False
            End If
        Else
            Return True
        End If
    End Function
End Class