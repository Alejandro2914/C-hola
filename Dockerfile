# Use a .NET SDK image to build and run the program
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# Set the working directory inside the container
WORKDIR /app

# Copy the C# source file into the container
COPY Program.cs .

# Compile the program
RUN dotnet new console -o . -n HelloWorldApp && dotnet build

# Use a lightweight .NET Runtime image to run the program
FROM mcr.microsoft.com/dotnet/runtime:7.0

# Set the working directory in the container
WORKDIR /app

# Copy the compiled files from the build stage
COPY --from=build /app/bin/Debug/net7.0 .

# Specify the command to run the application
CMD ["dotnet", "HolaMundoApp.dll"]
