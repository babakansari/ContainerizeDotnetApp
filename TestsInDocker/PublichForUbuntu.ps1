dotnet publish TestsInDocker -c Release --no-self-contained --runtime ubuntu.16.04-x64 --output Published/Console
dotnet publish TestsInDocker.MSTest -c Release --no-self-contained --runtime ubuntu.16.04-x64 --output Published/MSTest
dotnet publish TestsInDocker.NUnit -c Release --no-self-contained --runtime ubuntu.16.04-x64 --output Published/NUnit
dotnet publish TestsInDocker.NUnit.UIAutomation -c Release --no-self-contained --runtime ubuntu.16.04-x64 --output Published/UIAutomation
dotnet publish TestsInDocker.NUnit.UIAutomation -c Release --no-self-contained --runtime win-x64 --output Published/Win