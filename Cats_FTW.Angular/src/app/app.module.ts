import { BrowserModule } from '@angular/platform-browser';
import { ApplicationRef, NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CatFactComponent } from './components/cat-fact/cat-fact.component';
import { HttpConfigInterceptor} from './services/httpConfig/httpconfig.interceptor';
import { HttpClientModule, HTTP_INTERCEPTORS  } from '@angular/common/http';

import  { Injector} from '@angular/core';
import  { createCustomElement } from '@angular/elements';
//import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({ 
  declarations: [
    AppComponent,
    CatFactComponent
  ],

  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    //NgbModule
  ],
  providers: [    
    { provide: HTTP_INTERCEPTORS, useClass: HttpConfigInterceptor, multi: true },
  ],
  //bootstrap: [AppComponent , CatFactComponent]
  entryComponents: [AppComponent, CatFactComponent],
})
export class AppModule {

  constructor(private injector: Injector) {
    const el = createCustomElement(CatFactComponent, { injector });
    customElements.define('cat-facts-widget', el);
  }
  //ngDoBootstrap() {}

  public ngDoBootstrap(appRef: ApplicationRef): void {
    if (document.querySelector('app-root')) {
      appRef.bootstrap(AppComponent);
    }
  }

 }
