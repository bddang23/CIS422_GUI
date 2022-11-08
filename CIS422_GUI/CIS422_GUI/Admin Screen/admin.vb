Public Class admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tabControl.SelectedTab = tabFaculty
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tabControl.SelectedTab = tabUser
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tabControl.SelectedTab = tabBuilding
    End Sub


    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        tabControl.SelectedTab = tabGuideline
    End Sub


End Class
