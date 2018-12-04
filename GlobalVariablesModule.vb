Module GlobalVariablesModule
    'Catering Variables
    Public strCompanyName As String = String.Empty
    Public strCompanyPhoneNumber As String = String.Empty
    Public strMealOption() As String = {String.Empty, String.Empty, String.Empty, String.Empty}
    Public decMealCost() As Decimal = {0, 0, 0, 0}

    'Guest Variables
    Public strName(0) As String
    Public strStreetAddress(0) As String
    Public strCityStateZip(0) As String
    Public strTelephone(0) As String
    Public intGuests(0) As Integer

    Public intIndex As Integer = 0
    Public intMealCounter() As Integer = {0, 0, 0, 0}
    Dim intCounter As Integer

    Public Function TotalMeals() As Integer
        'calculates and returns the total meals to order
        Dim intTotalMeals As Integer = 0
        For intCounter = 0 To 3
            intTotalMeals += intMealCounter(intCounter)
        Next
        Return intTotalMeals
    End Function

    Public Function TotalPrice() As Decimal
        'calculates and returns the total price of the catering
        Dim decTotalPrice As Decimal = 0
        For intCounter = 0 To 3
            decTotalPrice += intMealCounter(intCounter) * decMealCost(intCounter)
        Next
        Return decTotalPrice
    End Function

    Public Function TotalAttending() As Integer
        'calculates and returns the total guests attending
        Dim intTotalAttending As Integer = 0
        For intCounter = 0 To intIndex - 1
            intTotalAttending += intGuests(intCounter)
        Next
        Return intTotalAttending
    End Function

    Public Sub ResetGlobalVariables()
        'reset global variables to o, null, or empty string
        'Catering Variables
        strCompanyName = String.Empty
        strCompanyPhoneNumber = String.Empty

        'Guest Variables
        ReDim strName(0)
        ReDim strStreetAddress(0)
        ReDim strCityStateZip(0)
        ReDim strTelephone(0)
        ReDim intGuests(0)

        intIndex = 0

        'meal options
        For intCounter = 0 To 3
            intMealCounter(intCounter) = 0
            decMealCost(intCounter) = 0
            strMealOption(intCounter) = String.Empty
        Next
    End Sub
End Module
