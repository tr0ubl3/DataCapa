Imports System
Imports FontAwesome.WPF
Class MainWindow

    Private Sub test_Click(sender As Object, e As RoutedEventArgs) Handles test.Click
        MsgBox(Environment.UserDomainName)
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As RoutedEventArgs)
        Close()
    End Sub
End Class
