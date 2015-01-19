Class MainWindow 

    Private Sub btnFirst_Click(sender As Object, e As RoutedEventArgs)
        firstTB.Text = "This"
        secondTB.Text = ""
        thirdTB.Text = ""
        fourthTB.Text = ""
        bottomRowBorder.Background = Brushes.LightBlue
    End Sub

    Private Sub btnSecond_Click(sender As Object, e As RoutedEventArgs)
        secondTB.Text = "Shit"
        firstTB.Text = ""
        thirdTB.Text = ""
        fourthTB.Text = ""
        bottomRowBorder.Background = Brushes.Pink
    End Sub

    Private Sub btnThird_Click(sender As Object, e As RoutedEventArgs)
        thirdTB.Text = "Is"
        firstTB.Text = ""
        secondTB.Text = ""
        fourthTB.Text = ""
        bottomRowBorder.Background = Brushes.LightGreen
    End Sub

    Private Sub btnFourth_Click(sender As Object, e As RoutedEventArgs)
        fourthTB.Text = "Tite"
        firstTB.Text = ""
        secondTB.Text = ""
        thirdTB.Text = ""
        bottomRowBorder.Background = Brushes.PaleGoldenrod



    End Sub
End Class
