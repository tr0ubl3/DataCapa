Class Page1
    Private Sub test_Click(sender As Object, e As RoutedEventArgs) Handles test.Click
        MsgBox(Environment.UserDomainName)
    End Sub

    Private Sub test2_Click(sender As Object, e As RoutedEventArgs) Handles test2.Click
        MsgBox(Environment.TickCount)
    End Sub
End Class
