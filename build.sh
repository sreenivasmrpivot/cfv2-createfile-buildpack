#!/usr/bin/env bash

# Build the dotnet solution
dotnet publish src/cfv2-createfile-buildpack.sln --configuration Release

# Copy the build output to bin folder
