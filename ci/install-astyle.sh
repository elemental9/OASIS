#! /bin/sh
set -eu
cd /tmp/
curl -L -o astyle.tar.gz http://sourceforge.net/projects/astyle/files/astyle/astyle%202.05.1/astyle_2.05.1_macosx.tar.gz/download
tar zxvf astyle.tar.gz
cd astyle
cd build/xcode
sudo xcodebuild install -project AStyle.xcodeproj
cd ../../build/mac/
make
sudo make install
