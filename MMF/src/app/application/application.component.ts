import { Component, OnInit, OnDestroy } from '@angular/core';

@Component({
  selector: 'app-application',
  templateUrl: './application.component.html',
  styleUrls: ['./application.component.css']
})
export class ApplicationComponent implements OnInit, OnDestroy {

  constructor() { }

  ngOnInit(): void {
    const element = document.getElementById('mainNav');

    element.classList.add('navbar-light');
    element.classList.remove('navbar-dark');

    document.addEventListener('scroll', this.onWindowScroll, false);
  }

  ngOnDestroy(): void {
    const element = document.getElementById('mainNav');

    element.classList.remove('navbar-light');
    element.classList.add('navbar-dark');

    document.removeEventListener('scroll', this.onWindowScroll, false);
  }

  onWindowScroll(): void {
    const element = document.getElementById('mainNav');

    if (window.pageYOffset > element.clientHeight) {
      element.classList.add('bg-light');
      element.classList.remove('bg-transparent');
    } else {
      element.classList.add('bg-transparent');
      element.classList.remove('bg-light');
    }
  }
}
