Note: you need Docker installed on your workstation. Get it [here](https://www.docker.com/products/docker#/)

1. Clone this repo
2. Run `docker build -t hallotapco .` from a command line
3. Run `docker run -d -p 6001:6001 hallotapco` from a command line
4. Browse to [http://localhost:6001/api/TAPCO](http://localhost:6001/api/TAPCO). You should see the JSON specified in [this file]
5. Changed Nancy to AspNet.MVC since WebApi is already included in the framework.
