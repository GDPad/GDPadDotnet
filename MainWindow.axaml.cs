using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace GDPadDotnet;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        if (App.IsCurrentProcessElevated()) {
            Console.WriteLine("Yeah, I'm elevated!");
        }
        else {
            Console.WriteLine("Nope, not elevated");
        }
    }
}