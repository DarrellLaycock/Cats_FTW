# Cat Facts

Demo UI: https://www.4sharing.ca

API Documentation (Swagger): https://catsftwdev.azurewebsites.net


## ASP.Net Web API Project Setup:
 
 Prerequisites:
 - Visual Studio 2019+ Community Edition
 - SQL Server Express
 
Setup Steps:

1. Open Visual Studio and then choose the top-right dashboard option "Clone a repository"

2. Enter the repository location: https://github.com/DarrellLaycock/Cats_FTW.git , then press the "Clone" button.

3. Open solution file Cats_FTW.sln
 
4. Create blank SQL Server database or provide your IP Address and I can Open the Azure SQL Firewall
 
5. Update the connection string for SQLDbContext in Web.config
 
6. If you created a new blank database, run following command in Visual Studio Package Manager Console:
 
```sh
pm> update-database
```
 
 - The above command will add some cat facts to the database table CatFacts.
 - When you start the project, up to 200 cat images will be added to the database table CatImages from the api https://thecatapi.com.
 
 

## Angular Setup:

Prerequisites:
 - node v14.20.0
 - VS Code

In VS Code:
1. Open Folder <Your Project folder>\Cats_FTW.Angular
2. Menu Terminal> New Terminal
3. Run the following command:
```sh
$ npm install
$ npm install -g @angular/cli@7.3.9
$ ng serve
```

If you want to use your local API, please change the api-url in the ./src/app/app.component.html:
FROM:
```sh
<cat-facts apiUrl="https://catsftwdev.azurewebsites.net/api/catfact"></cat-fact>
```
TO:

```sh
<cat-fact apiUrl="https://localhost:44368/api/catfact"></cat-fact>
```

Once compiled, open in browser: http://localhost:4200/
 
 ## Production Build

This step builds your project and concatenates the files into one JavaScript file that can be used wherever you want to use your web component. Head back to your terminal and run the following command:

 ```sh
$ npm run build:component
```

When the command is finished, you should find a widget folder in the root of your project with a cat-facts-widget.js file. Now, you can use this one file instead of including all the five JS files when you want to import your web component. In the widget folder, create an index.html file and add the following content:

Head back to your terminal, navigate to the widget folder and run the serve command:

```sh
$ cd widget
$ serve
```

Please note the custom element is in a differnt format for production. :
```sh
<cat-facts-widget api-url="https://catsftwdev.azurewebsites.net/api/catfact"></cat-facts-widget>
```


