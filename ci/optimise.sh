#!/usr/bin/env bash

find OASIS -iname "*.cs" | xargs -n 1 -I {} bash -c "astyle --options=.astylerc \"{}\""

./ci/commitpush.sh "CI | Optimised the files with uncrustify [skip ci]"
