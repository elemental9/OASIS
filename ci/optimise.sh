#!/usr/bin/env bash

uncrustify -c .uncrustify.cfg

./ci/commitpush.sh "CI | Optimised the files with uncrustify [skip ci]"
