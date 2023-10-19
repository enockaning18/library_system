<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Staff
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dvgStaffTable = New System.Windows.Forms.DataGridView()
        Me.rbnFemale = New System.Windows.Forms.RadioButton()
        Me.rbnMale = New System.Windows.Forms.RadioButton()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtReset = New System.Windows.Forms.Button()
        Me.txtPrint = New System.Windows.Forms.Button()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lable = New System.Windows.Forms.Label()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.picboxProfile = New System.Windows.Forms.PictureBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OpenFD = New System.Windows.Forms.OpenFileDialog()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.dvgStaffTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.picboxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dvgStaffTable
        '
        Me.dvgStaffTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgStaffTable.Location = New System.Drawing.Point(42, 431)
        Me.dvgStaffTable.Name = "dvgStaffTable"
        Me.dvgStaffTable.RowHeadersWidth = 51
        Me.dvgStaffTable.RowTemplate.Height = 29
        Me.dvgStaffTable.Size = New System.Drawing.Size(1058, 171)
        Me.dvgStaffTable.TabIndex = 16
        '
        'rbnFemale
        '
        Me.rbnFemale.AutoSize = True
        Me.rbnFemale.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbnFemale.Location = New System.Drawing.Point(287, 230)
        Me.rbnFemale.Name = "rbnFemale"
        Me.rbnFemale.Size = New System.Drawing.Size(95, 32)
        Me.rbnFemale.TabIndex = 14
        Me.rbnFemale.TabStop = True
        Me.rbnFemale.Text = "Female"
        Me.rbnFemale.UseVisualStyleBackColor = True
        '
        'rbnMale
        '
        Me.rbnMale.AutoSize = True
        Me.rbnMale.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbnMale.Location = New System.Drawing.Point(177, 230)
        Me.rbnMale.Name = "rbnMale"
        Me.rbnMale.Size = New System.Drawing.Size(76, 32)
        Me.rbnMale.TabIndex = 15
        Me.rbnMale.TabStop = True
        Me.rbnMale.Text = "Male"
        Me.rbnMale.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(650, 356)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(158, 39)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(268, 356)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(158, 39)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Blue
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Image = Global.Library_Managemey_System.My.Resources.Resources.icons8_print_301
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(459, 356)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(158, 39)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Blue
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdd.Image = Global.Library_Managemey_System.My.Resources.Resources.icons8_print_301
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(45, 356)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(190, 39)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add Records"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtReset
        '
        Me.txtReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtReset.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtReset.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtReset.Location = New System.Drawing.Point(842, 305)
        Me.txtReset.Name = "txtReset"
        Me.txtReset.Size = New System.Drawing.Size(158, 39)
        Me.txtReset.TabIndex = 10
        Me.txtReset.Text = "Reset"
        Me.txtReset.UseVisualStyleBackColor = False
        '
        'txtPrint
        '
        Me.txtPrint.BackColor = System.Drawing.Color.Blue
        Me.txtPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtPrint.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtPrint.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtPrint.Image = Global.Library_Managemey_System.My.Resources.Resources.icons8_print_301
        Me.txtPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtPrint.Location = New System.Drawing.Point(842, 260)
        Me.txtPrint.Name = "txtPrint"
        Me.txtPrint.Size = New System.Drawing.Size(158, 39)
        Me.txtPrint.TabIndex = 10
        Me.txtPrint.Text = "Print"
        Me.txtPrint.UseVisualStyleBackColor = False
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(171, 302)
        Me.txtPhone.Multiline = True
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(198, 34)
        Me.txtPhone.TabIndex = 8
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(817, 356)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(198, 34)
        Me.txtSearch.TabIndex = 8
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(588, 239)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(198, 34)
        Me.txtAddress.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(42, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 31)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "First Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(459, 302)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 31)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Designation"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(588, 164)
        Me.txtLastName.Multiline = True
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(198, 34)
        Me.txtLastName.TabIndex = 8
        '
        'Panel11
        '
        Me.Panel11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel11.BackColor = System.Drawing.Color.Purple
        Me.Panel11.Controls.Add(Me.Label10)
        Me.Panel11.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel11.Location = New System.Drawing.Point(1670, 1401)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(228, 42)
        Me.Panel11.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(62, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "No. of Readers"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(39, 233)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 31)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Gender"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(459, 233)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 31)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Adress"
        '
        'lable
        '
        Me.lable.AutoSize = True
        Me.lable.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lable.Location = New System.Drawing.Point(42, 296)
        Me.lable.Name = "lable"
        Me.lable.Size = New System.Drawing.Size(78, 31)
        Me.lable.TabIndex = 7
        Me.lable.Text = "Phone"
        '
        'txtStaffID
        '
        Me.txtStaffID.Location = New System.Drawing.Point(171, 95)
        Me.txtStaffID.Multiline = True
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.Size = New System.Drawing.Size(198, 34)
        Me.txtStaffID.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(78, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total Staff"
        '
        'txtDesignation
        '
        Me.txtDesignation.Location = New System.Drawing.Point(588, 303)
        Me.txtDesignation.Multiline = True
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(198, 34)
        Me.txtDesignation.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(459, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 31)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Last Name "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(42, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 31)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "StaffID"
        '
        'Panel15
        '
        Me.Panel15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel15.BackColor = System.Drawing.Color.Brown
        Me.Panel15.Controls.Add(Me.Label14)
        Me.Panel15.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel15.Location = New System.Drawing.Point(2294, 1401)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(228, 42)
        Me.Panel15.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(62, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 20)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "System Users"
        '
        'Panel13
        '
        Me.Panel13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel13.Controls.Add(Me.Label12)
        Me.Panel13.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel13.Location = New System.Drawing.Point(1980, 1401)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(228, 42)
        Me.Panel13.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(62, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "No. of Authors"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LinkLabel1)
        Me.Panel3.Controls.Add(Me.picboxProfile)
        Me.Panel3.Controls.Add(Me.dvgStaffTable)
        Me.Panel3.Controls.Add(Me.rbnFemale)
        Me.Panel3.Controls.Add(Me.rbnMale)
        Me.Panel3.Controls.Add(Me.btnDelete)
        Me.Panel3.Controls.Add(Me.btnEdit)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.btnAdd)
        Me.Panel3.Controls.Add(Me.txtReset)
        Me.Panel3.Controls.Add(Me.txtPrint)
        Me.Panel3.Controls.Add(Me.txtPhone)
        Me.Panel3.Controls.Add(Me.txtSearch)
        Me.Panel3.Controls.Add(Me.txtAddress)
        Me.Panel3.Controls.Add(Me.txtFirstName)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.lable)
        Me.Panel3.Controls.Add(Me.txtDesignation)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtLastName)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtStaffID)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel15)
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Controls.Add(Me.Panel13)
        Me.Panel3.Controls.Add(Me.Panel11)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(235, 125)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1125, 608)
        Me.Panel3.TabIndex = 11
        '
        'picboxProfile
        '
        Me.picboxProfile.BackgroundImage = Global.Library_Managemey_System.My.Resources.Resources.icons8_add_image_70
        Me.picboxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picboxProfile.Location = New System.Drawing.Point(814, 95)
        Me.picboxProfile.Name = "picboxProfile"
        Me.picboxProfile.Size = New System.Drawing.Size(225, 132)
        Me.picboxProfile.TabIndex = 17
        Me.picboxProfile.TabStop = False
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(171, 164)
        Me.txtFirstName.Multiline = True
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(198, 34)
        Me.txtFirstName.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Location = New System.Drawing.Point(3, 59)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1129, 5)
        Me.Panel4.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label8)
        Me.Panel9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel9.Location = New System.Drawing.Point(2294, 1113)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(228, 42)
        Me.Panel9.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(34, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 38)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Manage Staff"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 125)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(235, 608)
        Me.Panel2.TabIndex = 10
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Image = Global.Library_Managemey_System.My.Resources.Resources.icons8_logout_35
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(3, 550)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(235, 56)
        Me.Button8.TabIndex = 0
        Me.Button8.Text = "Sign Out"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = Global.Library_Managemey_System.My.Resources.Resources.icons8_users_35
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(3, 488)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(235, 56)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "Manage Users"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.Library_Managemey_System.My.Resources.Resources.icons8_users_30__1_
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(3, 301)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(235, 56)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Manage Staff"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = Global.Library_Managemey_System.My.Resources.Resources.icons8_owner_30
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(3, 425)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(235, 56)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "Author"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.Library_Managemey_System.My.Resources.Resources.icons8_bullet_list_30
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(3, 239)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(235, 56)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Category List "
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.Library_Managemey_System.My.Resources.Resources.icons8_readers_30
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(3, 363)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(235, 56)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Readers"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.Library_Managemey_System.My.Resources.Resources.icons8_books_30
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(3, 176)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(235, 56)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Manage Books "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 56)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Dashboard"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Library_Managemey_System.My.Resources.Resources.icons8_library_70
        Me.PictureBox2.Location = New System.Drawing.Point(8, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(229, 115)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Maroon
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1302, 50)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(55, 40)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnMaximize
        '
        Me.btnMaximize.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMaximize.ForeColor = System.Drawing.Color.White
        Me.btnMaximize.Location = New System.Drawing.Point(1241, 50)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(55, 40)
        Me.btnMaximize.TabIndex = 3
        Me.btnMaximize.Text = "O"
        Me.btnMaximize.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.Location = New System.Drawing.Point(1180, 50)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(55, 40)
        Me.btnMinimize.TabIndex = 3
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Library_Managemey_System.My.Resources.Resources.icons8_users_30
        Me.PictureBox1.Location = New System.Drawing.Point(1014, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(1052, 63)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(77, 20)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "Welcome.."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(271, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Library Management System "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnMaximize)
        Me.Panel1.Controls.Add(Me.btnMinimize)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1360, 125)
        Me.Panel1.TabIndex = 9
        '
        'OpenFD
        '
        Me.OpenFD.FileName = "OpenFileDialog1"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.Location = New System.Drawing.Point(1025, 360)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(75, 28)
        Me.LinkLabel1.TabIndex = 18
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Search"
        '
        'Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 733)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Staff"
        Me.Text = "Staff"
        CType(Me.dvgStaffTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.picboxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dvgStaffTable As DataGridView
    Friend WithEvents rbnFemale As RadioButton
    Friend WithEvents rbnMale As RadioButton
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtReset As Button
    Friend WithEvents txtPrint As Button
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lable As Label
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDesignation As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblUser As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OpenFD As OpenFileDialog
    Friend WithEvents picboxProfile As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
