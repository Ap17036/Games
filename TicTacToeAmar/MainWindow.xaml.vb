Class MainWindow
    Dim turn As Integer = 1
    Dim counter As Integer = 0
    Dim counter1 As Integer = 0
    Dim o As BitmapImage = New BitmapImage(New Uri("Resources/Opera_O.png", UriKind.Relative))
    Dim x As BitmapImage = New BitmapImage(New Uri("Resources/Apple-iPhone-X-Sales.png", UriKind.Relative))
    Dim blank As BitmapImage = New BitmapImage(New Uri("Resources/blank_png_image_143511.png", UriKind.Relative))
    Dim mall(8) As Image
    Dim mh3(2) As Image
    Dim mh2(2) As Image
    Dim mh1(2) As Image
    Dim mv1(2) As Image
    Dim mv2(2) As Image
    Dim mv3(2) As Image
    Dim md1(2) As Image
    Dim md2(2) As Image

    Private Sub Window_Initialized(sender As Object, e As EventArgs)
        img11.Source = blank
        img12.Source = blank
        img13.Source = blank
        img22.Source = blank
        img23.Source = blank
        img21.Source = blank

        img31.Source = blank
        img32.Source = blank
        img33.Source = blank
    End Sub
    Private Sub btnNew_Click(sender As Object, e As RoutedEventArgs) Handles btnNew.Click

        img11.Source = blank
        img12.Source = blank
        img13.Source = blank
        img22.Source = blank
        img23.Source = blank
        img21.Source = blank

        img31.Source = blank
        img32.Source = blank
        img33.Source = blank

        img11.IsEnabled = True
        img12.IsEnabled = True
        img13.IsEnabled = True
        img21.IsEnabled = True
        img22.IsEnabled = True
        img23.IsEnabled = True
        img31.IsEnabled = True
        img32.IsEnabled = True
        img33.IsEnabled = True
        txth1.Visibility = Visibility.Hidden
        txth2.Visibility = Visibility.Hidden
        txth3.Visibility = Visibility.Hidden
        txtd1.Visibility = Visibility.Hidden
        txtd2.Visibility = Visibility.Hidden
        txtv1.Visibility = Visibility.Hidden
        txtv2.Visibility = Visibility.Hidden
        txtv3.Visibility = Visibility.Hidden
        turn = 1
        counter = 0

    End Sub
    Private Sub doob()

        If (img11.Source.Equals(o) AndAlso img12.Source.Equals(o) AndAlso img13.Source.Equals(o)) Then
                txth1.Visibility = Visibility.Visible
                MsgBox("O wins!!!!!!, Click New Game to play again")
                img11.IsEnabled = False
                img12.IsEnabled = False
                img13.IsEnabled = False
                img21.IsEnabled = False
                img22.IsEnabled = False
                img23.IsEnabled = False
                img31.IsEnabled = False
                img32.IsEnabled = False
                img33.IsEnabled = False

        ElseIf ((img11.Source.Equals(x) AndAlso img12.Source.Equals(x) AndAlso img13.Source.Equals(x))) Then
                txth1.Visibility = Visibility.Visible
                MsgBox("X wins!!!!!!, Click New Game to play again")
                img11.IsEnabled = False
                img12.IsEnabled = False
                img13.IsEnabled = False
                img21.IsEnabled = False
                img22.IsEnabled = False
                img23.IsEnabled = False
                img31.IsEnabled = False
                img32.IsEnabled = False
                img33.IsEnabled = False

        End If

            If (img21.Source.Equals(o) AndAlso img22.Source.Equals(o) AndAlso img23.Source.Equals(o)) Then
                txth2.Visibility = Visibility.Visible
                MsgBox("O wins!!!!!!, Click New Game to play again")
                img11.IsEnabled = False
                img12.IsEnabled = False
                img13.IsEnabled = False
                img21.IsEnabled = False
                img22.IsEnabled = False
                img23.IsEnabled = False
                img31.IsEnabled = False
                img32.IsEnabled = False
                img33.IsEnabled = False

        ElseIf ((img21.Source.Equals(x) AndAlso img22.Source.Equals(x) AndAlso img23.Source.Equals(x))) Then
            txth2.Visibility = Visibility.Visible
                MsgBox("X wins!!!!!!, Click New Game to play again")
                img11.IsEnabled = False
                img12.IsEnabled = False
                img13.IsEnabled = False
                img21.IsEnabled = False
                img22.IsEnabled = False
                img23.IsEnabled = False
                img31.IsEnabled = False
                img32.IsEnabled = False
                img33.IsEnabled = False
       
            End If

            If (img31.Source.Equals(o) AndAlso img32.Source.Equals(o) AndAlso img33.Source.Equals(o)) Then
                txth3.Visibility = Visibility.Visible
                MsgBox("O wins!!!!!!, Click New Game to play again")
                img11.IsEnabled = False
                img12.IsEnabled = False
                img13.IsEnabled = False
                img21.IsEnabled = False
                img22.IsEnabled = False
                img23.IsEnabled = False
                img31.IsEnabled = False
                img32.IsEnabled = False
                img33.IsEnabled = False

        ElseIf ((img31.Source.Equals(x) AndAlso img32.Source.Equals(x) AndAlso img33.Source.Equals(x))) Then
                txth3.Visibility = Visibility.Visible
                MsgBox("X wins!!!!!!, Click New Game to play again")
                img11.IsEnabled = False
                img12.IsEnabled = False
                img13.IsEnabled = False
                img21.IsEnabled = False
                img22.IsEnabled = False
                img23.IsEnabled = False
                img31.IsEnabled = False
                img32.IsEnabled = False
                img33.IsEnabled = False

        End If

            If (img11.Source.Equals(o) AndAlso img21.Source.Equals(o) AndAlso img31.Source.Equals(o)) Then
                txtv1.Visibility = Visibility.Visible
                MsgBox("O wins!!!!!!, Click New Game to play again")
                img11.IsEnabled = False
                img12.IsEnabled = False
                img13.IsEnabled = False
                img21.IsEnabled = False
                img22.IsEnabled = False
                img23.IsEnabled = False
                img31.IsEnabled = False
                img32.IsEnabled = False
            img33.IsEnabled = False

        ElseIf ((img11.Source.Equals(x) AndAlso img21.Source.Equals(x) AndAlso img31.Source.Equals(x))) Then
                txtv1.Visibility = Visibility.Visible
                MsgBox("X wins!!!!!!, Click New Game to play again")
                img11.IsEnabled = False
                img12.IsEnabled = False
                img13.IsEnabled = False
                img21.IsEnabled = False
                img22.IsEnabled = False
                img23.IsEnabled = False
                img31.IsEnabled = False
                img32.IsEnabled = False
                img33.IsEnabled = False

        End If

            If (img12.Source.Equals(o) AndAlso img22.Source.Equals(o) AndAlso img32.Source.Equals(o)) Then
                txtv2.Visibility = Visibility.Visible
                MsgBox("O wins!!!!!!, Click New Game to play again")
                img11.IsEnabled = False
                img12.IsEnabled = False
                img13.IsEnabled = False
                img21.IsEnabled = False
                img22.IsEnabled = False
                img23.IsEnabled = False
                img31.IsEnabled = False
                img32.IsEnabled = False
                img33.IsEnabled = False

        ElseIf ((img12.Source.Equals(x) AndAlso img22.Source.Equals(x) AndAlso img32.Source.Equals(x))) Then
                txtv2.Visibility = Visibility.Visible
                MsgBox("X wins!!!!!!, Click New Game to play again")
                img11.IsEnabled = False
                img12.IsEnabled = False
                img13.IsEnabled = False
                img21.IsEnabled = False
                img22.IsEnabled = False
                img23.IsEnabled = False
                img31.IsEnabled = False
                img32.IsEnabled = False
                img33.IsEnabled = False

        End If

            If (img13.Source.Equals(o) AndAlso img23.Source.Equals(o) AndAlso img33.Source.Equals(o)) Then
                txtv3.Visibility = Visibility.Visible
                MsgBox("O wins!!!!!!, Click New Game to play again")
                img11.IsEnabled = False
                img12.IsEnabled = False
                img13.IsEnabled = False
                img21.IsEnabled = False
                img22.IsEnabled = False
                img23.IsEnabled = False
                img31.IsEnabled = False
                img32.IsEnabled = False
                img33.IsEnabled = False

        ElseIf ((img13.Source.Equals(x) AndAlso img23.Source.Equals(x) AndAlso img33.Source.Equals(x))) Then
                txtv3.Visibility = Visibility.Visible
                MsgBox("X wins!!!!!!, Click New Game to play again")
                img11.IsEnabled = False
                img12.IsEnabled = False
                img13.IsEnabled = False
                img21.IsEnabled = False
                img22.IsEnabled = False
                img23.IsEnabled = False
                img31.IsEnabled = False
                img32.IsEnabled = False
                img33.IsEnabled = False

        End If

            If (img11.Source.Equals(o) AndAlso img22.Source.Equals(o) AndAlso img33.Source.Equals(o)) Then
                txtd2.Visibility = Visibility.Visible
                MsgBox("O wins!!!!!!, Click New Game to play again")
                img11.IsEnabled = False
                img12.IsEnabled = False
                img13.IsEnabled = False
                img21.IsEnabled = False
                img22.IsEnabled = False
                img23.IsEnabled = False
                img31.IsEnabled = False
                img32.IsEnabled = False
                img33.IsEnabled = False

        ElseIf ((img11.Source.Equals(x) AndAlso img22.Source.Equals(x) AndAlso img33.Source.Equals(x))) Then
            txtd2.Visibility = Visibility.Visible
                MsgBox("X wins!!!!!!, Click New Game to play again")
                img11.IsEnabled = False
                img12.IsEnabled = False
                img13.IsEnabled = False
                img21.IsEnabled = False
                img22.IsEnabled = False
                img23.IsEnabled = False
                img31.IsEnabled = False
                img32.IsEnabled = False
                img33.IsEnabled = False

        End If

            If (img13.Source.Equals(o) AndAlso img22.Source.Equals(o) AndAlso img31.Source.Equals(o)) Then
                txtd1.Visibility = Visibility.Visible
                MsgBox("O wins!!!!!!, Click New Game to play again")
                img11.IsEnabled = False
                img12.IsEnabled = False
                img13.IsEnabled = False
                img21.IsEnabled = False
                img22.IsEnabled = False
                img23.IsEnabled = False
                img31.IsEnabled = False
                img32.IsEnabled = False
                img33.IsEnabled = False

        ElseIf ((img13.Source.Equals(x) AndAlso img22.Source.Equals(x) AndAlso img31.Source.Equals(x))) Then
                txtd1.Visibility = Visibility.Visible
                MsgBox("X wins!!!!!!, Click New Game to play again")
                img11.IsEnabled = False
                img12.IsEnabled = False
                img13.IsEnabled = False
                img21.IsEnabled = False
                img22.IsEnabled = False
                img23.IsEnabled = False
                img31.IsEnabled = False
                img32.IsEnabled = False
                img33.IsEnabled = False

        End If
        If (SinglePlayer.IsChecked = True) Then

            If (counter <= -9) Then
                MsgBox("WOW. Both of you are bad. Only tying")
                img11.IsEnabled = False
                img12.IsEnabled = False
                img13.IsEnabled = False
                img21.IsEnabled = False
                img22.IsEnabled = False
                img23.IsEnabled = False
                img31.IsEnabled = False
                img32.IsEnabled = False
                img33.IsEnabled = False
            End If
        ElseIf (multiplayer.IsChecked = True) Then

            If (counter1 = 0) Then
                img11.IsEnabled = False
                img12.IsEnabled = False
                img13.IsEnabled = False
                img21.IsEnabled = False
                img22.IsEnabled = False
                img23.IsEnabled = False
                img31.IsEnabled = False
                img32.IsEnabled = False
                img33.IsEnabled = False
                MsgBox("WOW. Both of you are bad. Only tying")
            End If
        End If
    End Sub

    Private Sub img11_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles img11.MouseDown
        If (SinglePlayer.IsChecked = True) Then
            If (turn Mod 2 = 0) Then
                img11.Source = x
                img11.IsEnabled = False
                turn += 1
            Else
                img11.Source = o
                img11.IsEnabled = False
                turn += 1
            End If
            counter -= 1
            doob()
        End If

        If (Multiplayer.IsChecked = True) Then

            img11.Source = x
            img11.IsEnabled = False
            Ai()
        End If
    End Sub

    Private Sub img12_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles img12.MouseDown
        If (SinglePlayer.IsChecked = True) Then
            If (turn Mod 2 = 0) Then
                img12.Source = x
                img12.IsEnabled = False
                turn += 1
            Else
                img12.Source = o
                img12.IsEnabled = False
                turn += 1
            End If
            counter -= 1
            doob()
        End If
        If (Multiplayer.IsChecked = True) Then

            img12.Source = x
            img12.IsEnabled = False
            Ai()
        End If
    End Sub

    Private Sub img13_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles img13.MouseDown
        If (SinglePlayer.IsChecked = True) Then
            If (turn Mod 2 = 0) Then
                img13.Source = x
                img13.IsEnabled = False
                turn += 1
            Else
                img13.Source = o
                img13.IsEnabled = False
                turn += 1
            End If
            counter -= 1
            doob()
        End If
        If (Multiplayer.IsChecked = True) Then

            img13.Source = x
            img13.IsEnabled = False
            Ai()
        End If
    End Sub

    Private Sub img21_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles img21.MouseDown
        If (SinglePlayer.IsChecked = True) Then
            If (turn Mod 2 = 0) Then
                img21.Source = x
                img21.IsEnabled = False
                turn += 1
            Else
                img21.Source = o
                img21.IsEnabled = False
                turn += 1
            End If
            counter -= 1
            doob()
        End If
        If (Multiplayer.IsChecked = True) Then

            img21.Source = x
            img21.IsEnabled = False
            Ai()
        End If
    End Sub

    Private Sub img22_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles img22.MouseDown
        If (SinglePlayer.IsChecked = True) Then
            If (turn Mod 2 = 0) Then
                img22.Source = x
                img22.IsEnabled = False
                turn += 1
            Else
                img22.Source = o
                img22.IsEnabled = False
                turn += 1
            End If
            counter -= 1
            doob()
        End If
        If (Multiplayer.IsChecked = True) Then

            img22.Source = x
            img22.IsEnabled = False
            Ai()
        End If
    End Sub

    Private Sub img23_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles img23.MouseDown
        If (SinglePlayer.IsChecked = True) Then
            If (turn Mod 2 = 0) Then
                img23.Source = x
                img23.IsEnabled = False
                turn += 1
            Else
                img23.Source = o
                img23.IsEnabled = False
                turn += 1
            End If
            counter -= 1
            doob()
        End If
        If (Multiplayer.IsChecked = True) Then

            img23.Source = x
            img23.IsEnabled = False
            Ai()
        End If
    End Sub

    Private Sub img31_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles img31.MouseDown
        If (SinglePlayer.IsChecked = True) Then
            If (turn Mod 2 = 0) Then
                img31.Source = x
                img31.IsEnabled = False
                turn += 1
            Else
                img31.Source = o
                img31.IsEnabled = False
                turn += 1
            End If
            counter -= 1
            doob()
        End If

        If (Multiplayer.IsChecked = True) Then


            img31.Source = x
            img31.IsEnabled = False
            Ai()
        End If
    End Sub

    Private Sub img32_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles img32.MouseDown
        If (SinglePlayer.IsChecked = True) Then
            If (turn Mod 2 = 0) Then
                img32.Source = x
                img32.IsEnabled = False
                turn += 1
            Else
                img32.Source = o
                img32.IsEnabled = False
                turn += 1
            End If
            counter -= 1
            doob()
        End If
        If (Multiplayer.IsChecked = True) Then

            img32.Source = x
            img32.IsEnabled = False
            Ai()
        End If
    End Sub

    Private Sub img33_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles img33.MouseDown
        If (SinglePlayer.IsChecked = True) Then
            If (turn Mod 2 = 0) Then
                img33.Source = x
                img33.IsEnabled = False
                turn += 1
            Else
                img33.Source = o
                img33.IsEnabled = False
                turn += 1
            End If
            counter -= 1
            doob()
        End If
        If (Multiplayer.IsChecked = True) Then

            img33.Source = x
            img33.IsEnabled = False
            Ai()
        End If
    End Sub
    Private Sub Ai()
        Dim xs As Integer = 0
        Dim potato As Integer = 0
        Dim potato1 As Integer = 0
        mh3(0) = img31
        mh3(1) = img32
        mh3(2) = img33

        mh1(0) = img11
        mh1(1) = img12
        mh1(2) = img13

        mh2(0) = img21
        mh2(1) = img22
        mh2(2) = img23

        mv3(0) = img33
        mv3(1) = img23
        mv3(2) = img13

        mv2(0) = img12
        mv2(1) = img22
        mv2(2) = img32

        mv1(0) = img11
        mv1(1) = img21
        mv1(2) = img31

        md1(0) = img11
        md1(1) = img22
        md1(2) = img33

        md2(0) = img13
        md2(1) = img22
        md2(2) = img31

        mall(0) = img11
        mall(1) = img12
        mall(2) = img13
        mall(3) = img21
        mall(4) = img22
        mall(5) = img23
        mall(6) = img31
        mall(7) = img32
        mall(8) = img33
        'check for x win
        If ((img11.Source.Equals(x) And img12.Source.Equals(x) And img13.Source.Equals(x)) Or (img22.Source.Equals(x) And img23.Source.Equals(x) And img21.Source.Equals(x)) Or (img31.Source.Equals(x) And img32.Source.Equals(x) And img33.Source.Equals(x)) Or (img11.Source.Equals(x) And img21.Source.Equals(x) And img31.Source.Equals(x)) Or (img12.Source.Equals(x) And img22.Source.Equals(x) And img32.Source.Equals(x)) Or (img13.Source.Equals(x) And img23.Source.Equals(x) And img33.Source.Equals(x)) Or (img11.Source.Equals(x) And img22.Source.Equals(x) And img33.Source.Equals(x)) Or (img13.Source.Equals(x) And img22.Source.Equals(x) And img31.Source.Equals(x))) Then
            doob()
            'Check If can win
        ElseIf ((img11.Source.Equals(blank) Or img12.Source.Equals(blank) Or img13.Source.Equals(blank)) And ((img11.Source.Equals(o) And img12.Source.Equals(o)) Or (img11.Source.Equals(o) And img13.Source.Equals(o)) Or (img12.Source.Equals(o) And img13.Source.Equals(o)))) Then
            For a As Integer = 0 To 2

                If (mh1(a).Source.Equals(blank)) Then
                    mh1(a).Source = (o)
                    mh1(a).IsEnabled = False
                End If
            Next
        ElseIf ((img21.Source.Equals(blank) Or img22.Source.Equals(blank) Or img23.Source.Equals(blank)) And ((img21.Source.Equals(o) And img22.Source.Equals(o)) Or (img21.Source.Equals(o) And img23.Source.Equals(o)) Or (img22.Source.Equals(o) And img23.Source.Equals(o)))) Then
            For a As Integer = 0 To 2
                If (mh2(a).Source.Equals(blank)) Then
                    mh2(a).Source = (o)
                    mh2(a).IsEnabled = False
                End If
            Next
        ElseIf ((img31.Source.Equals(blank) Or img32.Source.Equals(blank) Or img33.Source.Equals(blank)) And ((img31.Source.Equals(o) And img32.Source.Equals(o)) Or (img31.Source.Equals(o) And img33.Source.Equals(o)) Or (img32.Source.Equals(o) And img33.Source.Equals(o)))) Then
            For a As Integer = 0 To 2
                If (mh3(a).Source.Equals(blank)) Then
                    mh3(a).Source = (o)
                    mh3(a).IsEnabled = False
                End If
            Next
        ElseIf ((img11.Source.Equals(blank) Or img21.Source.Equals(blank) Or img31.Source.Equals(blank)) And ((img11.Source.Equals(o) And img21.Source.Equals(o)) Or (img21.Source.Equals(o) And img31.Source.Equals(o)) Or (img11.Source.Equals(o) And img31.Source.Equals(o)))) Then
            For a As Integer = 0 To 2
                If (mv1(a).Source.Equals(blank)) Then
                    mv1(a).Source = (o)
                    mv1(a).IsEnabled = False
                End If
            Next

        ElseIf ((img12.Source.Equals(blank) Or img22.Source.Equals(blank) Or img32.Source.Equals(blank)) And ((img12.Source.Equals(o) And img22.Source.Equals(o)) Or (img22.Source.Equals(o) And img32.Source.Equals(o)) Or (img12.Source.Equals(o) And img32.Source.Equals(o)))) Then
            For a As Integer = 0 To 2
                If (mv2(a).Source.Equals(blank)) Then
                    mv2(a).Source = (o)
                    mv2(a).IsEnabled = False
                End If
            Next

        ElseIf ((img13.Source.Equals(blank) Or img23.Source.Equals(blank) Or img33.Source.Equals(blank)) And ((img13.Source.Equals(o) And img23.Source.Equals(o)) Or (img23.Source.Equals(o) And img33.Source.Equals(o)) Or (img13.Source.Equals(o) And img33.Source.Equals(o)))) Then
            For a As Integer = 0 To 2

                If (mv3(a).Source.Equals(blank)) Then
                    mv3(a).Source = (o)
                    mv3(a).IsEnabled = False
                End If
            Next

        ElseIf ((img11.Source.Equals(blank) Or img22.Source.Equals(blank) Or img33.Source.Equals(blank)) And ((img11.Source.Equals(o) And img22.Source.Equals(o)) Or (img22.Source.Equals(o) And img33.Source.Equals(o)) Or (img11.Source.Equals(o) And img33.Source.Equals(o)))) Then
            For a As Integer = 0 To 2

                If (md1(a).Source.Equals(blank)) Then
                    md1(a).Source = (o)
                    md1(a).IsEnabled = False
                End If
            Next
        ElseIf ((img13.Source.Equals(blank) Or img22.Source.Equals(blank) Or img31.Source.Equals(blank)) And ((img13.Source.Equals(o) And img22.Source.Equals(o)) Or (img22.Source.Equals(o) And img31.Source.Equals(o)) Or (img13.Source.Equals(o) And img31.Source.Equals(o)))) Then
            For a As Integer = 0 To 2
                If (md2(a).Source.Equals(blank)) Then
                    md2(a).Source = (o)
                    md2(a).IsEnabled = False
                End If
            Next
            '1 more move block
            'h1
        ElseIf (img11.Source.Equals(x) And img12.Source.Equals(x) And img13.Source.Equals(blank)) Then
            img13.Source = o
            img13.IsEnabled = False
        ElseIf (img12.Source.Equals(x) And img13.Source.Equals(x) And img11.Source.Equals(blank)) Then
            img11.Source = o
            img11.IsEnabled = False
        ElseIf (img11.Source.Equals(x) And img13.Source.Equals(x) And img12.Source.Equals(blank)) Then
            img12.Source = o
            img12.IsEnabled = False
            'h2
        ElseIf (img21.Source.Equals(x) And img22.Source.Equals(x) And img23.Source.Equals(blank)) Then
            img23.Source = o
            img23.IsEnabled = False
        ElseIf (img22.Source.Equals(x) And img23.Source.Equals(x) And img21.Source.Equals(blank)) Then
            img21.Source = o
            img21.IsEnabled = False
        ElseIf (img21.Source.Equals(x) And img23.Source.Equals(x) And img22.Source.Equals(blank)) Then
            img22.Source = o
            img22.IsEnabled = False
            'h3
        ElseIf (img31.Source.Equals(x) And img32.Source.Equals(x) And img33.Source.Equals(blank)) Then
            img33.Source = o
            img33.IsEnabled = False
        ElseIf (img32.Source.Equals(x) And img33.Source.Equals(x) And img31.Source.Equals(blank)) Then
            img31.Source = o
            img31.IsEnabled = False
        ElseIf (img31.Source.Equals(x) And img33.Source.Equals(x) And img32.Source.Equals(blank)) Then
            img32.Source = o
            img32.IsEnabled = False
            'v1
        ElseIf (img11.Source.Equals(x) And img21.Source.Equals(x) And img31.Source.Equals(blank)) Then
            img31.Source = o
            img31.IsEnabled = False
        ElseIf (img21.Source.Equals(x) And img31.Source.Equals(x) And img11.Source.Equals(blank)) Then
            img11.Source = o
            img11.IsEnabled = False
        ElseIf (img11.Source.Equals(x) And img31.Source.Equals(x) And img21.Source.Equals(blank)) Then
            img21.Source = o
            img21.IsEnabled = False
            'v2
        ElseIf (img12.Source.Equals(x) And img22.Source.Equals(x) And img32.Source.Equals(blank)) Then
            img32.Source = o
            img32.IsEnabled = False
        ElseIf (img22.Source.Equals(x) And img32.Source.Equals(x) And img12.Source.Equals(blank)) Then
            img12.Source = o
            img12.IsEnabled = False
        ElseIf (img12.Source.Equals(x) And img32.Source.Equals(x) And img22.Source.Equals(blank)) Then
            img22.Source = o
            img22.IsEnabled = False
            'v3
        ElseIf (img13.Source.Equals(x) And img23.Source.Equals(x) And img33.Source.Equals(blank)) Then
            img33.Source = o
            img33.IsEnabled = False
        ElseIf (img23.Source.Equals(x) And img33.Source.Equals(x) And img13.Source.Equals(blank)) Then
            img13.Source = o
            img13.IsEnabled = False
        ElseIf (img13.Source.Equals(x) And img33.Source.Equals(x) And img23.Source.Equals(blank)) Then
            img23.Source = o
            img23.IsEnabled = False
            'd1
        ElseIf (img11.Source.Equals(x) And img22.Source.Equals(x) And img33.Source.Equals(blank)) Then
            img33.Source = o
            img33.IsEnabled = False
        ElseIf (img22.Source.Equals(x) And img33.Source.Equals(x) And img11.Source.Equals(blank)) Then
            img11.Source = o
            img11.IsEnabled = False
        ElseIf (img11.Source.Equals(x) And img33.Source.Equals(x) And img22.Source.Equals(blank)) Then
            img22.Source = o
            img22.IsEnabled = False
            'd2
        ElseIf (img13.Source.Equals(x) And img22.Source.Equals(x) And img31.Source.Equals(blank)) Then
            img31.Source = o
            img31.IsEnabled = False
        ElseIf (img22.Source.Equals(x) And img31.Source.Equals(x) And img13.Source.Equals(blank)) Then
            img13.Source = o
            img13.IsEnabled = False
        ElseIf (img13.Source.Equals(x) And img31.Source.Equals(x) And img22.Source.Equals(blank)) Then
            img22.Source = o
            img22.IsEnabled = False

            'special case
            'diagonal

        ElseIf (img11.Source.Equals(x) And img33.Source.Equals(x) And img12.Source.Equals(blank)) Then
            img12.Source = o
            img12.IsEnabled = False
        ElseIf (img11.Source.Equals(x) And img33.Source.Equals(x) And img32.Source.Equals(blank)) Then
            img32.Source = o
            img32.IsEnabled = False
            '3corners
        ElseIf ((img12.Source.Equals(x) And img21.Source.Equals(x)) And img11.Source.Equals(blank)) Then
            img11.Source = o
            img11.IsEnabled = False
        ElseIf ((img12.Source.Equals(x) And img23.Source.Equals(x)) And img13.Source.Equals(blank)) Then
            img13.Source = o
            img13.IsEnabled = False
        ElseIf ((img21.Source.Equals(x) And img32.Source.Equals(x)) And img31.Source.Equals(blank)) Then
            img31.Source = o
            img31.IsEnabled = False
        ElseIf ((img21.Source.Equals(x) And img32.Source.Equals(x)) And img31.Source.Equals(blank)) Then
            img31.Source = o
            img31.IsEnabled = False
        ElseIf ((img23.Source.Equals(x) And img32.Source.Equals(x)) And img33.Source.Equals(blank)) Then
            img33.Source = o
            img33.IsEnabled = False
        ElseIf (img21.Source.Equals(x) And img33.Source.Equals(x) And img32.Source.equals(blank)) Then
            img32.Source = o
            img32.IsEnabled = False
        ElseIf (img22.Source.Equals(x) And img33.Source.Equals(x) And img31.Source.Equals(blank)) Then
            img31.Source = o
            img31.IsEnabled = False
        ElseIf (img11.Source.Equals(x) And img32.Source.Equals(x) And img21.Source.Equals(blank)) Then
            img21.Source = o
            img21.IsEnabled = False
        ElseIf (img13.Source.Equals(x) And img32.Source.Equals(x) And img23.Source.Equals(blank)) Then
            img23.Source = o
            img23.IsEnabled = False
            'singles
        ElseIf (img11.Source.Equals(x)) Then
            potato = 0
            mh1(0) = img11
            mh1(1) = img12
            mh1(2) = img13
            If (img22.Source.Equals(blank)) Then
                img22.Source = o
                img22.IsEnabled = False
            ElseIf (mh1(1).Source.Equals(blank)) Then
                mh1(1).Source = o
                mh1(1).IsEnabled = False
            ElseIf (mh1(2).Source.Equals(blank)) Then
                mh1(2).Source = o
                mh1(2).IsEnabled = False
            Else
                For a As Integer = 0 To 8
                    If (mall(a).Source.Equals(blank)) Then
                        mall(a).Source = o
                        mall(a).IsEnabled = False
                        Exit For
                    End If
                Next
            End If
            potato = 0
        ElseIf (img12.Source.Equals(x)) Then
            mh1(0) = img11
            mh1(1) = img12
            mh1(2) = img13
            If (img22.Source.Equals(blank)) Then
                img22.Source = o
                img22.IsEnabled = False
            ElseIf (mh1(0).Source.Equals(blank)) Then
                mh1(0).Source = o
                mh1(0).IsEnabled = False
            ElseIf (mh1(2).Source.Equals(blank)) Then
                mh1(2).Source = o
                mh1(2).IsEnabled = False
            Else
                For a As Integer = 0 To 8
                    If (mall(a).Source.Equals(blank) And potato = 0) Then
                        mall(a).Source = o
                        mh1(a).IsEnabled = False
                        Exit For
                    End If
                    potato += 1
                Next
            End If
            potato = 0
        ElseIf (img13.Source.Equals(x)) Then
            mh1(0) = img11
            mh1(1) = img12
            mh1(2) = img13
            If (img22.Source.Equals(blank)) Then
                img22.Source = o
                img22.IsEnabled = False
            ElseIf (mh1(1).Source.Equals(blank)) Then
                mh1(1).Source = o
                mh1(1).IsEnabled = False
            ElseIf (mh1(0).Source.Equals(blank)) Then
                mh1(0).Source = o
                mh1(0).IsEnabled = False
            Else
                For a As Integer = 0 To 8
                    If (mall(a).Source.Equals(blank) And potato = 0) Then
                        mall(a).Source = o
                        mall(a).IsEnabled = False
                        Exit For
                    End If
                    potato += 1
                Next
            End If
            potato = 0
        ElseIf (img21.Source.Equals(x)) Then
            mh2(0) = img21
            mh2(1) = img22
            mh2(2) = img23
            If (mh2(1).Source.Equals(blank)) Then
                mh2(1).Source = o
                mh2(1).IsEnabled = False
            ElseIf (mh2(2).Source.Equals(blank)) Then
                mh2(2).Source = o
                mh2(2).IsEnabled = False
            Else
                For a As Integer = 0 To 8
                    If (mall(a).Source.Equals(blank) And potato = 0) Then
                        mall(a).Source = o
                        mall(a).IsEnabled = False
                        Exit For
                    End If
                    potato += 1
                Next
            End If
            potato = 0
            potato = 0
        ElseIf (img22.Source.Equals(x)) Then
            mh2(0) = img21
            mh2(1) = img22
            mh2(2) = img23
            If (img11.Source.Equals(blank)) Then
                img11.Source = o
                img11.IsEnabled = False
            ElseIf (img33.Source.Equals(blank)) Then
                img33.Source = o
                img33.IsEnabled = False
            ElseIf (mh2(0).Source.Equals(blank)) Then
            mh2(0).Source = o
                    mh2(0).IsEnabled = False
                ElseIf (mh2(2).Source.Equals(blank)) Then
                    mh2(2).Source = o
                    mh2(2).IsEnabled = False
                Else
                    For a As Integer = 0 To 8
                        If (mall(a).Source.Equals(blank) And potato = 0) Then
                            mall(a).Source = o
                            mall(a).IsEnabled = False
                            Exit For
                        End If
                        potato += 1
                    Next
                End If
                potato = 0
            ElseIf (img23.Source.Equals(x)) Then
                mh2(0) = img21
                mh2(1) = img22
                mh2(2) = img23
                If (mh2(1).Source.Equals(blank)) Then
                    mh2(1).Source = o
                    mh2(1).IsEnabled = False
                ElseIf (mh2(2).Source.Equals(blank)) Then
                    mh2(2).Source = o
                    mh2(2).IsEnabled = False
                Else
                    For a As Integer = 0 To 8
                        If (mall(a).Source.Equals(blank) And potato = 0) Then
                            mall(a).Source = o
                            mall(a).IsEnabled = False
                            Exit For
                        End If
                        potato += 1
                    Next
                End If
                potato = 0
                potato = 0
            ElseIf (img31.Source.Equals(x)) Then
                mh3(0) = img31
                mh3(1) = img32
                mh3(2) = img33
                If (img22.Source.Equals(blank)) Then
                    img22.Source = o
                    img22.IsEnabled = False
                ElseIf (mh3(1).Source.Equals(blank)) Then
                    mh3(1).Source = o
                    mh3(1).IsEnabled = False
                ElseIf (mh3(2).Source.Equals(blank)) Then
                    mh3(2).Source = o
                    mh3(2).IsEnabled = False
                Else
                    For a As Integer = 0 To 8
                        If (mall(a).Source.Equals(blank) And potato = 0) Then
                            mall(a).Source = o
                            mall(a).IsEnabled = False
                            Exit For
                        End If
                        potato += 1
                    Next
                End If
                potato = 0
            ElseIf (img32.Source.Equals(x)) Then
                mh3(0) = img31
                mh3(1) = img32
                mh3(2) = img33
                If (img22.Source.Equals(blank)) Then
                    img22.Source = o
                    img22.IsEnabled = False
                ElseIf (mh3(0).Source.Equals(blank)) Then
                    mh3(0).Source = o
                    mh3(0).IsEnabled = False
                ElseIf (mh3(2).Source.Equals(blank)) Then
                    img33.Source = o
                    mh3(2).IsEnabled = False
                Else
                    For a As Integer = 0 To 8
                        If (mall(a).Source.Equals(blank) And potato = 0) Then
                            mall(a).Source = o
                            mall(a).IsEnabled = False
                            Exit For
                        End If
                        potato += 1
                    Next
                End If
                potato = 0
                potato = 0
            ElseIf (img33.Source.Equals(x)) Then
                mh3(0) = img31
                mh3(1) = img32
            mh3(2) = img33
            If (img22.Source.Equals(blank)) Then
                img22.Source = o
                img22.IsEnabled = False
            ElseIf (img32.Source.Equals(blank)) Then
                img32.Source = o
                img32.IsEnabled = False
            ElseIf (mh3(0).Source.Equals(blank)) Then
                    mh3(0).Source = o
                    mh3(0).IsEnabled = False
                Else
                    For a As Integer = 0 To 8
                        If (mall(a).Source.Equals(blank) And potato = 0) Then
                            mall(a).Source = o
                            mall(a).IsEnabled = False
                            Exit For
                        End If
                        potato += 1
                    Next
                End If
                potato = 0
            Else
                For c As Integer = 0 To 8
                If (mall(c).Source.Equals(blank)) Then
                    mall(c).Source = o
                    mall(c).IsEnabled = False
                    Exit For
                End If
            Next
            potato = 0
        End If

        mall(0) = img11
        mall(1) = img12
        mall(2) = img13
        mall(3) = img21
        mall(4) = img22
        mall(5) = img23
        mall(6) = img31
        mall(7) = img32
        mall(8) = img33
        counter1 = 0
        For a As Integer = 0 To 8
            If (mall(a).Source.Equals(blank)) Then
                counter1 += 1
                Exit For
            End If
        Next
        If ((img11.Source.Equals(o) And img12.Source.Equals(o) And img13.Source.Equals(o)) Or (img22.Source.Equals(o) And img23.Source.Equals(o) And img21.Source.Equals(o)) Or (img31.Source.Equals(o) And img32.Source.Equals(o) And img33.Source.Equals(o)) Or (img11.Source.Equals(o) And img21.Source.Equals(o) And img31.Source.Equals(o)) Or (img12.Source.Equals(o) And img22.Source.Equals(o) And img32.Source.Equals(o)) Or (img13.Source.Equals(o) And img23.Source.Equals(o) And img33.Source.Equals(o)) Or (img11.Source.Equals(o) And img22.Source.Equals(o) And img33.Source.Equals(o)) Or (img13.Source.Equals(o) And img22.Source.Equals(o) And img31.Source.Equals(o)) Or counter1 = 0) Then
            doob()
        End If
    End Sub

    Private Sub SinglePlayer_Checked(sender As Object, e As RoutedEventArgs) Handles SinglePlayer.Checked
        counter = 0
    End Sub
End Class
