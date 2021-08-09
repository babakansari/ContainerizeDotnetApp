#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Selenium docker image to have chrome and chrome-driver installed as the base
FROM selenium/standalone-chrome-debug:3.141.59-yttrium AS base
WORKDIR /app
LABEL maintainer="Containerize_Tests"
MAINTAINER Babak Ansari<babakansari@hotmail.com>

# You could install Tree view in bash to use `tree` bash commad
# RUN sudo apt-get install tree

WORKDIR /usr/src
COPY ["./TestsInDocker/bin/Release/net5.0/ubuntu.16.04-x64/publish/**", "."]

# This step is not neccessary as dotnet automatically mark the TestsInDocker file as executable
RUN sudo chmod 777 ./TestsInDocker

# The following executes the counter program inside the console commad
# CMD ["./TestsInDocker"]