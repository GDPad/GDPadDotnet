SCRIPT=$(realpath "$0")
SCRIPTPATH=$(dirname "$SCRIPT")


flatpak-builder build-dir --user --force-clean --install --repo=repo $SCRIPTPATH/../Assets/Flatpak/org.gdpad.dotnet.json