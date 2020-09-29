import { Component, HostListener } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'MMF';

  @HostListener('window:scroll', ['$event'])

  onWindowScroll(e): void {
    let element = document.querySelector('.navbar');

    if (window.pageYOffset > element.clientHeight) {
      element.classList.add('bg-light');
      element.classList.add('navbar-light');
      element.classList.remove('navbar-dark');
      element.classList.remove('bg-transparent');
    } else {
      element.classList.add('bg-transparent');
      element.classList.add('navbar-dark');
      element.classList.remove('bg-light');
      element.classList.remove('navbar-light');
    }
  }
}
