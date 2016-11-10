FROM microsoft/dotnet:latest
MAINTAINER bwebb@bbandt.com

COPY . /app
WORKDIR /app

RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]

EXPOSE 6001/tcp
ENTRYPOINT ["dotnet", "run"]
