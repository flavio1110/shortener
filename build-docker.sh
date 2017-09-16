echo "BUILD"
dotnet build src/Shortener.Web.csproj

cd src/

echo "PUBLISH"
dotnet publish -c Release -o ../docker-publish --no-restore -v minimal

cd ../

echo "COPY DOCKERFILE"
cp Dockerfile docker-publish 

echo "BUILD DOCKER IMAGE"
#docker build -t shortener docker-publish

#rm -rf docker-publish