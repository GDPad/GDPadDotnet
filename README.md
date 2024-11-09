# GDPad.NET

A tool for configuring your GDPad Device.


# Download


## Windows (install .NET Runtime first):

[Install](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-8.0.10-windows-x64-installer)

Go to the [GitHub Releases](https://github.com/GDPad/GDPad.NET/releases) page and select the latest archive for Windows.


## Linux

There are two ways to install it: 

- Download Flatpak bundle from Releases and run `flatpak install gdpad.net.flatpak` (run it from the terminal in your downloaded file's directory)
- Using Binaries from the archive `x64-linux-native.tar.gz`



### If you want run the app from flatpak:

[Install flatpak for your distro](https://flatpak.org/setup/)

```bash
flatpak run org.gdpad.dotnet
```



### In case of the .NET binary for Linux, you can run it from the terminal in the unpacked directory (install .NET Runtime first):

[Install on Linux](https://learn.microsoft.com/en-us/dotnet/core/install/linux?WT.mc_id=dotnet-35129-website)


On Arch (btw) and it's derivatives you can install .NET Runtime with `sudo pacman -S dotnet-runtime-8.0`.


```bash
./GDPadDotnet
```


