# PowerplantCodingChallenge

## Infos

 - .Net 7 sdk

 - Nugets Packages : Automapper

 - Swagger UI (only in dev) : https://localhost:8888/swagger/index.html

 - Docker : 
    - Navigate to folder that include Dockerfile : "PowerplantCodingChallenge"
    - Create image run on powershell :  docker build --rm -f Powerplant.Api/Dockerfile -t powerplantapi:latest .
    - Create and run Container : docker run -it --name "PowerplantContainer" --rm -p 8888:80  powerplantapi:latest

## Authors

- Ayatt Mohamed