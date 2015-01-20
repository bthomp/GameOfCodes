Class MainWindow 

    Private Sub btnFirst_Click(sender As Object, e As RoutedEventArgs)
        firstTB.Text = "This"
        secondTB.Text = ""
        thirdTB.Text = ""
        fourthTB.Text = ""
        bottomRowBorder.Background = Brushes.LightBlue
    End Sub

    Private Sub btnSecond_Click(sender As Object, e As RoutedEventArgs)
        secondTB.Text = "Stuff"
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

    Private Sub FindMouse(sender As Object, e As MouseEventArgs) Handles MainCanvas.PreviewMouseMove
        Dim position As Point = e.GetPosition(MainCanvas)
        Dim circle As New Image
        Dim bm As New BitmapImage
        bm.BeginInit()
        bm.UriSource = New Uri("C:\MyDev\Game Of Codes\Game Of Codes\Resources\Images\red circle.png", UriKind.Absolute)
        bm.EndInit()
        circle.Source = bm
        circle.Height = circle.Source.Height
        circle.Width = circle.Source.Width
        circle.Stretch = Stretch.None
        circle.UpdateLayout()
        MainCanvas.Children.Add(circle)
        Dim location As New Rect
        location.Location = position
        location.Height = circle.Height
        location.Width = circle.Width
        MainCanvas.Children.Item(0).Arrange(location)
        InvalidateArrange()
        MainCanvas.UpdateLayout()
    End Sub
End Class
