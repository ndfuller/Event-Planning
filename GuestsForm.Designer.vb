<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestsForm
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAddGuest = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbGuest3Meal = New System.Windows.Forms.GroupBox()
        Me.gbGuest2Meal = New System.Windows.Forms.GroupBox()
        Me.gbGuest4Meal = New System.Windows.Forms.GroupBox()
        Me.gbGuest1Meal = New System.Windows.Forms.GroupBox()
        Me.btnSelectMeals = New System.Windows.Forms.Button()
        Me.txtGuestsAttending = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCityStateZip = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.radGuest1Meal1 = New System.Windows.Forms.RadioButton()
        Me.radGuest1Meal2 = New System.Windows.Forms.RadioButton()
        Me.radGuest1Meal3 = New System.Windows.Forms.RadioButton()
        Me.radGuest1Meal4 = New System.Windows.Forms.RadioButton()
        Me.radGuest2Meal4 = New System.Windows.Forms.RadioButton()
        Me.radGuest2Meal3 = New System.Windows.Forms.RadioButton()
        Me.radGuest2Meal2 = New System.Windows.Forms.RadioButton()
        Me.radGuest2Meal1 = New System.Windows.Forms.RadioButton()
        Me.radGuest3Meal4 = New System.Windows.Forms.RadioButton()
        Me.radGuest3Meal3 = New System.Windows.Forms.RadioButton()
        Me.radGuest3Meal2 = New System.Windows.Forms.RadioButton()
        Me.radGuest3Meal1 = New System.Windows.Forms.RadioButton()
        Me.radGuest4Meal4 = New System.Windows.Forms.RadioButton()
        Me.radGuest4Meal3 = New System.Windows.Forms.RadioButton()
        Me.radGuest4Meal2 = New System.Windows.Forms.RadioButton()
        Me.radGuest4Meal1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.gbGuest3Meal.SuspendLayout()
        Me.gbGuest2Meal.SuspendLayout()
        Me.gbGuest4Meal.SuspendLayout()
        Me.gbGuest1Meal.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(368, 445)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(141, 44)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click to exit.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(206, 445)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(141, 44)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Click to clear the form.")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAddGuest
        '
        Me.btnAddGuest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddGuest.Location = New System.Drawing.Point(38, 445)
        Me.btnAddGuest.Name = "btnAddGuest"
        Me.btnAddGuest.Size = New System.Drawing.Size(141, 44)
        Me.btnAddGuest.TabIndex = 7
        Me.btnAddGuest.Text = "&Add Guest"
        Me.ToolTip1.SetToolTip(Me.btnAddGuest, "Click to add guest and meal information.")
        Me.btnAddGuest.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gbGuest3Meal)
        Me.GroupBox1.Controls.Add(Me.gbGuest2Meal)
        Me.GroupBox1.Controls.Add(Me.gbGuest4Meal)
        Me.GroupBox1.Controls.Add(Me.gbGuest1Meal)
        Me.GroupBox1.Controls.Add(Me.btnSelectMeals)
        Me.GroupBox1.Controls.Add(Me.txtGuestsAttending)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCityStateZip)
        Me.GroupBox1.Controls.Add(Me.txtTelephone)
        Me.GroupBox1.Controls.Add(Me.txtStreetAddress)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 427)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Guest Data"
        '
        'gbGuest3Meal
        '
        Me.gbGuest3Meal.Controls.Add(Me.radGuest3Meal4)
        Me.gbGuest3Meal.Controls.Add(Me.radGuest3Meal3)
        Me.gbGuest3Meal.Controls.Add(Me.radGuest3Meal2)
        Me.gbGuest3Meal.Controls.Add(Me.radGuest3Meal1)
        Me.gbGuest3Meal.Location = New System.Drawing.Point(269, 280)
        Me.gbGuest3Meal.Name = "gbGuest3Meal"
        Me.gbGuest3Meal.Size = New System.Drawing.Size(121, 141)
        Me.gbGuest3Meal.TabIndex = 24
        Me.gbGuest3Meal.TabStop = False
        Me.gbGuest3Meal.Text = "Guest 3 Meal"
        Me.gbGuest3Meal.Visible = False
        '
        'gbGuest2Meal
        '
        Me.gbGuest2Meal.Controls.Add(Me.radGuest2Meal4)
        Me.gbGuest2Meal.Controls.Add(Me.radGuest2Meal3)
        Me.gbGuest2Meal.Controls.Add(Me.radGuest2Meal2)
        Me.gbGuest2Meal.Controls.Add(Me.radGuest2Meal1)
        Me.gbGuest2Meal.Location = New System.Drawing.Point(142, 280)
        Me.gbGuest2Meal.Name = "gbGuest2Meal"
        Me.gbGuest2Meal.Size = New System.Drawing.Size(121, 141)
        Me.gbGuest2Meal.TabIndex = 23
        Me.gbGuest2Meal.TabStop = False
        Me.gbGuest2Meal.Text = "Guest 2 Meal"
        Me.gbGuest2Meal.Visible = False
        '
        'gbGuest4Meal
        '
        Me.gbGuest4Meal.Controls.Add(Me.radGuest4Meal4)
        Me.gbGuest4Meal.Controls.Add(Me.radGuest4Meal3)
        Me.gbGuest4Meal.Controls.Add(Me.radGuest4Meal2)
        Me.gbGuest4Meal.Controls.Add(Me.radGuest4Meal1)
        Me.gbGuest4Meal.Location = New System.Drawing.Point(396, 280)
        Me.gbGuest4Meal.Name = "gbGuest4Meal"
        Me.gbGuest4Meal.Size = New System.Drawing.Size(121, 141)
        Me.gbGuest4Meal.TabIndex = 22
        Me.gbGuest4Meal.TabStop = False
        Me.gbGuest4Meal.Text = "Guest 4 Meal"
        Me.gbGuest4Meal.Visible = False
        '
        'gbGuest1Meal
        '
        Me.gbGuest1Meal.Controls.Add(Me.radGuest1Meal4)
        Me.gbGuest1Meal.Controls.Add(Me.radGuest1Meal3)
        Me.gbGuest1Meal.Controls.Add(Me.radGuest1Meal2)
        Me.gbGuest1Meal.Controls.Add(Me.radGuest1Meal1)
        Me.gbGuest1Meal.Location = New System.Drawing.Point(15, 280)
        Me.gbGuest1Meal.Name = "gbGuest1Meal"
        Me.gbGuest1Meal.Size = New System.Drawing.Size(121, 141)
        Me.gbGuest1Meal.TabIndex = 21
        Me.gbGuest1Meal.TabStop = False
        Me.gbGuest1Meal.Text = "Guest 1 Meal"
        Me.gbGuest1Meal.Visible = False
        '
        'btnSelectMeals
        '
        Me.btnSelectMeals.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectMeals.Location = New System.Drawing.Point(208, 203)
        Me.btnSelectMeals.Name = "btnSelectMeals"
        Me.btnSelectMeals.Size = New System.Drawing.Size(257, 52)
        Me.btnSelectMeals.TabIndex = 6
        Me.btnSelectMeals.Text = "Select Meals"
        Me.ToolTip1.SetToolTip(Me.btnSelectMeals, "Click to select meal preferences")
        Me.btnSelectMeals.UseVisualStyleBackColor = True
        '
        'txtGuestsAttending
        '
        Me.txtGuestsAttending.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestsAttending.Location = New System.Drawing.Point(208, 167)
        Me.txtGuestsAttending.Name = "txtGuestsAttending"
        Me.txtGuestsAttending.Size = New System.Drawing.Size(257, 30)
        Me.txtGuestsAttending.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 41)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Total Guests:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCityStateZip
        '
        Me.txtCityStateZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCityStateZip.Location = New System.Drawing.Point(208, 95)
        Me.txtCityStateZip.Name = "txtCityStateZip"
        Me.txtCityStateZip.Size = New System.Drawing.Size(257, 30)
        Me.txtCityStateZip.TabIndex = 3
        '
        'txtTelephone
        '
        Me.txtTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephone.Location = New System.Drawing.Point(208, 131)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(257, 30)
        Me.txtTelephone.TabIndex = 4
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreetAddress.Location = New System.Drawing.Point(208, 59)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(257, 30)
        Me.txtStreetAddress.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(208, 23)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(257, 30)
        Me.txtName.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(196, 41)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "City, State, Zip:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(196, 41)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Telephone:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 41)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Street Address:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'radGuest1Meal1
        '
        Me.radGuest1Meal1.AutoSize = True
        Me.radGuest1Meal1.Location = New System.Drawing.Point(6, 22)
        Me.radGuest1Meal1.Name = "radGuest1Meal1"
        Me.radGuest1Meal1.Size = New System.Drawing.Size(17, 16)
        Me.radGuest1Meal1.TabIndex = 25
        Me.radGuest1Meal1.TabStop = True
        Me.radGuest1Meal1.UseVisualStyleBackColor = True
        '
        'radGuest1Meal2
        '
        Me.radGuest1Meal2.AutoSize = True
        Me.radGuest1Meal2.Location = New System.Drawing.Point(6, 51)
        Me.radGuest1Meal2.Name = "radGuest1Meal2"
        Me.radGuest1Meal2.Size = New System.Drawing.Size(17, 16)
        Me.radGuest1Meal2.TabIndex = 26
        Me.radGuest1Meal2.TabStop = True
        Me.radGuest1Meal2.UseVisualStyleBackColor = True
        '
        'radGuest1Meal3
        '
        Me.radGuest1Meal3.AutoSize = True
        Me.radGuest1Meal3.Location = New System.Drawing.Point(6, 79)
        Me.radGuest1Meal3.Name = "radGuest1Meal3"
        Me.radGuest1Meal3.Size = New System.Drawing.Size(17, 16)
        Me.radGuest1Meal3.TabIndex = 27
        Me.radGuest1Meal3.TabStop = True
        Me.radGuest1Meal3.UseVisualStyleBackColor = True
        '
        'radGuest1Meal4
        '
        Me.radGuest1Meal4.AutoSize = True
        Me.radGuest1Meal4.Location = New System.Drawing.Point(6, 107)
        Me.radGuest1Meal4.Name = "radGuest1Meal4"
        Me.radGuest1Meal4.Size = New System.Drawing.Size(17, 16)
        Me.radGuest1Meal4.TabIndex = 28
        Me.radGuest1Meal4.TabStop = True
        Me.radGuest1Meal4.UseVisualStyleBackColor = True
        '
        'radGuest2Meal4
        '
        Me.radGuest2Meal4.AutoSize = True
        Me.radGuest2Meal4.Location = New System.Drawing.Point(8, 107)
        Me.radGuest2Meal4.Name = "radGuest2Meal4"
        Me.radGuest2Meal4.Size = New System.Drawing.Size(17, 16)
        Me.radGuest2Meal4.TabIndex = 32
        Me.radGuest2Meal4.TabStop = True
        Me.radGuest2Meal4.UseVisualStyleBackColor = True
        '
        'radGuest2Meal3
        '
        Me.radGuest2Meal3.AutoSize = True
        Me.radGuest2Meal3.Location = New System.Drawing.Point(8, 79)
        Me.radGuest2Meal3.Name = "radGuest2Meal3"
        Me.radGuest2Meal3.Size = New System.Drawing.Size(17, 16)
        Me.radGuest2Meal3.TabIndex = 31
        Me.radGuest2Meal3.TabStop = True
        Me.radGuest2Meal3.UseVisualStyleBackColor = True
        '
        'radGuest2Meal2
        '
        Me.radGuest2Meal2.AutoSize = True
        Me.radGuest2Meal2.Location = New System.Drawing.Point(8, 51)
        Me.radGuest2Meal2.Name = "radGuest2Meal2"
        Me.radGuest2Meal2.Size = New System.Drawing.Size(17, 16)
        Me.radGuest2Meal2.TabIndex = 30
        Me.radGuest2Meal2.TabStop = True
        Me.radGuest2Meal2.UseVisualStyleBackColor = True
        '
        'radGuest2Meal1
        '
        Me.radGuest2Meal1.AutoSize = True
        Me.radGuest2Meal1.Location = New System.Drawing.Point(8, 22)
        Me.radGuest2Meal1.Name = "radGuest2Meal1"
        Me.radGuest2Meal1.Size = New System.Drawing.Size(17, 16)
        Me.radGuest2Meal1.TabIndex = 29
        Me.radGuest2Meal1.TabStop = True
        Me.radGuest2Meal1.UseVisualStyleBackColor = True
        '
        'radGuest3Meal4
        '
        Me.radGuest3Meal4.AutoSize = True
        Me.radGuest3Meal4.Location = New System.Drawing.Point(6, 107)
        Me.radGuest3Meal4.Name = "radGuest3Meal4"
        Me.radGuest3Meal4.Size = New System.Drawing.Size(17, 16)
        Me.radGuest3Meal4.TabIndex = 32
        Me.radGuest3Meal4.TabStop = True
        Me.radGuest3Meal4.UseVisualStyleBackColor = True
        '
        'radGuest3Meal3
        '
        Me.radGuest3Meal3.AutoSize = True
        Me.radGuest3Meal3.Location = New System.Drawing.Point(6, 79)
        Me.radGuest3Meal3.Name = "radGuest3Meal3"
        Me.radGuest3Meal3.Size = New System.Drawing.Size(17, 16)
        Me.radGuest3Meal3.TabIndex = 31
        Me.radGuest3Meal3.TabStop = True
        Me.radGuest3Meal3.UseVisualStyleBackColor = True
        '
        'radGuest3Meal2
        '
        Me.radGuest3Meal2.AutoSize = True
        Me.radGuest3Meal2.Location = New System.Drawing.Point(6, 51)
        Me.radGuest3Meal2.Name = "radGuest3Meal2"
        Me.radGuest3Meal2.Size = New System.Drawing.Size(17, 16)
        Me.radGuest3Meal2.TabIndex = 30
        Me.radGuest3Meal2.TabStop = True
        Me.radGuest3Meal2.UseVisualStyleBackColor = True
        '
        'radGuest3Meal1
        '
        Me.radGuest3Meal1.AutoSize = True
        Me.radGuest3Meal1.Location = New System.Drawing.Point(6, 22)
        Me.radGuest3Meal1.Name = "radGuest3Meal1"
        Me.radGuest3Meal1.Size = New System.Drawing.Size(17, 16)
        Me.radGuest3Meal1.TabIndex = 29
        Me.radGuest3Meal1.TabStop = True
        Me.radGuest3Meal1.UseVisualStyleBackColor = True
        '
        'radGuest4Meal4
        '
        Me.radGuest4Meal4.AutoSize = True
        Me.radGuest4Meal4.Location = New System.Drawing.Point(6, 107)
        Me.radGuest4Meal4.Name = "radGuest4Meal4"
        Me.radGuest4Meal4.Size = New System.Drawing.Size(17, 16)
        Me.radGuest4Meal4.TabIndex = 32
        Me.radGuest4Meal4.TabStop = True
        Me.radGuest4Meal4.UseVisualStyleBackColor = True
        '
        'radGuest4Meal3
        '
        Me.radGuest4Meal3.AutoSize = True
        Me.radGuest4Meal3.Location = New System.Drawing.Point(6, 79)
        Me.radGuest4Meal3.Name = "radGuest4Meal3"
        Me.radGuest4Meal3.Size = New System.Drawing.Size(17, 16)
        Me.radGuest4Meal3.TabIndex = 31
        Me.radGuest4Meal3.TabStop = True
        Me.radGuest4Meal3.UseVisualStyleBackColor = True
        '
        'radGuest4Meal2
        '
        Me.radGuest4Meal2.AutoSize = True
        Me.radGuest4Meal2.Location = New System.Drawing.Point(6, 51)
        Me.radGuest4Meal2.Name = "radGuest4Meal2"
        Me.radGuest4Meal2.Size = New System.Drawing.Size(17, 16)
        Me.radGuest4Meal2.TabIndex = 30
        Me.radGuest4Meal2.TabStop = True
        Me.radGuest4Meal2.UseVisualStyleBackColor = True
        '
        'radGuest4Meal1
        '
        Me.radGuest4Meal1.AutoSize = True
        Me.radGuest4Meal1.Location = New System.Drawing.Point(6, 22)
        Me.radGuest4Meal1.Name = "radGuest4Meal1"
        Me.radGuest4Meal1.Size = New System.Drawing.Size(17, 16)
        Me.radGuest4Meal1.TabIndex = 29
        Me.radGuest4Meal1.TabStop = True
        Me.radGuest4Meal1.UseVisualStyleBackColor = True
        '
        'GuestsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 508)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAddGuest)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GuestsForm"
        Me.Text = "Add Guests"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbGuest3Meal.ResumeLayout(False)
        Me.gbGuest3Meal.PerformLayout()
        Me.gbGuest2Meal.ResumeLayout(False)
        Me.gbGuest2Meal.PerformLayout()
        Me.gbGuest4Meal.ResumeLayout(False)
        Me.gbGuest4Meal.PerformLayout()
        Me.gbGuest1Meal.ResumeLayout(False)
        Me.gbGuest1Meal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAddGuest As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gbGuest1Meal As GroupBox
    Friend WithEvents btnSelectMeals As Button
    Friend WithEvents txtGuestsAttending As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCityStateZip As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtStreetAddress As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gbGuest3Meal As GroupBox
    Friend WithEvents gbGuest2Meal As GroupBox
    Friend WithEvents gbGuest4Meal As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents radGuest3Meal4 As RadioButton
    Friend WithEvents radGuest3Meal3 As RadioButton
    Friend WithEvents radGuest3Meal2 As RadioButton
    Friend WithEvents radGuest3Meal1 As RadioButton
    Friend WithEvents radGuest2Meal4 As RadioButton
    Friend WithEvents radGuest2Meal3 As RadioButton
    Friend WithEvents radGuest2Meal2 As RadioButton
    Friend WithEvents radGuest2Meal1 As RadioButton
    Friend WithEvents radGuest4Meal4 As RadioButton
    Friend WithEvents radGuest4Meal3 As RadioButton
    Friend WithEvents radGuest4Meal2 As RadioButton
    Friend WithEvents radGuest4Meal1 As RadioButton
    Friend WithEvents radGuest1Meal4 As RadioButton
    Friend WithEvents radGuest1Meal3 As RadioButton
    Friend WithEvents radGuest1Meal2 As RadioButton
    Friend WithEvents radGuest1Meal1 As RadioButton
End Class
