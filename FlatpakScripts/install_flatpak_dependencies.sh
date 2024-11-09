SCRIPT=$(realpath "$0")
SCRIPTPATH=$(dirname "$SCRIPT")

flatpak-builder build-dir --user --repo=repo --install-deps-from=flathub --download-only "$SCRIPTPATH/../Assets/Flatpak/org.gdpad.dotnet.json"
