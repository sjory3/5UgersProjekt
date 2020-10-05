import { Component, OnInit, OnDestroy } from '@angular/core';
import { ApiService } from '../api.service';

@Component({
  selector: 'app-archive',
  templateUrl: './archive.component.html',
  styleUrls: ['./archive.component.css']
})
export class ArchiveComponent implements OnInit, OnDestroy {

  constructor(private apiService: ApiService) { }

  ngOnInit(): void {
    const element = document.getElementById('mainNav');

    element.classList.add('bg-dark');
    element.classList.remove('bg-transparent');

    this.apiService.GetPlaces().subscribe((data) => {
      console.log(data);
    });
  }

  ngOnDestroy(): void {
    const element = document.getElementById('mainNav');

    element.classList.remove('bg-dark');
    element.classList.add('bg-transparent');
  }
}
