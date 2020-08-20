import { Component } from '@angular/core';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
  public currentCount = 1;
  public lastCount = 1;
  public temp;

  public incrementCounter() {
    this.temp = this.currentCount;
    this.currentCount = this.currentCount + this.lastCount;
    this.lastCount = this.temp;
    
  }
}
