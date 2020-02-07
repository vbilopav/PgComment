dotnet clean src\PgComment.csproj -c Release
dotnet publish -r win10-x64 -c Release /p:PublishSingleFile=true /p:PublishTrimmed=true -o "out\win10-x64" --nologo src\PgComment.csproj
dotnet publish -r linux-x64 -c Release /p:PublishSingleFile=true /p:PublishTrimmed=true -o "out\linux-x64" --nologo src\PgComment.csproj
dotnet publish -r osx-x64 -c Release /p:PublishSingleFile=true /p:PublishTrimmed=true -o "out\osx-x64" --nologo src\PgComment.csproj