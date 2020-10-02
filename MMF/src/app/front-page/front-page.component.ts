import { ViewportScroller } from '@angular/common';
import { Component, OnInit, OnDestroy } from '@angular/core';

@Component({
  selector: 'app-front-page',
  templateUrl: './front-page.component.html',
  styleUrls: ['./front-page.component.css']
})
export class FrontPageComponent implements OnInit, OnDestroy {

  constructor(private viewportScroller: ViewportScroller) { }

  ngOnInit(): void {
    document.addEventListener('scroll', this.onWindowScroll, false);
  }

  ngOnDestroy(): void {
    document.removeEventListener('scroll', this.onWindowScroll, false);
  }

  onClickScroll(elementId: string): void {
    this.viewportScroller.scrollToAnchor(elementId);
  }

  onWindowScroll(): void {
    const element = document.getElementById('mainNav');

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
