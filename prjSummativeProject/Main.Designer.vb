<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Mordor = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picMap = New System.Windows.Forms.PictureBox()
        Me.plcNurnen = New System.Windows.Forms.Label()
        Me.plcKazaDoom = New System.Windows.Forms.Label()
        Me.plcMtDoom = New System.Windows.Forms.Label()
        Me.plcDeadMarsh = New System.Windows.Forms.Label()
        Me.plcLithland = New System.Windows.Forms.Label()
        Me.plcMinasMorgle = New System.Windows.Forms.Label()
        Me.picDot = New System.Windows.Forms.PictureBox()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabStats = New System.Windows.Forms.TabPage()
        Me.ldbXpBar = New System.Windows.Forms.ProgressBar()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.lblCharacter = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Stats = New System.Windows.Forms.GroupBox()
        Me.lblMaxHealth = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ldbHealthBar = New System.Windows.Forms.ProgressBar()
        Me.lblDefence = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblAttack = New System.Windows.Forms.Label()
        Me.lblHealth = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tabInventory = New System.Windows.Forms.TabPage()
        Me.lblItemInfo = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnUse = New System.Windows.Forms.Button()
        Me.btnSellItem = New System.Windows.Forms.Button()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbItem = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbxInventory = New System.Windows.Forms.ListBox()
        Me.tabStore = New System.Windows.Forms.TabPage()
        Me.lblStoreMoney = New System.Windows.Forms.Label()
        Me.lblStoreItemInfo = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnBuyItem = New System.Windows.Forms.Button()
        Me.tbStoreItem = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbStorePrice = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbxBuy = New System.Windows.Forms.ListBox()
        Me.Label18 = New System.Windows.Forms.Label()
        CType(Me.picMap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.tabStats.SuspendLayout()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Stats.SuspendLayout()
        Me.tabInventory.SuspendLayout()
        Me.tabStore.SuspendLayout()
        Me.SuspendLayout()
        '
        'Mordor
        '
        Me.Mordor.AutoSize = True
        Me.Mordor.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mordor.Location = New System.Drawing.Point(220, -1)
        Me.Mordor.Name = "Mordor"
        Me.Mordor.Size = New System.Drawing.Size(138, 31)
        Me.Mordor.TabIndex = 2
        Me.Mordor.Text = "MORDOR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(263, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Map"
        '
        'picMap
        '
        Me.picMap.Image = CType(resources.GetObject("picMap.Image"), System.Drawing.Image)
        Me.picMap.Location = New System.Drawing.Point(12, 54)
        Me.picMap.Name = "picMap"
        Me.picMap.Size = New System.Drawing.Size(543, 445)
        Me.picMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMap.TabIndex = 8
        Me.picMap.TabStop = False
        '
        'plcNurnen
        '
        Me.plcNurnen.AutoSize = True
        Me.plcNurnen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plcNurnen.Location = New System.Drawing.Point(249, 315)
        Me.plcNurnen.Name = "plcNurnen"
        Me.plcNurnen.Size = New System.Drawing.Size(61, 20)
        Me.plcNurnen.TabIndex = 9
        Me.plcNurnen.Text = "Nurnen"
        '
        'plcKazaDoom
        '
        Me.plcKazaDoom.AutoSize = True
        Me.plcKazaDoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plcKazaDoom.Location = New System.Drawing.Point(412, 263)
        Me.plcKazaDoom.Name = "plcKazaDoom"
        Me.plcKazaDoom.Size = New System.Drawing.Size(92, 20)
        Me.plcKazaDoom.TabIndex = 10
        Me.plcKazaDoom.Text = "Kaza Doom"
        '
        'plcMtDoom
        '
        Me.plcMtDoom.AutoSize = True
        Me.plcMtDoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plcMtDoom.Location = New System.Drawing.Point(153, 198)
        Me.plcMtDoom.Name = "plcMtDoom"
        Me.plcMtDoom.Size = New System.Drawing.Size(74, 20)
        Me.plcMtDoom.TabIndex = 11
        Me.plcMtDoom.Text = "Mt.Doom"
        '
        'plcDeadMarsh
        '
        Me.plcDeadMarsh.AutoSize = True
        Me.plcDeadMarsh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plcDeadMarsh.Location = New System.Drawing.Point(83, 113)
        Me.plcDeadMarsh.Name = "plcDeadMarsh"
        Me.plcDeadMarsh.Size = New System.Drawing.Size(113, 20)
        Me.plcDeadMarsh.TabIndex = 12
        Me.plcDeadMarsh.Text = "Dead Marshes"
        '
        'plcLithland
        '
        Me.plcLithland.AutoSize = True
        Me.plcLithland.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plcLithland.Location = New System.Drawing.Point(391, 185)
        Me.plcLithland.Name = "plcLithland"
        Me.plcLithland.Size = New System.Drawing.Size(65, 20)
        Me.plcLithland.TabIndex = 13
        Me.plcLithland.Text = "Lithland"
        '
        'plcMinasMorgle
        '
        Me.plcMinasMorgle.AutoSize = True
        Me.plcMinasMorgle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plcMinasMorgle.Location = New System.Drawing.Point(83, 268)
        Me.plcMinasMorgle.Name = "plcMinasMorgle"
        Me.plcMinasMorgle.Size = New System.Drawing.Size(103, 20)
        Me.plcMinasMorgle.TabIndex = 14
        Me.plcMinasMorgle.Text = "Minas Morgle"
        '
        'picDot
        '
        Me.picDot.Image = CType(resources.GetObject("picDot.Image"), System.Drawing.Image)
        Me.picDot.Location = New System.Drawing.Point(64, 429)
        Me.picDot.Name = "picDot"
        Me.picDot.Size = New System.Drawing.Size(20, 20)
        Me.picDot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picDot.TabIndex = 15
        Me.picDot.TabStop = False
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabStats)
        Me.tabMain.Controls.Add(Me.tabInventory)
        Me.tabMain.Controls.Add(Me.tabStore)
        Me.tabMain.Location = New System.Drawing.Point(561, 9)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(287, 501)
        Me.tabMain.TabIndex = 16
        '
        'tabStats
        '
        Me.tabStats.Controls.Add(Me.ldbXpBar)
        Me.tabStats.Controls.Add(Me.lblLevel)
        Me.tabStats.Controls.Add(Me.Label15)
        Me.tabStats.Controls.Add(Me.Label14)
        Me.tabStats.Controls.Add(Me.picPlayer)
        Me.tabStats.Controls.Add(Me.lblCharacter)
        Me.tabStats.Controls.Add(Me.lblInfo)
        Me.tabStats.Controls.Add(Me.Stats)
        Me.tabStats.Controls.Add(Me.Label7)
        Me.tabStats.Location = New System.Drawing.Point(4, 22)
        Me.tabStats.Name = "tabStats"
        Me.tabStats.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStats.Size = New System.Drawing.Size(279, 475)
        Me.tabStats.TabIndex = 0
        Me.tabStats.Text = "Stats"
        Me.tabStats.UseVisualStyleBackColor = True
        '
        'ldbXpBar
        '
        Me.ldbXpBar.Location = New System.Drawing.Point(145, 352)
        Me.ldbXpBar.Maximum = 5
        Me.ldbXpBar.Name = "ldbXpBar"
        Me.ldbXpBar.Size = New System.Drawing.Size(120, 21)
        Me.ldbXpBar.Step = 1
        Me.ldbXpBar.TabIndex = 31
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(159, 300)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(18, 20)
        Me.lblLevel.TabIndex = 29
        Me.lblLevel.Text = "1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(109, 353)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 20)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "XP:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(109, 300)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 20)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Level:"
        '
        'picPlayer
        '
        Me.picPlayer.Image = CType(resources.GetObject("picPlayer.Image"), System.Drawing.Image)
        Me.picPlayer.Location = New System.Drawing.Point(6, 300)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(93, 141)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 25
        Me.picPlayer.TabStop = False
        '
        'lblCharacter
        '
        Me.lblCharacter.AutoSize = True
        Me.lblCharacter.Location = New System.Drawing.Point(15, 284)
        Me.lblCharacter.Name = "lblCharacter"
        Me.lblCharacter.Size = New System.Drawing.Size(53, 13)
        Me.lblCharacter.TabIndex = 24
        Me.lblCharacter.Text = "Character"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(45, 232)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(128, 16)
        Me.lblInfo.TabIndex = 21
        Me.lblInfo.Text = "You arrive in Nurnen"
        '
        'Stats
        '
        Me.Stats.Controls.Add(Me.lblMaxHealth)
        Me.Stats.Controls.Add(Me.Label13)
        Me.Stats.Controls.Add(Me.ldbHealthBar)
        Me.Stats.Controls.Add(Me.lblDefence)
        Me.Stats.Controls.Add(Me.Label6)
        Me.Stats.Controls.Add(Me.lblAttack)
        Me.Stats.Controls.Add(Me.lblHealth)
        Me.Stats.Controls.Add(Me.Label5)
        Me.Stats.Controls.Add(Me.Label4)
        Me.Stats.Controls.Add(Me.lblMoney)
        Me.Stats.Controls.Add(Me.Label1)
        Me.Stats.Location = New System.Drawing.Point(18, 17)
        Me.Stats.Name = "Stats"
        Me.Stats.Size = New System.Drawing.Size(247, 190)
        Me.Stats.TabIndex = 23
        Me.Stats.TabStop = False
        Me.Stats.Text = "Stats"
        '
        'lblMaxHealth
        '
        Me.lblMaxHealth.AutoSize = True
        Me.lblMaxHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxHealth.Location = New System.Drawing.Point(171, 51)
        Me.lblMaxHealth.Name = "lblMaxHealth"
        Me.lblMaxHealth.Size = New System.Drawing.Size(27, 20)
        Me.lblMaxHealth.TabIndex = 26
        Me.lblMaxHealth.Text = "20"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(152, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 20)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "/"
        '
        'ldbHealthBar
        '
        Me.ldbHealthBar.Location = New System.Drawing.Point(44, 74)
        Me.ldbHealthBar.MarqueeAnimationSpeed = 1000
        Me.ldbHealthBar.Maximum = 20
        Me.ldbHealthBar.Name = "ldbHealthBar"
        Me.ldbHealthBar.Size = New System.Drawing.Size(168, 21)
        Me.ldbHealthBar.Step = 1
        Me.ldbHealthBar.TabIndex = 24
        Me.ldbHealthBar.Tag = ""
        Me.ldbHealthBar.Value = 20
        '
        'lblDefence
        '
        Me.lblDefence.AutoSize = True
        Me.lblDefence.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefence.Location = New System.Drawing.Point(123, 150)
        Me.lblDefence.Name = "lblDefence"
        Me.lblDefence.Size = New System.Drawing.Size(18, 20)
        Me.lblDefence.TabIndex = 14
        Me.lblDefence.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(39, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Defence:"
        '
        'lblAttack
        '
        Me.lblAttack.AutoSize = True
        Me.lblAttack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttack.Location = New System.Drawing.Point(123, 108)
        Me.lblAttack.Name = "lblAttack"
        Me.lblAttack.Size = New System.Drawing.Size(18, 20)
        Me.lblAttack.TabIndex = 12
        Me.lblAttack.Text = "5"
        '
        'lblHealth
        '
        Me.lblHealth.AutoSize = True
        Me.lblHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHealth.Location = New System.Drawing.Point(119, 51)
        Me.lblHealth.Name = "lblHealth"
        Me.lblHealth.Size = New System.Drawing.Size(27, 20)
        Me.lblHealth.TabIndex = 11
        Me.lblHealth.Text = "20"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Attack:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Health:"
        '
        'lblMoney
        '
        Me.lblMoney.AllowDrop = True
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.Location = New System.Drawing.Point(119, 18)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(36, 20)
        Me.lblMoney.TabIndex = 8
        Me.lblMoney.Text = "100"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Money:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Info:"
        '
        'tabInventory
        '
        Me.tabInventory.Controls.Add(Me.lblItemInfo)
        Me.tabInventory.Controls.Add(Me.Label16)
        Me.tabInventory.Controls.Add(Me.btnUse)
        Me.tabInventory.Controls.Add(Me.btnSellItem)
        Me.tabInventory.Controls.Add(Me.tbPrice)
        Me.tabInventory.Controls.Add(Me.Label2)
        Me.tabInventory.Controls.Add(Me.tbItem)
        Me.tabInventory.Controls.Add(Me.Label8)
        Me.tabInventory.Controls.Add(Me.Label9)
        Me.tabInventory.Controls.Add(Me.lbxInventory)
        Me.tabInventory.Location = New System.Drawing.Point(4, 22)
        Me.tabInventory.Name = "tabInventory"
        Me.tabInventory.Size = New System.Drawing.Size(279, 475)
        Me.tabInventory.TabIndex = 2
        Me.tabInventory.Text = "Inventory"
        Me.tabInventory.UseVisualStyleBackColor = True
        '
        'lblItemInfo
        '
        Me.lblItemInfo.AutoSize = True
        Me.lblItemInfo.Location = New System.Drawing.Point(155, 345)
        Me.lblItemInfo.Name = "lblItemInfo"
        Me.lblItemInfo.Size = New System.Drawing.Size(13, 13)
        Me.lblItemInfo.TabIndex = 17
        Me.lblItemInfo.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(62, 345)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 13)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Attack/Defence:"
        '
        'btnUse
        '
        Me.btnUse.Location = New System.Drawing.Point(5, 386)
        Me.btnUse.Name = "btnUse"
        Me.btnUse.Size = New System.Drawing.Size(267, 38)
        Me.btnUse.TabIndex = 15
        Me.btnUse.Text = "Use/Equip"
        Me.btnUse.UseVisualStyleBackColor = True
        '
        'btnSellItem
        '
        Me.btnSellItem.Enabled = False
        Me.btnSellItem.Location = New System.Drawing.Point(6, 430)
        Me.btnSellItem.Name = "btnSellItem"
        Me.btnSellItem.Size = New System.Drawing.Size(267, 38)
        Me.btnSellItem.TabIndex = 14
        Me.btnSellItem.Text = "Sell"
        Me.btnSellItem.UseVisualStyleBackColor = True
        '
        'tbPrice
        '
        Me.tbPrice.Enabled = False
        Me.tbPrice.Location = New System.Drawing.Point(145, 284)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(127, 20)
        Me.tbPrice.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Price"
        '
        'tbItem
        '
        Me.tbItem.Enabled = False
        Me.tbItem.Location = New System.Drawing.Point(12, 284)
        Me.tbItem.Name = "tbItem"
        Me.tbItem.Size = New System.Drawing.Size(127, 20)
        Me.tbItem.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(89, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 25)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Inventory"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(62, 270)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Item"
        '
        'lbxInventory
        '
        Me.lbxInventory.FormattingEnabled = True
        Me.lbxInventory.Location = New System.Drawing.Point(53, 64)
        Me.lbxInventory.Name = "lbxInventory"
        Me.lbxInventory.Size = New System.Drawing.Size(170, 199)
        Me.lbxInventory.Sorted = True
        Me.lbxInventory.TabIndex = 8
        '
        'tabStore
        '
        Me.tabStore.Controls.Add(Me.lblStoreMoney)
        Me.tabStore.Controls.Add(Me.lblStoreItemInfo)
        Me.tabStore.Controls.Add(Me.Label17)
        Me.tabStore.Controls.Add(Me.btnBuyItem)
        Me.tabStore.Controls.Add(Me.tbStoreItem)
        Me.tabStore.Controls.Add(Me.Label10)
        Me.tabStore.Controls.Add(Me.tbStorePrice)
        Me.tabStore.Controls.Add(Me.Label11)
        Me.tabStore.Controls.Add(Me.Label12)
        Me.tabStore.Controls.Add(Me.lbxBuy)
        Me.tabStore.Location = New System.Drawing.Point(4, 22)
        Me.tabStore.Name = "tabStore"
        Me.tabStore.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStore.Size = New System.Drawing.Size(279, 475)
        Me.tabStore.TabIndex = 1
        Me.tabStore.Text = "Store"
        Me.tabStore.UseVisualStyleBackColor = True
        '
        'lblStoreMoney
        '
        Me.lblStoreMoney.AutoSize = True
        Me.lblStoreMoney.Location = New System.Drawing.Point(9, 405)
        Me.lblStoreMoney.Name = "lblStoreMoney"
        Me.lblStoreMoney.Size = New System.Drawing.Size(63, 13)
        Me.lblStoreMoney.TabIndex = 22
        Me.lblStoreMoney.Text = "Money: 200"
        '
        'lblStoreItemInfo
        '
        Me.lblStoreItemInfo.AutoSize = True
        Me.lblStoreItemInfo.Location = New System.Drawing.Point(155, 345)
        Me.lblStoreItemInfo.Name = "lblStoreItemInfo"
        Me.lblStoreItemInfo.Size = New System.Drawing.Size(13, 13)
        Me.lblStoreItemInfo.TabIndex = 21
        Me.lblStoreItemInfo.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(62, 345)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 13)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Attack/Defence:"
        '
        'btnBuyItem
        '
        Me.btnBuyItem.Enabled = False
        Me.btnBuyItem.Location = New System.Drawing.Point(6, 429)
        Me.btnBuyItem.Name = "btnBuyItem"
        Me.btnBuyItem.Size = New System.Drawing.Size(267, 38)
        Me.btnBuyItem.TabIndex = 19
        Me.btnBuyItem.Text = "Buy"
        Me.btnBuyItem.UseVisualStyleBackColor = True
        '
        'tbStoreItem
        '
        Me.tbStoreItem.Enabled = False
        Me.tbStoreItem.Location = New System.Drawing.Point(12, 284)
        Me.tbStoreItem.Name = "tbStoreItem"
        Me.tbStoreItem.Size = New System.Drawing.Size(127, 20)
        Me.tbStoreItem.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(174, 268)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Buying Price"
        '
        'tbStorePrice
        '
        Me.tbStorePrice.Enabled = False
        Me.tbStorePrice.Location = New System.Drawing.Point(145, 284)
        Me.tbStorePrice.Name = "tbStorePrice"
        Me.tbStorePrice.Size = New System.Drawing.Size(127, 20)
        Me.tbStorePrice.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(105, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 25)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Store"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(62, 270)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Item"
        '
        'lbxBuy
        '
        Me.lbxBuy.FormattingEnabled = True
        Me.lbxBuy.Location = New System.Drawing.Point(53, 64)
        Me.lbxBuy.Name = "lbxBuy"
        Me.lbxBuy.Size = New System.Drawing.Size(170, 199)
        Me.lbxBuy.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(249, 244)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 20)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Final Platau"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 523)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.picDot)
        Me.Controls.Add(Me.plcMinasMorgle)
        Me.Controls.Add(Me.plcLithland)
        Me.Controls.Add(Me.plcDeadMarsh)
        Me.Controls.Add(Me.plcMtDoom)
        Me.Controls.Add(Me.plcKazaDoom)
        Me.Controls.Add(Me.plcNurnen)
        Me.Controls.Add(Me.picMap)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Mordor)
        Me.Controls.Add(Me.tabMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Form1"
        CType(Me.picMap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.tabStats.ResumeLayout(False)
        Me.tabStats.PerformLayout()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Stats.ResumeLayout(False)
        Me.Stats.PerformLayout()
        Me.tabInventory.ResumeLayout(False)
        Me.tabInventory.PerformLayout()
        Me.tabStore.ResumeLayout(False)
        Me.tabStore.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Mordor As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents picMap As System.Windows.Forms.PictureBox
    Friend WithEvents plcNurnen As System.Windows.Forms.Label
    Friend WithEvents plcKazaDoom As System.Windows.Forms.Label
    Friend WithEvents plcMtDoom As System.Windows.Forms.Label
    Friend WithEvents plcDeadMarsh As System.Windows.Forms.Label
    Friend WithEvents plcLithland As System.Windows.Forms.Label
    Friend WithEvents plcMinasMorgle As System.Windows.Forms.Label
    Friend WithEvents picDot As System.Windows.Forms.PictureBox
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents tabStats As System.Windows.Forms.TabPage
    Friend WithEvents ldbHealthBar As System.Windows.Forms.ProgressBar
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents Stats As System.Windows.Forms.GroupBox
    Friend WithEvents lblDefence As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblAttack As System.Windows.Forms.Label
    Friend WithEvents lblHealth As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMoney As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tabInventory As System.Windows.Forms.TabPage
    Friend WithEvents btnUse As System.Windows.Forms.Button
    Friend WithEvents btnSellItem As System.Windows.Forms.Button
    Friend WithEvents tbPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbItem As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbxInventory As System.Windows.Forms.ListBox
    Friend WithEvents tabStore As System.Windows.Forms.TabPage
    Friend WithEvents btnBuyItem As System.Windows.Forms.Button
    Friend WithEvents tbStoreItem As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbStorePrice As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbxBuy As System.Windows.Forms.ListBox
    Friend WithEvents lblMaxHealth As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblCharacter As System.Windows.Forms.Label
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents ldbXpBar As System.Windows.Forms.ProgressBar
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblItemInfo As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblStoreItemInfo As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblStoreMoney As System.Windows.Forms.Label

End Class
