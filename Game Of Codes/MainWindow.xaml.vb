Class MainWindow

    Public circle As New Image
    Public mouseOnCanvas As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeImages()

    End Sub
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

    Private Sub InitializeImages()
        Dim bm As New BitmapImage
        bm.BeginInit()
        bm.UriSource = New Uri("C:\MyDev\Game Of Codes\Game Of Codes\Resources\Images\red circle.png", UriKind.Absolute)
        bm.EndInit()
        circle.Source = bm
        circle.Height = circle.Source.Height
        circle.Width = circle.Source.Width
        circle.Stretch = Stretch.None
        MainCanvas.Children.Add(circle)
    End Sub

    Private Sub FindMouse(sender As Object, e As MouseEventArgs) Handles MainCanvas.PreviewMouseMove
        If mouseOnCanvas Then
            Dim position As Point = e.GetPosition(MainCanvas)
            position.X = position.X - (circle.Width / 2)
            position.Y = position.Y - (circle.Height / 2)
            Dim location As New Rect
            location.Location = position
            location.Height = circle.Height
            location.Width = circle.Width
            MainCanvas.Children.Item(0).Arrange(location)
            MainCanvas.Children.Item(0).InvalidateArrange()
            MainCanvas.UpdateLayout()
        End If
        
    End Sub

    Private Sub MouseOnMainCanvas() Handles MainCanvas.MouseEnter
        mouseOnCanvas = True
    End Sub
    Private Sub ReturnToCenter() Handles MainCanvas.MouseLeave
        Dim position As New Point
        position.X = (position.X - (MainCanvas.Width / 2))
        position.Y = (position.Y - (MainCanvas.Height / 2))
        Dim location As New Rect
        location.Location = position
        location.Height = circle.Height
        location.Width = circle.Width
        MainCanvas.Children.Item(0).Arrange(location)
        MainCanvas.Children.Item(0).InvalidateArrange()
        MainCanvas.UpdateLayout()
        mouseOnCanvas = False

    End Sub
End Class
