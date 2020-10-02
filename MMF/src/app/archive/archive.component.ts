import { Component, OnInit, OnDestroy } from '@angular/core';

@Component({
  selector: 'app-archive',
  templateUrl: './archive.component.html',
  styleUrls: ['./archive.component.css']
})
export class ArchiveComponent implements OnInit, OnDestroy {

  constructor() { }

  ngOnInit(): void {
    const element = document.getElementById('mainNav');

    element.classList.add('bg-dark');
    element.classList.remove('bg-transparent');
  }

  ngOnDestroy(): void {
    const element = document.getElementById('mainNav');

    element.classList.remove('bg-dark');
    element.classList.add('bg-transparent');
  }
}
