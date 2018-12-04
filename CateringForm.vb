Public Class CateringForm
    Private Sub CateringForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCompanyName.Text = strCompanyName
        txtPhoneNumber.Text = strCompanyPhoneNumber

        txtMeal1Name.Text = strMealOption(0)
        txtMeal1Price.Text = Str(decMealCost(0))
        txtMeal2Name.Text = strMealOption(1)
        txtMeal2Price.Text = Str(decMealCost(1))
        txtMeal3Name.Text = strMealOption(2)
        txtMeal3Price.Text = Str(decMealCost(2))
        txtMeal4Name.Text = strMealOption(3)
        txtMeal4Price.Text = Str(decMealCost(3))

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddMeals_Click(sender As Object, e As EventArgs) Handles btnAddMeals.Click
        If IsCompany() Then
            If IsPhoneNumber() Then
                If IsMeal1() Then
                    If IsMeal2() Then
                        If IsMeal3() Then
                            If IsMeal4() Then
                                Try
                                    strCompanyName = txtCompanyName.Text
                                    strCompanyPhoneNumber = txtPhoneNumber.Text
                                    strMealOption(0) = txtMeal1Name.Text
                                    decMealCost(0) = CDec(txtMeal1Price.Text)
                                    strMealOption(1) = txtMeal2Name.Text
                                    decMealCost(1) = CDec(txtMeal2Price.Text)
                                    strMealOption(2) = txtMeal3Name.Text
                                    decMealCost(2) = CDec(txtMeal3Price.Text)
                                    strMealOption(3) = txtMeal4Name.Text
                                    decMealCost(3) = CDec(txtMeal4Price.Text)

                                    MessageBox.Show("Catering details updated")
                                    Me.Close()
                                Catch
                                    MessageBox.Show("Catering details failed to save.")
                                End Try
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Function IsCompany() As Boolean
        If txtCompanyName.Text = String.Empty Then
            MessageBox.Show("Please enter a company name.")
            txtCompanyName.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Function IsPhoneNumber() As Boolean
        If txtPhoneNumber.Text = String.Empty Then
            MessageBox.Show("Please enter a company phone number.")
            txtPhoneNumber.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Function IsMeal1() As Boolean
        If txtMeal1Name.Text = String.Empty Then
            MessageBox.Show("Please enter a name for meal 1.")
            txtMeal1Name.Focus()
            Return False
        Else
            Try
                If CInt(txtMeal1Price.Text) = 0 Then
                    MessageBox.Show("Please enter a price for meal 1.")
                    txtMeal1Price.Focus()
                    Return False
                Else
                    Return True
                End If
            Catch
                MessageBox.Show("Please enter decimal number for meal 1.")
                txtMeal1Price.Text = String.Empty
                txtMeal1Price.Focus()
                Return False
            End Try
            Return True
        End If
    End Function

    Function IsMeal2() As Boolean
        If txtMeal2Name.Text = String.Empty Then
            MessageBox.Show("Please enter a name for meal 2.")
            txtMeal2Name.Focus()
            Return False
        Else
            Try
                If CInt(txtMeal2Price.Text) = 0 Then
                    MessageBox.Show("Please enter a price for meal 2.")
                    txtMeal2Price.Focus()
                    Return False
                Else
                    Return True
                End If
            Catch
                MessageBox.Show("Please enter decimal number for meal 2.")
                txtMeal2Price.Text = String.Empty
                txtMeal2Price.Focus()
                Return False
            End Try
            Return True
        End If
    End Function

    Function IsMeal3() As Boolean
        If txtMeal3Name.Text = String.Empty Then
            MessageBox.Show("Please enter a name for meal 3.")
            txtMeal3Name.Focus()
            Return False
        Else
            Try
                If CInt(txtMeal3Price.Text) = 0 Then
                    MessageBox.Show("Please enter a price for meal 3.")
                    txtMeal3Price.Focus()
                    Return False
                Else
                    Return True
                End If
            Catch
                MessageBox.Show("Please enter decimal number for meal 3.")
                txtMeal3Price.Text = String.Empty
                txtMeal3Price.Focus()
                Return False
            End Try
            Return True
        End If
    End Function

    Function IsMeal4() As Boolean
        If txtMeal4Name.Text = String.Empty Then
            MessageBox.Show("Please enter a name for meal 4.")
            txtMeal4Name.Focus()
            Return False
        Else
            Try
                If CInt(txtMeal4Price.Text) = 0 Then
                    MessageBox.Show("Please enter a price for meal 4.")
                    txtMeal4Price.Focus()
                    Return False
                Else
                    Return True
                End If
            Catch
                MessageBox.Show("Please enter decimal number for meal 4.")
                txtMeal4Price.Text = String.Empty
                txtMeal4Price.Focus()
                Return False
            End Try
            Return True
        End If
    End Function
End Class