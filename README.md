# Containerize Simple Dotnet Core App in Ubuntu container

This is sample project to demonstrate how to run dotnet core Console App, create Unit Tests and Automation Tests inside an Ubuntu docker container

## Console App
- First create a self contained App (so you won't need to install dotnet core on the container) after your code changes:
`dotnet publish -c Release --force --self-contained --runtime ubuntu.16.04-x64`

- Next execute the `Dockerfile` to build the image. Optionally, you could use Visual Studio support for docker instead of `docker build` command. 

- Run the container by the following command shell script once image is created:
`.\RunContainer.ps1`

- The following command is to run the self-contained app created:
`./TestsInDocker`


- *NOTE:* The following command is to run NOT self-contained dotnet core app (The docker image here is self-contained):
`dotnet TestsInDocker.dll`


 
