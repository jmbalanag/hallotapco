Note: you need Docker installed on your workstation. Get it [here](https://www.docker.com/products/docker#/)

1. Clone this repo
2. Run `docker build -t hallotapco .` from a command line
3. Run `docker run -d -p 6001:6001 hallotapco` from a command line
4. Browse to [http://localhost:6001/](http://localhost:6001/). You should see the JSON specified in [this file](https://github.com/flacito/hallotapco/blob/master/Modules/HomeModule.cs).
