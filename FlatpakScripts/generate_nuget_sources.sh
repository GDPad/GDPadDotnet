SCRIPT=$(realpath "$0")
SCRIPTPATH=$(dirname "$SCRIPT")

python3 $SCRIPTPATH/flatpak-dotnet-generator.py --dotnet 8 --freedesktop 23.08 $SCRIPTPATH/../nuget-sources.json $SCRIPTPATH/../GDPadDotnet.csproj