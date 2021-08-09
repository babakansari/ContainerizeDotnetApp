# Containerize Simple Dotnet Core App in Ubuntu container

This is sample project to demonstrate how to run dotnet core Console App, create Unit Tests and Automation Tests inside an Ubuntu docker container

## Console App
- Let''s create a self contained App (Useful when you won't need to install dotnet core on the container) after your code changes:
`./PublichToUbuntu.ps1` 
It runs the following dotnet command:
`dotnet publish -c Release --force --self-contained --runtime ubuntu.16.04-x64`

- Next execute the `Dockerfile` to build the image. Optionally, you could use Visual Studio support for docker instead of `docker build` command. 

- Run the container by the following command shell script once image is created:
`.\RunContainer.ps1`

- The following command could be used to run the self-contained app created:
`./TestsInDocker`


- *NOTE:* The following command is to run NOT self-contained dotnet core app. We installed dotnet core in the container to use it for running the tests:
`dotnet TestsInDocker.dll`

## MS Test
- Publish the assemblies, build image and then run the tests:
`sudo dotnet test TestsInDocker.MSTest.dll -v n`