#!/usr/bin/env bash

# Does the Unity installer already exist (from cache)?
if [ -e "./cache/unity-installer.sh" ]; then
    echo 'File already exists. Download not required.'
else
    # Download the Unity installer
    curl -L -o cache/unity-installer.sh http://beta.unity3d.com/download/fd37f3680b5f/unity-editor-installer-2017.2.0b11.sh
fi

# Make Unity installer executable
chmod +x ./cache/unity-installer.sh

# Run the Unity installer
sudo ./cache/unity-installer.sh
