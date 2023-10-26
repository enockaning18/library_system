<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Category
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
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.dvgCategoryTable = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtReset = New System.Windows.Forms.Button()
        Me.txtPrint = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.llkSearch = New System.Windows.Forms.LinkLabel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.btnReaders = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnAuthors = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtCategoryID = New System.Windows.Forms.TextBox()
        Me.btnCategory = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.OpenFD = New System.Windows.Forms.OpenFileDialog()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnStaffs = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtpDateAdded = New System.Windows.Forms.DateTimePicker()
        Me.cmbCreatedBy = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dvgCategoryTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel15.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
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
        'dvgCategoryTable
        '
        Me.dvgCategoryTable.AllowUserToAddRows = False
        Me.dvgCategoryTable.AllowUserToDeleteRows = False
        Me.dvgCategoryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgCategoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgCategoryTable.Location = New System.Drawing.Point(42, 431)
        Me.dvgCategoryTable.Name = "dvgCategoryTable"
        Me.dvgCategoryTable.ReadOnly = True
        Me.dvgCategoryTable.RowHeadersWidth = 51
        Me.dvgCategoryTable.RowTemplate.Height = 29
        Me.dvgCategoryTable.Size = New System.Drawing.Size(1058, 171)
        Me.dvgCategoryTable.TabIndex = 16
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
        Me.txtReset.Location = New System.Drawing.Point(885, 188)
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
        Me.txtPrint.Location = New System.Drawing.Point(885, 86)
        Me.txtPrint.Name = "txtPrint"
        Me.txtPrint.Size = New System.Drawing.Size(158, 39)
        Me.txtPrint.TabIndex = 10
        Me.txtPrint.Text = "Print"
        Me.txtPrint.UseVisualStyleBackColor = False
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
        'llkSearch
        '
        Me.llkSearch.AutoSize = True
        Me.llkSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.llkSearch.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llkSearch.Location = New System.Drawing.Point(1025, 360)
        Me.llkSearch.Name = "llkSearch"
        Me.llkSearch.Size = New System.Drawing.Size(75, 28)
        Me.llkSearch.TabIndex = 18
        Me.llkSearch.TabStop = True
        Me.llkSearch.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(817, 356)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(198, 34)
        Me.txtSearch.TabIndex = 8
        '
        'btnBooks
        '
        Me.btnBooks.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooks.Image = Global.Library_Managemey_System.My.Resources.Resources.icons8_books_30
        Me.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooks.Location = New System.Drawing.Point(3, 176)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Size = New System.Drawing.Size(235, 56)
        Me.btnBooks.TabIndex = 0
        Me.btnBooks.Text = "Manage Books "
        Me.btnBooks.UseVisualStyleBackColor = False
        '
        'btnReaders
        '
        Me.btnReaders.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnReaders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReaders.Image = Global.Library_Managemey_System.My.Resources.Resources.icons8_readers_30
        Me.btnReaders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReaders.Location = New System.Drawing.Point(3, 363)
        Me.btnReaders.Name = "btnReaders"
        Me.btnReaders.Size = New System.Drawing.Size(235, 56)
        Me.btnReaders.TabIndex = 0
        Me.btnReaders.Text = "Readers"
        Me.btnReaders.UseVisualStyleBackColor = False
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
        'btnAuthors
        '
        Me.btnAuthors.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAuthors.Image = Global.Library_Managemey_System.My.Resources.Resources.icons8_owner_30
        Me.btnAuthors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAuthors.Location = New System.Drawing.Point(3, 425)
        Me.btnAuthors.Name = "btnAuthors"
        Me.btnAuthors.Size = New System.Drawing.Size(235, 56)
        Me.btnAuthors.TabIndex = 0
        Me.btnAuthors.Text = "Author"
        Me.btnAuthors.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(3, 114)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(235, 56)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(54, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 31)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CatID"
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
        'txtCategoryID
        '
        Me.txtCategoryID.Location = New System.Drawing.Point(188, 95)
        Me.txtCategoryID.Multiline = True
        Me.txtCategoryID.Name = "txtCategoryID"
        Me.txtCategoryID.ReadOnly = True
        Me.txtCategoryID.Size = New System.Drawing.Size(198, 34)
        Me.txtCategoryID.TabIndex = 8
        '
        'btnCategory
        '
        Me.btnCategory.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategory.Image = Global.Library_Managemey_System.My.Resources.Resources.icons8_bullet_list_30
        Me.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCategory.Location = New System.Drawing.Point(3, 239)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(235, 56)
        Me.btnCategory.TabIndex = 0
        Me.btnCategory.Text = "Category List "
        Me.btnCategory.UseVisualStyleBackColor = False
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
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(651, 92)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(198, 34)
        Me.txtName.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(517, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 31)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Name "
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Location = New System.Drawing.Point(3, 59)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1129, 5)
        Me.Panel4.TabIndex = 1
        '
        'OpenFD
        '
        Me.OpenFD.FileName = "OpenFileDialog1"
        '
        'Panel15
        '
        Me.Panel15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel15.BackColor = System.Drawing.Color.Brown
        Me.Panel15.Controls.Add(Me.Label14)
        Me.Panel15.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel15.Location = New System.Drawing.Point(2537, 1552)
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
        'btnUsers
        '
        Me.btnUsers.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Image = Global.Library_Managemey_System.My.Resources.Resources.icons8_users_35
        Me.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.Location = New System.Drawing.Point(3, 488)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(235, 56)
        Me.btnUsers.TabIndex = 0
        Me.btnUsers.Text = "Manage Users"
        Me.btnUsers.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Controls.Add(Me.btnUsers)
        Me.Panel2.Controls.Add(Me.btnStaffs)
        Me.Panel2.Controls.Add(Me.btnAuthors)
        Me.Panel2.Controls.Add(Me.btnCategory)
        Me.Panel2.Controls.Add(Me.btnReaders)
        Me.Panel2.Controls.Add(Me.btnBooks)
        Me.Panel2.Controls.Add(Me.btnDashboard)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 125)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(235, 602)
        Me.Panel2.TabIndex = 13
        '
        'btnStaffs
        '
        Me.btnStaffs.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnStaffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaffs.Image = Global.Library_Managemey_System.My.Resources.Resources.icons8_users_30__1_
        Me.btnStaffs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaffs.Location = New System.Drawing.Point(3, 301)
        Me.btnStaffs.Name = "btnStaffs"
        Me.btnStaffs.Size = New System.Drawing.Size(235, 56)
        Me.btnStaffs.TabIndex = 0
        Me.btnStaffs.Text = "Manage Staff"
        Me.btnStaffs.UseVisualStyleBackColor = False
        '
        'Panel9
        '
        Me.Panel9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label8)
        Me.Panel9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel9.Location = New System.Drawing.Point(2537, 1264)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(228, 42)
        Me.Panel9.TabIndex = 0
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(34, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 38)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Category List "
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
        'Panel13
        '
        Me.Panel13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel13.Controls.Add(Me.Label12)
        Me.Panel13.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel13.Location = New System.Drawing.Point(2223, 1552)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(228, 42)
        Me.Panel13.TabIndex = 0
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
        Me.Panel1.Size = New System.Drawing.Size(1367, 125)
        Me.Panel1.TabIndex = 12
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
        'Panel11
        '
        Me.Panel11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel11.BackColor = System.Drawing.Color.Purple
        Me.Panel11.Controls.Add(Me.Label10)
        Me.Panel11.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel11.Location = New System.Drawing.Point(1913, 1552)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(228, 42)
        Me.Panel11.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dtpDateAdded)
        Me.Panel3.Controls.Add(Me.cmbCreatedBy)
        Me.Panel3.Controls.Add(Me.llkSearch)
        Me.Panel3.Controls.Add(Me.dvgCategoryTable)
        Me.Panel3.Controls.Add(Me.btnDelete)
        Me.Panel3.Controls.Add(Me.btnEdit)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.btnAdd)
        Me.Panel3.Controls.Add(Me.txtReset)
        Me.Panel3.Controls.Add(Me.txtPrint)
        Me.Panel3.Controls.Add(Me.txtSearch)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtName)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtCategoryID)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel15)
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Controls.Add(Me.Panel13)
        Me.Panel3.Controls.Add(Me.Panel11)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(234, 125)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1130, 606)
        Me.Panel3.TabIndex = 14
        '
        'dtpDateAdded
        '
        Me.dtpDateAdded.Location = New System.Drawing.Point(188, 197)
        Me.dtpDateAdded.Name = "dtpDateAdded"
        Me.dtpDateAdded.Size = New System.Drawing.Size(238, 27)
        Me.dtpDateAdded.TabIndex = 19
        '
        'cmbCreatedBy
        '
        Me.cmbCreatedBy.FormattingEnabled = True
        Me.cmbCreatedBy.Location = New System.Drawing.Point(651, 196)
        Me.cmbCreatedBy.Name = "cmbCreatedBy"
        Me.cmbCreatedBy.Size = New System.Drawing.Size(198, 28)
        Me.cmbCreatedBy.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(517, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Created By"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(45, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 31)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Date Added"
        '
        'Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1367, 727)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Category"
        Me.Text = "Category"
        CType(Me.dvgCategoryTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMinimize As Button
    Friend WithEvents dvgCategoryTable As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtReset As Button
    Friend WithEvents txtPrint As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnClose As Button
    Friend WithEvents llkSearch As LinkLabel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnBooks As Button
    Friend WithEvents btnReaders As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnAuthors As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtCategoryID As TextBox
    Friend WithEvents btnCategory As Button
    Friend WithEvents lblUser As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents OpenFD As OpenFileDialog
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnStaffs As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dtpDateAdded As DateTimePicker
    Friend WithEvents cmbCreatedBy As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
End Class
