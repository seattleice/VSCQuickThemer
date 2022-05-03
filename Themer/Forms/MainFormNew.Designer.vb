<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFormNew
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvEnvironment = New System.Windows.Forms.DataGridView()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.tabEdit = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDeleteEditorColor = New System.Windows.Forms.Button()
        Me.btnFindColor = New System.Windows.Forms.Button()
        Me.btnAddEditorColor = New System.Windows.Forms.Button()
        Me.txtFindColor = New System.Windows.Forms.TextBox()
        Me.btnEditEnvironmentColor = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvToken = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDeleteToken = New System.Windows.Forms.Button()
        Me.btnEditBackground = New System.Windows.Forms.Button()
        Me.btnEditForeground = New System.Windows.Forms.Button()
        Me.btnAddToken = New System.Windows.Forms.Button()
        Me.dlgOpenJson = New System.Windows.Forms.OpenFileDialog()
        Me.btnCreateFromTemplate = New System.Windows.Forms.Button()
        Me.txtThemeName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDisplayName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.dlgThemeFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblValidName = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblValidDisplayName = New System.Windows.Forms.Label()
        Me.lblValidPublisher = New System.Windows.Forms.Label()
        Me.lblValidVersion = New System.Windows.Forms.Label()
        Me.btnSelectJsonTemplate = New System.Windows.Forms.Button()
        Me.btnOpenTemplatesFolder = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEditExisting = New System.Windows.Forms.Button()
        Me.btnFindScope = New System.Windows.Forms.Button()
        Me.btnDeleteScope = New System.Windows.Forms.Button()
        Me.btnAddScope = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.mnuSettings = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DefaultEnvironmentPropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultEditorScopesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtVersion1 = New System.Windows.Forms.TextBox()
        Me.txtVersion2 = New System.Windows.Forms.TextBox()
        Me.txtVersion3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbTemplate = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbThemeType = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lstScopes = New System.Windows.Forms.ListBox()
        Me.lblScopes = New System.Windows.Forms.Label()
        Me.txtFindScope = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pnlToken = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlColor = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnPkgDef = New System.Windows.Forms.Button()
        CType(Me.dgvEnvironment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEdit.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvToken, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.mnuSettings.SuspendLayout()
        Me.pnlToken.SuspendLayout()
        Me.pnlColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvEnvironment
        '
        Me.dgvEnvironment.AllowUserToAddRows = False
        Me.dgvEnvironment.AllowUserToDeleteRows = False
        Me.dgvEnvironment.AllowUserToResizeRows = False
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.White
        Me.dgvEnvironment.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvEnvironment.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvEnvironment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEnvironment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEnvironment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.dgvEnvironment.ColumnHeadersHeight = 34
        Me.dgvEnvironment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEnvironment.DefaultCellStyle = DataGridViewCellStyle21
        Me.dgvEnvironment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEnvironment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvEnvironment.GridColor = System.Drawing.Color.LightGray
        Me.dgvEnvironment.Location = New System.Drawing.Point(3, 41)
        Me.dgvEnvironment.Name = "dgvEnvironment"
        Me.dgvEnvironment.RowHeadersVisible = False
        Me.dgvEnvironment.RowHeadersWidth = 30
        Me.dgvEnvironment.RowTemplate.Height = 25
        Me.dgvEnvironment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvEnvironment.Size = New System.Drawing.Size(750, 670)
        Me.dgvEnvironment.TabIndex = 2
        '
        'ColorDialog1
        '
        Me.ColorDialog1.AnyColor = True
        Me.ColorDialog1.Color = System.Drawing.Color.DarkGray
        Me.ColorDialog1.FullOpen = True
        '
        'tabEdit
        '
        Me.tabEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabEdit.Controls.Add(Me.TabPage1)
        Me.tabEdit.Controls.Add(Me.TabPage2)
        Me.tabEdit.ItemSize = New System.Drawing.Size(190, 34)
        Me.tabEdit.Location = New System.Drawing.Point(431, 62)
        Me.tabEdit.Name = "tabEdit"
        Me.tabEdit.SelectedIndex = 0
        Me.tabEdit.Size = New System.Drawing.Size(764, 756)
        Me.tabEdit.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabEdit.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.dgvEnvironment)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(756, 714)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Environment/IDE Colors"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnDeleteEditorColor)
        Me.Panel1.Controls.Add(Me.btnFindColor)
        Me.Panel1.Controls.Add(Me.btnAddEditorColor)
        Me.Panel1.Controls.Add(Me.txtFindColor)
        Me.Panel1.Controls.Add(Me.btnEditEnvironmentColor)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 38)
        Me.Panel1.TabIndex = 3
        '
        'btnDeleteEditorColor
        '
        Me.btnDeleteEditorColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeleteEditorColor.FlatAppearance.BorderSize = 0
        Me.btnDeleteEditorColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteEditorColor.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDeleteEditorColor.ForeColor = System.Drawing.Color.White
        Me.btnDeleteEditorColor.Location = New System.Drawing.Point(133, 1)
        Me.btnDeleteEditorColor.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnDeleteEditorColor.Name = "btnDeleteEditorColor"
        Me.btnDeleteEditorColor.Size = New System.Drawing.Size(143, 36)
        Me.btnDeleteEditorColor.TabIndex = 49
        Me.btnDeleteEditorColor.Text = "Delete Property"
        Me.ToolTip1.SetToolTip(Me.btnDeleteEditorColor, "Delete an environment property")
        Me.btnDeleteEditorColor.UseVisualStyleBackColor = False
        '
        'btnFindColor
        '
        Me.btnFindColor.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnFindColor.FlatAppearance.BorderSize = 0
        Me.btnFindColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindColor.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFindColor.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnFindColor.Location = New System.Drawing.Point(563, 3)
        Me.btnFindColor.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnFindColor.Name = "btnFindColor"
        Me.btnFindColor.Size = New System.Drawing.Size(56, 31)
        Me.btnFindColor.TabIndex = 43
        Me.btnFindColor.Text = "Find"
        Me.ToolTip1.SetToolTip(Me.btnFindColor, "Find a editor property by name ( wildcards allowed)")
        Me.btnFindColor.UseVisualStyleBackColor = False
        '
        'btnAddEditorColor
        '
        Me.btnAddEditorColor.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAddEditorColor.FlatAppearance.BorderSize = 0
        Me.btnAddEditorColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEditorColor.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAddEditorColor.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddEditorColor.Location = New System.Drawing.Point(2, 1)
        Me.btnAddEditorColor.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnAddEditorColor.Name = "btnAddEditorColor"
        Me.btnAddEditorColor.Size = New System.Drawing.Size(129, 36)
        Me.btnAddEditorColor.TabIndex = 45
        Me.btnAddEditorColor.Text = "Add Property"
        Me.ToolTip1.SetToolTip(Me.btnAddEditorColor, "Add a new environment property")
        Me.btnAddEditorColor.UseVisualStyleBackColor = False
        '
        'txtFindColor
        '
        Me.txtFindColor.Location = New System.Drawing.Point(289, 5)
        Me.txtFindColor.Name = "txtFindColor"
        Me.txtFindColor.Size = New System.Drawing.Size(274, 27)
        Me.txtFindColor.TabIndex = 42
        Me.ToolTip1.SetToolTip(Me.txtFindColor, "Find the name containing the text")
        '
        'btnEditEnvironmentColor
        '
        Me.btnEditEnvironmentColor.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEditEnvironmentColor.FlatAppearance.BorderSize = 0
        Me.btnEditEnvironmentColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditEnvironmentColor.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEditEnvironmentColor.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditEnvironmentColor.Location = New System.Drawing.Point(631, 1)
        Me.btnEditEnvironmentColor.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnEditEnvironmentColor.Name = "btnEditEnvironmentColor"
        Me.btnEditEnvironmentColor.Size = New System.Drawing.Size(118, 36)
        Me.btnEditEnvironmentColor.TabIndex = 34
        Me.btnEditEnvironmentColor.Text = "Edit Color"
        Me.ToolTip1.SetToolTip(Me.btnEditEnvironmentColor, "Modify the selected color(s)")
        Me.btnEditEnvironmentColor.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.dgvToken)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(756, 714)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Text Editor / Syntax Tokens"
        '
        'dgvToken
        '
        Me.dgvToken.AllowUserToAddRows = False
        Me.dgvToken.AllowUserToDeleteRows = False
        Me.dgvToken.AllowUserToResizeRows = False
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.DimGray
        Me.dgvToken.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle22
        Me.dgvToken.BackgroundColor = System.Drawing.Color.White
        Me.dgvToken.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvToken.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvToken.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.dgvToken.ColumnHeadersHeight = 34
        Me.dgvToken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvToken.DefaultCellStyle = DataGridViewCellStyle24
        Me.dgvToken.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvToken.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvToken.GridColor = System.Drawing.Color.LightGray
        Me.dgvToken.Location = New System.Drawing.Point(3, 41)
        Me.dgvToken.Name = "dgvToken"
        Me.dgvToken.RowHeadersVisible = False
        Me.dgvToken.RowHeadersWidth = 30
        Me.dgvToken.RowTemplate.Height = 25
        Me.dgvToken.Size = New System.Drawing.Size(750, 670)
        Me.dgvToken.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnDeleteToken)
        Me.Panel2.Controls.Add(Me.btnEditBackground)
        Me.Panel2.Controls.Add(Me.btnEditForeground)
        Me.Panel2.Controls.Add(Me.btnAddToken)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(750, 38)
        Me.Panel2.TabIndex = 4
        '
        'btnDeleteToken
        '
        Me.btnDeleteToken.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeleteToken.FlatAppearance.BorderSize = 0
        Me.btnDeleteToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteToken.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDeleteToken.ForeColor = System.Drawing.Color.White
        Me.btnDeleteToken.Location = New System.Drawing.Point(133, 1)
        Me.btnDeleteToken.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnDeleteToken.Name = "btnDeleteToken"
        Me.btnDeleteToken.Size = New System.Drawing.Size(143, 36)
        Me.btnDeleteToken.TabIndex = 49
        Me.btnDeleteToken.Text = "Delete Token"
        Me.ToolTip1.SetToolTip(Me.btnDeleteToken, "Delete Token")
        Me.btnDeleteToken.UseVisualStyleBackColor = False
        '
        'btnEditBackground
        '
        Me.btnEditBackground.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEditBackground.FlatAppearance.BorderSize = 0
        Me.btnEditBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditBackground.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEditBackground.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditBackground.Location = New System.Drawing.Point(604, 1)
        Me.btnEditBackground.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnEditBackground.Name = "btnEditBackground"
        Me.btnEditBackground.Size = New System.Drawing.Size(144, 36)
        Me.btnEditBackground.TabIndex = 41
        Me.btnEditBackground.Text = "Edit Background"
        Me.ToolTip1.SetToolTip(Me.btnEditBackground, "Modify the foreground color for the selected token(s)")
        Me.btnEditBackground.UseVisualStyleBackColor = False
        Me.btnEditBackground.Visible = False
        '
        'btnEditForeground
        '
        Me.btnEditForeground.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEditForeground.FlatAppearance.BorderSize = 0
        Me.btnEditForeground.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditForeground.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEditForeground.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditForeground.Location = New System.Drawing.Point(463, 1)
        Me.btnEditForeground.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnEditForeground.Name = "btnEditForeground"
        Me.btnEditForeground.Size = New System.Drawing.Size(140, 36)
        Me.btnEditForeground.TabIndex = 40
        Me.btnEditForeground.Text = "Edit Foreground"
        Me.ToolTip1.SetToolTip(Me.btnEditForeground, "Modify the foreground color for the selected token(s)")
        Me.btnEditForeground.UseVisualStyleBackColor = False
        Me.btnEditForeground.Visible = False
        '
        'btnAddToken
        '
        Me.btnAddToken.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAddToken.FlatAppearance.BorderSize = 0
        Me.btnAddToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddToken.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAddToken.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddToken.Location = New System.Drawing.Point(2, 1)
        Me.btnAddToken.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnAddToken.Name = "btnAddToken"
        Me.btnAddToken.Size = New System.Drawing.Size(129, 36)
        Me.btnAddToken.TabIndex = 45
        Me.btnAddToken.Text = "Add Token"
        Me.ToolTip1.SetToolTip(Me.btnAddToken, "Add a new token")
        Me.btnAddToken.UseVisualStyleBackColor = False
        '
        'dlgOpenJson
        '
        Me.dlgOpenJson.Filter = "Json Files(*.json)|*.json"
        '
        'btnCreateFromTemplate
        '
        Me.btnCreateFromTemplate.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCreateFromTemplate.FlatAppearance.BorderSize = 0
        Me.btnCreateFromTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateFromTemplate.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCreateFromTemplate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCreateFromTemplate.Location = New System.Drawing.Point(362, 4)
        Me.btnCreateFromTemplate.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnCreateFromTemplate.Name = "btnCreateFromTemplate"
        Me.btnCreateFromTemplate.Size = New System.Drawing.Size(194, 36)
        Me.btnCreateFromTemplate.TabIndex = 6
        Me.btnCreateFromTemplate.Text = "Create From Template:"
        Me.ToolTip1.SetToolTip(Me.btnCreateFromTemplate, "Start with a template")
        Me.btnCreateFromTemplate.UseVisualStyleBackColor = False
        '
        'txtThemeName
        '
        Me.txtThemeName.Location = New System.Drawing.Point(135, 64)
        Me.txtThemeName.Name = "txtThemeName"
        Me.txtThemeName.Size = New System.Drawing.Size(245, 27)
        Me.txtThemeName.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Theme Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Display Name"
        '
        'txtDisplayName
        '
        Me.txtDisplayName.Location = New System.Drawing.Point(135, 97)
        Me.txtDisplayName.Name = "txtDisplayName"
        Me.txtDisplayName.Size = New System.Drawing.Size(245, 27)
        Me.txtDisplayName.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Publisher"
        '
        'txtPublisher
        '
        Me.txtPublisher.Location = New System.Drawing.Point(135, 130)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(245, 27)
        Me.txtPublisher.TabIndex = 11
        '
        'lblValidName
        '
        Me.lblValidName.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblValidName.ForeColor = System.Drawing.Color.Red
        Me.lblValidName.Location = New System.Drawing.Point(383, 67)
        Me.lblValidName.Name = "lblValidName"
        Me.lblValidName.Size = New System.Drawing.Size(23, 24)
        Me.lblValidName.TabIndex = 13
        Me.lblValidName.Tag = "false"
        Me.lblValidName.Text = "*"
        Me.ToolTip1.SetToolTip(Me.lblValidName, "Name must be 4-40 characters, numbers or hyphens with no spaces")
        Me.lblValidName.Visible = False
        '
        'lblValidDisplayName
        '
        Me.lblValidDisplayName.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblValidDisplayName.ForeColor = System.Drawing.Color.Red
        Me.lblValidDisplayName.Location = New System.Drawing.Point(383, 97)
        Me.lblValidDisplayName.Name = "lblValidDisplayName"
        Me.lblValidDisplayName.Size = New System.Drawing.Size(23, 24)
        Me.lblValidDisplayName.TabIndex = 14
        Me.lblValidDisplayName.Text = "*"
        Me.ToolTip1.SetToolTip(Me.lblValidDisplayName, "Name must be 4-40 characters, numbers, space and ""-"" or ""_""")
        Me.lblValidDisplayName.Visible = False
        '
        'lblValidPublisher
        '
        Me.lblValidPublisher.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblValidPublisher.ForeColor = System.Drawing.Color.Red
        Me.lblValidPublisher.Location = New System.Drawing.Point(383, 130)
        Me.lblValidPublisher.Name = "lblValidPublisher"
        Me.lblValidPublisher.Size = New System.Drawing.Size(23, 24)
        Me.lblValidPublisher.TabIndex = 15
        Me.lblValidPublisher.Text = "*"
        Me.ToolTip1.SetToolTip(Me.lblValidPublisher, "Name must be 4-40 characters, numbers, space and ""-"" or ""_""")
        Me.lblValidPublisher.Visible = False
        '
        'lblValidVersion
        '
        Me.lblValidVersion.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblValidVersion.ForeColor = System.Drawing.Color.Red
        Me.lblValidVersion.Location = New System.Drawing.Point(255, 165)
        Me.lblValidVersion.Name = "lblValidVersion"
        Me.lblValidVersion.Size = New System.Drawing.Size(23, 24)
        Me.lblValidVersion.TabIndex = 21
        Me.lblValidVersion.Text = "*"
        Me.ToolTip1.SetToolTip(Me.lblValidVersion, "Must be a vlid version number that does not start with zero")
        Me.lblValidVersion.Visible = False
        '
        'btnSelectJsonTemplate
        '
        Me.btnSelectJsonTemplate.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSelectJsonTemplate.FlatAppearance.BorderSize = 0
        Me.btnSelectJsonTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectJsonTemplate.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSelectJsonTemplate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSelectJsonTemplate.Location = New System.Drawing.Point(905, 3)
        Me.btnSelectJsonTemplate.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnSelectJsonTemplate.Name = "btnSelectJsonTemplate"
        Me.btnSelectJsonTemplate.Size = New System.Drawing.Size(44, 36)
        Me.btnSelectJsonTemplate.TabIndex = 28
        Me.btnSelectJsonTemplate.Text = "+"
        Me.ToolTip1.SetToolTip(Me.btnSelectJsonTemplate, "Select existing json theme file to copy to templates folder")
        Me.btnSelectJsonTemplate.UseVisualStyleBackColor = False
        '
        'btnOpenTemplatesFolder
        '
        Me.btnOpenTemplatesFolder.BackColor = System.Drawing.Color.PaleGreen
        Me.btnOpenTemplatesFolder.FlatAppearance.BorderSize = 0
        Me.btnOpenTemplatesFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenTemplatesFolder.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnOpenTemplatesFolder.ForeColor = System.Drawing.Color.DimGray
        Me.btnOpenTemplatesFolder.Location = New System.Drawing.Point(951, 3)
        Me.btnOpenTemplatesFolder.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnOpenTemplatesFolder.Name = "btnOpenTemplatesFolder"
        Me.btnOpenTemplatesFolder.Size = New System.Drawing.Size(52, 36)
        Me.btnOpenTemplatesFolder.TabIndex = 33
        Me.btnOpenTemplatesFolder.Text = "[...]"
        Me.ToolTip1.SetToolTip(Me.btnOpenTemplatesFolder, "Open templates folder in Windows Explorer")
        Me.btnOpenTemplatesFolder.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSave.Location = New System.Drawing.Point(20, 299)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(147, 36)
        Me.btnSave.TabIndex = 36
        Me.btnSave.Text = "Save Theme"
        Me.ToolTip1.SetToolTip(Me.btnSave, "Save your changes")
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnEditExisting
        '
        Me.btnEditExisting.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEditExisting.FlatAppearance.BorderSize = 0
        Me.btnEditExisting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditExisting.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEditExisting.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditExisting.Location = New System.Drawing.Point(182, 4)
        Me.btnEditExisting.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnEditExisting.Name = "btnEditExisting"
        Me.btnEditExisting.Size = New System.Drawing.Size(130, 36)
        Me.btnEditExisting.TabIndex = 37
        Me.btnEditExisting.Text = "Edit Existing"
        Me.ToolTip1.SetToolTip(Me.btnEditExisting, "Edit the colors and styles of an existing theme file")
        Me.btnEditExisting.UseVisualStyleBackColor = False
        '
        'btnFindScope
        '
        Me.btnFindScope.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnFindScope.FlatAppearance.BorderSize = 0
        Me.btnFindScope.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindScope.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFindScope.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnFindScope.Location = New System.Drawing.Point(320, 131)
        Me.btnFindScope.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnFindScope.Name = "btnFindScope"
        Me.btnFindScope.Size = New System.Drawing.Size(91, 31)
        Me.btnFindScope.TabIndex = 43
        Me.btnFindScope.Text = "Find -->"
        Me.ToolTip1.SetToolTip(Me.btnFindScope, "Edit the colors and styles of an existing theme file")
        Me.btnFindScope.UseVisualStyleBackColor = False
        '
        'btnDeleteScope
        '
        Me.btnDeleteScope.BackColor = System.Drawing.Color.Red
        Me.btnDeleteScope.FlatAppearance.BorderSize = 0
        Me.btnDeleteScope.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteScope.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDeleteScope.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteScope.Location = New System.Drawing.Point(19, 323)
        Me.btnDeleteScope.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnDeleteScope.Name = "btnDeleteScope"
        Me.btnDeleteScope.Size = New System.Drawing.Size(40, 36)
        Me.btnDeleteScope.TabIndex = 48
        Me.btnDeleteScope.Text = "-"
        Me.ToolTip1.SetToolTip(Me.btnDeleteScope, "Delete Scope from Token")
        Me.btnDeleteScope.UseVisualStyleBackColor = False
        '
        'btnAddScope
        '
        Me.btnAddScope.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAddScope.FlatAppearance.BorderSize = 0
        Me.btnAddScope.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddScope.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddScope.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddScope.Location = New System.Drawing.Point(19, 284)
        Me.btnAddScope.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnAddScope.Name = "btnAddScope"
        Me.btnAddScope.Size = New System.Drawing.Size(40, 36)
        Me.btnAddScope.TabIndex = 47
        Me.btnAddScope.Text = "+"
        Me.ToolTip1.SetToolTip(Me.btnAddScope, "Add Scope to Token")
        Me.btnAddScope.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.PaleGreen
        Me.btnSettings.ContextMenuStrip = Me.mnuSettings
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSettings.ForeColor = System.Drawing.Color.DimGray
        Me.btnSettings.Location = New System.Drawing.Point(1037, 3)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(164, 36)
        Me.btnSettings.TabIndex = 51
        Me.btnSettings.Text = "Edit Settings"
        Me.ToolTip1.SetToolTip(Me.btnSettings, "Settings")
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'mnuSettings
        '
        Me.mnuSettings.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mnuSettings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultEnvironmentPropertiesToolStripMenuItem, Me.DefaultEditorScopesToolStripMenuItem})
        Me.mnuSettings.Name = "mnuSettings"
        Me.mnuSettings.Size = New System.Drawing.Size(279, 60)
        '
        'DefaultEnvironmentPropertiesToolStripMenuItem
        '
        Me.DefaultEnvironmentPropertiesToolStripMenuItem.Name = "DefaultEnvironmentPropertiesToolStripMenuItem"
        Me.DefaultEnvironmentPropertiesToolStripMenuItem.Size = New System.Drawing.Size(278, 28)
        Me.DefaultEnvironmentPropertiesToolStripMenuItem.Text = "Default Environment Properties"
        '
        'DefaultEditorScopesToolStripMenuItem
        '
        Me.DefaultEditorScopesToolStripMenuItem.Name = "DefaultEditorScopesToolStripMenuItem"
        Me.DefaultEditorScopesToolStripMenuItem.Size = New System.Drawing.Size(278, 28)
        Me.DefaultEditorScopesToolStripMenuItem.Text = "Default Editor Scopes"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(-1, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1206, 2)
        Me.Label7.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(60, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 23)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Version"
        '
        'txtVersion1
        '
        Me.txtVersion1.Location = New System.Drawing.Point(135, 163)
        Me.txtVersion1.MaxLength = 2
        Me.txtVersion1.Name = "txtVersion1"
        Me.txtVersion1.Size = New System.Drawing.Size(34, 27)
        Me.txtVersion1.TabIndex = 17
        Me.txtVersion1.Text = "1"
        Me.txtVersion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVersion2
        '
        Me.txtVersion2.Location = New System.Drawing.Point(175, 163)
        Me.txtVersion2.MaxLength = 2
        Me.txtVersion2.Name = "txtVersion2"
        Me.txtVersion2.Size = New System.Drawing.Size(34, 27)
        Me.txtVersion2.TabIndex = 19
        Me.txtVersion2.Text = "00"
        Me.txtVersion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVersion3
        '
        Me.txtVersion3.Location = New System.Drawing.Point(215, 163)
        Me.txtVersion3.MaxLength = 2
        Me.txtVersion3.Name = "txtVersion3"
        Me.txtVersion3.Size = New System.Drawing.Size(34, 27)
        Me.txtVersion3.TabIndex = 20
        Me.txtVersion3.Text = "00"
        Me.txtVersion3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(165, 166)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 28)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(205, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 28)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(8, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 34)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Color Theme"
        '
        'cmbTemplate
        '
        Me.cmbTemplate.FormattingEnabled = True
        Me.cmbTemplate.Location = New System.Drawing.Point(560, 6)
        Me.cmbTemplate.Name = "cmbTemplate"
        Me.cmbTemplate.Size = New System.Drawing.Size(341, 31)
        Me.cmbTemplate.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 23)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Theme Type"
        '
        'cmbThemeType
        '
        Me.cmbThemeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbThemeType.FormattingEnabled = True
        Me.cmbThemeType.Items.AddRange(New Object() {"light", "dark"})
        Me.cmbThemeType.Location = New System.Drawing.Point(135, 197)
        Me.cmbThemeType.Name = "cmbThemeType"
        Me.cmbThemeType.Size = New System.Drawing.Size(101, 31)
        Me.cmbThemeType.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(43, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 23)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(135, 238)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(245, 53)
        Me.txtDescription.TabIndex = 31
        '
        'lstScopes
        '
        Me.lstScopes.FormattingEnabled = True
        Me.lstScopes.ItemHeight = 23
        Me.lstScopes.Location = New System.Drawing.Point(65, 234)
        Me.lstScopes.Name = "lstScopes"
        Me.lstScopes.Size = New System.Drawing.Size(344, 188)
        Me.lstScopes.TabIndex = 38
        '
        'lblScopes
        '
        Me.lblScopes.Location = New System.Drawing.Point(65, 209)
        Me.lblScopes.Name = "lblScopes"
        Me.lblScopes.Size = New System.Drawing.Size(343, 23)
        Me.lblScopes.TabIndex = 39
        Me.lblScopes.Text = "Related Scopes <--"
        Me.lblScopes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFindScope
        '
        Me.txtFindScope.Location = New System.Drawing.Point(38, 133)
        Me.txtFindScope.Name = "txtFindScope"
        Me.txtFindScope.Size = New System.Drawing.Size(279, 27)
        Me.txtFindScope.TabIndex = 42
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(38, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(359, 23)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Scope to find (Accepts Wildcards for partial matches)"
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.LightGray
        Me.Label13.Location = New System.Drawing.Point(-2, 344)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(435, 2)
        Me.Label13.TabIndex = 46
        '
        'pnlToken
        '
        Me.pnlToken.Controls.Add(Me.Label14)
        Me.pnlToken.Controls.Add(Me.Label1)
        Me.pnlToken.Controls.Add(Me.btnDeleteScope)
        Me.pnlToken.Controls.Add(Me.btnAddScope)
        Me.pnlToken.Controls.Add(Me.Label12)
        Me.pnlToken.Controls.Add(Me.lblScopes)
        Me.pnlToken.Controls.Add(Me.btnFindScope)
        Me.pnlToken.Controls.Add(Me.lstScopes)
        Me.pnlToken.Controls.Add(Me.txtFindScope)
        Me.pnlToken.Location = New System.Drawing.Point(2, 350)
        Me.pnlToken.Name = "pnlToken"
        Me.pnlToken.Size = New System.Drawing.Size(430, 464)
        Me.pnlToken.TabIndex = 49
        Me.pnlToken.Visible = False
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(33, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(369, 53)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Environment Items and Text Tokens can be edited by double clicking the ""Name"" or " &
    "'Color"" column in the grids"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 23)
        Me.Label1.TabIndex = 49
        '
        'pnlColor
        '
        Me.pnlColor.Controls.Add(Me.Label24)
        Me.pnlColor.Controls.Add(Me.Label23)
        Me.pnlColor.Controls.Add(Me.Label22)
        Me.pnlColor.Controls.Add(Me.Label21)
        Me.pnlColor.Controls.Add(Me.Label20)
        Me.pnlColor.Controls.Add(Me.Label19)
        Me.pnlColor.Controls.Add(Me.Label18)
        Me.pnlColor.Controls.Add(Me.Label17)
        Me.pnlColor.Controls.Add(Me.Label16)
        Me.pnlColor.Controls.Add(Me.Label15)
        Me.pnlColor.Location = New System.Drawing.Point(2, 350)
        Me.pnlColor.Name = "pnlColor"
        Me.pnlColor.Size = New System.Drawing.Size(430, 464)
        Me.pnlColor.TabIndex = 50
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label24.Location = New System.Drawing.Point(38, 197)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(345, 67)
        Me.Label24.TabIndex = 25
        Me.Label24.Text = " - 'Save Theme' will only save the current file in 'Edit Existing' mode, but will" &
    " create the entire theme package when 'Create From Template' is selected."
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label23.Location = New System.Drawing.Point(38, 417)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(345, 44)
        Me.Label23.TabIndex = 24
        Me.Label23.Text = " - These are edited by creating tokens, then adding Textmate scopes to the token"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label22.Location = New System.Drawing.Point(38, 370)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(345, 44)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "- These are all the colors and text styles that affect the code window itself."
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(19, 346)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 23)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Text Editor:"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label20.Location = New System.Drawing.Point(38, 292)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(345, 44)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "- These are all the colors and text styles that affect the environment and IDE it" &
    "self."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(19, 268)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 23)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Environment:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(23, 7)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 23)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "To Begin:"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label17.Location = New System.Drawing.Point(38, 126)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(345, 68)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = " - You can click the buttons to add/modify/remove items and their names and color" &
    "s, or you can double click in the grids to edit individual items"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(38, 79)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(345, 44)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = " - Create From Template: Use an example as a starting point, and create a new the" &
    "me package."
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(38, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(345, 44)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "- Edit Existing: Navigate to an existing theme file on your computer, and edit it" &
    " in place."
        '
        'btnPkgDef
        '
        Me.btnPkgDef.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnPkgDef.FlatAppearance.BorderSize = 0
        Me.btnPkgDef.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPkgDef.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPkgDef.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPkgDef.Location = New System.Drawing.Point(172, 299)
        Me.btnPkgDef.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnPkgDef.Name = "btnPkgDef"
        Me.btnPkgDef.Size = New System.Drawing.Size(240, 36)
        Me.btnPkgDef.TabIndex = 52
        Me.btnPkgDef.Text = "Convert to pkgDef"
        Me.ToolTip1.SetToolTip(Me.btnPkgDef, "Save your changes and convert theme to pkgDef for Visual Studio")
        Me.btnPkgDef.UseVisualStyleBackColor = False
        '
        'MainFormNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1204, 830)
        Me.Controls.Add(Me.btnPkgDef)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.pnlColor)
        Me.Controls.Add(Me.pnlToken)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnEditExisting)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpenTemplatesFolder)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.cmbThemeType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSelectJsonTemplate)
        Me.Controls.Add(Me.cmbTemplate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtVersion2)
        Me.Controls.Add(Me.txtVersion3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtVersion1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblValidVersion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblValidPublisher)
        Me.Controls.Add(Me.lblValidDisplayName)
        Me.Controls.Add(Me.lblValidName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPublisher)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDisplayName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtThemeName)
        Me.Controls.Add(Me.btnCreateFromTemplate)
        Me.Controls.Add(Me.tabEdit)
        Me.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainFormNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visual Studio Code - Quick Theme Editor"
        CType(Me.dgvEnvironment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEdit.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvToken, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.mnuSettings.ResumeLayout(False)
        Me.pnlToken.ResumeLayout(False)
        Me.pnlToken.PerformLayout()
        Me.pnlColor.ResumeLayout(False)
        Me.pnlColor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvEnvironment As Windows.Forms.DataGridView
    Friend WithEvents ColorDialog1 As Windows.Forms.ColorDialog
    Friend WithEvents tabEdit As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dlgOpenJson As OpenFileDialog
    Friend WithEvents dgvToken As Windows.Forms.DataGridView
    Friend WithEvents btnCreateFromTemplate As Button
    Friend WithEvents txtThemeName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDisplayName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents dlgThemeFolder As FolderBrowserDialog
    Friend WithEvents lblValidName As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblValidDisplayName As Label
    Friend WithEvents lblValidPublisher As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtVersion1 As TextBox
    Friend WithEvents txtVersion2 As TextBox
    Friend WithEvents txtVersion3 As TextBox
    Friend WithEvents lblValidVersion As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbTemplate As ComboBox
    Friend WithEvents btnSelectJsonTemplate As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbThemeType As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnOpenTemplatesFolder As Button
    Friend WithEvents btnEditEnvironmentColor As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEditExisting As Button
    Friend WithEvents lstScopes As ListBox
    Friend WithEvents lblScopes As Label
    Friend WithEvents btnEditForeground As Button
    Friend WithEvents btnEditBackground As Button
    Friend WithEvents txtFindScope As TextBox
    Friend WithEvents btnFindScope As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents btnAddToken As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents btnDeleteScope As Button
    Friend WithEvents btnAddScope As Button
    Friend WithEvents pnlToken As Panel
    Friend WithEvents btnDeleteToken As Button
    Friend WithEvents pnlColor As Panel
    Friend WithEvents btnDeleteEditorColor As Button
    Friend WithEvents btnAddEditorColor As Button
    Friend WithEvents btnFindColor As Button
    Friend WithEvents txtFindColor As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnSettings As Button
    Friend WithEvents mnuSettings As ContextMenuStrip
    Friend WithEvents DefaultEnvironmentPropertiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DefaultEditorScopesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnPkgDef As Button
End Class
