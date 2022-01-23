Class MainWindow
    Dim rolls As Integer = 0
    Dim imgns(4) As Image
    Dim dice(5) As BitmapImage
    Dim randdice1 As Random
    Dim selected(4) As Image
    Dim blank As BitmapImage = New BitmapImage(New Uri("Resources/blank.png", UriKind.Relative))
    Dim diceinnumbers(4) As Integer
    Dim howmany(5) As Integer
    Dim needstobedisabled As ArrayList = New ArrayList
    Dim sumlower1 As Integer = 0
    Dim sumlower2 As Integer = 0
    Dim sumupper1 As Integer = 0
    Dim sumupper2 As Integer = 0
    Dim total(12) As TextBlock
    Dim total1(12) As TextBlock
    Dim turn As Boolean = False
    Dim yahtzee1(4) As TextBlock
    Dim yahtzee2(4) As TextBlock
    Dim yeezer As Integer = 0
    Dim counter As Integer = 0
    Dim yahtzeec1 As Boolean = False
    Dim yahtzeec2 As Boolean = False
    Private Sub resetP()
        rolls = 0
        needstobedisabled.Clear()
        sumlower1 = 0
        sumlower2 = 0
        sumupper1 = 0
        sumupper2 = 0
        yeezer = 0
        turn = False
        For a As Integer = 0 To 12
            total(a).Text = 0
            total1(a).Text = 0
        Next
        counter = 0
    End Sub
    Private Sub btnroll_Click(sender As Object, e As RoutedEventArgs) Handles btnroll.Click
        For a As Integer = 0 To 4
            imgns(a).Source = dice(randdice1.Next(6))
        Next
        info()
    End Sub
    Private Sub info()
        rolls += 1
        If (rolls = 3) Then
            btnroll.IsEnabled = False
        End If
        My.Computer.Audio.Play(My.Resources.roll, AudioPlayMode.Background)
        Dim c As Integer = 0
        For a As Integer = 0 To 4
            If (imgns(a).Visibility.Equals(Visibility.Visible)) Then
                For b As Integer = 0 To 5
                    If (imgns(a).Source().Equals(dice(b))) Then
                        diceinnumbers(c) = b + 1
                        c += 1
                    End If
                Next
            ElseIf (selected(a).Visibility.Equals(Visibility.Visible)) Then
                For b As Integer = 0 To 5
                    If (selected(a).Source().Equals(dice(b))) Then
                        diceinnumbers(c) = b + 1
                        c += 1
                    End If
                Next
            End If
        Next
        For a As Integer = 0 To 5
            howmany(a) = 0
        Next
        For a As Integer = 0 To 4
            If (diceinnumbers(a) = 1) Then
                howmany(0) += 1
            ElseIf (diceinnumbers(a) = 2) Then
                howmany(1) += 1
            ElseIf (diceinnumbers(a) = 3) Then
                howmany(2) += 1
            ElseIf (diceinnumbers(a) = 4) Then
                howmany(3) += 1
            ElseIf (diceinnumbers(a) = 5) Then
                howmany(4) += 1
            ElseIf (diceinnumbers(a) = 6) Then
                howmany(5) += 1
            End If
        Next
        If turn = False Then
            For a As Integer = 0 To 12
                total(a).IsEnabled = True
            Next
            For a As Integer = 0 To needstobedisabled.Count - 1
                needstobedisabled(a).isenabled = False
            Next
            If (txtthreeokkinds.IsEnabled = True) Then
                Dim tok As Integer = threeofkind()
                txtthreeokkinds.Text = tok
            End If
            If (txtfourofkinds.IsEnabled = True) Then
                Dim fok As Integer = fourofkind()
                txtfourofkinds.Text = fok
            End If
            If (txtfullhouses.IsEnabled.Equals(True)) Then
                Dim fh As Integer = Fullhouse()
                txtfullhouses.Text = fh
            End If
            If (txtsmallstraights.IsEnabled.Equals(True)) Then
                Dim SSS As Integer = SmallStraight()
                txtsmallstraights.Text = SSS
            End If
            If (txtlargestraights.IsEnabled.Equals(True)) Then
                Dim LSS As Integer = LargeStraight()
                txtlargestraights.Text = LSS
            End If
            If (txtchance.IsEnabled.Equals(True)) Then
                Dim cha As Integer = Chance()
                txtchance.Text = cha
            End If
            If (txtOnes.IsEnabled.Equals(True)) Then
                Dim one As Integer = numbers(1)
                txtOnes.Text = one
            End If
            If (txtTwos.IsEnabled.Equals(True)) Then
                Dim two As Integer = numbers(2)
                txtTwos.Text = two
            End If
            If (txtthrees.IsEnabled.Equals(True)) Then
                Dim three As Integer = numbers(3)
                txtthrees.Text = three
            End If
            If (testfours.IsEnabled.Equals(True)) Then
                Dim four As Integer = numbers(4)
                testfours.Text = four
            End If
            If (txtfives.IsEnabled.Equals(True)) Then
                Dim five As Integer = numbers(5)
                txtfives.Text = five
            End If
            If (txtsixs.IsEnabled.Equals(True)) Then
                Dim six As Integer = numbers(6)
                txtsixs.Text = six
            End If
            yahtzee(yahtzee1, yahtzeec1)
        End If
        If turn = True Then
            For a As Integer = 0 To 12
                total1(a).IsEnabled = True
            Next
            For a As Integer = 0 To needstobedisabled.Count - 1
                needstobedisabled(a).isenabled = False
            Next
            If (txtthreeokkinds_Copy.IsEnabled.Equals(True)) Then
                Dim tok As Integer = threeofkind()
                txtthreeokkinds_Copy.Text = tok
            End If
            If (txtfourofkinds_Copy.IsEnabled.Equals(True)) Then
                Dim fok As Integer = fourofkind()
                txtfourofkinds_Copy.Text = fok
            End If
            If (txtfullhouses_Copy.IsEnabled.Equals(True)) Then
                Dim fh As Integer = Fullhouse()
                txtfullhouses_Copy.Text = fh
            End If
            If (txtsmallstraights_Copy.IsEnabled.Equals(True)) Then
                Dim SSS As Integer = SmallStraight()
                txtsmallstraights_Copy.Text = SSS
            End If
            If (txtlargestraights_Copy.IsEnabled.Equals(True)) Then
                Dim LSS As Integer = LargeStraight()
                txtlargestraights_Copy.Text = LSS
            End If
            If (txtchance_Copy.IsEnabled.Equals(True)) Then
                Dim cha As Integer = Chance()
                txtchance_Copy.Text = cha
            End If
            If (txtOnes_Copy.IsEnabled.Equals(True)) Then
                Dim one As Integer = numbers(1)
                txtOnes_Copy.Text = one
            End If
            If (txtTwos_Copy.IsEnabled.Equals(True)) Then
                Dim two As Integer = numbers(2)
                txtTwos_Copy.Text = two
            End If
            If (txtthrees_Copy.IsEnabled.Equals(True)) Then
                Dim three As Integer = numbers(3)
                txtthrees_Copy.Text = three
            End If
            If (testfours_Copy.IsEnabled.Equals(True)) Then
                Dim four As Integer = numbers(4)
                testfours_Copy.Text = four
            End If
            If (txtfives_Copy.IsEnabled.Equals(True)) Then
                Dim five As Integer = numbers(5)
                txtfives_Copy.Text = five
            End If
            If (txtsixs_Copy.IsEnabled.Equals(True)) Then
                Dim six As Integer = numbers(6)
                txtsixs_Copy.Text = six
            End If
            yahtzee(yahtzee2, yahtzeec2)
        End If
    End Sub
    Private Sub yahtzee(a, b)
        For c As Integer = 0 To 5
            If (howmany(c) = 5) Then
                If (b = False) Then
                    If (a(0).Visibility.Equals(Visibility.Visible)) Then
                        a(0).isenabled = True
                        a(0).Text = 50
                    ElseIf (a(1).Visibility.Equals(Visibility.Visible)) Then
                        a(1).Text = 150
                        a(1).isenabled = True
                    ElseIf (a(2).Visibility.Equals(Visibility.Visible)) Then
                        a(2).text = 250
                        a(2).isenabled = True
                    ElseIf (a(3).Visibility.Equals(Visibility.Visible)) Then
                        a(3).text = 350
                        a(3).isenabled = True
                    End If
                End If
                Exit For
            Else
                a(0).text = "0"
            End If
        Next
    End Sub
    Private Sub yahtze1(b As TextBlock(), c As TextBlock())
        MsgBox("Please select other scoring option.")
        For e As Integer = 0 To needstobedisabled.Count - 1
            needstobedisabled(e).isenabled = False
        Next
        For bc As Integer = 0 To 12
            Dim yoinkers As Integer = 0
            For cd As Integer = 0 To needstobedisabled.Count - 1
                If (c(bc).Equals(needstobedisabled(cd))) Then
                    yoinkers += 1
                End If
            Next
            If (yoinkers = 0 And (Not (c(bc).Equals(b(0)) Or c(bc).Equals(b(1)) Or c(bc).Equals(b(2)) Or c(bc).Equals(b(3))))) Then
                c(bc).Text = 0
            End If
        Next
        If turn = False Then
            yaye(c)
        ElseIf turn = True Then
            yaye1(c)
        End If
    End Sub
    Private Sub yaye(c)
        turn = True
        txtTotalB.Text = sumlower1
        txtTotalsU.Text = sumupper1
        If (sumupper1 >= 63) Then
            txtBonus.Text = 35
        Else
            txtBonus.Text = 0
        End If
        txtUpper.Text = Integer.Parse(txtBonus.Text) + Integer.Parse(txtTotalsU.Text)
        txtCombined.Text = Integer.Parse(txtUpper.Text) + Integer.Parse(txtTotalB.Text)
        reset()
    End Sub
    Private Sub yaye1(c)
        turn = False
        txtTotalB_Copy.Text = sumlower2
        txtTotalsU_Copy.Text = sumupper2
        If (sumupper2 >= 63) Then
            txtBonus_Copy.Text = 35
        Else
            txtBonus_Copy.Text = 0
        End If
        txtUpper_Copy.Text = Integer.Parse(txtBonus_Copy.Text) + Integer.Parse(txtTotalsU_Copy.Text)
        txtCombined_Copy.Text = Integer.Parse(txtUpper_Copy.Text) + Integer.Parse(txtTotalB_Copy.Text)
        reset()
    End Sub
    Private Sub yeezer1(a)
        If (yeezer = 1) Then
            a.text = 0
            yeezer = 0
        End If
    End Sub
    Private Function numbers(c)
        Dim b As Integer = 0
        For a As Integer = 0 To 4
            If (diceinnumbers(a) = c) Then
                b += 1
            End If
        Next
        Return (b * c)
    End Function
    Private Function threeofkind()
        Dim sumation As Integer = 0
        For a As Integer = 0 To 5
            If (howmany(a) >= 3) Then
                For b As Integer = 0 To 4
                    sumation += diceinnumbers(b)
                Next
            End If
        Next
        Return sumation
    End Function
    Private Function fourofkind()
        Dim sumation As Integer = 0
        For a As Integer = 0 To 5
            If (howmany(a) >= 4) Then
                For b As Integer = 0 To 4
                    sumation += diceinnumbers(b)
                Next
            End If
        Next
        Return sumation
    End Function
    Private Function Fullhouse()
        Dim sumation As Integer = 0
        Dim sumation1 As Integer = 0
        Dim sumation2 As Integer = 0
        For a As Integer = 0 To 5
            If (howmany(a) = 3) Then
                sumation += 1
            ElseIf (howmany(a) = 2) Then
                sumation1 += 1
            End If
        Next
        If (sumation >= 1 And sumation1 >= 1) Then
            Return 25
        End If
        Return 0
    End Function
    Private Function SmallStraight()
        Dim hazMeSmallStrate As Boolean = False

        For i = 0 To 2
            If (howmany(i) >= 1 And howmany(i + 1) >= 1 And howmany(i + 2) >= 1 And howmany(i + 3) >= 1) Then
                hazMeSmallStrate = True
            End If
        Next
        If (hazMeSmallStrate = True) Then
            Return 30
        End If
        Return 0
    End Function
    Private Function LargeStraight()
        Array.Sort(diceinnumbers)
        If (diceinnumbers(0).Equals(diceinnumbers(1) - 1) And diceinnumbers(1).Equals(diceinnumbers(2) - 1) And diceinnumbers(2).Equals(diceinnumbers(3) - 1) And diceinnumbers(3).Equals(diceinnumbers(4) - 1)) Then
            Return 40
        End If
        Return 0
    End Function
    Private Function Chance()
        Dim sum As Integer = 0
        For a As Integer = 0 To 4
            sum += diceinnumbers(a)
        Next
        Return sum
    End Function
    Private Sub YahtzeeAmar_Initialized(sender As Object, e As EventArgs) Handles YahtzeeAmar.Initialized
        imgns(0) = imgns1
        imgns(1) = imgns2
        imgns(2) = imgns3
        imgns(3) = imgns4
        imgns(4) = imgns5
        dice(0) = New BitmapImage(New Uri("Resources/dice1.png", UriKind.Relative))
        dice(1) = New BitmapImage(New Uri("Resources/dice2.png", UriKind.Relative))
        dice(2) = New BitmapImage(New Uri("Resources/dice3.png", UriKind.Relative))
        dice(3) = New BitmapImage(New Uri("Resources/dice4.png", UriKind.Relative))
        dice(4) = New BitmapImage(New Uri("Resources/dice5.png", UriKind.Relative))
        dice(5) = New BitmapImage(New Uri("Resources/dice6.png", UriKind.Relative))
        randdice1 = New Random
        selected(0) = imgs1
        selected(1) = imgs2
        selected(2) = imgs3
        selected(3) = imgs4
        selected(4) = imgs5
        total(0) = txtOnes
        total(1) = txtTwos
        total(2) = txtthrees
        total(3) = testfours
        total(4) = txtfives
        total(5) = txtsixs
        total(6) = txtthreeokkinds
        total(7) = txtfourofkinds
        total(8) = txtfullhouses
        total(9) = txtsmallstraights
        total(10) = txtlargestraights
        total(11) = txtyahtzees
        total(12) = txtchance
        total1(0) = txtOnes_Copy
        total1(1) = txtTwos_Copy
        total1(2) = txtthrees_Copy
        total1(3) = testfours_Copy
        total1(4) = txtfives_Copy
        total1(5) = txtsixs_Copy
        total1(6) = txtthreeokkinds_Copy
        total1(7) = txtfourofkinds_Copy
        total1(8) = txtfullhouses_Copy
        total1(9) = txtsmallstraights_Copy
        total1(10) = txtlargestraights_Copy
        total1(11) = txtyahtzee_Copy
        total1(12) = txtchance_Copy
        yahtzee1(0) = txtyahtzee3
        yahtzee1(1) = txtyahtzees2
        yahtzee1(2) = txtyahtzees1
        yahtzee1(3) = txtyahtzees
        yahtzee2(0) = txtyahtzee3_Copy
        yahtzee2(1) = txtyahtzee2_Copy
        yahtzee2(2) = txtyahtzee1_Copy
        yahtzee2(3) = txtyahtzee_Copy
        For a As Integer = 1 To 3
            yahtzee1(a).Visibility = Visibility.Hidden
            yahtzee2(a).Visibility = Visibility.Hidden
        Next
    End Sub

    Private Sub imgs1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles imgs1.MouseDown
        selected(0).Source = blank
        imgns1.Visibility = Visibility.Visible
    End Sub

    Private Sub imgs2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles imgs2.MouseDown
        selected(1).Source = blank
        imgns2.Visibility = Visibility.Visible
    End Sub

    Private Sub imgs3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles imgs3.MouseDown
        selected(2).Source = blank
        imgns3.Visibility = Visibility.Visible
    End Sub

    Private Sub imgs4_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles imgs4.MouseDown
        selected(3).Source = blank
        imgns4.Visibility = Visibility.Visible
    End Sub

    Private Sub imgs5_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles imgs5.MouseDown
        selected(4).Source = blank
        imgns5.Visibility = Visibility.Visible
    End Sub

    Private Sub imgns1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles imgns1.MouseDown
        selected(0) = imgs1
        selected(0).Source = imgns(0).Source
        imgns1.Visibility = Visibility.Collapsed
        imgs1.IsEnabled = True
    End Sub

    Private Sub imgns2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles imgns2.MouseDown
        selected(1) = imgs2
        selected(1).Source = imgns(1).Source
        imgns2.Visibility = Visibility.Collapsed
        imgs2.IsEnabled = True
    End Sub

    Private Sub imgns3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles imgns3.MouseDown
        selected(2) = imgs3
        selected(2).Source = imgns(2).Source
        imgns3.Visibility = Visibility.Collapsed
        imgs3.IsEnabled = True
    End Sub

    Private Sub imgns4_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles imgns4.MouseDown
        selected(3) = imgs4
        selected(3).Source = imgns(3).Source
        imgns4.Visibility = Visibility.Collapsed
        imgs4.IsEnabled = True
    End Sub

    Private Sub imgns5_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles imgns5.MouseDown
        selected(4) = imgs5
        selected(4).Source = imgns(4).Source
        imgns5.Visibility = Visibility.Collapsed
        imgs5.IsEnabled = True
    End Sub

    Private Sub txtthreeokkinds_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtthreeokkinds.MouseDown
        sumlower1 += Integer.Parse(txtthreeokkinds.Text)
        needstobedisabled.Add(txtthreeokkinds)
        txtthreeokkinds.Foreground = Brushes.Green
        yeezer1(txtthreeokkinds)
        score1()
    End Sub

    Private Sub txtfourofkinds_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtfourofkinds.MouseDown
        sumlower1 += Integer.Parse(txtfourofkinds.Text)
        needstobedisabled.Add(txtfourofkinds)
        txtfourofkinds.Foreground = Brushes.Green
        yeezer1(txtfourofkinds)
        score1()
    End Sub

    Private Sub txtfullhouses_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtfullhouses.MouseDown
        sumlower1 += Integer.Parse(txtfullhouses.Text)
        needstobedisabled.Add(txtfullhouses)
        txtfullhouses.Foreground = Brushes.Green
        yeezer1(txtfullhouses)
        score1()
    End Sub

    Private Sub txtsmallstraights_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtsmallstraights.MouseDown
        sumlower1 += Integer.Parse(txtsmallstraights.Text)
        needstobedisabled.Add(txtsmallstraights)
        txtsmallstraights.Foreground = Brushes.Green
        yeezer1(txtsmallstraights)
        score1()
    End Sub

    Private Sub txtlargestraights_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtlargestraights.MouseDown
        sumlower1 += Integer.Parse(txtlargestraights.Text)
        needstobedisabled.Add(txtlargestraights)
        txtlargestraights.Foreground = Brushes.Green
        yeezer1(txtlargestraights)
        score1()
    End Sub
    Private Sub score1()
        txtTotalB.Text = sumlower1
        txtTotalsU.Text = sumupper1
        If (sumupper1 >= 63) Then
            txtBonus.Text = 35
        Else
            txtBonus.Text = 0
        End If
        txtUpper.Text = Integer.Parse(txtBonus.Text) + Integer.Parse(txtTotalsU.Text)
        txtCombined.Text = Integer.Parse(txtUpper.Text) + Integer.Parse(txtTotalB.Text)
        For a As Integer = 0 To 12
            total(a).IsEnabled = False
        Next
        For a As Integer = 0 To 12
            If (Not total(a).Foreground.Equals(Brushes.Green)) Then
                total(a).Text = 0
            End If
        Next
        For a As Integer = 0 To 3
            yahtzee1(a).IsEnabled = False
        Next
        For a As Integer = 0 To 3
            If (yahtzeec2.Equals(False)) Then
                yahtzee2(a).IsEnabled = True
            End If
        Next
        If (Not yahtzee1(0).Visibility.Equals(Visibility.Collapsed)) Then
            yahtzee1(0).Text = "0"
        End If
        turn = True
        reset()
    End Sub

    Private Sub txtthreeokkinds_Copy_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtthreeokkinds_Copy.MouseDown
        sumlower2 += Integer.Parse(txtthreeokkinds_Copy.Text)
        needstobedisabled.Add(txtthreeokkinds_Copy)
        txtthreeokkinds_Copy.Foreground = Brushes.Green
        yeezer1(txtthreeokkinds_Copy)
        score2()
    End Sub

    Private Sub txtfourofkinds_Copy_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtfourofkinds_Copy.MouseDown
        sumlower2 += Integer.Parse(txtfourofkinds_Copy.Text)
        needstobedisabled.Add(txtfourofkinds_Copy)
        txtfourofkinds_Copy.Foreground = Brushes.Green
        yeezer1(txtfourofkinds_Copy)
        score2()
    End Sub

    Private Sub txtfullhouses_Copy_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtfullhouses_Copy.MouseDown
        sumlower2 += Integer.Parse(txtfullhouses_Copy.Text)
        needstobedisabled.Add(txtfullhouses_Copy)
        txtfullhouses_Copy.Foreground = Brushes.Green
        yeezer1(txtfullhouses_Copy)
        score2()
    End Sub

    Private Sub txtsmallstraights_Copy_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtsmallstraights_Copy.MouseDown
        sumlower2 += Integer.Parse(txtsmallstraights_Copy.Text)
        needstobedisabled.Add(txtsmallstraights_Copy)
        txtsmallstraights_Copy.Foreground = Brushes.Green
        yeezer1(txtsmallstraights_Copy)
        score2()
    End Sub

    Private Sub txtlargestraights_Copy_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtlargestraights_Copy.MouseDown
        sumlower2 += Integer.Parse(txtlargestraights_Copy.Text)
        needstobedisabled.Add(txtlargestraights_Copy)
        txtlargestraights_Copy.Foreground = Brushes.Green
        yeezer1(txtlargestraights_Copy)
        score2()
    End Sub
    Private Sub score2()
        txtTotalB_Copy.Text = sumlower2
        txtTotalsU_Copy.Text = sumupper2
        If (sumupper2 >= 63) Then
            txtBonus_Copy.Text = 35
        Else
            txtBonus_Copy.Text = 0
        End If
        txtUpper_Copy.Text = Integer.Parse(txtBonus_Copy.Text) + Integer.Parse(txtTotalsU_Copy.Text)
        txtCombined_Copy.Text = Integer.Parse(txtUpper_Copy.Text) + Integer.Parse(txtTotalB_Copy.Text)
        For a As Integer = 0 To 12
            total1(a).IsEnabled = False
        Next
        For a As Integer = 0 To 12
            If (Not total1(a).Foreground.Equals(Brushes.Green)) Then
                total1(a).Text = 0
            End If
        Next
        If (Not yahtzee2(0).Visibility.Equals(Visibility.Collapsed)) Then
            yahtzee2(0).Text = "0"
        End If
        For a As Integer = 0 To 3
            yahtzee2(a).IsEnabled = False
        Next
        For a As Integer = 0 To 3
            If (yahtzeec1.Equals(False)) Then
                yahtzee1(a).IsEnabled = True
            End If
        Next
        counter += 1
        turn = False
        reset()
    End Sub
    Private Sub reset()
        For a As Integer = 0 To 4
            imgns(a).Visibility = Visibility.Visible
            selected(a).Visibility = Visibility.Visible
            imgns(a).Source = blank
            selected(a).Source = blank
            rolls = 0
            btnroll.IsEnabled = True
        Next
        If (counter >= 13) Then
            If (Integer.Parse(txtTotalB.Text) > Integer.Parse(txtTotalB_Copy.Text)) Then
                MsgBox("Game Over. Player 1 Wins")
                resetP()
            ElseIf (Integer.Parse(txtTotalB.Text) < Integer.Parse(txtTotalB_Copy.Text)) Then
                MsgBox("Game Over. Player 2 Wins")
                resetP()
            ElseIf (Integer.Parse(txtTotalB.Text) = Integer.Parse(txtTotalB_Copy.Text)) Then
                MsgBox("Game Over. TIE")
                resetP()
            End If
        End If
    End Sub

    Private Sub txtchance_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtchance.MouseDown
        sumlower1 += Integer.Parse(txtchance.Text)
        needstobedisabled.Add(txtchance)
        txtchance.Foreground = Brushes.Green
        yeezer1(txtchance)
        score1()
    End Sub

    Private Sub txtchance_Copy_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtchance_Copy.MouseDown
        sumlower2 += Integer.Parse(txtchance_Copy.Text)
        needstobedisabled.Add(txtchance_Copy)
        txtchance_Copy.Foreground = Brushes.Green
        yeezer1(txtchance_Copy)
        score2()
    End Sub

    Private Sub txtOnes_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtOnes.MouseDown
        sumupper1 += Integer.Parse(txtOnes.Text)
        needstobedisabled.Add(txtOnes)
        txtOnes.Foreground = Brushes.Green
        yeezer1(txtOnes)
        score1()
    End Sub

    Private Sub txtTwos_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtTwos.MouseDown
        sumupper1 += Integer.Parse(txtTwos.Text)
        needstobedisabled.Add(txtTwos)
        txtTwos.Foreground = Brushes.Green
        yeezer1(txtTwos)
        score1()
    End Sub

    Private Sub txtthrees_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtthrees.MouseDown
        sumupper1 += Integer.Parse(txtthrees.Text)
        needstobedisabled.Add(txtthrees)
        txtthrees.Foreground = Brushes.Green
        yeezer1(txtthrees)
        score1()
    End Sub

    Private Sub testfours_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles testfours.MouseDown
        sumupper1 += Integer.Parse(testfours.Text)
        needstobedisabled.Add(testfours)
        testfours.Foreground = Brushes.Green
        yeezer1(testfours)
        score1()
    End Sub

    Private Sub txtfives_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtfives.MouseDown
        sumupper1 += Integer.Parse(txtfives.Text)
        needstobedisabled.Add(txtfives)
        txtfives.Foreground = Brushes.Green
        yeezer1(txtfives)
        score1()
    End Sub

    Private Sub txtsixs_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtsixs.MouseDown
        sumupper1 += Integer.Parse(txtsixs.Text)
        needstobedisabled.Add(txtsixs)
        txtsixs.Foreground = Brushes.Green
        yeezer1(txtsixs)
        score1()
    End Sub

    Private Sub txtOnes_Copy_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtOnes_Copy.MouseDown
        sumupper2 += Integer.Parse(txtOnes_Copy.Text)
        needstobedisabled.Add(txtOnes_Copy)
        txtOnes_Copy.Foreground = Brushes.Green
        yeezer1(txtOnes_Copy)
        score2()
    End Sub

    Private Sub txtTwos_Copy_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtTwos_Copy.MouseDown
        sumupper2 += Integer.Parse(txtTwos_Copy.Text)
        needstobedisabled.Add(txtTwos_Copy)
        txtTwos_Copy.Foreground = Brushes.Green
        yeezer1(txtTwos_Copy)
        score2()
    End Sub

    Private Sub txtthrees_Copy_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtthrees_Copy.MouseDown
        sumupper2 += Integer.Parse(txtthrees_Copy.Text)
        needstobedisabled.Add(txtthrees_Copy)
        txtthrees_Copy.Foreground = Brushes.Green
        yeezer1(txtthrees_Copy)
        score2()
    End Sub

    Private Sub testfours_Copy_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles testfours_Copy.MouseDown
        sumupper2 += Integer.Parse(testfours_Copy.Text)
        needstobedisabled.Add(testfours_Copy)
        testfours_Copy.Foreground = Brushes.Green
        yeezer1(testfours_Copy)
        score2()
    End Sub

    Private Sub txtfives_Copy_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtfives_Copy.MouseDown
        sumupper2 += Integer.Parse(txtfives_Copy.Text)
        needstobedisabled.Add(txtfives_Copy)
        txtfives_Copy.Foreground = Brushes.Green
        yeezer1(txtfives_Copy)
        score2()
    End Sub

    Private Sub txtsixs_Copy_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtsixs_Copy.MouseDown
        sumupper2 += Integer.Parse(txtsixs_Copy.Text)
        needstobedisabled.Add(txtsixs_Copy)
        txtsixs_Copy.Foreground = Brushes.Green
        yeezer1(txtsixs_Copy)
        score2()
    End Sub

    Private Sub YahtzeeAmar_KeyDown(sender As Object, e As KeyEventArgs) Handles YahtzeeAmar.KeyDown
        If (e.Key.Equals(Key.Y)) Then
            For a As Integer = 0 To 4
                If imgns(a).Visibility.Equals(Visibility.Visible) Then
                    imgns(a).Source = dice(1)
                ElseIf selected(a).Visibility.Equals(Visibility.Visible) Then
                    selected(a).Source = dice(1)
                End If
            Next
        End If
        If (e.Key.Equals(Key.L)) Then
            If imgns(0).Visibility.Equals(Visibility.Visible) Then
                imgns(0).Source = dice(1)
            ElseIf selected(0).Visibility.Equals(Visibility.Visible) Then
                selected(0).Source = dice(1)
            End If
            If imgns(1).Visibility.Equals(Visibility.Visible) Then
                imgns(1).Source = dice(2)
            ElseIf selected(1).Visibility.Equals(Visibility.Visible) Then
                selected(1).Source = dice(2)
            End If

            If imgns(2).Visibility.Equals(Visibility.Visible) Then
                imgns(2).Source = dice(3)
            ElseIf selected(2).Visibility.Equals(Visibility.Visible) Then
                selected(2).Source = dice(3)
            End If

            If imgns(3).Visibility.Equals(Visibility.Visible) Then
                imgns(3).Source = dice(4)
            ElseIf selected(3).Visibility.Equals(Visibility.Visible) Then
                selected(3).Source = dice(4)
            End If
            If imgns(4).Visibility.Equals(Visibility.Visible) Then
                imgns(4).Source = dice(5)
            ElseIf selected(4).Visibility.Equals(Visibility.Visible) Then
                selected(4).Source = dice(5)
            End If
        End If
        If (e.Key.Equals(Key.F)) Then
            If imgns(0).Visibility.Equals(Visibility.Visible) Then
                imgns(0).Source = dice(1)
            ElseIf selected(0).Visibility.Equals(Visibility.Visible) Then
                selected(0).Source = dice(1)
            End If
            If imgns(1).Visibility.Equals(Visibility.Visible) Then
                imgns(1).Source = dice(1)
            ElseIf selected(1).Visibility.Equals(Visibility.Visible) Then
                selected(1).Source = dice(1)
            End If

            If imgns(2).Visibility.Equals(Visibility.Visible) Then
                imgns(2).Source = dice(1)
            ElseIf selected(2).Visibility.Equals(Visibility.Visible) Then
                selected(2).Source = dice(1)
            End If
            If imgns(3).Visibility.Equals(Visibility.Visible) Then
                imgns(3).Source = dice(4)
            ElseIf selected(3).Visibility.Equals(Visibility.Visible) Then
                selected(3).Source = dice(4)
            End If
            If imgns(4).Visibility.Equals(Visibility.Visible) Then
                imgns(4).Source = dice(4)
            ElseIf selected(4).Visibility.Equals(Visibility.Visible) Then
                selected(4).Source = dice(4)
            End If
        End If
        info()
    End Sub
    Private Sub txtyahtzees_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtyahtzees.MouseDown
        sumlower1 += 100
        txtyahtzees.Foreground = Brushes.Green
        needstobedisabled.Add(txtyahtzees)
        yahtzeec1 = True
        yahtze1(yahtzee1, total)
    End Sub

    Private Sub txtyahtzees2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtyahtzees2.MouseDown
        sumlower1 += 100
        txtyahtzees1.Foreground = Brushes.Green
        txtyahtzees2.Visibility = Visibility.Collapsed
        txtyahtzees1.Visibility = Visibility.Visible
        txtyahtzees1.IsEnabled = False
        txtyahtzees1.Text = "150"
        yahtze1(yahtzee1, total)
    End Sub

    Private Sub txtyahtzees1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtyahtzees1.MouseDown
        sumlower1 += 100
        txtyahtzees.Foreground = Brushes.Green
        txtyahtzees1.Visibility = Visibility.Collapsed
        txtyahtzees.Visibility = Visibility.Visible
        txtyahtzees.IsEnabled = False
        txtyahtzees.Text = "250"
        yahtze1(yahtzee1, total)
    End Sub
    Private Sub txtyahtzee_Copy_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtyahtzee_Copy.MouseDown
        sumlower2 += 100
        txtyahtzee_Copy.Foreground = Brushes.Green
        needstobedisabled.Add(txtyahtzee_Copy)
        yahtzeec2 = True
        yahtze1(yahtzee2, total1)
    End Sub
    Private Sub txtyahtzee1_Copy_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtyahtzee1_Copy.MouseDown
        sumlower2 += 100
        txtyahtzee_Copy.Foreground = Brushes.Green
        txtyahtzee1_Copy.Visibility = Visibility.Collapsed
        txtyahtzee_Copy.Visibility = Visibility.Visible
        txtyahtzee_Copy.IsEnabled = False
        txtyahtzee_Copy.Text = "250"
        yahtze1(yahtzee2, total1)
    End Sub

    Private Sub txtyahtzee2_Copy_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtyahtzee2_Copy.MouseDown
        sumlower2 += 100
        txtyahtzee1_Copy.Foreground = Brushes.Green
        txtyahtzee2_Copy.Visibility = Visibility.Collapsed
        txtyahtzee1_Copy.Visibility = Visibility.Visible
        txtyahtzee1_Copy.IsEnabled = False
        txtyahtzee1_Copy.Text = "150"
        yahtze1(yahtzee2, total1)
    End Sub
    Private Sub txtyahtzee3_Copy_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles txtyahtzee3_Copy.MouseDown
        txtyahtzee2_Copy.Foreground = Brushes.Green
        txtyahtzee2_Copy.Visibility = Visibility.Visible
        txtyahtzee2_Copy.IsEnabled = False
        If (txtyahtzee3_Copy.Text = "50") Then
            sumlower2 += 50
            txtyahtzee2_Copy.Text = "50"
        Else
            yahtzeec2 = True
            For a As Integer = 0 To 3
                yahtzee2(a).IsEnabled = False
                If (Not yahtzee2(a).Equals(txtyahtzee2_Copy)) Then
                    yahtzee2(a).Visibility = Visibility.Collapsed
                End If
            Next
            txtyahtzee2_Copy.Text = "0"
            txtyahtzee2_Copy.Foreground = Brushes.Green
        End If
        txtyahtzee3_Copy.Visibility = Visibility.Collapsed
        score2()
    End Sub
    Private Sub txtyahtzee3_MouseDown_1(sender As Object, e As MouseButtonEventArgs) Handles txtyahtzee3.MouseDown
        txtyahtzees2.Foreground = Brushes.Green
        txtyahtzees2.Visibility = Visibility.Visible
        txtyahtzees2.IsEnabled = False
        If (txtyahtzee3.Text = "50") Then
            sumlower1 += 50
            txtyahtzees2.Text = "50"
        Else
            yahtzeec1 = True
            For a As Integer = 0 To 3
                yahtzee1(a).IsEnabled = False
                If (Not yahtzee1(a).Equals(txtyahtzees2)) Then
                    yahtzee1(a).Visibility = Visibility.Collapsed
                End If
            Next
            txtyahtzees2.Text = "0"
            txtyahtzees2.Foreground = Brushes.Green
        End If
        txtyahtzee3.Visibility = Visibility.Collapsed
        score1()
    End Sub
End Class
