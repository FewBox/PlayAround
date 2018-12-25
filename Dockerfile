FROM microsoft/dotnet
WORKDIR /app
COPY . .
ENTRYPOINT ["dotnet", "FewBox.K8S-Secrets-ConfigMaps.dll"]