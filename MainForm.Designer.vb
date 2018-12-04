<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCatering = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditGuests = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilePrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilePrintCateringBill = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilePrintGuestList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilePrintAddressLabels = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.sfdSaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.pdPrintCateringBill = New System.Drawing.Printing.PrintDocument()
        Me.ppdPrintDialog = New System.Windows.Forms.PrintDialog()
        Me.pdPrintGuestList = New System.Drawing.Printing.PrintDocument()
        Me.pdPrintAddressLabels = New System.Drawing.Printing.PrintDocument()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(472, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileOpen, Me.mnuFileSave, Me.ToolStripMenuItem1, Me.mnuFilePrint, Me.ToolStripMenuItem2, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(44, 24)
        Me.mnuFile.Text = "File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuFileNew.Size = New System.Drawing.Size(181, 26)
        Me.mnuFileNew.Text = "New"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFileOpen.Size = New System.Drawing.Size(181, 26)
        Me.mnuFileOpen.Text = "Open"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(181, 26)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(53, 24)
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(181, 26)
        Me.mnuHelpAbout.Text = "About"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome to Event Planning 101"
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.FileName = "OpenFileDialog1"
        Me.ofdOpenFile.Filter = "Text Files (*.txt) | *.txt"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditCatering, Me.mnuEditGuests})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(47, 24)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuEditCatering
        '
        Me.mnuEditCatering.Name = "mnuEditCatering"
        Me.mnuEditCatering.Size = New System.Drawing.Size(181, 26)
        Me.mnuEditCatering.Text = "Catering"
        '
        'mnuEditGuests
        '
        Me.mnuEditGuests.Name = "mnuEditGuests"
        Me.mnuEditGuests.Size = New System.Drawing.Size(181, 26)
        Me.mnuEditGuests.Text = "Guests"
        '
        'mnuFilePrint
        '
        Me.mnuFilePrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFilePrintCateringBill, Me.mnuFilePrintGuestList, Me.mnuFilePrintAddressLabels})
        Me.mnuFilePrint.Name = "mnuFilePrint"
        Me.mnuFilePrint.Size = New System.Drawing.Size(181, 26)
        Me.mnuFilePrint.Text = "Print"
        '
        'mnuFilePrintCateringBill
        '
        Me.mnuFilePrintCateringBill.Name = "mnuFilePrintCateringBill"
        Me.mnuFilePrintCateringBill.Size = New System.Drawing.Size(183, 26)
        Me.mnuFilePrintCateringBill.Text = "Catering Bill"
        '
        'mnuFilePrintGuestList
        '
        Me.mnuFilePrintGuestList.Name = "mnuFilePrintGuestList"
        Me.mnuFilePrintGuestList.Size = New System.Drawing.Size(183, 26)
        Me.mnuFilePrintGuestList.Text = "Guest List"
        '
        'mnuFilePrintAddressLabels
        '
        Me.mnuFilePrintAddressLabels.Name = "mnuFilePrintAddressLabels"
        Me.mnuFilePrintAddressLabels.Size = New System.Drawing.Size(183, 26)
        Me.mnuFilePrintAddressLabels.Text = "Address Labels"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(181, 26)
        Me.mnuFileSave.Text = "Save"
        '
        'sfdSaveFile
        '
        Me.sfdSaveFile.Filter = "Text Files (*.txt) | *.txt"
        '
        'pdPrintCateringBill
        '
        '
        'ppdPrintDialog
        '
        Me.ppdPrintDialog.UseEXDialog = True
        '
        'pdPrintGuestList
        '
        '
        'pdPrintAddressLabels
        '
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(178, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(178, 6)
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 226)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Event Planning 101"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileNew As ToolStripMenuItem
    Friend WithEvents mnuFileOpen As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents ofdOpenFile As OpenFileDialog
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuEditCatering As ToolStripMenuItem
    Friend WithEvents mnuEditGuests As ToolStripMenuItem
    Friend WithEvents mnuFilePrint As ToolStripMenuItem
    Friend WithEvents mnuFilePrintCateringBill As ToolStripMenuItem
    Friend WithEvents mnuFilePrintGuestList As ToolStripMenuItem
    Friend WithEvents mnuFilePrintAddressLabels As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents sfdSaveFile As SaveFileDialog
    Friend WithEvents pdPrintCateringBill As Printing.PrintDocument
    Friend WithEvents ppdPrintDialog As PrintDialog
    Friend WithEvents pdPrintGuestList As Printing.PrintDocument
    Friend WithEvents pdPrintAddressLabels As Printing.PrintDocument
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
End Class
