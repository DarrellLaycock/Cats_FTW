const fs = require('fs-extra');
const concat = require('concat');


build = async () =>{
    const files = [
        './dist/cat-facts-component/runtime.js',
        './dist/cat-facts-component/polyfills.js',
        './dist/cat-facts-component/es2015-polyfills.js',
        './dist/cat-facts-component/scripts.js',
        './dist/cat-facts-component/main.js'
      ];
    
      await fs.ensureDir('widget');
      await concat(files, 'widget/cat-facts-widget.js');
}

build();

