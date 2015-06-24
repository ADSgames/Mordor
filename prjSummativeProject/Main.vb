Public Class Main

    'Current name of the location of the player
    Dim place As String
    'Possibility for a fight to occur
    Dim possibility As String
    'Character stats
    Public money As Integer
    Public health As Integer
    Public attack As Integer
    Public defence As Integer
    'Career Money (Used for score)
    Public careerMoney As Integer
    'Levelup variables used to make game progressively harder
    Public level As Integer
    Public experience As Integer

    'Runs all neccisary functions on startup
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Assigns character stats to starter values
        money = 200
        health = 20
        attack = 5
        level = 1
        careerMoney = money

        'Assigns the lables to variable values
        lblMoney.Text = money
        lblHealth.Text = health
        lblAttack.Text = attack

        'Adds starting goods into player inventory list box
        lbxInventory.Items.Add("Rusty Dagger")
        lbxInventory.Items.Add("Health Potion")
        lbxInventory.Items.Add("Health Potion")
        lbxInventory.Items.Add("Wooden Sheild")
        lbxInventory.Items.Add("Money Bag")

        'Adds starting goods into store inventory list box
        lbxBuy.Items.Add("Wooden Stick")
        lbxBuy.Items.Add("Iron Sword")
        lbxBuy.Items.Add("Gold Sword")
        lbxBuy.Items.Add("Spear of Petoria")
        lbxBuy.Items.Add("Diamond Sword")
        lbxBuy.Items.Add("Godly Sword")

        
        lbxBuy.Items.Add("Wooden Sheild")
        lbxBuy.Items.Add("Iron Sheild")
        lbxBuy.Items.Add("Gold Sheild")
        lbxBuy.Items.Add("Sheild of Petoria")
        lbxBuy.Items.Add("Diamond Sheild")
        lbxBuy.Items.Add("Godly Sheild")

        lbxBuy.Items.Add("Health Potion")
        lbxBuy.Items.Add("Health Potion")

    End Sub

    'Checks if fight will occur
    Private Sub fight()
        'Sets up random number variables
        Dim number As Integer
        Dim answer As Boolean
        'Sets random generator to a more complex algorythm
        Randomize()
        'Randomizes number
        number = Math.Round(1 + Rnd() * possibility)
        'Finds if fight should occur depending on random number result
        If number = 1 Then
            answer = True
        Else
            answer = False
        End If
        'If fight will occur shows fight screen
        If answer = True Then
            FightScreen.Show()
            FightScreen.NewFight()
        End If
    End Sub
    'Nurnens label click event
    Private Sub plcNurnen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plcNurnen.Click
        'Makes sure you are not allready there
        If place <> "Nurnen" Then
            'Assigns valuse to name, possibility of attack and the character map dot x and y positions
            place = "Nurnen"
            possibility = 2
            'Runs fight function
            fight()
            'Moves player map dot
            picDot.Top = plcNurnen.Top + 20
            picDot.Left = plcNurnen.Left + plcNurnen.Width / 2 - 10
            'Sets info message
            lblInfo.Text = "You arrive in Nurnen."
        Else
            lblInfo.Text = "You are already in Nurnen."
        End If
        If health < 20 Then
            health += 1
            lblHealth.Text = health
            ldbHealthBar.Value = health
        End If
    End Sub
    'MtDoom label click event
    Private Sub plcMtDoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plcMtDoom.Click
        'Makes sure you are not allready there
        If place <> "MtDoom" Then
            'Assigns valuse to name, possibility of attack and the character map dot x and y positions
            place = "MtDoom"
            possibility = 0
            'Runs fight function
            fight()
            'Moves player map dot
            picDot.Top = plcMtDoom.Top + 20
            picDot.Left = plcMtDoom.Left + plcMtDoom.Width / 2 - 10
            'Sets info message
            lblInfo.Text = "You arrive in Mt. Doom."
        Else
            lblInfo.Text = "You are already in Mt. Doom."
        End If
        If health < 20 Then
            health += 1
            lblHealth.Text = health
            ldbHealthBar.Value = health
        End If
    End Sub
    'Lithland label click event
    Private Sub plcLithland_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plcLithland.Click
        'Makes sure you are not allready there
        If place <> "Lithland" Then
            'Assigns valuse to name, possibility of attack and the character map dot x and y positions
            place = "Lithland"
            'Runs fight function
            fight()
            'Moves player map dot
            possibility = 2
            picDot.Top = plcLithland.Top + 20
            picDot.Left = plcLithland.Left + plcLithland.Width / 2 - 10
            'Sets info message
            lblInfo.Text = "You arrive in Lithland."
        Else
            lblInfo.Text = "You are already in Lithland."
        End If
        If health < 20 Then
            health += 1
            lblHealth.Text = health
            ldbHealthBar.Value = health
        End If
    End Sub
    'MinasMorgle label click event
    Private Sub plcMinasMorgle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plcMinasMorgle.Click
        'Makes sure you are not allready there
        If place <> "MinasMorgle" Then
            'Assigns valuse to name, possibility of attack and the character map dot x and y positions
            place = "MinasMorgle"
            possibility = 1
            'Runs fight function
            fight()
            'Moves player map dot
            picDot.Top = plcMinasMorgle.Top + 20
            picDot.Left = plcMinasMorgle.Left + plcMinasMorgle.Width / 2 - 10
            'Sets info message
            lblInfo.Text = "You arrive in Minas Morgle."
        Else
            lblInfo.Text = "You are already in Minas Morgle."
        End If
        If health < 20 Then
            health += 1
            lblHealth.Text = health
            ldbHealthBar.Value = health
        End If
    End Sub
    'KazaDoom label click event
    Private Sub plcKazaDoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plcKazaDoom.Click
        'Makes sure you are not allready there
        If place <> "KazaDoom" Then
            'Assigns valuse to name, possibility of attack and the character map dot x and y positions
            place = "KazaDoom"
            possibility = 1
            'Runs fight function
            fight()
            'Moves player map dot
            picDot.Top = plcKazaDoom.Top + 20
            picDot.Left = plcKazaDoom.Left + plcKazaDoom.Width / 2
            'Sets info message
            lblInfo.Text = "You arrive in Kaza Doom."
        Else
            lblInfo.Text = "You are already in Kaza Doom."
        End If
        If health < 20 Then
            health += 1
            lblHealth.Text = health
            ldbHealthBar.Value = health
        End If
    End Sub
    'DeadMarsh label click event
    Private Sub plcDeadMarsh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plcDeadMarsh.Click
        'Makes sure you are not allready there
        If place <> "DeadMarsh" Then
            'Assigns valuse to name, possibility of attack and the character map dot x and y positions
            place = "DeadMarsh"
            possibility = 0
            'Runs fight function
            fight()
            'Moves player map dot
            picDot.Top = plcDeadMarsh.Top + 20
            picDot.Left = plcDeadMarsh.Left + plcDeadMarsh.Width / 2 - 10
            'Sets info message
            lblInfo.Text = "You arrive in Dead Marsh."
        Else
            lblInfo.Text = "You are already in Dead Marsh."
        End If
        If health < 20 Then
            health += 1
            lblHealth.Text = health
            ldbHealthBar.Value = health
        End If
    End Sub
    'Inventory functions

    'Checks if user presses on an inventory item
    Private Sub lbxInventory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbxInventory.SelectedIndexChanged
        'Shows name and price and enables you to sell the item
        tbItem.Text = lbxInventory.SelectedItem
        tbPrice.Text = getPrice()
        btnSellItem.Enabled = True
        lblItemInfo.Text = getDamage(lbxInventory.SelectedItem)
    End Sub
    'Sells the item
    Private Sub btnSellItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSellItem.Click
        'Makes sure the item is sellable , gives money to player, removes the item from invnetory and adds it to the store inventory 
        If getPrice() Then
            money += getPrice()
            lblMoney.Text = money
            lblStoreMoney.Text = "Money: " + Str(money)
            lbxBuy.Items.Add(lbxInventory.SelectedItem)
            lbxInventory.Items.Remove(lbxInventory.SelectedItem)
            btnSellItem.Enabled = False
        Else
            MessageBox.Show("You can't sell that item")
            btnSellItem.Enabled = False
        End If
    End Sub
    'Returns price depending on the item name
    Public Function getPrice()
        Dim itemPrice As Integer
        If lbxInventory.SelectedItem = "Health Potion" Then
            itemPrice = 50

        ElseIf lbxInventory.SelectedItem = "Wooden Stick" Then
            itemPrice = 25
        ElseIf lbxInventory.SelectedItem = "Rusty Dagger" Then
            itemPrice = 50
        ElseIf lbxInventory.SelectedItem = "Iron Sword" Then
            itemPrice = 200
        ElseIf lbxInventory.SelectedItem = "Gold Sword" Then
            itemPrice = 500
        ElseIf lbxInventory.SelectedItem = "Spear of Petoria" Then
            itemPrice = 1000
        ElseIf lbxInventory.SelectedItem = "Diamond Sword" Then
            itemPrice = 1250
        ElseIf lbxInventory.SelectedItem = "Godly Sword" Then
            itemPrice = 2500

        ElseIf lbxInventory.SelectedItem = "Wooden Sheild" Then
            itemPrice = 25
        ElseIf lbxInventory.SelectedItem = "Iron Sheild" Then
            itemPrice = 200
        ElseIf lbxInventory.SelectedItem = "Gold Sheild" Then
            itemPrice = 500
        ElseIf lbxInventory.SelectedItem = "Sheild of Petoria" Then
            itemPrice = 1000
        ElseIf lbxInventory.SelectedItem = "Diamond Sheild" Then
            itemPrice = 1250
        ElseIf lbxInventory.SelectedItem = "Godly Sheild" Then
            itemPrice = 2500
        Else
            itemPrice = 0
        End If

        Return itemPrice
    End Function
    'Equips/Uses items in the inventory depending on type
    Private Sub btnUse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUse.Click
        If lbxInventory.SelectedItem = "Health Potion" Then
            MessageBox.Show("You drink the potion.")
            health = ldbHealthBar.Maximum
            ldbHealthBar.Value = health
            lbxInventory.Items.Remove(lbxInventory.SelectedItem)
            lblHealth.Text = health
        ElseIf lbxInventory.SelectedItem = "Money Bag" Then
            MessageBox.Show("You rattle the moneybag.")

        ElseIf lbxInventory.SelectedItem = "Wooden Stick" Then
            MessageBox.Show("You grasp the stick.")
            attack = getDamage(lbxInventory.SelectedItem)
        ElseIf lbxInventory.SelectedItem = "Rusty Dagger" Then
            MessageBox.Show("You clench the dagger.")
            attack = getDamage(lbxInventory.SelectedItem)
        ElseIf lbxInventory.SelectedItem = "Iron Sword" Then
            MessageBox.Show("You equip the sword.")
            attack = getDamage(lbxInventory.SelectedItem)
        ElseIf lbxInventory.SelectedItem = "Gold Sword" Then
            MessageBox.Show("You equip the sword.")
            attack = getDamage(lbxInventory.SelectedItem)
        ElseIf lbxInventory.SelectedItem = "Spear of Petoria" Then
            MessageBox.Show("You equip the spear. Energy courses throughout your body.")
            attack = getDamage(lbxInventory.SelectedItem)
        ElseIf lbxInventory.SelectedItem = "Diamond Sword" Then
            MessageBox.Show("You equip the sword.")
            attack = getDamage(lbxInventory.SelectedItem)
        ElseIf lbxInventory.SelectedItem = "Godly Sword" Then
            MessageBox.Show("You equip the sword.")
            attack = getDamage(lbxInventory.SelectedItem)

        ElseIf lbxInventory.SelectedItem = "Wooden Sheild" Then
            MessageBox.Show("You hold the wooden sheild.")
            defence = getDamage(lbxInventory.SelectedItem)
        ElseIf lbxInventory.SelectedItem = "Iron Sheild" Then
            MessageBox.Show("You hold the iron sheild.")
            defence = getDamage(lbxInventory.SelectedItem)
        ElseIf lbxInventory.SelectedItem = "Gold Sheild" Then
            MessageBox.Show("You hold the gold sheild.")
            defence = getDamage(lbxInventory.SelectedItem)
        ElseIf lbxInventory.SelectedItem = "Sheild of Petoria" Then
            MessageBox.Show("You hold the sheild of Petoria.")
            defence = getDamage(lbxInventory.SelectedItem)
        ElseIf lbxInventory.SelectedItem = "Diamond Sheild" Then
            MessageBox.Show("You hold the diamond sheild.")
            defence = getDamage(lbxInventory.SelectedItem)
        ElseIf lbxInventory.SelectedItem = "Godly Sheild" Then
            MessageBox.Show("You hold the Godly sheild.")
            defence = getDamage(lbxBuy.SelectedItem)
        Else
            MessageBox.Show("Whats a " & tbItem.Text & "?")
        End If

        'Updates the lables
        lblAttack.Text = attack
        lblHealth.Text = health
        lblDefence.Text = defence
    End Sub
    'Store


    'Checks if user selected a store item and provides information accordingly
    Private Sub lbxBuy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbxBuy.SelectedIndexChanged
        tbStoreItem.Text = lbxBuy.SelectedItem
        tbStorePrice.Text = storeGetPrice()
        btnBuyItem.Enabled = True
        lblStoreItemInfo.Text = getDamage(lbxBuy.SelectedItem)
    End Sub
    'Checks if player has enought money then if true subtracts money from the player and gives them their item
    Private Sub ftnBuyItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuyItem.Click
        'Makes sure user has enough money to purchase item
        If storeGetPrice() <= money Then
            money -= storeGetPrice()
            lblMoney.Text = money
            lblStoreMoney.Text = "Money: " + Str(money)
            lbxInventory.Items.Add(lbxBuy.SelectedItem)
            btnBuyItem.Enabled = False
            If lbxBuy.SelectedItem <> "Health Potion" Then
                lbxBuy.Items.Remove(lbxBuy.SelectedItem)
            End If
        Else
            MessageBox.Show("You can't afford that item")
        End If


        'Checks for win
        If lbxInventory.Items.Contains("Godly Sword") = True And lbxInventory.Items.Contains("Godly Sheild") = True Then
            MessageBox.Show("congratulations, you win!")
            MessageBox.Show("Your final score is " & careerMoney & ".")
            Dim reply As DialogResult = MessageBox.Show("Continue Playing?", "Caption", _
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If reply = DialogResult.Yes Then
                MessageBox.Show("Have fun!")
            Else
                MessageBox.Show("Bye!")
                End
            End If
        End If

    End Sub
    'Returns prices for store depending on type
    Public Function storeGetPrice()
        Dim itemPrice As Integer

        If lbxBuy.SelectedItem = "Health Potion" Then
            itemPrice = 100

        ElseIf lbxBuy.SelectedItem = "Wooden Stick" Then
            itemPrice = 50
        ElseIf lbxBuy.SelectedItem = "Rusty Dagger" Then
            itemPrice = 100
        ElseIf lbxBuy.SelectedItem = "Iron Sword" Then
            itemPrice = 400
        ElseIf lbxBuy.SelectedItem = "Gold Sword" Then
            itemPrice = 1000
        ElseIf lbxBuy.SelectedItem = "Spear of Petoria" Then
            itemPrice = 2000
        ElseIf lbxBuy.SelectedItem = "Diamond Sword" Then
            itemPrice = 2500
        ElseIf lbxBuy.SelectedItem = "Godly Sword" Then
            itemPrice = 5000

        ElseIf lbxBuy.SelectedItem = "Wooden Sheild" Then
            itemPrice = 50
        ElseIf lbxBuy.SelectedItem = "Iron Sheild" Then
            itemPrice = 400
        ElseIf lbxBuy.SelectedItem = "Gold Sheild" Then
            itemPrice = 1000
        ElseIf lbxBuy.SelectedItem = "Sheild of Petoria" Then
            itemPrice = 2000
        ElseIf lbxBuy.SelectedItem = "Diamond Sheild" Then
            itemPrice = 2500
        ElseIf lbxBuy.SelectedItem = "Godly Sheild" Then
            itemPrice = 5000
        Else
            itemPrice = 0
        End If

        Return itemPrice
    End Function

    Public Function getDamage(ByVal NewItemName As String)
        Dim damage As Integer
        If NewItemName = "Wooden Stick" Then
            damage = 3
        ElseIf NewItemName = "Rusty Dagger" Then
            damage = 5
        ElseIf NewItemName = "Iron Sword" Then
            damage = 8
        ElseIf NewItemName = "Gold Sword" Then
            damage = 10
        ElseIf NewItemName = "Spear of Petoria" Then
            damage = 12
        ElseIf NewItemName = "Diamond Sword" Then
            damage = 14
        ElseIf NewItemName = "Godly Sword" Then
            damage = 18
        ElseIf NewItemName = "Wooden Sheild" Then
            damage = 2
        ElseIf NewItemName = "Iron Sheild" Then
            damage = 4
        ElseIf NewItemName = "Gold Sheild" Then
            damage = 6
        ElseIf NewItemName = "Sheild of Petoria" Then
            damage = 8
        ElseIf NewItemName = "Diamond Sheild" Then
            damage = 10
        ElseIf NewItemName = "Godly Sheild" Then
            damage = 12
        Else
            damage = 0
        End If
        Return damage
    End Function

End Class

