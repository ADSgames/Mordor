Public Class FightScreen
    'Variables for fighting
    Dim fightType As Integer
    Dim compName As String
    Dim enemyHealth As Integer
    Dim enemyAttack As Integer

    Public Sub NewFight()
        Randomize()
        'Chooses a  computer type
        fightType = Math.Round(1 + Rnd() * 4)
        If fightType = 1 Then
            compName = "Kobold"
            enemyHealth = 5 + Main.level * 2
            enemyAttack = 2 + Main.level * 2
            picEnemy.Image = Image.FromFile("images/characters/enemies/kobold.jpg")
        ElseIf fightType = 2 Then
            compName = "Giant Spider"
            enemyHealth = 7 + Main.level * 2
            enemyAttack = 2 + Main.level * 2
            picEnemy.Image = Image.FromFile("images/characters/enemies/spider.jpg")
        ElseIf fightType = 3 Then
            compName = "Goblin"
            enemyHealth = 10 + Main.level * 2
            enemyAttack = 3 + Main.level * 2
            picEnemy.Image = Image.FromFile("images/characters/enemies/goblin.jpg")
        ElseIf fightType = 4 Then
            compName = "Ajeash"
            enemyHealth = 1 + Main.level * 2
            enemyAttack = 2 + Main.level * 2
            picEnemy.Image = Image.FromFile("images/characters/enemies/ajeash.jpg")
        ElseIf fightType = 5 Then
            compName = "Shadow Demon"
            enemyHealth = 10 + Main.level * 2
            enemyAttack = 4 + Main.level * 2
            picEnemy.Image = Image.FromFile("images/characters/enemies/shadowdemon.jpg")
        Else
            Name = "Error"
        End If
        'Assignes the propour image to the enemy
        picPlayer.Image = Main.picPlayer.Image
        'Updates all lables for character and enemies
        lblInfo.Text = "Info:"
        lblEnemyName.Text = compName
        lblCharacter.Text = Stats.tbName.Text
        lblHealth.Text = Main.health
        lblAttack.Text = Main.attack
        lblDefence.Text = Main.defence
        lblCompHealth.Text = enemyHealth
        lblCompAttack.Text = enemyAttack
        'Updates main screen labels
        Main.ldbHealthBar.Value = Main.health
        Main.lblHealth.Text = Main.health
    End Sub

    Private Sub btnAttack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAttack.Click
        'Shows info on attack
        lblInfo.Text = ("Info: You attack " & compName & " and do " & Main.attack & " damage. " & vbNewLine & compName & " attacks you and does " & enemyAttack - Main.defence & " damage.")
        'Hurts enemy
        enemyHealth -= Main.attack
        If enemyHealth <= 0 Then
            'Gives player experience
            Main.experience += 1
            Randomize()
            'Variable to store money received from attack
            Dim bonus As Integer
            'Randomizes bonus
            bonus = Math.Round(50 + Rnd() * 200)
            'Adds bonus money to money
            Main.money += bonus
            'Adds bonus to score
            Main.careerMoney += bonus
            'hides the screen
            Me.Hide()
            'Post carnage information
            MessageBox.Show("You defeated the " & compName & " and received " & bonus & " gold")
            'Updates all lables
            Main.lblMoney.Text = Main.money
            Main.lblStoreMoney.Text = "Money: " + Str(Main.money)
            Main.lblHealth.Text = Main.health
            'Checks if level up is required
            If Main.experience > 4 Then
                'Inreases level
                Main.level += 1
                'Restarts experience counter
                Main.experience = 0
                'Updates level label
                Main.lblLevel.Text = Main.level
            End If
        Else
            'Damages player if enemy or player is killed
            If enemyAttack - Main.defence > 0 Then
                Main.health -= (enemyAttack - Main.defence)
            End If

        End If
        'Checks if player is dead
        If Main.health <= 0 Then
            'Displays who you were killed by
            MessageBox.Show("You were killed by a " & compName & "!")
            'Displays final score
            MessageBox.Show("You received a score of " & Main.careerMoney)
            End
        End If
        'Checks if enemy is dead
        'Updates lables
        lblHealth.Text = Main.health
        lblAttack.Text = Main.attack
        lblDefence.Text = Main.defence
        lblCompHealth.Text = enemyHealth
        lblCompAttack.Text = enemyAttack
        Main.lblHealth.Text = Main.health
        Main.ldbXpBar.Value = Main.experience
        'Checks if health is less than 0 and sets it if not so that there is no crashes
        If Main.health >= 0 Then
            Main.ldbHealthBar.Value = Main.health
        End If

    End Sub
    'Character can run away from fight
    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        'Hides character
        Me.Hide()
        'Removes gold from player
        If Main.money > 50 Then
            MessageBox.Show("You lost 50 gold!")
            Main.money -= 50
        ElseIf Main.money < 50 Then
            MessageBox.Show("You lost all your gold!")
            Main.money -= Main.money
        End If
        'Removes points from final score
        Main.careerMoney -= 50
        'Updates lables
        Main.lblMoney.Text = Main.money
        Main.lblStoreMoney.Text = "Money: " + Str(Main.money)
        Main.lblHealth.Text = Main.health
        Main.ldbHealthBar.Value = Main.health
    End Sub
End Class