<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FightScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FightScreen))
        Me.lblCharacter = New System.Windows.Forms.Label()
        Me.lblEnemyName = New System.Windows.Forms.Label()
        Me.picEnemy = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCompHealth = New System.Windows.Forms.Label()
        Me.lblAttack = New System.Windows.Forms.Label()
        Me.lblCompAttack = New System.Windows.Forms.Label()
        Me.lblHealth = New System.Windows.Forms.Label()
        Me.btnAttack = New System.Windows.Forms.Button()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Defence = New System.Windows.Forms.Label()
        Me.lblDefence = New System.Windows.Forms.Label()
        CType(Me.picEnemy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCharacter
        '
        Me.lblCharacter.AutoSize = True
        Me.lblCharacter.Location = New System.Drawing.Point(61, 9)
        Me.lblCharacter.Name = "lblCharacter"
        Me.lblCharacter.Size = New System.Drawing.Size(26, 13)
        Me.lblCharacter.TabIndex = 0
        Me.lblCharacter.Text = "You"
        Me.lblCharacter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEnemyName
        '
        Me.lblEnemyName.AutoSize = True
        Me.lblEnemyName.Location = New System.Drawing.Point(190, 9)
        Me.lblEnemyName.Name = "lblEnemyName"
        Me.lblEnemyName.Size = New System.Drawing.Size(39, 13)
        Me.lblEnemyName.TabIndex = 1
        Me.lblEnemyName.Text = "Enemy"
        Me.lblEnemyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picEnemy
        '
        Me.picEnemy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picEnemy.Image = CType(resources.GetObject("picEnemy.Image"), System.Drawing.Image)
        Me.picEnemy.Location = New System.Drawing.Point(174, 25)
        Me.picEnemy.Name = "picEnemy"
        Me.picEnemy.Size = New System.Drawing.Size(78, 99)
        Me.picEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEnemy.TabIndex = 2
        Me.picEnemy.TabStop = False
        '
        'picPlayer
        '
        Me.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPlayer.Image = CType(resources.GetObject("picPlayer.Image"), System.Drawing.Image)
        Me.picPlayer.Location = New System.Drawing.Point(39, 25)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(78, 99)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 3
        Me.picPlayer.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Health:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Attack:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(182, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Health:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(182, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Attack:"
        '
        'lblCompHealth
        '
        Me.lblCompHealth.AutoSize = True
        Me.lblCompHealth.Location = New System.Drawing.Point(229, 127)
        Me.lblCompHealth.Name = "lblCompHealth"
        Me.lblCompHealth.Size = New System.Drawing.Size(13, 13)
        Me.lblCompHealth.TabIndex = 8
        Me.lblCompHealth.Text = "0"
        '
        'lblAttack
        '
        Me.lblAttack.AutoSize = True
        Me.lblAttack.Location = New System.Drawing.Point(93, 150)
        Me.lblAttack.Name = "lblAttack"
        Me.lblAttack.Size = New System.Drawing.Size(13, 13)
        Me.lblAttack.TabIndex = 9
        Me.lblAttack.Text = "0"
        '
        'lblCompAttack
        '
        Me.lblCompAttack.AutoSize = True
        Me.lblCompAttack.Location = New System.Drawing.Point(229, 150)
        Me.lblCompAttack.Name = "lblCompAttack"
        Me.lblCompAttack.Size = New System.Drawing.Size(13, 13)
        Me.lblCompAttack.TabIndex = 10
        Me.lblCompAttack.Text = "0"
        '
        'lblHealth
        '
        Me.lblHealth.AutoSize = True
        Me.lblHealth.Location = New System.Drawing.Point(93, 127)
        Me.lblHealth.Name = "lblHealth"
        Me.lblHealth.Size = New System.Drawing.Size(13, 13)
        Me.lblHealth.TabIndex = 11
        Me.lblHealth.Text = "0"
        '
        'btnAttack
        '
        Me.btnAttack.Location = New System.Drawing.Point(21, 214)
        Me.btnAttack.Name = "btnAttack"
        Me.btnAttack.Size = New System.Drawing.Size(239, 22)
        Me.btnAttack.TabIndex = 12
        Me.btnAttack.Text = "Attack"
        Me.btnAttack.UseVisualStyleBackColor = True
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(21, 242)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(239, 19)
        Me.btnRun.TabIndex = 13
        Me.btnRun.Text = "Run Away"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(18, 189)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(28, 13)
        Me.lblInfo.TabIndex = 14
        Me.lblInfo.Text = "Info:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(293, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Label1"
        '
        'Defence
        '
        Me.Defence.AutoSize = True
        Me.Defence.Location = New System.Drawing.Point(36, 172)
        Me.Defence.Name = "Defence"
        Me.Defence.Size = New System.Drawing.Size(51, 13)
        Me.Defence.TabIndex = 16
        Me.Defence.Text = "Defence:"
        '
        'lblDefence
        '
        Me.lblDefence.AutoSize = True
        Me.lblDefence.Location = New System.Drawing.Point(93, 172)
        Me.lblDefence.Name = "lblDefence"
        Me.lblDefence.Size = New System.Drawing.Size(13, 13)
        Me.lblDefence.TabIndex = 17
        Me.lblDefence.Text = "0"
        '
        'FightScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.lblDefence)
        Me.Controls.Add(Me.Defence)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.btnAttack)
        Me.Controls.Add(Me.lblHealth)
        Me.Controls.Add(Me.lblCompAttack)
        Me.Controls.Add(Me.lblAttack)
        Me.Controls.Add(Me.lblCompHealth)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picEnemy)
        Me.Controls.Add(Me.lblEnemyName)
        Me.Controls.Add(Me.lblCharacter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FightScreen"
        Me.Text = "Fight"
        CType(Me.picEnemy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCharacter As System.Windows.Forms.Label
    Friend WithEvents lblEnemyName As System.Windows.Forms.Label
    Friend WithEvents picEnemy As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCompHealth As System.Windows.Forms.Label
    Friend WithEvents lblAttack As System.Windows.Forms.Label
    Friend WithEvents lblCompAttack As System.Windows.Forms.Label
    Friend WithEvents lblHealth As System.Windows.Forms.Label
    Friend WithEvents btnAttack As System.Windows.Forms.Button
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Defence As System.Windows.Forms.Label
    Friend WithEvents lblDefence As System.Windows.Forms.Label
End Class
