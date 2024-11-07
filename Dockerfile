# Usa una imagen base de .NET SDK para compilar y ejecutar el programa
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# Crea el directorio de trabajo en el contenedor
WORKDIR /app

# Copia el archivo fuente C# al contenedor
COPY Program.cs .

# Crea un directorio separado para el proyecto y lo compila
RUN dotnet new console -o HelloWorldApp && dotnet build HelloWorldApp

# Usa una imagen ligera de .NET Runtime para ejecutar el programa
FROM mcr.microsoft.com/dotnet/runtime:7.0

# Establece el directorio de trabajo en el contenedor
WORKDIR /app

# Copia los archivos compilados desde la etapa de compilación
COPY --from=build /app/HelloWorldApp/bin/Debug/net7.0 .

# Especifica el comando para ejecutar la aplicación
CMD ["dotnet", "HelloWorldApp.dll"]