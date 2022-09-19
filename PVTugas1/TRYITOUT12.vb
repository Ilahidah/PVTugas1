Public Class TRYITOUT12
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click
        'Declare variable
        Dim dteResults As Date
        'Get the current date and time
        dteResults = Now
        'Display the results
        MessageBox.Show(dteResults.ToString, "Date Demo")
        'Display dates
        MessageBox.Show(dteResults.ToLongDateString, "Date Demo")
        MessageBox.Show(dteResults.ToShortDateString, "Date Demo")

    End Sub
End Class