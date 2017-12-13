import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'movies',
    templateUrl: './movies.component.html',
})
export class MoviesComponent {

    public movies: Movie[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Movies').subscribe(result => {
            this.movies = result.json() as Movie[];
        }, error => console.error(error));
    }
}

interface Movie {
    ID: number;
    Title: string;
    Price: number;
    Genre: string;
    Rating: string;
}