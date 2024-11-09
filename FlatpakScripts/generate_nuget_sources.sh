SCRIPT=$(realpath "$0")
SCRIPTPATH=$(dirname "$SCRIPT")

if [ ! -f $SCRIPTPATH/flatpak-dotnet-generator.py ]; then
    wget https://raw.githubusercontent.com/flatpak/flatpak-builder-tools/master/dotnet/flatpak-dotnet-generator.py -O $SCRIPTPATH/flatpak-dotnet-generator.py
fi


python3 $SCRIPTPATH/flatpak-dotnet-generator.py --dotnet 8 --freedesktop 23.08 $SCRIPTPATH/../nuget-sources.json $SCRIPTPATH/../GDPadDotnet.csproj