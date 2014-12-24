Public Class Stats
    'Variables used to create the Character
    Dim character As String
    Dim playerName As String
    Dim gender As String
    Dim race As String

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        'Select name
        playerName = tbName.Text
        'Select what gender you want to be; Male or Female
        gender = cbGender.Text
        'Select race
        race = cbRace.Text
        'Selects image depending on race
        Main.picPlayer.Image = Image.FromFile("images/characters/players/" & race & ".jpg")
        'Show info
        MessageBox.Show("Welcome " & playerName & " the " & race & " to the land of Mordor.")
        'Finalizes starting the game by hiding this screen and opening the main screen
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        'Sets race to race combo box text
        race = cbRace.Text
        'Shows extra information about the race type
        If race = "Orc" Then
            MessageBox.Show("Orcs, are a barbarian people from the mountainous regions of western Tamriel. They are centrally located in Orsinium, The City of Orcs, but are common in other great cities throughout Tamriel. Their speciality is hand to hand combat. They are often praised for their crafted heavy armors, outstanding service in the Imperial Legion, and highly upheld code of honor.")
        ElseIf race = "Dark Elf" Then
            MessageBox.Show(" Dark Elves, also known as Dunmer, are a prejudiced, disciplined, tradition-heavy people. This hardness has led to the development of an ancestral wrath power that surrounds them in flames. They are not only known for being ruthless in war, but for being very skilled at it, too. They are the most combat balanced race in Tamriel, being proficient in combat magic, weaponry, and archery.")
        ElseIf race = "High Elf" Then
            MessageBox.Show(" High Elves, also known as Altmer, are natives of Summerset Isle. They are the most magically proficient race in Tamriel as well as being the most hubristic. Their racial power is a constant effect that lets them regenerate magicka faster than other races.")
        ElseIf race = "Wood Elf" Then
            MessageBox.Show("Wood Elves (also known as Bomier) hail from the gladed forest of Valenwood. They are skilled in the use of bows and are gifted among most stealth skills. The Wood Elves also are known to command animals as it is one of their racial skills.")
        ElseIf race = "Khajiit" Then
            MessageBox.Show(" Hailing from the province of Elsweyr, Khajiit are intelligent, quick, and agile. They make excellent thieves due to their natural stealthiness. All Khajiit can see in the dark at will and have unarmed claw attacks.")
        ElseIf race = "Argonian" Then
            MessageBox.Show("Argonians are a reptilian race from Black Marsh. They can breathe under water indefinitely and have a natural resistance to disease. Argonians also have Histskin which lets them rapidly regenerate health (once a day). They make a very good stealth-focused character. Also, their combined abilities are well-suited for exploration, as they have an easier time passing through water and locked doors than most.")
        ElseIf race = "Redguard" Then
            MessageBox.Show(" Redguards, the dark-skinned people of Hammerfell, are a physically powerful race in Tamriel. Combined with their knowledge of all weapon and armor types, they make great warriors or thief-type characters. The Redguards' Adrenaline Rush ability is similar to the Orcs' Berserker Rage and Nords' Battlecry. Their naturally high One-Handed and Destruction attributes make the Redguard a good race for those who want to play as battle mages.")
        ElseIf race = "Nord" Then
            MessageBox.Show(" Nords are a fair haired people. They live in the cold, mountainous province of Skyrim and have a natural resistance to frost. Tough and hardy, they make great heavy warriors. Their famed battlecry makes them the toughest race. Battlecry can only be used once a day.")
        ElseIf race = "Daedra" Then
            MessageBox.Show(" The Daedra are a group of powerful supernatural entities that inhabit the plane of Oblivion. Although they are generally not bound to the physical world, they are capable of manifesting within the mortal plane of Mundus. They are well-known to the inhabitants of Tamriel, where they are feared by some and worshipped by others.")
        ElseIf race = "Link" Then
            MessageBox.Show(" You found a secret place! Link is the main character from Legend of Zelda!.")
        ElseIf race = "Ajeash" Then
            MessageBox.Show(" You found a secret place! Ajeash is a short kid. He is found in village houses eating food or playing LOL.")
        End If
    End Sub

End Class