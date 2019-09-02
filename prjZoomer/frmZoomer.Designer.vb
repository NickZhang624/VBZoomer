<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmZoomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmZoomer))
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.radPm = New System.Windows.Forms.RadioButton()
        Me.grpCustomerDetails = New System.Windows.Forms.GroupBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.cboTitle = New System.Windows.Forms.ComboBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.radAm = New System.Windows.Forms.RadioButton()
        Me.lblPickUpTime = New System.Windows.Forms.Label()
        Me.cboNumberofPeople = New System.Windows.Forms.ComboBox()
        Me.cboTypeofDelivery = New System.Windows.Forms.ComboBox()
        Me.lblTypeofDelivery = New System.Windows.Forms.Label()
        Me.lblPickUpAddress = New System.Windows.Forms.Label()
        Me.txtPickUpAddress = New System.Windows.Forms.TextBox()
        Me.lblDestinationAddress = New System.Windows.Forms.Label()
        Me.txtDestinationAddress = New System.Windows.Forms.TextBox()
        Me.grpSpecialRequirement = New System.Windows.Forms.GroupBox()
        Me.lblSpecialRequirement = New System.Windows.Forms.Label()
        Me.txtSpecialRequirement = New System.Windows.Forms.TextBox()
        Me.lblNumberofPeople = New System.Windows.Forms.Label()
        Me.grpVehicleType = New System.Windows.Forms.GroupBox()
        Me.cboVehicleType = New System.Windows.Forms.ComboBox()
        Me.lblVehicleType = New System.Windows.Forms.Label()
        Me.lblPickUpDate = New System.Windows.Forms.Label()
        Me.dtpPickUpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnPrintAll = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.grpPaymentType = New System.Windows.Forms.GroupBox()
        Me.cboPaymentType = New System.Windows.Forms.ComboBox()
        Me.lblPaymentType = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilePreviousRecord = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNextRecord = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileCreatNewRecord = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveRecord = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileDeleteRecord = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrintAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.picZoomer = New System.Windows.Forms.PictureBox()
        Me.grpDeliveryInformation = New System.Windows.Forms.GroupBox()
        Me.dtpPickUpTime = New System.Windows.Forms.DateTimePicker()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.grpCustomerDetails.SuspendLayout()
        Me.grpSpecialRequirement.SuspendLayout()
        Me.grpVehicleType.SuspendLayout()
        Me.grpPaymentType.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picZoomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDeliveryInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(455, 85)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(359, 29)
        Me.txtEmail.TabIndex = 20
        Me.txtEmail.Tag = "c"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.BackColor = System.Drawing.Color.White
        Me.txtContactNumber.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.Location = New System.Drawing.Point(169, 88)
        Me.txtContactNumber.Multiline = True
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(175, 29)
        Me.txtContactNumber.TabIndex = 10
        Me.txtContactNumber.Tag = "c"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.White
        Me.txtLastName.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(647, 33)
        Me.txtLastName.Multiline = True
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(167, 27)
        Me.txtLastName.TabIndex = 8
        Me.txtLastName.Tag = "c"
        '
        'radPm
        '
        Me.radPm.AutoSize = True
        Me.radPm.Location = New System.Drawing.Point(714, 142)
        Me.radPm.Name = "radPm"
        Me.radPm.Size = New System.Drawing.Size(51, 23)
        Me.radPm.TabIndex = 36
        Me.radPm.Tag = "c"
        Me.radPm.Text = "PM"
        Me.radPm.UseVisualStyleBackColor = True
        '
        'grpCustomerDetails
        '
        Me.grpCustomerDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpCustomerDetails.Controls.Add(Me.txtEmail)
        Me.grpCustomerDetails.Controls.Add(Me.lblEmail)
        Me.grpCustomerDetails.Controls.Add(Me.txtContactNumber)
        Me.grpCustomerDetails.Controls.Add(Me.cboTitle)
        Me.grpCustomerDetails.Controls.Add(Me.txtLastName)
        Me.grpCustomerDetails.Controls.Add(Me.txtFirstName)
        Me.grpCustomerDetails.Controls.Add(Me.lblContactNumber)
        Me.grpCustomerDetails.Controls.Add(Me.lblLastName)
        Me.grpCustomerDetails.Controls.Add(Me.lblFirstName)
        Me.grpCustomerDetails.Controls.Add(Me.lblTitle)
        Me.grpCustomerDetails.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCustomerDetails.ForeColor = System.Drawing.Color.White
        Me.grpCustomerDetails.Location = New System.Drawing.Point(31, 93)
        Me.grpCustomerDetails.Name = "grpCustomerDetails"
        Me.grpCustomerDetails.Size = New System.Drawing.Size(834, 140)
        Me.grpCustomerDetails.TabIndex = 55
        Me.grpCustomerDetails.TabStop = False
        Me.grpCustomerDetails.Tag = "c"
        Me.grpCustomerDetails.Text = "Customer Details"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(392, 95)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(63, 19)
        Me.lblEmail.TabIndex = 19
        Me.lblEmail.Tag = "c"
        Me.lblEmail.Text = "*Email:"
        '
        'cboTitle
        '
        Me.cboTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTitle.FormattingEnabled = True
        Me.cboTitle.Items.AddRange(New Object() {"Mr", "Mrs", "Ms"})
        Me.cboTitle.Location = New System.Drawing.Point(70, 38)
        Me.cboTitle.Name = "cboTitle"
        Me.cboTitle.Size = New System.Drawing.Size(127, 27)
        Me.cboTitle.TabIndex = 9
        Me.cboTitle.Tag = "c"
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.White
        Me.txtFirstName.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(341, 34)
        Me.txtFirstName.Multiline = True
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(161, 27)
        Me.txtFirstName.TabIndex = 7
        Me.txtFirstName.Tag = "c"
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Location = New System.Drawing.Point(17, 98)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(146, 19)
        Me.lblContactNumber.TabIndex = 4
        Me.lblContactNumber.Tag = "c"
        Me.lblContactNumber.Text = "*Contact Number:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(539, 41)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(102, 19)
        Me.lblLastName.TabIndex = 3
        Me.lblLastName.Tag = "c"
        Me.lblLastName.Text = "*Last Name:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(232, 41)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(103, 19)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Tag = "c"
        Me.lblFirstName.Text = "*First Name:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(17, 46)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(53, 19)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Tag = "c"
        Me.lblTitle.Text = "*Title:"
        '
        'radAm
        '
        Me.radAm.AutoSize = True
        Me.radAm.Location = New System.Drawing.Point(647, 143)
        Me.radAm.Name = "radAm"
        Me.radAm.Size = New System.Drawing.Size(51, 23)
        Me.radAm.TabIndex = 35
        Me.radAm.Tag = "c"
        Me.radAm.Text = "AM"
        Me.radAm.UseVisualStyleBackColor = True
        '
        'lblPickUpTime
        '
        Me.lblPickUpTime.AutoSize = True
        Me.lblPickUpTime.Location = New System.Drawing.Point(383, 146)
        Me.lblPickUpTime.Name = "lblPickUpTime"
        Me.lblPickUpTime.Size = New System.Drawing.Size(113, 19)
        Me.lblPickUpTime.TabIndex = 25
        Me.lblPickUpTime.Tag = "c"
        Me.lblPickUpTime.Text = "Pick up Time:"
        '
        'cboNumberofPeople
        '
        Me.cboNumberofPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboNumberofPeople.FormattingEnabled = True
        Me.cboNumberofPeople.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10+"})
        Me.cboNumberofPeople.Location = New System.Drawing.Point(543, 191)
        Me.cboNumberofPeople.Name = "cboNumberofPeople"
        Me.cboNumberofPeople.Size = New System.Drawing.Size(104, 27)
        Me.cboNumberofPeople.TabIndex = 24
        Me.cboNumberofPeople.Tag = "c"
        '
        'cboTypeofDelivery
        '
        Me.cboTypeofDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTypeofDelivery.FormattingEnabled = True
        Me.cboTypeofDelivery.Items.AddRange(New Object() {"People", "Parcel", "Food"})
        Me.cboTypeofDelivery.Location = New System.Drawing.Point(169, 191)
        Me.cboTypeofDelivery.Name = "cboTypeofDelivery"
        Me.cboTypeofDelivery.Size = New System.Drawing.Size(156, 27)
        Me.cboTypeofDelivery.TabIndex = 22
        Me.cboTypeofDelivery.Tag = "c"
        '
        'lblTypeofDelivery
        '
        Me.lblTypeofDelivery.AutoSize = True
        Me.lblTypeofDelivery.Location = New System.Drawing.Point(6, 196)
        Me.lblTypeofDelivery.Name = "lblTypeofDelivery"
        Me.lblTypeofDelivery.Size = New System.Drawing.Size(143, 19)
        Me.lblTypeofDelivery.TabIndex = 21
        Me.lblTypeofDelivery.Tag = "c"
        Me.lblTypeofDelivery.Text = "*Type of Delivery:"
        '
        'lblPickUpAddress
        '
        Me.lblPickUpAddress.AutoSize = True
        Me.lblPickUpAddress.Location = New System.Drawing.Point(6, 47)
        Me.lblPickUpAddress.Name = "lblPickUpAddress"
        Me.lblPickUpAddress.Size = New System.Drawing.Size(146, 19)
        Me.lblPickUpAddress.TabIndex = 11
        Me.lblPickUpAddress.Tag = "c"
        Me.lblPickUpAddress.Text = "*Pick-up Address:"
        '
        'txtPickUpAddress
        '
        Me.txtPickUpAddress.BackColor = System.Drawing.Color.White
        Me.txtPickUpAddress.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPickUpAddress.Location = New System.Drawing.Point(153, 37)
        Me.txtPickUpAddress.Multiline = True
        Me.txtPickUpAddress.Name = "txtPickUpAddress"
        Me.txtPickUpAddress.Size = New System.Drawing.Size(661, 29)
        Me.txtPickUpAddress.TabIndex = 12
        Me.txtPickUpAddress.Tag = "c"
        '
        'lblDestinationAddress
        '
        Me.lblDestinationAddress.AutoSize = True
        Me.lblDestinationAddress.Location = New System.Drawing.Point(6, 100)
        Me.lblDestinationAddress.Name = "lblDestinationAddress"
        Me.lblDestinationAddress.Size = New System.Drawing.Size(175, 19)
        Me.lblDestinationAddress.TabIndex = 13
        Me.lblDestinationAddress.Tag = "c"
        Me.lblDestinationAddress.Text = "*Destination Address:"
        '
        'txtDestinationAddress
        '
        Me.txtDestinationAddress.BackColor = System.Drawing.Color.White
        Me.txtDestinationAddress.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestinationAddress.Location = New System.Drawing.Point(182, 90)
        Me.txtDestinationAddress.Multiline = True
        Me.txtDestinationAddress.Name = "txtDestinationAddress"
        Me.txtDestinationAddress.Size = New System.Drawing.Size(632, 29)
        Me.txtDestinationAddress.TabIndex = 14
        Me.txtDestinationAddress.Tag = "c"
        '
        'grpSpecialRequirement
        '
        Me.grpSpecialRequirement.Controls.Add(Me.lblSpecialRequirement)
        Me.grpSpecialRequirement.Controls.Add(Me.txtSpecialRequirement)
        Me.grpSpecialRequirement.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.grpSpecialRequirement.ForeColor = System.Drawing.Color.White
        Me.grpSpecialRequirement.Location = New System.Drawing.Point(427, 504)
        Me.grpSpecialRequirement.Name = "grpSpecialRequirement"
        Me.grpSpecialRequirement.Size = New System.Drawing.Size(438, 211)
        Me.grpSpecialRequirement.TabIndex = 66
        Me.grpSpecialRequirement.TabStop = False
        Me.grpSpecialRequirement.Tag = "c"
        '
        'lblSpecialRequirement
        '
        Me.lblSpecialRequirement.AutoSize = True
        Me.lblSpecialRequirement.Location = New System.Drawing.Point(28, 22)
        Me.lblSpecialRequirement.Name = "lblSpecialRequirement"
        Me.lblSpecialRequirement.Size = New System.Drawing.Size(179, 19)
        Me.lblSpecialRequirement.TabIndex = 19
        Me.lblSpecialRequirement.Tag = "c"
        Me.lblSpecialRequirement.Text = "*Special Requirement:"
        '
        'txtSpecialRequirement
        '
        Me.txtSpecialRequirement.Location = New System.Drawing.Point(32, 59)
        Me.txtSpecialRequirement.Multiline = True
        Me.txtSpecialRequirement.Name = "txtSpecialRequirement"
        Me.txtSpecialRequirement.Size = New System.Drawing.Size(372, 134)
        Me.txtSpecialRequirement.TabIndex = 20
        Me.txtSpecialRequirement.Tag = "c"
        '
        'lblNumberofPeople
        '
        Me.lblNumberofPeople.AutoSize = True
        Me.lblNumberofPeople.Location = New System.Drawing.Point(380, 196)
        Me.lblNumberofPeople.Name = "lblNumberofPeople"
        Me.lblNumberofPeople.Size = New System.Drawing.Size(158, 19)
        Me.lblNumberofPeople.TabIndex = 23
        Me.lblNumberofPeople.Tag = "c"
        Me.lblNumberofPeople.Text = "*Number of People:"
        '
        'grpVehicleType
        '
        Me.grpVehicleType.Controls.Add(Me.cboVehicleType)
        Me.grpVehicleType.Controls.Add(Me.lblVehicleType)
        Me.grpVehicleType.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.grpVehicleType.ForeColor = System.Drawing.Color.White
        Me.grpVehicleType.Location = New System.Drawing.Point(31, 504)
        Me.grpVehicleType.Name = "grpVehicleType"
        Me.grpVehicleType.Size = New System.Drawing.Size(352, 96)
        Me.grpVehicleType.TabIndex = 64
        Me.grpVehicleType.TabStop = False
        Me.grpVehicleType.Tag = "c"
        '
        'cboVehicleType
        '
        Me.cboVehicleType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboVehicleType.FormattingEnabled = True
        Me.cboVehicleType.Items.AddRange(New Object() {"Seden", "Station Wagon", "Van", "Truck"})
        Me.cboVehicleType.Location = New System.Drawing.Point(143, 37)
        Me.cboVehicleType.Name = "cboVehicleType"
        Me.cboVehicleType.Size = New System.Drawing.Size(156, 27)
        Me.cboVehicleType.TabIndex = 31
        Me.cboVehicleType.Tag = "c"
        '
        'lblVehicleType
        '
        Me.lblVehicleType.AutoSize = True
        Me.lblVehicleType.Location = New System.Drawing.Point(10, 45)
        Me.lblVehicleType.Name = "lblVehicleType"
        Me.lblVehicleType.Size = New System.Drawing.Size(117, 19)
        Me.lblVehicleType.TabIndex = 26
        Me.lblVehicleType.Tag = "c"
        Me.lblVehicleType.Text = "*Vehicle Type:"
        '
        'lblPickUpDate
        '
        Me.lblPickUpDate.AutoSize = True
        Me.lblPickUpDate.Location = New System.Drawing.Point(6, 147)
        Me.lblPickUpDate.Name = "lblPickUpDate"
        Me.lblPickUpDate.Size = New System.Drawing.Size(115, 19)
        Me.lblPickUpDate.TabIndex = 15
        Me.lblPickUpDate.Tag = "c"
        Me.lblPickUpDate.Text = "Pick up Date :"
        '
        'dtpPickUpDate
        '
        Me.dtpPickUpDate.AllowDrop = True
        Me.dtpPickUpDate.Checked = False
        Me.dtpPickUpDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpPickUpDate.CustomFormat = "yyyy/MM/dd"
        Me.dtpPickUpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPickUpDate.Location = New System.Drawing.Point(143, 141)
        Me.dtpPickUpDate.Name = "dtpPickUpDate"
        Me.dtpPickUpDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpPickUpDate.Size = New System.Drawing.Size(182, 26)
        Me.dtpPickUpDate.TabIndex = 5
        Me.dtpPickUpDate.Tag = ""
        Me.dtpPickUpDate.Value = New Date(2018, 9, 11, 0, 0, 0, 0)
        '
        'btnPrintAll
        '
        Me.btnPrintAll.BackColor = System.Drawing.Color.White
        Me.btnPrintAll.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrintAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPrintAll.Location = New System.Drawing.Point(790, 730)
        Me.btnPrintAll.Name = "btnPrintAll"
        Me.btnPrintAll.Size = New System.Drawing.Size(75, 29)
        Me.btnPrintAll.TabIndex = 67
        Me.btnPrintAll.Tag = "c"
        Me.btnPrintAll.Text = "Print &All"
        Me.btnPrintAll.UseVisualStyleBackColor = False
        '
        'grpPaymentType
        '
        Me.grpPaymentType.Controls.Add(Me.cboPaymentType)
        Me.grpPaymentType.Controls.Add(Me.lblPaymentType)
        Me.grpPaymentType.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.grpPaymentType.ForeColor = System.Drawing.Color.White
        Me.grpPaymentType.Location = New System.Drawing.Point(31, 620)
        Me.grpPaymentType.Name = "grpPaymentType"
        Me.grpPaymentType.Size = New System.Drawing.Size(352, 95)
        Me.grpPaymentType.TabIndex = 65
        Me.grpPaymentType.TabStop = False
        Me.grpPaymentType.Tag = "c"
        '
        'cboPaymentType
        '
        Me.cboPaymentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPaymentType.FormattingEnabled = True
        Me.cboPaymentType.Items.AddRange(New Object() {"Cash", "Credit", "Eftpos"})
        Me.cboPaymentType.Location = New System.Drawing.Point(143, 32)
        Me.cboPaymentType.Name = "cboPaymentType"
        Me.cboPaymentType.Size = New System.Drawing.Size(156, 27)
        Me.cboPaymentType.TabIndex = 32
        Me.cboPaymentType.Tag = "c"
        '
        'lblPaymentType
        '
        Me.lblPaymentType.AutoSize = True
        Me.lblPaymentType.Location = New System.Drawing.Point(8, 40)
        Me.lblPaymentType.Name = "lblPaymentType"
        Me.lblPaymentType.Size = New System.Drawing.Size(129, 19)
        Me.lblPaymentType.TabIndex = 31
        Me.lblPaymentType.Tag = "c"
        Me.lblPaymentType.Text = "*Payment Type:"
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.White
        Me.btnPrevious.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrevious.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPrevious.Location = New System.Drawing.Point(31, 730)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(99, 29)
        Me.btnPrevious.TabIndex = 61
        Me.btnPrevious.Tag = "c"
        Me.btnPrevious.Text = "&Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.White
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPrint.Location = New System.Drawing.Point(709, 730)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 29)
        Me.btnPrint.TabIndex = 60
        Me.btnPrint.Tag = "c"
        Me.btnPrint.Text = "P&rint"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'BtnCreate
        '
        Me.BtnCreate.BackColor = System.Drawing.Color.White
        Me.BtnCreate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCreate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCreate.Location = New System.Drawing.Point(326, 730)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(75, 29)
        Me.BtnCreate.TabIndex = 59
        Me.BtnCreate.Tag = "c"
        Me.BtnCreate.Text = "&Create"
        Me.BtnCreate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(488, 730)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 29)
        Me.btnDelete.TabIndex = 58
        Me.btnDelete.Tag = "c"
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(407, 730)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 29)
        Me.btnSave.TabIndex = 57
        Me.btnSave.Tag = "c"
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowDrop = True
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.mnuPrint, Me.mnuPrintAll, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(908, 27)
        Me.MenuStrip1.TabIndex = 62
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFilePreviousRecord, Me.mnuFileNextRecord, Me.mnuFileCreatNewRecord, Me.mnuFileSaveRecord, Me.mnuFileDeleteRecord})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(48, 23)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuFilePreviousRecord
        '
        Me.mnuFilePreviousRecord.BackColor = System.Drawing.Color.White
        Me.mnuFilePreviousRecord.ForeColor = System.Drawing.Color.Black
        Me.mnuFilePreviousRecord.Name = "mnuFilePreviousRecord"
        Me.mnuFilePreviousRecord.Size = New System.Drawing.Size(226, 24)
        Me.mnuFilePreviousRecord.Text = "&Previous Record"
        '
        'mnuFileNextRecord
        '
        Me.mnuFileNextRecord.BackColor = System.Drawing.Color.White
        Me.mnuFileNextRecord.ForeColor = System.Drawing.Color.Black
        Me.mnuFileNextRecord.Name = "mnuFileNextRecord"
        Me.mnuFileNextRecord.Size = New System.Drawing.Size(226, 24)
        Me.mnuFileNextRecord.Text = "&Next Record"
        '
        'mnuFileCreatNewRecord
        '
        Me.mnuFileCreatNewRecord.Name = "mnuFileCreatNewRecord"
        Me.mnuFileCreatNewRecord.Size = New System.Drawing.Size(226, 24)
        Me.mnuFileCreatNewRecord.Text = "&Create New Record"
        '
        'mnuFileSaveRecord
        '
        Me.mnuFileSaveRecord.Name = "mnuFileSaveRecord"
        Me.mnuFileSaveRecord.Size = New System.Drawing.Size(226, 24)
        Me.mnuFileSaveRecord.Text = "&Save Record"
        '
        'mnuFileDeleteRecord
        '
        Me.mnuFileDeleteRecord.Name = "mnuFileDeleteRecord"
        Me.mnuFileDeleteRecord.Size = New System.Drawing.Size(226, 24)
        Me.mnuFileDeleteRecord.Text = "&Delete Record"
        '
        'mnuPrint
        '
        Me.mnuPrint.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.Size = New System.Drawing.Size(57, 23)
        Me.mnuPrint.Text = "&Print"
        '
        'mnuPrintAll
        '
        Me.mnuPrintAll.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.mnuPrintAll.Name = "mnuPrintAll"
        Me.mnuPrintAll.Size = New System.Drawing.Size(79, 23)
        Me.mnuPrintAll.Text = "Print &All"
        '
        'mnuExit
        '
        Me.mnuExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.mnuExit.ForeColor = System.Drawing.Color.Black
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(50, 23)
        Me.mnuExit.Text = "&Exit"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.White
        Me.btnNext.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNext.Location = New System.Drawing.Point(137, 730)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 29)
        Me.btnNext.TabIndex = 63
        Me.btnNext.Tag = "c"
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'picZoomer
        '
        Me.picZoomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picZoomer.Image = CType(resources.GetObject("picZoomer.Image"), System.Drawing.Image)
        Me.picZoomer.ImageLocation = ""
        Me.picZoomer.Location = New System.Drawing.Point(346, 38)
        Me.picZoomer.Name = "picZoomer"
        Me.picZoomer.Size = New System.Drawing.Size(187, 71)
        Me.picZoomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picZoomer.TabIndex = 54
        Me.picZoomer.TabStop = False
        Me.picZoomer.Tag = "c"
        '
        'grpDeliveryInformation
        '
        Me.grpDeliveryInformation.Controls.Add(Me.dtpPickUpTime)
        Me.grpDeliveryInformation.Controls.Add(Me.radPm)
        Me.grpDeliveryInformation.Controls.Add(Me.radAm)
        Me.grpDeliveryInformation.Controls.Add(Me.lblPickUpTime)
        Me.grpDeliveryInformation.Controls.Add(Me.cboNumberofPeople)
        Me.grpDeliveryInformation.Controls.Add(Me.lblNumberofPeople)
        Me.grpDeliveryInformation.Controls.Add(Me.cboTypeofDelivery)
        Me.grpDeliveryInformation.Controls.Add(Me.lblTypeofDelivery)
        Me.grpDeliveryInformation.Controls.Add(Me.lblPickUpAddress)
        Me.grpDeliveryInformation.Controls.Add(Me.txtPickUpAddress)
        Me.grpDeliveryInformation.Controls.Add(Me.lblDestinationAddress)
        Me.grpDeliveryInformation.Controls.Add(Me.txtDestinationAddress)
        Me.grpDeliveryInformation.Controls.Add(Me.lblPickUpDate)
        Me.grpDeliveryInformation.Controls.Add(Me.dtpPickUpDate)
        Me.grpDeliveryInformation.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.grpDeliveryInformation.ForeColor = System.Drawing.Color.White
        Me.grpDeliveryInformation.Location = New System.Drawing.Point(31, 254)
        Me.grpDeliveryInformation.Name = "grpDeliveryInformation"
        Me.grpDeliveryInformation.Size = New System.Drawing.Size(834, 232)
        Me.grpDeliveryInformation.TabIndex = 56
        Me.grpDeliveryInformation.TabStop = False
        Me.grpDeliveryInformation.Tag = "c"
        Me.grpDeliveryInformation.Text = "Delivery Information"
        '
        'dtpPickUpTime
        '
        Me.dtpPickUpTime.CustomFormat = "hh:mm"
        Me.dtpPickUpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPickUpTime.Location = New System.Drawing.Point(543, 140)
        Me.dtpPickUpTime.MaxDate = New Date(2020, 4, 24, 0, 0, 0, 0)
        Me.dtpPickUpTime.MinDate = New Date(1991, 11, 9, 0, 0, 0, 0)
        Me.dtpPickUpTime.Name = "dtpPickUpTime"
        Me.dtpPickUpTime.ShowUpDown = True
        Me.dtpPickUpTime.Size = New System.Drawing.Size(87, 26)
        Me.dtpPickUpTime.TabIndex = 37
        Me.dtpPickUpTime.Value = New Date(2018, 11, 9, 12, 59, 0, 0)
        '
        'PrintDialog1
        '
        Me.PrintDialog1.AllowCurrentPage = True
        Me.PrintDialog1.AllowSelection = True
        Me.PrintDialog1.AllowSomePages = True
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomer.ForeColor = System.Drawing.Color.Red
        Me.lblCustomer.Location = New System.Drawing.Point(619, 71)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(110, 19)
        Me.lblCustomer.TabIndex = 68
        Me.lblCustomer.Tag = "c"
        Me.lblCustomer.Text = "Customer ID:"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCustomerID.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.ForeColor = System.Drawing.Color.Red
        Me.txtCustomerID.Location = New System.Drawing.Point(735, 63)
        Me.txtCustomerID.Multiline = True
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(130, 27)
        Me.txtCustomerID.TabIndex = 69
        Me.txtCustomerID.Tag = "c"
        '
        'frmZoomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(908, 774)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.grpCustomerDetails)
        Me.Controls.Add(Me.grpSpecialRequirement)
        Me.Controls.Add(Me.grpVehicleType)
        Me.Controls.Add(Me.btnPrintAll)
        Me.Controls.Add(Me.grpPaymentType)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.picZoomer)
        Me.Controls.Add(Me.grpDeliveryInformation)
        Me.Name = "frmZoomer"
        Me.Text = "Zoomer"
        Me.grpCustomerDetails.ResumeLayout(False)
        Me.grpCustomerDetails.PerformLayout()
        Me.grpSpecialRequirement.ResumeLayout(False)
        Me.grpSpecialRequirement.PerformLayout()
        Me.grpVehicleType.ResumeLayout(False)
        Me.grpVehicleType.PerformLayout()
        Me.grpPaymentType.ResumeLayout(False)
        Me.grpPaymentType.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picZoomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDeliveryInformation.ResumeLayout(False)
        Me.grpDeliveryInformation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents radPm As RadioButton
    Friend WithEvents grpCustomerDetails As GroupBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents cboTitle As ComboBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents radAm As RadioButton
    Friend WithEvents lblPickUpTime As Label
    Friend WithEvents cboNumberofPeople As ComboBox
    Friend WithEvents cboTypeofDelivery As ComboBox
    Friend WithEvents lblTypeofDelivery As Label
    Friend WithEvents lblPickUpAddress As Label
    Friend WithEvents txtPickUpAddress As TextBox
    Friend WithEvents lblDestinationAddress As Label
    Friend WithEvents txtDestinationAddress As TextBox
    Friend WithEvents grpSpecialRequirement As GroupBox
    Friend WithEvents lblSpecialRequirement As Label
    Friend WithEvents txtSpecialRequirement As TextBox
    Friend WithEvents lblNumberofPeople As Label
    Friend WithEvents grpVehicleType As GroupBox
    Friend WithEvents lblVehicleType As Label
    Friend WithEvents lblPickUpDate As Label
    Friend WithEvents dtpPickUpDate As DateTimePicker
    Friend WithEvents btnPrintAll As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents grpPaymentType As GroupBox
    Friend WithEvents lblPaymentType As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents BtnCreate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuFilePreviousRecord As ToolStripMenuItem
    Friend WithEvents mnuFileNextRecord As ToolStripMenuItem
    Friend WithEvents mnuFileCreatNewRecord As ToolStripMenuItem
    Friend WithEvents mnuFileSaveRecord As ToolStripMenuItem
    Friend WithEvents mnuFileDeleteRecord As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuPrint As ToolStripMenuItem
    Friend WithEvents mnuPrintAll As ToolStripMenuItem
    Friend WithEvents btnNext As Button
    Friend WithEvents picZoomer As PictureBox
    Friend WithEvents grpDeliveryInformation As GroupBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents lblCustomer As Label
    Friend WithEvents cboVehicleType As ComboBox
    Friend WithEvents cboPaymentType As ComboBox
    Friend WithEvents txtCustomerID As TextBox
    Public WithEvents dtpPickUpTime As DateTimePicker
End Class
