Public Class frmNumbers
    ' Form Load Event: Make lblFrench Invisible Initially
    Private Sub frmNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFrench.Visible = False

    End Sub

    ' Button Click Events to Show the French Number
    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        lblFrench.Text = "Un"
        lblFrench.Visible = True
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        lblFrench.Text = "Deux"
        lblFrench.Visible = True
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        lblFrench.Text = "Trois"
        lblFrench.Visible = True
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        lblFrench.Text = "Quatre"
        lblFrench.Visible = True
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        lblFrench.Text = "Cinq"
        lblFrench.Visible = True
    End Sub

    ' Exit Button Click Event to Close the Form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
