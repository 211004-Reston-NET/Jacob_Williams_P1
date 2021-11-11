#first our virutal OS will need the .NET 5.0 SDK
#We can utlize docker hub to access one of the published images from .NET themselves
from mcr.microsoft.com/dotnet/sdk:5.0 as build

#setting our working directory
workdir /app

#time to copy our projects and paste it to the working directory 
# * is the wildcard meaning it'll grab anything in your folder that has the .sln extension

copy *.sln ./
copy BusinessLogic/*.csproj BusinessLogic/
copy DataLogic/*.csproj DataLogic/
copy Models/*.csproj Models/
copy TestCases/*.csproj TestCases/
copy WebUIOne/*.csproj WebUIOne/

#We Need to build /restore our files (bin and obj)
run cd WebUIOne && dotnet restore

#copy the source files (. copies everything)
copy . ./

#We need to publish the application and its dependencies to a folder for deployment
run dotnet publish WebUIOne -c Release -o publish --no-restore

#we will change our base image to be the runtime since we already used the sdk to create the application itself
#this is to use a lot less memory
from mcr.microsoft.com/dotnet/aspnet:5.0 as runtime

workdir /app
copy --from=build /app/publish ./

cmd ["dotnet", "WebUIOne.dll"]