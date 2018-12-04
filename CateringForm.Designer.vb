<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CateringForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.gbMeal1 = New System.Windows.Forms.GroupBox()
        Me.txtMeal1Price = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMeal1Name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.gbMeal2 = New System.Windows.Forms.GroupBox()
        Me.txtMeal2Price = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMeal2Name = New System.Windows.Forms.TextBox()
        Me.gbMeal4 = New System.Windows.Forms.GroupBox()
        Me.txtMeal4Price = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMeal4Name = New System.Windows.Forms.TextBox()
        Me.gbMeal3 = New System.Windows.Forms.GroupBox()
        Me.txtMeal3Price = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMeal3Name = New System.Windows.Forms.TextBox()
        Me.btnAddMeals = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbMeal1.SuspendLayout()
        Me.gbMeal2.SuspendLayout()
        Me.gbMeal4.SuspendLayout()
        Me.gbMeal3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(146, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(132, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Company:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(285, 43)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(140, 22)
        Me.txtCompanyName.TabIndex = 1
        '
        'gbMeal1
        '
        Me.gbMeal1.Controls.Add(Me.txtMeal1Price)
        Me.gbMeal1.Controls.Add(Me.Label4)
        Me.gbMeal1.Controls.Add(Me.Label3)
        Me.gbMeal1.Controls.Add(Me.txtMeal1Name)
        Me.gbMeal1.Location = New System.Drawing.Point(12, 103)
        Me.gbMeal1.Name = "gbMeal1"
        Me.gbMeal1.Size = New System.Drawing.Size(267, 80)
        Me.gbMeal1.TabIndex = 3
        Me.gbMeal1.TabStop = False
        Me.gbMeal1.Text = "Meal 1"
        '
        'txtMeal1Price
        '
        Me.txtMeal1Price.Location = New System.Drawing.Point(121, 47)
        Me.txtMeal1Price.Name = "txtMeal1Price"
        Me.txtMeal1Price.Size = New System.Drawing.Size(123, 22)
        Me.txtMeal1Price.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Meal: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Price per plate:"
        '
        'txtMeal1Name
        '
        Me.txtMeal1Name.Location = New System.Drawing.Point(122, 19)
        Me.txtMeal1Name.Name = "txtMeal1Name"
        Me.txtMeal1Name.Size = New System.Drawing.Size(122, 22)
        Me.txtMeal1Name.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(101, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Phone Number:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(284, 78)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(141, 22)
        Me.txtPhoneNumber.TabIndex = 2
        '
        'gbMeal2
        '
        Me.gbMeal2.Controls.Add(Me.txtMeal2Price)
        Me.gbMeal2.Controls.Add(Me.Label5)
        Me.gbMeal2.Controls.Add(Me.Label6)
        Me.gbMeal2.Controls.Add(Me.txtMeal2Name)
        Me.gbMeal2.Location = New System.Drawing.Point(285, 103)
        Me.gbMeal2.Name = "gbMeal2"
        Me.gbMeal2.Size = New System.Drawing.Size(267, 80)
        Me.gbMeal2.TabIndex = 6
        Me.gbMeal2.TabStop = False
        Me.gbMeal2.Text = "Meal 2"
        '
        'txtMeal2Price
        '
        Me.txtMeal2Price.Location = New System.Drawing.Point(121, 47)
        Me.txtMeal2Price.Name = "txtMeal2Price"
        Me.txtMeal2Price.Size = New System.Drawing.Size(125, 22)
        Me.txtMeal2Price.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(15, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Meal: "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Price per plate:"
        '
        'txtMeal2Name
        '
        Me.txtMeal2Name.Location = New System.Drawing.Point(122, 19)
        Me.txtMeal2Name.Name = "txtMeal2Name"
        Me.txtMeal2Name.Size = New System.Drawing.Size(124, 22)
        Me.txtMeal2Name.TabIndex = 5
        '
        'gbMeal4
        '
        Me.gbMeal4.Controls.Add(Me.txtMeal4Price)
        Me.gbMeal4.Controls.Add(Me.Label7)
        Me.gbMeal4.Controls.Add(Me.Label8)
        Me.gbMeal4.Controls.Add(Me.txtMeal4Name)
        Me.gbMeal4.Location = New System.Drawing.Point(285, 189)
        Me.gbMeal4.Name = "gbMeal4"
        Me.gbMeal4.Size = New System.Drawing.Size(267, 80)
        Me.gbMeal4.TabIndex = 10
        Me.gbMeal4.TabStop = False
        Me.gbMeal4.Text = "Meal 4"
        '
        'txtMeal4Price
        '
        Me.txtMeal4Price.Location = New System.Drawing.Point(121, 47)
        Me.txtMeal4Price.Name = "txtMeal4Price"
        Me.txtMeal4Price.Size = New System.Drawing.Size(125, 22)
        Me.txtMeal4Price.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(15, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Meal: "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 23)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Price per plate:"
        '
        'txtMeal4Name
        '
        Me.txtMeal4Name.Location = New System.Drawing.Point(122, 19)
        Me.txtMeal4Name.Name = "txtMeal4Name"
        Me.txtMeal4Name.Size = New System.Drawing.Size(124, 22)
        Me.txtMeal4Name.TabIndex = 9
        '
        'gbMeal3
        '
        Me.gbMeal3.Controls.Add(Me.txtMeal3Price)
        Me.gbMeal3.Controls.Add(Me.Label9)
        Me.gbMeal3.Controls.Add(Me.Label10)
        Me.gbMeal3.Controls.Add(Me.txtMeal3Name)
        Me.gbMeal3.Location = New System.Drawing.Point(12, 189)
        Me.gbMeal3.Name = "gbMeal3"
        Me.gbMeal3.Size = New System.Drawing.Size(267, 80)
        Me.gbMeal3.TabIndex = 10
        Me.gbMeal3.TabStop = False
        Me.gbMeal3.Text = "Meal 3"
        '
        'txtMeal3Price
        '
        Me.txtMeal3Price.Location = New System.Drawing.Point(121, 47)
        Me.txtMeal3Price.Name = "txtMeal3Price"
        Me.txtMeal3Price.Size = New System.Drawing.Size(123, 22)
        Me.txtMeal3Price.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(15, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Meal: "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 23)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Price per plate:"
        '
        'txtMeal3Name
        '
        Me.txtMeal3Name.Location = New System.Drawing.Point(122, 19)
        Me.txtMeal3Name.Name = "txtMeal3Name"
        Me.txtMeal3Name.Size = New System.Drawing.Size(122, 22)
        Me.txtMeal3Name.TabIndex = 7
        '
        'btnAddMeals
        '
        Me.btnAddMeals.Location = New System.Drawing.Point(134, 275)
        Me.btnAddMeals.Name = "btnAddMeals"
        Me.btnAddMeals.Size = New System.Drawing.Size(122, 39)
        Me.btnAddMeals.TabIndex = 11
        Me.btnAddMeals.Text = "Add Meals"
        Me.ToolTip1.SetToolTip(Me.btnAddMeals, "Click to add caterer and meals to event.")
        Me.btnAddMeals.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(303, 275)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(122, 39)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click to exit.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'CateringForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 339)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAddMeals)
        Me.Controls.Add(Me.gbMeal4)
        Me.Controls.Add(Me.gbMeal3)
        Me.Controls.Add(Me.gbMeal2)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gbMeal1)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CateringForm"
        Me.Text = "Catering Details"
        Me.gbMeal1.ResumeLayout(False)
        Me.gbMeal1.PerformLayout()
        Me.gbMeal2.ResumeLayout(False)
        Me.gbMeal2.PerformLayout()
        Me.gbMeal4.ResumeLayout(False)
        Me.gbMeal4.PerformLayout()
        Me.gbMeal3.ResumeLayout(False)
        Me.gbMeal3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents gbMeal1 As GroupBox
    Friend WithEvents txtMeal1Price As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMeal1Name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents gbMeal2 As GroupBox
    Friend WithEvents txtMeal2Price As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMeal2Name As TextBox
    Friend WithEvents gbMeal4 As GroupBox
    Friend WithEvents txtMeal4Price As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMeal4Name As TextBox
    Friend WithEvents gbMeal3 As GroupBox
    Friend WithEvents txtMeal3Price As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMeal3Name As TextBox
    Friend WithEvents btnAddMeals As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
