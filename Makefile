watch-css:
	cd Profile.Web && \
		npx tailwindcss -i ./Styles/app.css -o ./wwwroot/app.css --watch

watch:
	dotnet watch --project Profile.Web/Profile.Web.csproj
