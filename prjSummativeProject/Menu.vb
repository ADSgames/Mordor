Public Class Menu

    'Starts a new game by showing the character setup screen
    Private Sub btnNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewGame.Click
        Stats.Show()
        Me.Hide()
    End Sub
    'Ends game if exit button pressed
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.Show()
    End Sub
End Class