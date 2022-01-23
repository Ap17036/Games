Class MainWindow
    Dim turn As Integer = 1
    Private Sub Grid_Initialized(sender As Object, e As EventArgs)
        txt11.Text = ""
        txt12.Text = ""
        txt13.Text = ""
        txt23.Text = ""
        txt22.Text = ""
        txt21.Text = ""
        txt31.Text = ""
        txt32.Text = ""
        txt33.Text = ""
        txth1.Visibility = Visibility.Hidden
        txth2.Visibility = Visibility.Hidden
        txth3.Visibility = Visibility.Hidden
        txtd1.Visibility = Visibility.Hidden
        txtd2.Visibility = Visibility.Hidden
        txtv1.Visibility = Visibility.Hidden
        txtv2.Visibility = Visibility.Hidden
        txtv3.Visibility = Visibility.Hidden
    End Sub
    Private Sub btnNew_Click(sender As Object, e As RoutedEventArgs) Handles btnNew.Click
        txt11.Text = ""
        txt12.Text = ""
        txt13.Text = ""
        txt23.Text = ""
        txt22.Text = ""
        txt21.Text = ""
        txt31.Text = ""
        txt32.Text = ""
        txt33.Text = ""
        txth1.Visibility = Visibility.Hidden
        txth2.Visibility = Visibility.Hidden
        txth3.Visibility = Visibility.Hidden
        txtd1.Visibility = Visibility.Hidden
        txtd2.Visibility = Visibility.Hidden
        txtv1.Visibility = Visibility.Hidden
        txtv2.Visibility = Visibility.Hidden
        txtv3.Visibility = Visibility.Hidden
    End Sub

    Private Sub txt11_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txt11.MouseDown
        If (turn Mod 2 = 0) Then
            txt11.Text = "X"
            txt11.IsEnabled = False
            turn += 1
        Else
            txt11.Text = "0"
            txt11.IsEnabled = False
            turn += 1
        End If
        doob()
    End Sub

    Private Sub txt12_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txt12.MouseDown
        If (turn Mod 2 = 0) Then
            txt12.Text = "X"
            txt12.IsEnabled = False
            turn += 1
        Else
            txt12.Text = "0"
            txt12.IsEnabled = False
            turn += 1
        End If
        doob()
    End Sub

    Private Sub txt13_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txt13.MouseDown
        If (turn Mod 2 = 0) Then
            txt13.Text = "X"
            txt13.IsEnabled = False
            turn += 1
        Else
            txt13.Text = "0"
            txt13.IsEnabled = False
            turn += 1
        End If
        doob()
    End Sub

    Private Sub txt21_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txt21.MouseDown
        If (turn Mod 2 = 0) Then
            txt21.Text = "X"
            txt21.IsEnabled = False
            turn += 1
        Else
            txt21.Text = "0"
            txt21.IsEnabled = False
            turn += 1
        End If
        doob()
    End Sub

    Private Sub txt22_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txt22.MouseDown
        If (turn Mod 2 = 0) Then
            txt22.Text = "X"
            txt22.IsEnabled = False
            turn += 1
        Else
            txt22.Text = "0"
            txt22.IsEnabled = False
            turn += 1
        End If
        doob()
    End Sub

    Private Sub txt23_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txt23.MouseDown
        If (turn Mod 2 = 0) Then
            txt23.Text = "X"
            txt23.IsEnabled = False
            turn += 1
        Else
            txt23.Text = "0"
            txt23.IsEnabled = False
            turn += 1
        End If
        doob()
    End Sub

    Private Sub txt31_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txt31.MouseDown
        If (turn Mod 2 = 0) Then
            txt31.Text = "X"
            txt31.IsEnabled = False
            turn += 1
        Else
            txt31.Text = "0"
            txt31.IsEnabled = False
            turn += 1
        End If
        doob()
    End Sub

    Private Sub txt32_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txt32.MouseDown
        If (turn Mod 2 = 0) Then
            txt32.Text = "X"
            txt32.IsEnabled = False
            turn += 1
        Else
            txt32.Text = "0"
            txt32.IsEnabled = False
            turn += 1
        End If
        doob()
    End Sub

    Private Sub txt33_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txt33.MouseDown
        If (turn Mod 2 = 0) Then
            txt33.Text = "X"
            txt33.IsEnabled = False
            turn += 1
        Else
            txt33.Text = "0"
            txt33.IsEnabled = False
            turn += 1
        End If
        doob()
    End Sub
    Private Sub doob()
        If (txt11.Text.Equals("X") And (txt12.Text.Equals("X") And (txt13.Text.Equals("X")))) Then
            txth1.Visibility = Visibility.Visible
        ElseIf (txt11.Text.Equals("0") And (txt12.Text.Equals("0") And (txt13.Text.Equals("0")))) Then
            txth1.Visibility = Visibility.Visible
        End If

        If (txt21.Text.Equals("X") And (txt22.Text.Equals("X") And (txt23.Text.Equals("X")))) Then
            txth2.Visibility = Visibility.Visible
        ElseIf (txt21.Text.Equals("0") And (txt22.Text.Equals("0") And (txt23.Text.Equals("0")))) Then
            txth2.Visibility = Visibility.Visible
        End If

        If (txt31.Text.Equals("X") And (txt32.Text.Equals("X") And (txt33.Text.Equals("X")))) Then
            txth3.Visibility = Visibility.Visible
        ElseIf (txt31.Text.Equals("0") And (txt32.Text.Equals("0") And (txt33.Text.Equals("0")))) Then
            txth3.Visibility = Visibility.Visible
        End If

        If (txt21.Text.Equals("X") And (txt11.Text.Equals("X") And (txt31.Text.Equals("X")))) Then
            txtv1.Visibility = Visibility.Visible
        ElseIf (txt31.Text.Equals("0") And (txt11.Text.Equals("0") And (txt21.Text.Equals("0")))) Then
            txtv1.Visibility = Visibility.Visible
        End If

        If (txt22.Text.Equals("X") And (txt32.Text.Equals("X") And (txt12.Text.Equals("X")))) Then
            txtv2.Visibility = Visibility.Visible
        ElseIf (txt22.Text.Equals("0") And (txt32.Text.Equals("0") And (txt12.Text.Equals("0")))) Then
            txtv2.Visibility = Visibility.Visible
        End If

        If (txt13.Text.Equals("X") And (txt23.Text.Equals("X") And (txt33.Text.Equals("X")))) Then
            txtv3.Visibility = Visibility.Visible
        ElseIf (txt13.Text.Equals("0") And (txt23.Text.Equals("0") And (txt33.Text.Equals("0")))) Then
            txtv3.Visibility = Visibility.Visible
        End If

        If (txt11.Text.Equals("X") And (txt22.Text.Equals("X") And (txt33.Text.Equals("X")))) Then
            txtd2.Visibility = Visibility.Visible
        ElseIf (txt11.Text.Equals("0") And (txt22.Text.Equals("0") And (txt33.Text.Equals("0")))) Then
            txtd2.Visibility = Visibility.Visible
        End If

        If (txt13.Text.Equals("X") And (txt22.Text.Equals("X") And (txt31.Text.Equals("X")))) Then
            txtd1.Visibility = Visibility.Visible
        ElseIf (txt13.Text.Equals("0") And (txt22.Text.Equals("0") And (txt31.Text.Equals("0")))) Then
            txtd01.Visibility = Visibility.Visible
        End If
    End Sub
End Class
