# Cat Facts

Demo UI: https://www.4sharing.ca

API Documentation (Swagger): https://catsftwdev.azurewebsites.net

## Angular Setup:

Prerequisites:
 - node v14.20.0
 - VS Code
 - Visual Studio 2019+

In VS Code:
1. Open Folder <Your Project folder>\Cats_FTW.Angular
2. Menu Terminal> New Terminal
3. Run the following command:
```sh
$ npm install
$ npm install -g @angular/cli@7.3.9
$ ng serve
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


## API Project Setup:
- With Visual Studio 2019+ Community Edition, open soultion file Cats_FTW.sln
- Create blank SQL Server database or provide your IP Address and I can Open the Azure SQL Firewall
- Update the connection string for SQLDbContext in Web.config
- If you created a new blank database, run following command in Visual Studio Package Manager Console:
 
```sh
pm> update-database
```
 
 - The above command will add some cat fact to the database table CatFacts.
 - When you start the project, up to 200 cat images will be added to the database table CatImages from the https://thecatapi.com.
 



