#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Selenium docker image to have chrome and chrome-driver installed as the base
FROM selenium/standalone-chrome-debug:3.141.59-yttrium AS base
WORKDIR /app
LABEL maintainer="Containerize_Tests"
MAINTAINER Babak Ansari<babakansari@hotmail.com>

# Install dotnet 5.0 from https://docs.microsoft.com/en-us/dotnet/core/install/linux-ubuntu into the image
# FROM mcr.microsoft.com/dotnet/sdk:5.0

FROM base AS Dotnet5
RUN wget https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb &&\
	sudo dpkg -i packages-microsoft-prod.deb  &&\
	rm packages-microsoft-prod.deb

RUN sudo apt-get update; \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-5.0

# You could install Tree view in bash to use `tree` bash commad
# RUN sudo apt-get install tree

WORKDIR /usr/src
#COPY ["./Published/**", "."]
VOLUME "/usr/src"

# The following executes the counter program inside the console commad
# CMD ["./TestsInDocker"]