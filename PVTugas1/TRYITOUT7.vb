Public Class TRYITOUT7
    Private Sub btnStrings_Click(sender As Object, e As EventArgs) Handles btnStrings.Click
        'Declare variable
        Dim strResults As String
        'Set the string value
        strResults = "Hello World!"
        'Display the results
        MessageBox.Show(strResults, "Strings")
    End Sub

    Private Sub btnConcatenation_Click(sender As Object, e As EventArgs) Handles btnConcatenation.Click
        'Declare variables
        Dim strResults As String
        Dim strOne As String
        Dim strTwo As String
        'Set the string values
        strOne = "Hello"
        strTwo = " World!"
        'Concatenate the strings
        strResults = strOne & strTwo
        'Display the results
        MessageBox.Show(strResults, "Strings")
    End Sub
    Private Sub btnLength_Click(sender As Object, e As EventArgs) Handles btnLength.Click
        'Declare variable
        Dim strResults As String
        'Get the text from the TextBox
        strResults = txtString.Text
        'Display the length of the string
        MessageBox.Show(strResults.Length.ToString & " characters(s)", "Strings")
    End Sub
End Class