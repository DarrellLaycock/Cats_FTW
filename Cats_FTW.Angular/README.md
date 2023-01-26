# Cat Facts Demo

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 7.3.9.

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The app will automatically reload if you change any of the source files.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory. Use the `--prod` flag for a production build.

## Production Build

Finally, you can run your script to build your project and concatenate the files into one JavaScript file that can be used wherever you want to use your web component to display news. Head back to your terminal and run the following command:

$ npm run build:component

When the command is finished, you should find a widget folder in the root of your project with a cat-facts-widget.js file.

Now, you can use this one file instead of including all the five JS files when you want to import your web component.

In the widget folder, create an index.html file and add the following content:

Head back to your terminal, navigate to the widget folder and run the serve command:

$ cd widget
$ serve
