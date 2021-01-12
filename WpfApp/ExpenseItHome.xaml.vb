Class ExpenseItHome

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        ' View Expense Report
        Dim expenseReportPage As New ExpenseReportPage()
        Me.NavigationService.Navigate(expenseReportPage)
    End Sub
End Class
