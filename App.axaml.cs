using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace GDPadDotnet;

public partial class App : Application
{

    [DllImport("libc")]
    private static extern uint geteuid();
    
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow();
        }

        base.OnFrameworkInitializationCompleted();
    }

    public static bool IsCurrentProcessElevated()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            using var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        return geteuid() == 0;
    }

    public static void AddLinuxUserToGroup(string group) {
        var username = Environment.GetEnvironmentVariable("USER");
        var command = $"usermod -aG {group} {username}";

        ProcessStartInfo startInfo = new ProcessStartInfo() 
        { 
            FileName = "/bin/pkexec", 
            Arguments = command
        }; 
        Process proc = new Process() 
        { 
            StartInfo = startInfo
        };
        proc.Start();
    }

}