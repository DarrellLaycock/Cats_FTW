import { Component, OnInit, Input, isDevMode, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs';
import { DataService } from 'src/app/services/data/data.service';
import { CatFact } from 'src/app/viewModels/catFact';

@Component({
  selector: 'cat-fact',
  templateUrl: './cat-fact.component.html',
  styleUrls: ['./cat-fact.component.css']
})
export class CatFactComponent implements OnInit, OnDestroy {
  @Input() apiUrl: string;

  public catFact: CatFact

  private _subscription = new Subscription()

  constructor(
    private dataService: DataService) {
  }

  ngOnInit() {
    if (!this.apiUrl || this.apiUrl.length === 0) {
      this.catFact = { fact: 'Please provide the "api-url=" parameter', img: undefined }
      return
    }

    this.getCatFact()
  }

  getCatFact() {
    this._subscription.add(
      this.dataService.getCatFact(this.apiUrl)
        .subscribe((data) => {
          this.catFact = data as CatFact
        })
    )
  }

  ngOnDestroy() {
    this._subscription.unsubscribe();
  }
}