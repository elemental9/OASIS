#! /bin/sh

winname="${UNITYCI_PROJECT_NAME}_win.tar.gz"
osxname="${UNITYCI_PROJECT_NAME}_osx.tar.gz"

# set file permissions so builds can run out of the box
for infile in `find $(pwd)/Build | grep -E '\.exe$|\.dll$'`; do
	chmod 755 $infile
done

# tar and zip the build folders
tar -C "$(pwd)/Build" -czvf $winname "windows"
tar -C "$(pwd)/Build" -czvf $osxname "osx"

# upload the tarballs to the server for storage
