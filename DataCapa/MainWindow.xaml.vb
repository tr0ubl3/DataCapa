Imports System
Imports FontAwesome.WPF
Class MainWindow
    Private Sub mnuExit_Click(sender As Object, e As RoutedEventArgs)
        Close()
    End Sub

    Private Sub mnuLogin_Click(sender As Object, e As RoutedEventArgs)
        yeld.NavigationService.Navigate(New Page1)
    End Sub
End Class
