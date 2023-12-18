# Guía Rápida para Docker y Cobertura de Código
Proyecto API desarrollado con .NET 6 Docker.

# Ejecución con Docker
`docker-compose up --build -d`

# Comando para ejecutar pruebas
`dotnet test --collect:"XPlat Code Coverage" --settings coverlet.runsettings`

`reportgenerator "-reports:TestResults/coverage.cobertura.xml" "-targetdir:coverage-report" "-reporttypes:Html;Cobertura"`
