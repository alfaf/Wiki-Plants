<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search))
        Me.TableAdapterManager = New Wiki_Plants.PlantDataSetTableAdapters.TableAdapterManager()
        Me.PLANTTableAdapter = New Wiki_Plants.PlantDataSetTableAdapters.PLANTTableAdapter()
        Me.PlantDataSet = New Wiki_Plants.PlantDataSet()
        Me.PLANTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.resultPlantName1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.resultPlantID1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.resultPname = New System.Windows.Forms.TextBox()
        Me.resultPID = New System.Windows.Forms.TextBox()
        Me.sbyid = New System.Windows.Forms.ComboBox()
        Me.sbyname = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Header = New System.Windows.Forms.Panel()
        Me.headerLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PlantDataSet1 = New Wiki_Plants.PlantDataSet1()
        Me.BIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BIOTableAdapter = New Wiki_Plants.PlantDataSet1TableAdapters.BIOTableAdapter()
        Me.PLANTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.getInfo1 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.addFav1 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuFlatButton6 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.resultPpicture = New System.Windows.Forms.PictureBox()
        Me.resultaddFav = New System.Windows.Forms.Button()
        Me.resultgetInfo = New System.Windows.Forms.Button()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuFlatButton7 = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.PlantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLANTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Header.SuspendLayout()
        CType(Me.PlantDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLANTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.resultPpicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PLANTTableAdapter = Me.PLANTTableAdapter
        Me.TableAdapterManager.UpdateOrder = Wiki_Plants.PlantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PLANTTableAdapter
        '
        Me.PLANTTableAdapter.ClearBeforeFill = True
        '
        'PlantDataSet
        '
        Me.PlantDataSet.DataSetName = "PlantDataSet"
        Me.PlantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLANTBindingSource
        '
        Me.PLANTBindingSource.DataMember = "PLANT"
        Me.PLANTBindingSource.DataSource = Me.PlantDataSet
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Controls.Add(Me.resultPlantName1)
        Me.Panel2.Controls.Add(Me.resultPlantID1)
        Me.Panel2.Controls.Add(Me.getInfo1)
        Me.Panel2.Controls.Add(Me.addFav1)
        Me.Panel2.Controls.Add(Me.BunifuFlatButton6)
        Me.Panel2.Controls.Add(Me.BunifuFlatButton5)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.resultPname)
        Me.Panel2.Controls.Add(Me.resultPpicture)
        Me.Panel2.Controls.Add(Me.resultaddFav)
        Me.Panel2.Controls.Add(Me.resultPID)
        Me.Panel2.Controls.Add(Me.resultgetInfo)
        Me.Panel2.Controls.Add(Me.sbyid)
        Me.Panel2.Controls.Add(Me.sbyname)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(239, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1075, 613)
        Me.Panel2.TabIndex = 11
        '
        'resultPlantName1
        '
        Me.resultPlantName1.AutoSize = True
        Me.resultPlantName1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultPlantName1.ForeColor = System.Drawing.Color.White
        Me.resultPlantName1.Location = New System.Drawing.Point(208, 285)
        Me.resultPlantName1.Name = "resultPlantName1"
        Me.resultPlantName1.Size = New System.Drawing.Size(83, 17)
        Me.resultPlantName1.TabIndex = 59
        Me.resultPlantName1.Text = "Plant Name: "
        Me.resultPlantName1.Visible = False
        '
        'resultPlantID1
        '
        Me.resultPlantID1.AutoSize = True
        Me.resultPlantID1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultPlantID1.ForeColor = System.Drawing.Color.White
        Me.resultPlantID1.Location = New System.Drawing.Point(231, 254)
        Me.resultPlantID1.Name = "resultPlantID1"
        Me.resultPlantID1.Size = New System.Drawing.Size(59, 17)
        Me.resultPlantID1.TabIndex = 4
        Me.resultPlantID1.Text = "Plant ID: "
        Me.resultPlantID1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(479, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(10, 23)
        Me.Button2.TabIndex = 58
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(479, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(10, 23)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'resultPname
        '
        Me.resultPname.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.resultPname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resultPname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLANTBindingSource, "p_name", True))
        Me.resultPname.Enabled = False
        Me.resultPname.ForeColor = System.Drawing.SystemColors.Info
        Me.resultPname.Location = New System.Drawing.Point(297, 285)
        Me.resultPname.Name = "resultPname"
        Me.resultPname.Size = New System.Drawing.Size(409, 20)
        Me.resultPname.TabIndex = 52
        Me.resultPname.Visible = False
        '
        'resultPID
        '
        Me.resultPID.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.resultPID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resultPID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLANTBindingSource, "p_ID", True))
        Me.resultPID.Enabled = False
        Me.resultPID.ForeColor = System.Drawing.Color.White
        Me.resultPID.Location = New System.Drawing.Point(297, 250)
        Me.resultPID.Multiline = True
        Me.resultPID.Name = "resultPID"
        Me.resultPID.Size = New System.Drawing.Size(409, 20)
        Me.resultPID.TabIndex = 50
        Me.resultPID.Visible = False
        '
        'sbyid
        '
        Me.sbyid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.sbyid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.sbyid.BackColor = System.Drawing.Color.SeaGreen
        Me.sbyid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sbyid.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sbyid.ForeColor = System.Drawing.SystemColors.Window
        Me.sbyid.FormattingEnabled = True
        Me.sbyid.Location = New System.Drawing.Point(49, 119)
        Me.sbyid.Name = "sbyid"
        Me.sbyid.Size = New System.Drawing.Size(424, 24)
        Me.sbyid.TabIndex = 35
        Me.sbyid.Text = "Search Plant by ID"
        '
        'sbyname
        '
        Me.sbyname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.sbyname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.sbyname.BackColor = System.Drawing.Color.SeaGreen
        Me.sbyname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sbyname.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sbyname.ForeColor = System.Drawing.SystemColors.Window
        Me.sbyname.FormattingEnabled = True
        Me.sbyname.Location = New System.Drawing.Point(49, 89)
        Me.sbyname.Name = "sbyname"
        Me.sbyname.Size = New System.Drawing.Size(424, 24)
        Me.sbyname.TabIndex = 34
        Me.sbyname.Text = "Search Plant by Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(45, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 24)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Search"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuFlatButton7)
        Me.Panel1.Controls.Add(Me.logo)
        Me.Panel1.Controls.Add(Me.BunifuFlatButton4)
        Me.Panel1.Controls.Add(Me.BunifuFlatButton3)
        Me.Panel1.Controls.Add(Me.BunifuFlatButton2)
        Me.Panel1.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 613)
        Me.Panel1.TabIndex = 9
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Header
        Me.BunifuDragControl1.Vertical = True
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Header.Controls.Add(Me.BunifuImageButton2)
        Me.Header.Controls.Add(Me.headerLabel)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1314, 35)
        Me.Header.TabIndex = 10
        '
        'headerLabel
        '
        Me.headerLabel.AutoSize = True
        Me.headerLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.headerLabel.Location = New System.Drawing.Point(32, 7)
        Me.headerLabel.Name = "headerLabel"
        Me.headerLabel.Size = New System.Drawing.Size(162, 21)
        Me.headerLabel.TabIndex = 0
        Me.headerLabel.Text = "Wiki Plants | Search"
        '
        'PlantDataSet1
        '
        Me.PlantDataSet1.DataSetName = "PlantDataSet1"
        Me.PlantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BIOBindingSource
        '
        Me.BIOBindingSource.DataMember = "BIO"
        Me.BIOBindingSource.DataSource = Me.PlantDataSet1
        '
        'BIOTableAdapter
        '
        Me.BIOTableAdapter.ClearBeforeFill = True
        '
        'PLANTBindingSource1
        '
        Me.PLANTBindingSource1.DataMember = "PLANT"
        Me.PLANTBindingSource1.DataSource = Me.PlantDataSet
        '
        'getInfo1
        '
        Me.getInfo1.ActiveBorderThickness = 1
        Me.getInfo1.ActiveCornerRadius = 30
        Me.getInfo1.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.getInfo1.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.getInfo1.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.getInfo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.getInfo1.BackgroundImage = CType(resources.GetObject("getInfo1.BackgroundImage"), System.Drawing.Image)
        Me.getInfo1.ButtonText = "Get Info"
        Me.getInfo1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.getInfo1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.getInfo1.ForeColor = System.Drawing.Color.SeaGreen
        Me.getInfo1.IdleBorderThickness = 1
        Me.getInfo1.IdleCornerRadius = 20
        Me.getInfo1.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.getInfo1.IdleForecolor = System.Drawing.Color.Honeydew
        Me.getInfo1.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.getInfo1.Location = New System.Drawing.Point(726, 241)
        Me.getInfo1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.getInfo1.Name = "getInfo1"
        Me.getInfo1.Size = New System.Drawing.Size(110, 40)
        Me.getInfo1.TabIndex = 53
        Me.getInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.getInfo1.Visible = False
        '
        'addFav1
        '
        Me.addFav1.ActiveBorderThickness = 1
        Me.addFav1.ActiveCornerRadius = 30
        Me.addFav1.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.addFav1.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.addFav1.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.addFav1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.addFav1.BackgroundImage = CType(resources.GetObject("addFav1.BackgroundImage"), System.Drawing.Image)
        Me.addFav1.ButtonText = "Add Favoutites"
        Me.addFav1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addFav1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addFav1.ForeColor = System.Drawing.Color.SeaGreen
        Me.addFav1.IdleBorderThickness = 1
        Me.addFav1.IdleCornerRadius = 20
        Me.addFav1.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.addFav1.IdleForecolor = System.Drawing.Color.Honeydew
        Me.addFav1.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.addFav1.Location = New System.Drawing.Point(726, 289)
        Me.addFav1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.addFav1.Name = "addFav1"
        Me.addFav1.Size = New System.Drawing.Size(110, 40)
        Me.addFav1.TabIndex = 54
        Me.addFav1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.addFav1.Visible = False
        '
        'BunifuFlatButton6
        '
        Me.BunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton6.BorderRadius = 0
        Me.BunifuFlatButton6.ButtonText = "    Search"
        Me.BunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.Iconimage = CType(resources.GetObject("BunifuFlatButton6.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton6.Iconimage_right = Nothing
        Me.BunifuFlatButton6.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton6.Iconimage_Selected = Nothing
        Me.BunifuFlatButton6.IconMarginLeft = 0
        Me.BunifuFlatButton6.IconMarginRight = 0
        Me.BunifuFlatButton6.IconRightVisible = True
        Me.BunifuFlatButton6.IconRightZoom = 0.0R
        Me.BunifuFlatButton6.IconVisible = True
        Me.BunifuFlatButton6.IconZoom = 30.0R
        Me.BunifuFlatButton6.IsTab = False
        Me.BunifuFlatButton6.Location = New System.Drawing.Point(479, 120)
        Me.BunifuFlatButton6.Name = "BunifuFlatButton6"
        Me.BunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton6.selected = False
        Me.BunifuFlatButton6.Size = New System.Drawing.Size(118, 24)
        Me.BunifuFlatButton6.TabIndex = 37
        Me.BunifuFlatButton6.Text = "    Search"
        Me.BunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton6.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton6.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 0
        Me.BunifuFlatButton5.ButtonText = "    Search"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = CType(resources.GetObject("BunifuFlatButton5.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = True
        Me.BunifuFlatButton5.IconRightZoom = 0.0R
        Me.BunifuFlatButton5.IconVisible = True
        Me.BunifuFlatButton5.IconZoom = 30.0R
        Me.BunifuFlatButton5.IsTab = False
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(479, 88)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(118, 24)
        Me.BunifuFlatButton5.TabIndex = 36
        Me.BunifuFlatButton5.Text = "    Search"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'resultPpicture
        '
        Me.resultPpicture.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.PLANTBindingSource, "p_img", True))
        Me.resultPpicture.Enabled = False
        Me.resultPpicture.Location = New System.Drawing.Point(84, 229)
        Me.resultPpicture.Name = "resultPpicture"
        Me.resultPpicture.Size = New System.Drawing.Size(112, 117)
        Me.resultPpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.resultPpicture.TabIndex = 49
        Me.resultPpicture.TabStop = False
        Me.resultPpicture.Visible = False
        '
        'resultaddFav
        '
        Me.resultaddFav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.resultaddFav.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.resultaddFav.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.resultaddFav.Image = CType(resources.GetObject("resultaddFav.Image"), System.Drawing.Image)
        Me.resultaddFav.Location = New System.Drawing.Point(780, 300)
        Me.resultaddFav.Name = "resultaddFav"
        Me.resultaddFav.Size = New System.Drawing.Size(10, 15)
        Me.resultaddFav.TabIndex = 56
        Me.resultaddFav.UseVisualStyleBackColor = True
        Me.resultaddFav.Visible = False
        '
        'resultgetInfo
        '
        Me.resultgetInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.resultgetInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.resultgetInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.resultgetInfo.Image = CType(resources.GetObject("resultgetInfo.Image"), System.Drawing.Image)
        Me.resultgetInfo.Location = New System.Drawing.Point(780, 251)
        Me.resultgetInfo.Name = "resultgetInfo"
        Me.resultgetInfo.Size = New System.Drawing.Size(10, 20)
        Me.resultgetInfo.TabIndex = 55
        Me.resultgetInfo.UseVisualStyleBackColor = True
        Me.resultgetInfo.Visible = False
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(14, 20)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(211, 93)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 7
        Me.logo.TabStop = False
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = "About Us"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = Global.Wiki_Plants.My.Resources.Resources.About_us_icon1
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0.0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 40.0R
        Me.BunifuFlatButton4.IsTab = True
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(0, 356)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(241, 48)
        Me.BunifuFlatButton4.TabIndex = 5
        Me.BunifuFlatButton4.Text = "About Us"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "Favourite List"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = CType(resources.GetObject("BunifuFlatButton3.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0.0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 35.0R
        Me.BunifuFlatButton3.IsTab = True
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(-1, 248)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(241, 48)
        Me.BunifuFlatButton3.TabIndex = 4
        Me.BunifuFlatButton3.Text = "Favourite List"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Search"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = CType(resources.GetObject("BunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0.0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 35.0R
        Me.BunifuFlatButton2.IsTab = True
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(-2, 194)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(241, 48)
        Me.BunifuFlatButton2.TabIndex = 3
        Me.BunifuFlatButton2.Text = "Search"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Home"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0.0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 35.0R
        Me.BunifuFlatButton1.IsTab = True
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 146)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(241, 48)
        Me.BunifuFlatButton1.TabIndex = 2
        Me.BunifuFlatButton1.Text = "Home"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(1280, 7)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(22, 22)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton2.TabIndex = 3
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 20
        '
        'BunifuFlatButton7
        '
        Me.BunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton7.BorderRadius = 0
        Me.BunifuFlatButton7.ButtonText = "Report"
        Me.BunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.Iconimage = Global.Wiki_Plants.My.Resources.Resources.rep
        Me.BunifuFlatButton7.Iconimage_right = Nothing
        Me.BunifuFlatButton7.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton7.Iconimage_Selected = Nothing
        Me.BunifuFlatButton7.IconMarginLeft = 0
        Me.BunifuFlatButton7.IconMarginRight = 0
        Me.BunifuFlatButton7.IconRightVisible = True
        Me.BunifuFlatButton7.IconRightZoom = 0.0R
        Me.BunifuFlatButton7.IconVisible = True
        Me.BunifuFlatButton7.IconZoom = 40.0R
        Me.BunifuFlatButton7.IsTab = True
        Me.BunifuFlatButton7.Location = New System.Drawing.Point(-1, 302)
        Me.BunifuFlatButton7.Name = "BunifuFlatButton7"
        Me.BunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton7.selected = False
        Me.BunifuFlatButton7.Size = New System.Drawing.Size(241, 48)
        Me.BunifuFlatButton7.TabIndex = 8
        Me.BunifuFlatButton7.Text = "Report"
        Me.BunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton7.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton7.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1314, 648)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        CType(Me.PlantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLANTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        CType(Me.PlantDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLANTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.resultPpicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableAdapterManager As Wiki_Plants.PlantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PLANTTableAdapter As Wiki_Plants.PlantDataSetTableAdapters.PLANTTableAdapter
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PlantDataSet As Wiki_Plants.PlantDataSet
    Friend WithEvents PLANTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Header As System.Windows.Forms.Panel
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents headerLabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents sbyname As System.Windows.Forms.ComboBox
    Friend WithEvents PlantDataSet1 As Wiki_Plants.PlantDataSet1
    Friend WithEvents BIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BIOTableAdapter As Wiki_Plants.PlantDataSet1TableAdapters.BIOTableAdapter
    Friend WithEvents PLANTBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents sbyid As System.Windows.Forms.ComboBox
    Friend WithEvents BunifuFlatButton6 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents resultPname As System.Windows.Forms.TextBox
    Friend WithEvents getInfo1 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents resultPpicture As System.Windows.Forms.PictureBox
    Friend WithEvents resultaddFav As System.Windows.Forms.Button
    Friend WithEvents resultPID As System.Windows.Forms.TextBox
    Friend WithEvents resultgetInfo As System.Windows.Forms.Button
    Friend WithEvents addFav1 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents resultPlantID1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents resultPlantName1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuFlatButton7 As Bunifu.Framework.UI.BunifuFlatButton
End Class
