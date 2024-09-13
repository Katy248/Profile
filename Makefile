watch-css:
	npx tailwindcss -i ./Profile.Web/Styles/app.css -o ./Profile.Web/wwwroot/app.css --watch

watch:
	dotnet watch --project Profile.Web/Profile.Web.csproj
