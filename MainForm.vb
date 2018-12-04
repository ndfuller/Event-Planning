' Event Planning 101 Program
'
' This program allows a user to enter catering information, guests, and guests' meal
' selection through a GUI.  You can save what has been entered at any time, open an existing event, and
' add more people and make changes to catering information. You can print several reports at any time.
' The report options are "Catering Bill", "Guest List", and "Address Labels".
'
' CSC220
' Author Nicholas Fuller
' Version 1.0, 12-2-2016

Imports System.IO

Public Class MainForm
    'create variables for forms
    Dim frmAbout As New AboutForm
    Dim frmGuests As New GuestsForm
    Dim frmCatering As New CateringForm
    'create variables for file name to open and save
    Private strFilename As String = String.Empty
    'varaible for printing formatting
    Dim intVertPosition As Integer

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        'open about form
        frmAbout.ShowDialog()
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        'close the program
        Me.Close()
    End Sub

    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        'start a new project and open catering form

        If strFilename = String.Empty Then
            'save current document if unsaved
            If MessageBox.Show("The current information is not saved. Would you like to save it?",
                               "Confirm", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                If sfdSaveFile.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    strFilename = sfdSaveFile.FileName
                    SaveDocument()
                    strFilename = String.Empty
                    ResetGlobalVariables()
                    frmCatering.ShowDialog()
                End If
            End If
        Else
            SaveDocument()
            strFilename = String.Empty
            ResetGlobalVariables()
            frmCatering.ShowDialog()
        End If
    End Sub

    Private Sub mnuEditCatering_Click(sender As Object, e As EventArgs) Handles mnuEditCatering.Click
        'open catering form
        frmCatering.ShowDialog()
    End Sub

    Private Sub mnuEditGuests_Click(sender As Object, e As EventArgs) Handles mnuEditGuests.Click
        'open guests form
        frmGuests.ShowDialog()
    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        'save file
        If strFilename = String.Empty Then
            'the document has not been saved
            If sfdSaveFile.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                strFilename = sfdSaveFile.FileName
                SaveDocument()
            End If
        Else
            'save the document with the current file name
            SaveDocument()
        End If
    End Sub

    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        'open a new event
        If strFilename = String.Empty Then
            'save current document if unsaved
            If MessageBox.Show("The current information is not saved. Would you like to save it?",
                               "Confirm", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                If sfdSaveFile.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    strFilename = sfdSaveFile.FileName
                    SaveDocument()
                    strFilename = String.Empty
                End If
            End If
            'select file to be opened
            If ofdOpenFile.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    strFilename = ofdOpenFile.FileName
                    OpenDocument()
                End If
            Else
                'select file to be opened
                If ofdOpenFile.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                strFilename = ofdOpenFile.FileName
                OpenDocument()
            End If
        End If
    End Sub

    Sub SaveDocument()
        'save document
        Dim outputFile As StreamWriter
        Try
            'create the file
            outputFile = File.CreateText(strFilename)

            'write the variables to a file
            Try
                Dim intCounter As Integer

                'write catering variables to file
                outputFile.WriteLine(strCompanyName)
                outputFile.WriteLine(strCompanyPhoneNumber)
                For intCounter = 0 To 3
                    outputFile.WriteLine(strMealOption(intCounter))
                    outputFile.WriteLine(decMealCost(intCounter))
                    outputFile.WriteLine(intMealCounter(intCounter))
                Next

                'write index to file
                outputFile.WriteLine(intIndex)

                'write guest info to file
                For intCounter = 0 To intIndex - 1
                    outputFile.WriteLine(strName(intCounter))
                    outputFile.WriteLine(strStreetAddress(intCounter))
                    outputFile.WriteLine(strCityStateZip(intCounter))
                    outputFile.WriteLine(strTelephone(intCounter))
                    outputFile.WriteLine(intGuests(intCounter))
                Next

                MessageBox.Show("Data saved.")
            Catch
                'error message for file creation error
                MessageBox.Show("Error writing to the file.")
            End Try

            'close the file
            outputFile.Close()
        Catch
            'error message for file creation error
            MessageBox.Show("Error creating the file.")
        End Try
    End Sub

    Sub OpenDocument()
        'open document
        Dim inputFile As StreamReader

        Try
            'open the file
            inputFile = File.OpenText(strFilename)

            'input the variables from the file
            Try
                Dim intCounter As Integer

                'input catering variables from the file
                strCompanyName = inputFile.ReadLine
                strCompanyPhoneNumber = inputFile.ReadLine
                For intCounter = 0 To 3
                    strMealOption(intCounter) = inputFile.ReadLine
                    decMealCost(intCounter) = CDec(inputFile.ReadLine)
                    intMealCounter(intCounter) = CInt(inputFile.ReadLine)
                Next

                'input index from file
                intIndex = CInt(inputFile.ReadLine)

                'Dynamically resize guest arrays
                ReDim strName(intIndex)
                ReDim strStreetAddress(intIndex)
                ReDim strCityStateZip(intIndex)
                ReDim strTelephone(intIndex)
                ReDim intGuests(intIndex)

                'input guest info from file
                For intCounter = 0 To intIndex - 1
                    strName(intCounter) = inputFile.ReadLine
                    strStreetAddress(intCounter) = inputFile.ReadLine
                    strCityStateZip(intCounter) = inputFile.ReadLine
                    strTelephone(intCounter) = inputFile.ReadLine
                    intGuests(intCounter) = CInt(inputFile.ReadLine)
                Next
                MessageBox.Show("Data imported.")

            Catch
                'error message for uploading data from the file
                MessageBox.Show("Error uploading the file.")
            End Try

            'close the file
            inputFile.Close()
        Catch
            'error message for opening file
            MessageBox.Show("could not find the file.")
        End Try
    End Sub

    Private Sub mnuFilePrintCateringBill_Click(sender As Object, e As EventArgs) Handles mnuFilePrintCateringBill.Click
        'print catering bill
        'open print dialog
        If ppdPrintDialog.ShowDialog() = DialogResult.OK Then
            pdPrintCateringBill.PrinterSettings = ppdPrintDialog.PrinterSettings
            'print catering bill
            pdPrintCateringBill.Print()
        End If
    End Sub

    Private Sub mnuFilePrintGuestList_Click(sender As Object, e As EventArgs) Handles mnuFilePrintGuestList.Click
        'print guest list
        'open print dialog
        If ppdPrintDialog.ShowDialog() = DialogResult.OK Then
            pdPrintGuestList.PrinterSettings = ppdPrintDialog.PrinterSettings
            'print guest list
            pdPrintGuestList.Print()
        End If
    End Sub

    Private Sub mnuFilePrintAddressLabels_Click(sender As Object, e As EventArgs) Handles mnuFilePrintAddressLabels.Click
        'print address labels
        'open print dialog
        If ppdPrintDialog.ShowDialog() = DialogResult.OK Then
            pdPrintAddressLabels.PrinterSettings = ppdPrintDialog.PrinterSettings
            'print address labels
            pdPrintAddressLabels.Print()
        End If
    End Sub

    Private Sub pdPrintCateringBill_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdPrintCateringBill.PrintPage
        'format catering bill
        Dim intCounter As Integer
        'create header with title and date
        e.Graphics.DrawString("Catering Bill Estimate", New Font("Courier New", 12, FontStyle.Bold),
                              Brushes.Black, 10, 10)
        e.Graphics.DrawString("Date: " & Now.ToString(), New Font("Courier New", 12, FontStyle.Regular),
                      Brushes.Black, 10, 28)
        intVertPosition = 52

        'list meals and number needed
        For intCounter = 0 To 3
            e.Graphics.DrawString(strMealOption(intCounter) & ": " & intMealCounter(intCounter),
                                  New Font("Courier New", 12, FontStyle.Regular), Brushes.Black,
                                  10, intVertPosition)
            intVertPosition += 16
        Next

        ' list total meals being ordered
        e.Graphics.DrawString("Total Meals: " & TotalMeals(),
                              New Font("Courier New", 12, FontStyle.Regular), Brushes.Black,
                              10, intVertPosition)
        intVertPosition += 16

        ' list total price being ordered
        e.Graphics.DrawString("Total Price: " & TotalPrice().ToString("c"),
                      New Font("Courier New", 12, FontStyle.Regular), Brushes.Black,
                      10, intVertPosition)
    End Sub

    Private Sub pdPrintGuestList_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdPrintGuestList.PrintPage
        'format guest list
        Dim intCounter As Integer
        'create header with title,  date, and total attending
        e.Graphics.DrawString("Guest List", New Font("Courier New", 12, FontStyle.Bold),
                              Brushes.Black, 10, 10)
        e.Graphics.DrawString("Date: " & Now.ToString(), New Font("Courier New", 12, FontStyle.Regular),
                      Brushes.Black, 10, 28)
        e.Graphics.DrawString("Total Attending: " & TotalAttending(),
                              New Font("Courier New", 12, FontStyle.Regular), Brushes.Black, 10, 44)
        intVertPosition = 68

        'create columns for name, group size, and phone number
        e.Graphics.DrawString(String.Format("{0, -25} {1, -12} {2, -12} ", "Name",
                                                "Group Size", "Phone Number"),
                      New Font("Courier New", 12, FontStyle.Regular), Brushes.Black, 10, intVertPosition)
        intVertPosition += 16

        'list name, group size, and phone number
        For intCounter = 0 To intIndex
            e.Graphics.DrawString(String.Format("{0, -30} {1, -7} {2, -12} ", strName(intCounter),
                                                intGuests(intCounter), strTelephone(intCounter)),
                      New Font("Courier New", 12, FontStyle.Regular), Brushes.Black, 10, intVertPosition)
            intVertPosition += 16
        Next
    End Sub

    Private Sub pdPrintAddressLabels_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdPrintAddressLabels.PrintPage
        'format address labels
        intVertPosition = 10

        'list name and mailing information as a mailing label
        For intCounter = 0 To intIndex
            e.Graphics.DrawString(strName(intCounter), New Font("Courier New", 12, FontStyle.Regular),
                                  Brushes.Black, 10, intVertPosition)
            intVertPosition += 16
            e.Graphics.DrawString(strStreetAddress(intCounter), New Font("Courier New", 12, FontStyle.Regular),
                                  Brushes.Black, 10, intVertPosition)
            intVertPosition += 16
            e.Graphics.DrawString(strCityStateZip(intCounter), New Font("Courier New", 12, FontStyle.Regular),
                                  Brushes.Black, 10, intVertPosition)
            intVertPosition += 32
        Next
    End Sub
End Class