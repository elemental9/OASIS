#! /bin/sh

project="OASIS"

echo "Attempting to build $project for Windows"
/Applications/Unity/Unity.app/Contents/MacOS/Unity -batchmode -nographics -silent-crashes -logFile $(pwd)/unity.log -projectPath "$(pwd)/$project" -buildWindowsPlayer "$(pwd)/Build/windows/$project.exe" -quit

echo "Attempting to build $project for OS X"
/Applications/Unity/Unity.app/Contents/MacOS/Unity -batchmode -nographics -silent-crashes -logFile $(pwd)/unity.log -projectPath "$(pwd)/$project" -buildOSXUniversalPlayer "$(pwd)/Build/osx/$project.app" -quit

echo "Attempting to build $project for Linux"
/Applications/Unity/Unity.app/Contents/MacOS/Unity -batchmode -nographics -silent-crashes -logFile $(pwd)/unity.log -projectPath "$(pwd)/$project" -buildLinuxUniversalPlayer "$(pwd)/Build/linux/$project.exe" -quit

echo 'Logs from build'
cat $(pwd)/unity.log

echo 'Attempting to zip builds'
zip -r $(pwd)/dist/linux.zip $(pwd)/Build/linux/
zip -r $(pwd)/dist/mac.zip $(pwd)/Build/osx/
zip -r $(pwd)/dist/windows.zip $(pwd)/Build/windows/
