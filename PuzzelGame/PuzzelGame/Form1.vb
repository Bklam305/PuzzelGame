Public Class Form1
    Public counter As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Shuffle()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call EmptySpotChecker(Button1, Button2)
        Call EmptySpotChecker(Button1, Button5)

        Call SolutionChecker()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Call Shuffle()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call EmptySpotChecker(Button2, Button1)
        Call EmptySpotChecker(Button2, Button3)
        Call EmptySpotChecker(Button2, Button6)

        Call SolutionChecker()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call EmptySpotChecker(Button3, Button2)
        Call EmptySpotChecker(Button3, Button4)
        Call EmptySpotChecker(Button3, Button7)

        Call SolutionChecker()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call EmptySpotChecker(Button4, Button3)
        Call EmptySpotChecker(Button4, Button8)

        Call SolutionChecker()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call EmptySpotChecker(Button5, Button1)
        Call EmptySpotChecker(Button5, Button6)
        Call EmptySpotChecker(Button5, Button9)

        Call SolutionChecker()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call EmptySpotChecker(Button6, Button2)
        Call EmptySpotChecker(Button6, Button5)
        Call EmptySpotChecker(Button6, Button7)
        Call EmptySpotChecker(Button6, Button10)

        Call SolutionChecker()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call EmptySpotChecker(Button7, Button3)
        Call EmptySpotChecker(Button7, Button6)
        Call EmptySpotChecker(Button7, Button8)
        Call EmptySpotChecker(Button7, Button11)

        Call SolutionChecker()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call EmptySpotChecker(Button8, Button4)
        Call EmptySpotChecker(Button8, Button7)
        Call EmptySpotChecker(Button8, Button12)

        Call SolutionChecker()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Call EmptySpotChecker(Button9, Button4)
        Call EmptySpotChecker(Button8, Button7)
        Call EmptySpotChecker(Button8, Button12)

        Call SolutionChecker()
    End Sub
End Class
