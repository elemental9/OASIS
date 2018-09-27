#!/usr/bin/env bash

# Return the output
git diff --name-only $TRAVIS_COMMIT_RANGE
