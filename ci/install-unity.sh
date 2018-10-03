#!/usr/bin/env bash

# Does the Unity installer already exist (from cache)?
if [ -e "./cache/unity-installer.deb" ]; then
    echo 'File already exists. Download not required.'
else
    # Download the Unity installer
    curl -L -o ./cache/unity-installer.deb http://beta.unity3d.com/download/fd37f3680b5f/unity-editor_amd64-2017.2.0b11.deb
fi

# Make Unity installer executable
chmod +x ./cache/unity-installer.deb

# Run the Unity installer
sudo dpkg -i unity-installer.deb
