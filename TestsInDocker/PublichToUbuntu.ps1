dotnet publish TestsInDocker -c Release --force --self-contained --runtime ubuntu.16.04-x64
dotnet publish TestsInDocker.MSTest -c Release --force --self-contained --runtime ubuntu.16.04-x64
dotnet publish TestsInDocker.NUnit -c Release --force --self-contained --runtime ubuntu.16.04-x64