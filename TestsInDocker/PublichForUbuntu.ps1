dotnet publish TestsInDocker -c Release --force --no-self-contained --runtime ubuntu.16.04-x64
dotnet publish TestsInDocker.MSTest -c Release --force --no-self-contained --runtime ubuntu.16.04-x64
dotnet publish TestsInDocker.NUnit -c Release --force --no-self-contained --runtime ubuntu.16.04-x64
dotnet publish TestsInDocker.NUnit.UIAutomation -c Release --force --no-self-contained --runtime ubuntu.16.04-x64