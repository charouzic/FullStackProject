import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-compute',
  templateUrl: './compute.component.html',
  styleUrls: ['./compute.component.css']
})
export class ComputeComponent  implements OnInit {
  fibNumSeq: number;
  fibResult: number;
  apiUrl: string = 'http://localhost:5000/compute/';
  constructor(private http: HttpClient) {}


  // function calling the API endpoint based on users input
  computeFibNum() {
    if (this.fibNumSeq > 0)
    {
      this.http.get<number>(this.apiUrl + this.fibNumSeq)
      .subscribe(response => {
        this.fibResult = response;
        console.log(this.fibResult);
        error => console.log('oops', error)
        }
      )
    }
    else
    {
      console.log('Number must be >= 1');
    }
  }
  
 ngOnInit(): void {
}

  

}
