export class Place {
  id: number;
  name: string;
  cordinatesN: number;
  cordinatesE: number;
  temperature: number;
  country: string;
  soilMoisture: number;

  constructor(
    id: number,
    name: string,
    cordinatesN: number,
    cordinatesE: number,
    temperature: number,
    country: string,
    soilMoisture: number
  ) {
    this.id = id;
    this.name = name;
    this.cordinatesN = cordinatesN;
    this.cordinatesE = cordinatesE;
    this.temperature = temperature;
    this.country = country;
    this.soilMoisture = soilMoisture;
  }
}
