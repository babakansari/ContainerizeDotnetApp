dotnet publish TestsInDocker -c Release --no-self-contained --runtime ubuntu.16.04-x64 --output Published
dotnet publish TestsInDocker.MSTest -c Release --no-self-contained --runtime ubuntu.16.04-x64 --output Published
dotnet publish TestsInDocker.NUnit -c Release --no-self-contained --runtime ubuntu.16.04-x64 --output Published
dotnet publish TestsInDocker.NUnit.UIAutomation -c Release --no-self-contained --runtime ubuntu.16.04-x64 --output Published
dotnet publish TestsInDocker.NUnit.UIAutomation -c Release --no-self-contained --runtime win-x64 --output Published