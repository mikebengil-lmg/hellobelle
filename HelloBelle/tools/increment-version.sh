#!/bin/bash

# Define the path to the .csproj file
csproj_file="../HelloBelle.csproj"

# Get the current version from the .csproj file using basic regular expressions
current_version=$(grep -o '<Version>[^<]*' "$csproj_file" | sed 's/<Version>//')

# Increment the version number (e.g., by adding 1 to the last part)
IFS='.' read -ra parts <<< "$current_version"
((parts[2]++))

# Update the .csproj file with the new version
new_version="${parts[0]}.${parts[1]}.${parts[2]}"
sed -i '' "s/<Version>$current_version<\/Version>/<Version>$new_version<\/Version>/" "$csproj_file"

echo "Version incremented to $new_version"
