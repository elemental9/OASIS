#!/usr/bin/env bash

uncrustify -c .uncrustify.cfg

./commitpush.sh "CI | Optimised the files with uncrustify [skip ci]"
