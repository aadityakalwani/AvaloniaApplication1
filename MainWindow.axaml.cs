using System;
using System.Threading;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        Console.WriteLine("Hello World!");
        InitializeComponent();
        firstEverButton.Content = "Click me!";
    }

    public void somethingClicked(object? sender, RoutedEventArgs routedEventArgs)
    {
        firstEverButton.Background = Brushes.Chartreuse;
        firstEverButton.Content = "You clicked me!";
    }
}
