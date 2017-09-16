FROM microsoft/aspnetcore:2.0.0
WORKDIR /app
COPY . /app
EXPOSE 80
ENTRYPOINT ["dotnet", "Shortener.Web.dll"]