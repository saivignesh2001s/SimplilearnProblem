#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat 

FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8-windowsservercore-ltsc2019 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:4.8 AS build
WORKDIR /src
COPY ["Asp.NetMvc/Asp.NetMvc.csproj", "Asp.NetMvc/"]
RUN dotnet restore "Asp.NetMvc/Asp.NetMvc.csproj"
COPY . .
WORKDIR "/src/Asp.NetMvc"
RUN dotnet build "Asp.NetMvc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Asp.NetMvc.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Asp.NetMvc.dll"]
