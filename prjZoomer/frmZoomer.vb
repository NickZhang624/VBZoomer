Public Class frmZoomer
    'Name: Nick Zhang
    'Date: 26 Oct 2018
    'Purpose: This is software development assignment Part 2, design for Zoomer

    'Delcare those global variables
    'This is connection variable
    Dim con As New OleDb.OleDbConnection
    'Delcare the dbprovider as a string variable to hold the dbprovider information
    Dim dbProvider As String
    'Delcare the dbsource as a string variable to hold the dbsource information
    Dim dbSource As String
    'Delcare the sql as string variable
    Dim sql As String

    'Delcare the dataset and dataadapotor variable
    'Delcare the ds as a variable to hold the dataset information
    Dim ds As New DataSet
    'Delcare the da a variable to hold the dataadaptor information
    Dim da As OleDb.OleDbDataAdapter

    'Delcare the program variable
    'Delcare the inc as a integer variable for incrementing thru records
    Dim inc As Integer
    'Delcare the intMaxRows as a integer variable for holding the total number of records
    Dim intMaxRows As Integer


    Private Sub prjZoomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'To fill the provider variable with OLEDB info
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        'To fill the source variable with the path to the database
        dbSource = "Data Source=" & Application.StartupPath & "\ZoomerCustomers.accdb"

        'To fill the connection string variable by dbprovider and dbsource
        con.ConnectionString = dbProvider & dbSource

        'Open the database by con.connectionstring information
        con.Open()
        'Show the msgbox since above connect successfully
        MsgBox("Customers data loading ... ...", MsgBoxStyle.Exclamation, "Notice")

        'This is sql statement to retrieve all records been selected from the tblFileName
        sql = "SELECT * FROM tblCustomers"

        'Dataadaptor will retrieve all sql records has been hold from con 
        'which is the connectiton to the database(FileName.accdb)
        da = New OleDb.OleDbDataAdapter(sql, con)

        'Dataadaptor hold all records to fill dataset
        da.Fill(ds, "ZoomerCustomers")

        'The connection to the database is been closed since the dataset been filled
        con.Close()
        'Show the message box all connection been connected
        MsgBox("ALL data loading finished", MsgBoxStyle.Exclamation, "Notice")

        'Counts how many rows in this tables from dataset 
        intMaxRows = ds.Tables("ZoomerCustomers").Rows.Count

        'Means increment variable, it can constantly increment up and down
        '0 means first rows (0) will show when user executed the procedure
        inc = 0

        'This is sub procedure to display the record from dataset which these form controls
        Call DisplayRecord()

    End Sub

    'This is sub procedure to display data from dataset what hold from database
    Private Sub DisplayRecord()

        'textbox or rad button get data from dataset
        'As inc=0 means records display start from row(0) and items from 0 to 15 
        txtCustomerID.Text = ds.Tables("ZoomerCustomers").Rows(inc).Item(0)
        cboTitle.Text = ds.Tables("ZoomerCustomers").Rows(inc).Item(1)
        txtFirstName.Text = ds.Tables("ZoomerCustomers").Rows(inc).Item(2)
        txtLastName.Text = ds.Tables("ZoomerCustomers").Rows(inc).Item(3)
        txtContactNumber.Text = ds.Tables("ZoomerCustomers").Rows(inc).Item(4)
        txtEmail.Text = ds.Tables("ZoomerCustomers").Rows(inc).Item(5)
        txtPickUpAddress.Text = ds.Tables("ZoomerCustomers").Rows(inc).Item(6)
        txtDestinationAddress.Text = ds.Tables("ZoomerCustomers").Rows(inc).Item(7)
        radAm.Checked = ds.Tables("ZoomerCustomers").Rows(inc).Item(8)
        'This code to check YesorNo from database, if one of two been selected
        'then display selected records, vice versa
        If radAm.Checked = False Then
            radPm.Checked = True
        End If
        cboTypeofDelivery.Text = ds.Tables("ZoomerCustomers").Rows(inc).Item(9)
        cboNumberofPeople.Text = ds.Tables("ZoomerCustomers").Rows(inc).Item(10)
        cboVehicleType.Text = ds.Tables("ZoomerCustomers").Rows(inc).Item(11)
        cboPaymentType.Text = ds.Tables("ZoomerCustomers").Rows(inc).Item(12)
        txtSpecialRequirement.Text = ds.Tables("ZoomerCustomers").Rows(inc).Item(13)
        dtpPickUpDate.Text = ds.Tables("ZoomerCustomers").Rows(inc).Item(14)
        dtpPickUpTime.Text = ds.Tables("ZoomerCustomers").Rows(inc).Item(15)

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Set if statement to declare (inc not equal maxrow - 1) which means not the last records
        If inc <> intMaxRows - 1 Then
            ' This code to executed if the records increment and able to get the next data
            inc = inc + 1
            'This is sub procedure to display the record from dataset which these form controls
            Call DisplayRecord()
        Else
            'If inc equal to -1, means this is last records
            'so msgbox display
            MsgBox("This is last Record", MsgBoxStyle.Exclamation, "Alert")
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        'Set if statement to declare (inc = 0) which means this is first records, so any records if greater then 0 
        If inc > 0 Then
            'This code means if the decrement data and able to get the previous records
            inc = inc - 1
            'This is sub procedure to display the record from dataset which these form controls
            Call DisplayRecord()
        Else
            'If inc equal to 0, means this is first records
            'so msgbox display
            MsgBox("This is First Record", MsgBoxStyle.Exclamation, "Alert")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Declare the commanbuilder which build SQL statement to update the database
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        'Update the form data to dateset
        'Use if statement to set data in the text box if it is null value or empty
        If String.IsNullOrEmpty(cboTitle.Text.ToString()) Then
            'Change the cbo box backcolor to remind user need data input
            cboTitle.BackColor = Color.Yellow
            'Also display msgbox 
            MsgBox("Please choose the customer Title!", MsgBoxStyle.Exclamation, "Error")
            'return means back to beginning from if statement until data in the
            'cbo box is not null or empty
            Return
        End If

        'Use if statement to set data in the text box if it is null value or empty
        If String.IsNullOrEmpty(txtFirstName.Text.ToString()) Then

            'Change the text box backcolor to remind user need data input
            txtFirstName.BackColor = Color.Yellow
            'Also display msgbox 
            MsgBox("Please enter the Firstname!", MsgBoxStyle.Exclamation, "Error")
            'return means back to beginning from if statement until data in the
            'text box is not null or empty
            Return
        End If

        'Use if statement to set data in the text box if it is null value or empty
        If String.IsNullOrEmpty(txtLastName.Text.ToString()) Then

            'Change the text box backcolor to remind user need data input
            txtLastName.BackColor = Color.Yellow
            'Also display msgbox 
            MsgBox("Please enter the Lastname!", MsgBoxStyle.Exclamation, "Error")
            'return means back to beginning from if statement until data in the
            'text box is not null or empty
            Return
        End If

        'Use if statement to set data in the text box if it is null value or empty
        If String.IsNullOrEmpty(txtContactNumber.Text.ToString()) Then

            'Change the text box backcolor to remind user need data input
            txtContactNumber.BackColor = Color.Yellow
            'Also display msgbox 
            MsgBox("Please enter the customer Contact number!", MsgBoxStyle.Exclamation, "Error")
            'return means back to beginning from if statement until data in the
            'text box is not null or empty
            Return
        End If

        'Use if statement to set data in the text box if it is null value or empty
        If String.IsNullOrEmpty(txtEmail.Text.ToString()) Then

            'Change the text box backcolor to remind user need data input
            txtEmail.BackColor = Color.Yellow
            'Also display msgbox 
            MsgBox("Please enter the customer Email address!", MsgBoxStyle.Exclamation, "Error")
            'return means back to beginning from if statement until data in the
            'text box is not null or empty
            Return
        End If

        'Use if statement to set data in the text box if it is null value or empty
        If String.IsNullOrEmpty(txtPickUpAddress.Text.ToString()) Then

            'Change the text box backcolor to remind user need data input
            txtPickUpAddress.BackColor = Color.Yellow
            'Also display msgbox 
            MsgBox("Please enter the pick up address!", MsgBoxStyle.Exclamation, "Error")
            'return means back to beginning from if statement until data in the
            'text box is not null or empty
            Return
        End If

        'Use if statement to set data in the text box if it is null value or empty
        If String.IsNullOrEmpty(txtDestinationAddress.Text.ToString()) Then

            'Change the text box backcolor to remind user need data input
            txtDestinationAddress.BackColor = Color.Yellow
            'Also display msgbox 
            MsgBox("Please enter the destination address!", MsgBoxStyle.Exclamation, "Error")
            'return means back to beginning from if statement until data in the
            'text box is not null or empty
            Return
        End If

        'Use if statement to set data in the text box if it is null value or empty
        If String.IsNullOrEmpty(cboTypeofDelivery.Text.ToString()) Then

            'Change the cbo box backcolor to remind user need data input
            cboTypeofDelivery.BackColor = Color.Yellow
            'Also display msgbox 
            MsgBox("Please choose type of delivery!", MsgBoxStyle.Exclamation, "Error")
            'return means back to beginning from if statement until data in the
            'cbo box is not null or empty
            Return
        End If

        'Use if statement to set data in the text box if it is null value or empty
        If String.IsNullOrEmpty(cboNumberofPeople.Text.ToString()) Then

            'Change the cbo box backcolor to remind user need data input
            cboNumberofPeople.BackColor = Color.Yellow
            'Also display msgbox 
            MsgBox("Please choose number of people, if delivery item is Food or Parcel choose '0' to continue", MsgBoxStyle.Exclamation, "Error")
            'return means back to beginning from if statement until data in the
            'cbo box is not null or empty
            Return
        End If

        'Use if statement to set data in the text box if it is null value or empty
        If String.IsNullOrEmpty(cboVehicleType.Text.ToString()) Then

            'Change the cbo box backcolor to remind user need data input
            cboVehicleType.BackColor = Color.Yellow
            'Also display msgbox 
            MsgBox("Please choose vehicle type!", MsgBoxStyle.Exclamation, "Error")
            'return means back to beginning from if statement until data in the
            'cbo box is not null or empty
            Return
        End If

        'Use if statement to set data in the text box if it is null value or empty
        If String.IsNullOrEmpty(cboPaymentType.Text.ToString()) Then

            'Change the cbo box backcolor to remind user need data input
            cboPaymentType.BackColor = Color.Yellow
            'Also display msgbox 
            MsgBox("Please choose type of payment!", MsgBoxStyle.Exclamation, "Error")
            'return means back to beginning from if statement until data in the
            'cbo box is not null or empty
            Return
        End If

        'Use if statement to set data in the text box if it is null value or empty
        If String.IsNullOrEmpty(txtSpecialRequirement.Text.ToString()) Then

            'Change the text box backcolor to remind user need data input
            txtSpecialRequirement.BackColor = Color.Yellow
            'Also display msgbox 
            MsgBox("Please enter special requirement, if nothing just enter NONE to continue!", MsgBoxStyle.Exclamation, "Error")
            'return means back to beginning from if statement until data in the
            'text box is not null or empty
            Return
        End If

        'As previuos null value would show yellow color fill the text box
        'So change to normal color after data value filled 
        cboTitle.BackColor = Color.White
        txtFirstName.BackColor = Color.White
        txtLastName.BackColor = Color.White
        txtContactNumber.BackColor = Color.White
        txtEmail.BackColor = Color.White
        txtPickUpAddress.BackColor = Color.White
        txtDestinationAddress.BackColor = Color.White
        cboTypeofDelivery.BackColor = Color.White
        cboNumberofPeople.BackColor = Color.White
        cboVehicleType.BackColor = Color.White
        cboPaymentType.BackColor = Color.White
        txtSpecialRequirement.BackColor = Color.White

        'Save specific data which from textbox or rad button checked to dataset according the item 1 to 15
        ds.Tables("ZoomerCustomers").Rows(inc).Item(1) = cboTitle.Text
        ds.Tables("ZoomerCustomers").Rows(inc).Item(2) = txtFirstName.Text
        ds.Tables("ZoomerCustomers").Rows(inc).Item(3) = txtLastName.Text
        ds.Tables("ZoomerCustomers").Rows(inc).Item(4) = txtContactNumber.Text
        ds.Tables("ZoomerCustomers").Rows(inc).Item(5) = txtEmail.Text
        ds.Tables("ZoomerCustomers").Rows(inc).Item(6) = txtPickUpAddress.Text
        ds.Tables("ZoomerCustomers").Rows(inc).Item(7) = txtDestinationAddress.Text
        ds.Tables("ZoomerCustomers").Rows(inc).Item(8) = radAm.Checked
        ds.Tables("ZoomerCustomers").Rows(inc).Item(9) = cboTypeofDelivery.Text
        ds.Tables("ZoomerCustomers").Rows(inc).Item(10) = cboNumberofPeople.Text
        ds.Tables("ZoomerCustomers").Rows(inc).Item(11) = cboVehicleType.Text
        ds.Tables("ZoomerCustomers").Rows(inc).Item(12) = cboPaymentType.Text
        ds.Tables("ZoomerCustomers").Rows(inc).Item(13) = txtSpecialRequirement.Text
        ds.Tables("ZoomerCustomers").Rows(inc).Item(14) = dtpPickUpDate.Text
        ds.Tables("ZoomerCustomers").Rows(inc).Item(15) = dtpPickUpTime.Text

        'Commandbuilder(da) is a connection bridge
        'So update allowed date from dataset to dataadaptor
        da.Update(ds, "ZoomerCustomers")

        'Clear the data from dataset and refill the dataadaptor
        ds.Clear()
        da.Fill(ds, "ZoomerCustomers")

        'Show the msgbox 
        MsgBox("Date Saved!", MsgBoxStyle.Exclamation, "Notice")

    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        'Declare the commandbuilder which build SQL statement to update the dataset
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        'Creat new row by newrow project, declare the variable dsnewrow
        Dim dsNewRow As DataRow

        'Creat a new row in the database form and store these to variable named dsnewrow
        dsNewRow = ds.Tables("ZoomerCustomers").NewRow()

        'Clear the textbox(not data from database) 
        txtCustomerID.Clear()
        cboTitle.Text = ""
        txtFirstName.Clear()
        txtLastName.Clear()
        txtContactNumber.Clear()
        txtEmail.Clear()
        txtPickUpAddress.Clear()
        txtDestinationAddress.Clear()
        cboTypeofDelivery.Text = ""
        cboNumberofPeople.Text = ""
        cboVehicleType.Text = ""
        cboPaymentType.Text = ""
        txtSpecialRequirement.Clear()

        'Any new data from textbox or rad button will update to dsnewrow
        'dsnewrow will hold the data match with the field name from database
        dsNewRow.Item("Title") = cboTitle.Text
        dsNewRow.Item("FirstName") = txtFirstName.Text
        dsNewRow.Item("LastName") = txtLastName.Text
        dsNewRow.Item("ContactNumber") = txtContactNumber.Text
        dsNewRow.Item("Email") = txtEmail.Text
        dsNewRow.Item("PickupAddress") = txtPickUpAddress.Text
        dsNewRow.Item("DestinationAddress") = txtDestinationAddress.Text
        dsNewRow.Item("TypeofDelivery") = cboTypeofDelivery.Text
        dsNewRow.Item("NumberofPeople") = cboNumberofPeople.Text
        dsNewRow.Item("VehicleType") = cboVehicleType.Text
        dsNewRow.Item("PaymentType") = cboPaymentType.Text
        dsNewRow.Item("SpecialRequirement") = txtSpecialRequirement.Text
        dsNewRow.Item("PickUpDate") = dtpPickUpDate.Text
        dsNewRow.Item("PickUpTime") = dtpPickUpTime.Text

        'Add data from dsnewrow to dataset 
        ds.Tables("ZoomerCustomers").Rows.Add(dsNewRow)

        'Dataadaptor update data from dataset
        da.Update(ds, "ZoomerCustomers")

        'Clear the dataset data and refill the dataadaptor
        ds.Clear()
        da.Fill(ds, "ZoomerCustomers")

        'Update the maxrow variable by counting the rows
        intMaxRows = ds.Tables("ZoomerCustomers").Rows.Count

        'Show the msgbox 
        MsgBox("New Record Added", MsgBoxStyle.Exclamation, "Notice")

        'Update the inc to indicate this is the last record
        inc = intMaxRows - 1

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Declare the commandbuilder which build SQL statement to update the dataset
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        'Declare the local integer for the record number check
        Dim intLastRecCheck As Integer
        'set intresponse as integer variable give user interactive dialog box
        Dim intResponse As Integer

        'If this is the last records in the database, we set a procedure to check rows count
        intLastRecCheck = ds.Tables("ZoomerCustomers").Rows.Count

        'Display the msgbox with vb procedure yes or no and question form
        intResponse = MsgBox("Delete this customer records?", vbYesNo + vbQuestion, "Warning")

        If intResponse = vbYes Then
            'If only one rows in the database, then count equals one and warn user this is last records
            If intLastRecCheck = 1 Then
                'Msgbox display
                MsgBox("Last Record, So Clear the Record")

                'Clear all text information on the from form
                cboTitle.Text = ""
                txtFirstName.Clear()
                txtLastName.Clear()
                txtContactNumber.Clear()
                txtEmail.Clear()
                txtPickUpAddress.Clear()
                txtDestinationAddress.Clear()
                radAm.Checked = False
                radPm.Checked = False
                cboTypeofDelivery.Text = ""
                cboNumberofPeople.Text = ""
                cboVehicleType.Text = ""
                cboPaymentType.Text = ""
                txtSpecialRequirement.Clear()
                dtpPickUpDate.Text = ""
                dtpPickUpTime.Text = ""

                'Write into dataset holding these cleared control
                ds.Tables("ZoomerCustomers").Rows(inc).Item(1) = cboTitle.Text
                ds.Tables("ZoomerCustomers").Rows(inc).Item(2) = txtFirstName.Text
                ds.Tables("ZoomerCustomers").Rows(inc).Item(3) = txtLastName.Text
                ds.Tables("ZoomerCustomers").Rows(inc).Item(4) = txtContactNumber.Text
                ds.Tables("ZoomerCustomers").Rows(inc).Item(5) = txtEmail.Text
                ds.Tables("ZoomerCustomers").Rows(inc).Item(6) = txtPickUpAddress.Text
                ds.Tables("ZoomerCustomers").Rows(inc).Item(7) = txtDestinationAddress.Text
                ds.Tables("ZoomerCustomers").Rows(inc).Item(8) = radAm.Checked
                ds.Tables("ZoomerCustomers").Rows(inc).Item(9) = cboTypeofDelivery.Text
                ds.Tables("ZoomerCustomers").Rows(inc).Item(10) = cboNumberofPeople.Text
                ds.Tables("ZoomerCustomers").Rows(inc).Item(11) = cboVehicleType.Text
                ds.Tables("ZoomerCustomers").Rows(inc).Item(12) = cboPaymentType.Text
                ds.Tables("ZoomerCustomers").Rows(inc).Item(13) = txtSpecialRequirement.Text
                ds.Tables("ZoomerCustomers").Rows(inc).Item(14) = dtpPickUpDate.Text
                ds.Tables("ZoomerCustomers").Rows(inc).Item(15) = dtpPickUpTime.Text

                'Update cleared data to dataadaptor and refill the dataadaptor
                da.Update(ds, "ZoomerCustomers")
                da.Fill(ds)
            Else
                'If rows count greater than 1, then just delete the row selected
                ds.Tables("ZoomerCustomers").Rows(inc).Delete()

                'Recount the maxrows
                intMaxRows = intMaxRows - 1

                'Update to dataadaptor with one rows has been remove
                da.Update(ds, "ZoomerCustomers")

                'Refresh the dataadaptor
                da.Fill(ds)

                'This code to determine the previous records deleted and what records need
                'to show on the form
                'As inc start from 0 if not the last records then show the previous records(inc-1)
                'Otherwise show the first row(0) records
                If inc > 1 Then
                    inc = inc - 1
                Else
                    inc = 0
                End If

                'To call sub procedure display the records
                Call DisplayRecord()
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Set the interactive dialog box when user clicked the button
        'set intresponse as integer variable
        Dim intResponse As Integer

        'Display the msgbox with vb procedure yes or no and question form
        intResponse = MsgBox("Are want to print current customer information?", vbYesNo + vbQuestion, "Notice")

        'If user click the yes button then executed follwing procedure
        If intResponse = vbYes Then
            'The "" will display before the data from text box, and show in the immediate window
            Debug.Print("Customer ID: " & txtCustomerID.Text)
            Debug.Print("Title: " & cboTitle.Text)
            Debug.Print("First Name: " & txtFirstName.Text)
            Debug.Print("Last Name: " & txtLastName.Text)
            Debug.Print("Contact Number: " & txtContactNumber.Text)
            Debug.Print("Email Address: " & txtEmail.Text)
            Debug.Print("Pick up address: " & txtPickUpAddress.Text)
            Debug.Print("Destination address: " & txtDestinationAddress.Text)
            Debug.Print("Pick up Date: " & dtpPickUpDate.Text)
            'Set if statement to indicate what information will be show in the immediate window
            'and rad button checked value 
            If radAm.Checked = True Then
                Debug.Print("Pick up Time: " & dtpPickUpTime.Text & " AM ")
            Else
                Debug.Print("Pick up Time: " & dtpPickUpTime.Text & " PM ")
            End If
            Debug.Print("Type of Delivery: " & cboTypeofDelivery.Text)
            Debug.Print("Number of people: " & cboNumberofPeople.Text)
            Debug.Print("Vehicle type: " & cboVehicleType.Text)
            Debug.Print("Payment type: " & cboPaymentType.Text)
            Debug.Print("Special requirement: " & txtSpecialRequirement.Text)

            'Add a break line after the records in the immediate window
            Debug.Print("==================================================================================")

            'Add a blank line after he break line 
            Debug.Print("")

            'Display the msgbox to user 
            MsgBox("Please check print details on Immediate window", MsgBoxStyle.Exclamation, "Notice")
        End If

    End Sub

    Private Sub btnPrintAll_Click(sender As Object, e As EventArgs) Handles btnPrintAll.Click
        'Print all will use loop statement check each records in the database
        'and display in the immediate window
        'Delcare the loacal variable
        Dim intCounter As Integer

        'Set the interactive dialog box when user clicked the button
        'set intresponse as integer variable
        Dim intResponse As Integer

        'Set start parameter is 0 for loop
        intCounter = 0

        'Display the msgbox with vb procedure yes or no and question form
        intResponse = MsgBox("Are you sure print ALL customers information?", vbYesNo + vbQuestion, "Notice")
        'If user click yes means execute the follwing procedure
        If intResponse = vbYes Then

            'Use for loop to record each data from database
            'Until to max rows and display all data been choosed in the immediate window
            Do Until intCounter = intMaxRows
                Debug.Print("Customer ID: " & ds.Tables("ZoomerCustomers").Rows(intCounter).Item(0))
                Debug.Print("Title: " & ds.Tables("ZoomerCustomers").Rows(intCounter).Item(1))
                Debug.Print("First Name: " & ds.Tables("ZoomerCustomers").Rows(intCounter).Item(2))
                Debug.Print("Last Name: " & ds.Tables("ZoomerCustomers").Rows(intCounter).Item(3))
                Debug.Print("Contact Number: " & ds.Tables("ZoomerCustomers").Rows(intCounter).Item(4))
                Debug.Print("Email Address: " & ds.Tables("ZoomerCustomers").Rows(intCounter).Item(5))
                Debug.Print("Pick up address: " & ds.Tables("ZoomerCustomers").Rows(intCounter).Item(6))
                Debug.Print("Destination address: " & ds.Tables("ZoomerCustomers").Rows(intCounter).Item(7))
                Debug.Print("Pick up Date: " & ds.Tables("ZoomerCustomers").Rows(intCounter).Item(14))
                If radAm.Checked = True Then
                    Debug.Print("Pick up Time: " & ds.Tables("ZoomerCustomers").Rows(intCounter).Item(15) & " AM ")
                Else
                    Debug.Print("Pick up Time: " & ds.Tables("ZoomerCustomers").Rows(intCounter).Item(15) & " PM ")
                End If
                Debug.Print("Type of Delivery: " & ds.Tables("ZoomerCustomers").Rows(intCounter).Item(9))
                Debug.Print("Number of people: " & ds.Tables("ZoomerCustomers").Rows(intCounter).Item(10))
                Debug.Print("Vehicle type: " & ds.Tables("ZoomerCustomers").Rows(intCounter).Item(11))
                Debug.Print("Payment type: " & ds.Tables("ZoomerCustomers").Rows(intCounter).Item(12))
                Debug.Print("Special requirement: " & ds.Tables("ZoomerCustomers").Rows(intCounter).Item(13))

                'Add a break line after each records to recognize customers easily
                Debug.Print("-------------------------------------------------------------------------------------")

                'This code to help loop to move next row until last one
                intCounter = intCounter + 1
            Loop

            'Add a blank break after all customers records print
            Debug.Print("")

            'Display the msgbox to user
            MsgBox("Please check ALL details on Immediate window", MsgBoxStyle.Exclamation, "Notice")
        End If

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'Set the interactive dialog box when user clicked the button
        'set intresponse as integer variable
        Dim intResponse As Integer

        'Display the msgbox with vb procedure yes or no and question form
        intResponse = MsgBox("Are you sure you want to exit?", vbYesNo + vbQuestion, "Exit")

        'If vbYes been clicked then execute following procedure
        If intResponse = vbYes Then
            'Close the form
            Me.Close()

        End If
    End Sub

    Private Sub mnuFilePreviousRecord_Click(sender As Object, e As EventArgs) Handles mnuFilePreviousRecord.Click
        'This is menu button to call button previous procedure
        'If user click this button then execute same procrdure as button previous
        Call btnPrevious_Click(sender, e)
    End Sub

    Private Sub mnuFileNextRecord_Click(sender As Object, e As EventArgs) Handles mnuFileNextRecord.Click
        'This is menu button to call button next procedure
        'If user click this button then execute same procrdure as button next
        Call btnNext_Click(sender, e)
    End Sub

    Private Sub mnuFileCreatNewRecord_Click(sender As Object, e As EventArgs) Handles mnuFileCreatNewRecord.Click
        'This is menu button to call button create procedure
        'If user click this button then execute same procrdure as button create
        Call BtnCreate_Click(sender, e)
    End Sub

    Private Sub mnuFileSaveRecord_Click(sender As Object, e As EventArgs) Handles mnuFileSaveRecord.Click
        'This is menu button to call button save procedure
        'If user click this button then execute same procrdure as button save
        Call btnSave_Click(sender, e)
    End Sub

    Private Sub mnuFileDeleteRecord_Click(sender As Object, e As EventArgs) Handles mnuFileDeleteRecord.Click
        'This is menu button to call button delete procedure
        'If user click this button then execute same procrdure as button delete
        Call btnDelete_Click(sender, e)
    End Sub

    Private Sub mnuPrint_Click(sender As Object, e As EventArgs) Handles mnuPrint.Click
        'This is menu button to call button print procedure
        'If user click this button then execute same procrdure as button print
        Call btnPrint_Click(sender, e)
    End Sub

    Private Sub mnuPrintAll_Click(sender As Object, e As EventArgs) Handles mnuPrintAll.Click
        'This is menu button to call button printALL procedure
        'If user click this button then execute same procrdure as button printALL
        Call btnPrintAll_Click(sender, e)
    End Sub
End Class
