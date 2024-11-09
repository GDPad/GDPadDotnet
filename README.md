# GDPad.NET

⚒ A tool for configuring your GDPad Device.

![image](https://github.com/user-attachments/assets/786e18a1-c073-4fe7-9d13-2aff9141141d)


## ➤ Run on Windows


- [Install .NET Runtime for Windows](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-8.0.10-windows-x64-installer)
- Go to the [GitHub Releases](https://github.com/GDPad/GDPad.NET/releases) page and select the latest archive for Windows.




## ➤ Run on Linux

There are two ways to install it: 

- **Download Flatpak bundle from Releases**
    - [Install flatpak for your distro](https://flatpak.org/setup/)
    - Run `flatpak install gdpad.net.flatpak` from the terminal in your downloaded file's directory
    - Run `flatpak run org.gdpad.dotnet`
- **Using Binaries from the archive `x64-linux-native.tar.gz`**
    - [Install .NET Runtime for Linux](https://learn.microsoft.com/en-us/dotnet/core/install/linux?WT.mc_id=dotnet-35129-website)
    - Run `./GDPadDotnet` from the terminal in the extracted directory

On **Arch (btw)** and it's *derivatives* you can install .NET Runtime with `sudo pacman -S dotnet-runtime-8.0`.
