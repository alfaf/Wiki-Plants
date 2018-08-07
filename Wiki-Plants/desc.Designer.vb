<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class desc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(desc))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Header = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.descriptionPanel = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BIOTabPage = New System.Windows.Forms.TabPage()
        Me.tbscn = New System.Windows.Forms.TextBox()
        Me.tbgenus = New System.Windows.Forms.TextBox()
        Me.tbcolor = New System.Windows.Forms.TextBox()
        Me.tbfamily = New System.Windows.Forms.TextBox()
        Me.tbpID = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.DescTabPage = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbloc = New System.Windows.Forms.TextBox()
        Me.tbseason = New System.Windows.Forms.TextBox()
        Me.tbgrowth = New System.Windows.Forms.TextBox()
        Me.tbdesc = New System.Windows.Forms.TextBox()
        Me.AdvaTabPage = New System.Windows.Forms.TabPage()
        Me.tbadv = New System.Windows.Forms.TextBox()
        Me.DisadvaTabPage = New System.Windows.Forms.TabPage()
        Me.tbdisadv = New System.Windows.Forms.TextBox()
        Me.ConatactTabPage = New System.Windows.Forms.TabPage()
        Me.tbseloc = New System.Windows.Forms.TextBox()
        Me.tbemail = New System.Windows.Forms.TextBox()
        Me.tbselno = New System.Windows.Forms.TextBox()
        Me.tbselname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbplant = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.BunifuFlatButton10 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton9 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.plantPicture = New System.Windows.Forms.PictureBox()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Header.SuspendLayout()
        Me.descriptionPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.BIOTabPage.SuspendLayout()
        Me.DescTabPage.SuspendLayout()
        Me.AdvaTabPage.SuspendLayout()
        Me.DisadvaTabPage.SuspendLayout()
        Me.ConatactTabPage.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plantPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Header.Controls.Add(Me.BunifuImageButton2)
        Me.Header.Controls.Add(Me.BunifuCustomLabel1)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1314, 35)
        Me.Header.TabIndex = 2
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(32, 7)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(195, 21)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Wiki Plants | Description"
        '
        'descriptionPanel
        '
        Me.descriptionPanel.Controls.Add(Me.logo)
        Me.descriptionPanel.Controls.Add(Me.BunifuFlatButton10)
        Me.descriptionPanel.Controls.Add(Me.BunifuFlatButton9)
        Me.descriptionPanel.Controls.Add(Me.TabControl1)
        Me.descriptionPanel.Controls.Add(Me.tbplant)
        Me.descriptionPanel.Controls.Add(Me.plantPicture)
        Me.descriptionPanel.Controls.Add(Me.BunifuFlatButton5)
        Me.descriptionPanel.Location = New System.Drawing.Point(12, 41)
        Me.descriptionPanel.Name = "descriptionPanel"
        Me.descriptionPanel.Size = New System.Drawing.Size(1218, 548)
        Me.descriptionPanel.TabIndex = 17
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.BIOTabPage)
        Me.TabControl1.Controls.Add(Me.DescTabPage)
        Me.TabControl1.Controls.Add(Me.AdvaTabPage)
        Me.TabControl1.Controls.Add(Me.DisadvaTabPage)
        Me.TabControl1.Controls.Add(Me.ConatactTabPage)
        Me.TabControl1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(614, 153)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(570, 290)
        Me.TabControl1.TabIndex = 3
        '
        'BIOTabPage
        '
        Me.BIOTabPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BIOTabPage.Controls.Add(Me.tbscn)
        Me.BIOTabPage.Controls.Add(Me.tbgenus)
        Me.BIOTabPage.Controls.Add(Me.tbcolor)
        Me.BIOTabPage.Controls.Add(Me.tbfamily)
        Me.BIOTabPage.Controls.Add(Me.tbpID)
        Me.BIOTabPage.Controls.Add(Me.BunifuCustomLabel6)
        Me.BIOTabPage.Controls.Add(Me.BunifuCustomLabel5)
        Me.BIOTabPage.Controls.Add(Me.BunifuCustomLabel4)
        Me.BIOTabPage.Controls.Add(Me.BunifuCustomLabel3)
        Me.BIOTabPage.Controls.Add(Me.BunifuCustomLabel2)
        Me.BIOTabPage.Location = New System.Drawing.Point(4, 25)
        Me.BIOTabPage.Name = "BIOTabPage"
        Me.BIOTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.BIOTabPage.Size = New System.Drawing.Size(562, 261)
        Me.BIOTabPage.TabIndex = 0
        Me.BIOTabPage.Text = "BIO"
        '
        'tbscn
        '
        Me.tbscn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbscn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbscn.Enabled = False
        Me.tbscn.ForeColor = System.Drawing.SystemColors.Window
        Me.tbscn.Location = New System.Drawing.Point(144, 66)
        Me.tbscn.Name = "tbscn"
        Me.tbscn.Size = New System.Drawing.Size(388, 21)
        Me.tbscn.TabIndex = 9
        '
        'tbgenus
        '
        Me.tbgenus.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbgenus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbgenus.Enabled = False
        Me.tbgenus.ForeColor = System.Drawing.SystemColors.Window
        Me.tbgenus.Location = New System.Drawing.Point(144, 165)
        Me.tbgenus.Name = "tbgenus"
        Me.tbgenus.Size = New System.Drawing.Size(388, 21)
        Me.tbgenus.TabIndex = 8
        '
        'tbcolor
        '
        Me.tbcolor.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbcolor.Enabled = False
        Me.tbcolor.ForeColor = System.Drawing.SystemColors.Window
        Me.tbcolor.Location = New System.Drawing.Point(144, 132)
        Me.tbcolor.Name = "tbcolor"
        Me.tbcolor.Size = New System.Drawing.Size(388, 21)
        Me.tbcolor.TabIndex = 7
        '
        'tbfamily
        '
        Me.tbfamily.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbfamily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbfamily.Enabled = False
        Me.tbfamily.ForeColor = System.Drawing.SystemColors.Window
        Me.tbfamily.Location = New System.Drawing.Point(144, 100)
        Me.tbfamily.Name = "tbfamily"
        Me.tbfamily.Size = New System.Drawing.Size(388, 21)
        Me.tbfamily.TabIndex = 6
        '
        'tbpID
        '
        Me.tbpID.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpID.Enabled = False
        Me.tbpID.ForeColor = System.Drawing.SystemColors.Window
        Me.tbpID.Location = New System.Drawing.Point(144, 30)
        Me.tbpID.Name = "tbpID"
        Me.tbpID.Size = New System.Drawing.Size(388, 21)
        Me.tbpID.TabIndex = 5
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(32, 66)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(97, 16)
        Me.BunifuCustomLabel6.TabIndex = 4
        Me.BunifuCustomLabel6.Text = "Scientific Name: "
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(81, 100)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(47, 16)
        Me.BunifuCustomLabel5.TabIndex = 3
        Me.BunifuCustomLabel5.Text = "Family: "
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(85, 132)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(42, 16)
        Me.BunifuCustomLabel4.TabIndex = 2
        Me.BunifuCustomLabel4.Text = "Color: "
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(77, 165)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(49, 16)
        Me.BunifuCustomLabel3.TabIndex = 1
        Me.BunifuCustomLabel3.Text = "Genus: "
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(73, 33)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(56, 16)
        Me.BunifuCustomLabel2.TabIndex = 0
        Me.BunifuCustomLabel2.Text = "Plant ID: "
        '
        'DescTabPage
        '
        Me.DescTabPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DescTabPage.Controls.Add(Me.Label4)
        Me.DescTabPage.Controls.Add(Me.Label3)
        Me.DescTabPage.Controls.Add(Me.Label2)
        Me.DescTabPage.Controls.Add(Me.tbloc)
        Me.DescTabPage.Controls.Add(Me.tbseason)
        Me.DescTabPage.Controls.Add(Me.tbgrowth)
        Me.DescTabPage.Controls.Add(Me.tbdesc)
        Me.DescTabPage.Location = New System.Drawing.Point(4, 25)
        Me.DescTabPage.Name = "DescTabPage"
        Me.DescTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DescTabPage.Size = New System.Drawing.Size(562, 261)
        Me.DescTabPage.TabIndex = 1
        Me.DescTabPage.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(51, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Location Commonly Found: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(83, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Growth Requirement: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(157, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Season: "
        '
        'tbloc
        '
        Me.tbloc.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbloc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbloc.Enabled = False
        Me.tbloc.ForeColor = System.Drawing.SystemColors.Window
        Me.tbloc.Location = New System.Drawing.Point(225, 133)
        Me.tbloc.Name = "tbloc"
        Me.tbloc.Size = New System.Drawing.Size(305, 21)
        Me.tbloc.TabIndex = 3
        '
        'tbseason
        '
        Me.tbseason.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbseason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbseason.Enabled = False
        Me.tbseason.ForeColor = System.Drawing.SystemColors.Window
        Me.tbseason.Location = New System.Drawing.Point(225, 98)
        Me.tbseason.Name = "tbseason"
        Me.tbseason.Size = New System.Drawing.Size(305, 21)
        Me.tbseason.TabIndex = 2
        '
        'tbgrowth
        '
        Me.tbgrowth.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbgrowth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbgrowth.Enabled = False
        Me.tbgrowth.ForeColor = System.Drawing.SystemColors.Window
        Me.tbgrowth.Location = New System.Drawing.Point(38, 186)
        Me.tbgrowth.Multiline = True
        Me.tbgrowth.Name = "tbgrowth"
        Me.tbgrowth.Size = New System.Drawing.Size(492, 57)
        Me.tbgrowth.TabIndex = 1
        '
        'tbdesc
        '
        Me.tbdesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbdesc.Enabled = False
        Me.tbdesc.ForeColor = System.Drawing.SystemColors.Window
        Me.tbdesc.Location = New System.Drawing.Point(38, 28)
        Me.tbdesc.Multiline = True
        Me.tbdesc.Name = "tbdesc"
        Me.tbdesc.Size = New System.Drawing.Size(492, 57)
        Me.tbdesc.TabIndex = 0
        '
        'AdvaTabPage
        '
        Me.AdvaTabPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.AdvaTabPage.Controls.Add(Me.tbadv)
        Me.AdvaTabPage.Location = New System.Drawing.Point(4, 25)
        Me.AdvaTabPage.Name = "AdvaTabPage"
        Me.AdvaTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.AdvaTabPage.Size = New System.Drawing.Size(562, 261)
        Me.AdvaTabPage.TabIndex = 2
        Me.AdvaTabPage.Text = "Advantages"
        '
        'tbadv
        '
        Me.tbadv.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbadv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbadv.Enabled = False
        Me.tbadv.ForeColor = System.Drawing.SystemColors.Window
        Me.tbadv.Location = New System.Drawing.Point(31, 28)
        Me.tbadv.Multiline = True
        Me.tbadv.Name = "tbadv"
        Me.tbadv.Size = New System.Drawing.Size(503, 205)
        Me.tbadv.TabIndex = 0
        '
        'DisadvaTabPage
        '
        Me.DisadvaTabPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DisadvaTabPage.Controls.Add(Me.tbdisadv)
        Me.DisadvaTabPage.Location = New System.Drawing.Point(4, 25)
        Me.DisadvaTabPage.Name = "DisadvaTabPage"
        Me.DisadvaTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DisadvaTabPage.Size = New System.Drawing.Size(562, 261)
        Me.DisadvaTabPage.TabIndex = 3
        Me.DisadvaTabPage.Text = "Disadvantages"
        '
        'tbdisadv
        '
        Me.tbdisadv.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbdisadv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbdisadv.Enabled = False
        Me.tbdisadv.ForeColor = System.Drawing.SystemColors.Window
        Me.tbdisadv.Location = New System.Drawing.Point(30, 28)
        Me.tbdisadv.Multiline = True
        Me.tbdisadv.Name = "tbdisadv"
        Me.tbdisadv.Size = New System.Drawing.Size(503, 205)
        Me.tbdisadv.TabIndex = 1
        '
        'ConatactTabPage
        '
        Me.ConatactTabPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ConatactTabPage.Controls.Add(Me.tbseloc)
        Me.ConatactTabPage.Controls.Add(Me.tbemail)
        Me.ConatactTabPage.Controls.Add(Me.tbselno)
        Me.ConatactTabPage.Controls.Add(Me.tbselname)
        Me.ConatactTabPage.Controls.Add(Me.Label9)
        Me.ConatactTabPage.Controls.Add(Me.Label8)
        Me.ConatactTabPage.Controls.Add(Me.Label7)
        Me.ConatactTabPage.Controls.Add(Me.Label5)
        Me.ConatactTabPage.Location = New System.Drawing.Point(4, 25)
        Me.ConatactTabPage.Name = "ConatactTabPage"
        Me.ConatactTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ConatactTabPage.Size = New System.Drawing.Size(562, 261)
        Me.ConatactTabPage.TabIndex = 4
        Me.ConatactTabPage.Text = "Seller Details"
        '
        'tbseloc
        '
        Me.tbseloc.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbseloc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbseloc.Enabled = False
        Me.tbseloc.ForeColor = System.Drawing.SystemColors.Window
        Me.tbseloc.Location = New System.Drawing.Point(155, 71)
        Me.tbseloc.Name = "tbseloc"
        Me.tbseloc.Size = New System.Drawing.Size(368, 21)
        Me.tbseloc.TabIndex = 8
        '
        'tbemail
        '
        Me.tbemail.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbemail.Enabled = False
        Me.tbemail.ForeColor = System.Drawing.SystemColors.Window
        Me.tbemail.Location = New System.Drawing.Point(155, 134)
        Me.tbemail.Name = "tbemail"
        Me.tbemail.Size = New System.Drawing.Size(368, 21)
        Me.tbemail.TabIndex = 7
        '
        'tbselno
        '
        Me.tbselno.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbselno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbselno.Enabled = False
        Me.tbselno.ForeColor = System.Drawing.SystemColors.Window
        Me.tbselno.Location = New System.Drawing.Point(155, 104)
        Me.tbselno.Name = "tbselno"
        Me.tbselno.Size = New System.Drawing.Size(368, 21)
        Me.tbselno.TabIndex = 6
        '
        'tbselname
        '
        Me.tbselname.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbselname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbselname.Enabled = False
        Me.tbselname.ForeColor = System.Drawing.SystemColors.Window
        Me.tbselname.Location = New System.Drawing.Point(155, 42)
        Me.tbselname.Name = "tbselname"
        Me.tbselname.Size = New System.Drawing.Size(368, 21)
        Me.tbselname.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(89, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Location: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(44, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Contact Number: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(94, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Email ID: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(72, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Seller Name: "
        '
        'tbplant
        '
        Me.tbplant.AutoSize = True
        Me.tbplant.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbplant.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbplant.Location = New System.Drawing.Point(602, 94)
        Me.tbplant.Name = "tbplant"
        Me.tbplant.Size = New System.Drawing.Size(165, 22)
        Me.tbplant.TabIndex = 2
        Me.tbplant.Text = "Plant Name Here"
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(3, 14)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(211, 93)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 18
        Me.logo.TabStop = False
        '
        'BunifuFlatButton10
        '
        Me.BunifuFlatButton10.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton10.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton10.BorderRadius = 0
        Me.BunifuFlatButton10.ButtonText = "Add to Favorites"
        Me.BunifuFlatButton10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton10.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton10.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton10.Iconimage = CType(resources.GetObject("BunifuFlatButton10.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton10.Iconimage_right = Nothing
        Me.BunifuFlatButton10.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton10.Iconimage_Selected = Nothing
        Me.BunifuFlatButton10.IconMarginLeft = 0
        Me.BunifuFlatButton10.IconMarginRight = 0
        Me.BunifuFlatButton10.IconRightVisible = True
        Me.BunifuFlatButton10.IconRightZoom = 0.0R
        Me.BunifuFlatButton10.IconVisible = True
        Me.BunifuFlatButton10.IconZoom = 50.0R
        Me.BunifuFlatButton10.IsTab = False
        Me.BunifuFlatButton10.Location = New System.Drawing.Point(411, 461)
        Me.BunifuFlatButton10.Name = "BunifuFlatButton10"
        Me.BunifuFlatButton10.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton10.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton10.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton10.selected = False
        Me.BunifuFlatButton10.Size = New System.Drawing.Size(155, 48)
        Me.BunifuFlatButton10.TabIndex = 8
        Me.BunifuFlatButton10.Text = "Add to Favorites"
        Me.BunifuFlatButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton10.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton10.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton9
        '
        Me.BunifuFlatButton9.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton9.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton9.BorderRadius = 0
        Me.BunifuFlatButton9.ButtonText = "Get Seller Details"
        Me.BunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton9.Iconimage = CType(resources.GetObject("BunifuFlatButton9.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton9.Iconimage_right = Nothing
        Me.BunifuFlatButton9.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton9.Iconimage_Selected = Nothing
        Me.BunifuFlatButton9.IconMarginLeft = 0
        Me.BunifuFlatButton9.IconMarginRight = 0
        Me.BunifuFlatButton9.IconRightVisible = True
        Me.BunifuFlatButton9.IconRightZoom = 0.0R
        Me.BunifuFlatButton9.IconVisible = True
        Me.BunifuFlatButton9.IconZoom = 90.0R
        Me.BunifuFlatButton9.IsTab = False
        Me.BunifuFlatButton9.Location = New System.Drawing.Point(259, 461)
        Me.BunifuFlatButton9.Name = "BunifuFlatButton9"
        Me.BunifuFlatButton9.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton9.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton9.selected = False
        Me.BunifuFlatButton9.Size = New System.Drawing.Size(146, 48)
        Me.BunifuFlatButton9.TabIndex = 7
        Me.BunifuFlatButton9.Text = "Get Seller Details"
        Me.BunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton9.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton9.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'plantPicture
        '
        Me.plantPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.plantPicture.Enabled = False
        Me.plantPicture.Location = New System.Drawing.Point(259, 94)
        Me.plantPicture.Name = "plantPicture"
        Me.plantPicture.Size = New System.Drawing.Size(307, 349)
        Me.plantPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.plantPicture.TabIndex = 1
        Me.plantPicture.TabStop = False
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuFlatButton5.BorderRadius = 0
        Me.BunifuFlatButton5.ButtonText = ""
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
        Me.BunifuFlatButton5.IconZoom = 90.0R
        Me.BunifuFlatButton5.IsTab = False
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(213, 102)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(25, 25)
        Me.BunifuFlatButton5.TabIndex = 0
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(1280, 10)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(22, 22)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton2.TabIndex = 3
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 20
        '
        'desc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1314, 648)
        Me.Controls.Add(Me.descriptionPanel)
        Me.Controls.Add(Me.Header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "desc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "desc"
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        Me.descriptionPanel.ResumeLayout(False)
        Me.descriptionPanel.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.BIOTabPage.ResumeLayout(False)
        Me.BIOTabPage.PerformLayout()
        Me.DescTabPage.ResumeLayout(False)
        Me.DescTabPage.PerformLayout()
        Me.AdvaTabPage.ResumeLayout(False)
        Me.AdvaTabPage.PerformLayout()
        Me.DisadvaTabPage.ResumeLayout(False)
        Me.DisadvaTabPage.PerformLayout()
        Me.ConatactTabPage.ResumeLayout(False)
        Me.ConatactTabPage.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plantPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Header As System.Windows.Forms.Panel
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents descriptionPanel As System.Windows.Forms.Panel
    Friend WithEvents BunifuFlatButton10 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton9 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents BIOTabPage As System.Windows.Forms.TabPage
    Friend WithEvents tbscn As System.Windows.Forms.TextBox
    Friend WithEvents tbgenus As System.Windows.Forms.TextBox
    Friend WithEvents tbcolor As System.Windows.Forms.TextBox
    Friend WithEvents tbfamily As System.Windows.Forms.TextBox
    Friend WithEvents tbpID As System.Windows.Forms.TextBox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents DescTabPage As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbloc As System.Windows.Forms.TextBox
    Friend WithEvents tbseason As System.Windows.Forms.TextBox
    Friend WithEvents tbgrowth As System.Windows.Forms.TextBox
    Friend WithEvents tbdesc As System.Windows.Forms.TextBox
    Friend WithEvents AdvaTabPage As System.Windows.Forms.TabPage
    Friend WithEvents tbadv As System.Windows.Forms.TextBox
    Friend WithEvents DisadvaTabPage As System.Windows.Forms.TabPage
    Friend WithEvents tbdisadv As System.Windows.Forms.TextBox
    Friend WithEvents ConatactTabPage As System.Windows.Forms.TabPage
    Friend WithEvents tbseloc As System.Windows.Forms.TextBox
    Friend WithEvents tbemail As System.Windows.Forms.TextBox
    Friend WithEvents tbselno As System.Windows.Forms.TextBox
    Friend WithEvents tbselname As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbplant As System.Windows.Forms.Label
    Friend WithEvents plantPicture As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents logo As System.Windows.Forms.PictureBox
End Class
