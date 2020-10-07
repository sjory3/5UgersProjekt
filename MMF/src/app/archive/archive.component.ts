import { Component, OnInit, OnDestroy } from '@angular/core';
import { ApiService } from '../api.service';
import { Place } from '../place';

@Component({
  selector: 'app-archive',
  templateUrl: './archive.component.html',
  styleUrls: ['./archive.component.css']
})
export class ArchiveComponent implements OnInit, OnDestroy {
  places: Place[] = [];

  constructor(private apiService: ApiService) { }

  ngOnInit(): void {
    const element = document.getElementById('mainNav');

    element.classList.add('bg-dark');
    element.classList.remove('bg-transparent');

    this.apiService.GetPlaces().subscribe((data) => {
      for (let index = 0; index < 20; index++) {
        console.log(data[index]);
        let place = new Place(
          data[index].id,
          data[index].name,
          data[index].coordinatesN,
          data[index].coordinatesE,
          data[index].temperature,
          data[index].country,
          data[index].soilMoisture
        );
        console.log(place);
        this.places.push(place);
      }
    });
  }

  ngOnDestroy(): void {
    const element = document.getElementById('mainNav');

    element.classList.remove('bg-dark');
    element.classList.add('bg-transparent');
  }

  Onclick(order: string){
    if (order == 'desc'){
    this.places.sort((a, b) => b.temperature < a.temperature ? -1 : b.temperature > a.temperature ? 1 : 0);
       }

      else if (order == 'asc'){
        
    this.places.sort((a, b) => a.temperature < b.temperature ? -1 : a.temperature > b.temperature ? 1 : 0);
      }
    }
}
