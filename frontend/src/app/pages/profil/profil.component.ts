import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-profil',
  templateUrl: './profil.component.html',
  styleUrls: ['./profil.component.css']
})
export class ProfilComponent implements OnInit {

  public id : string ="";
  constructor(private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.activatedRoute.params.subscribe((params:any)=>{
      console.log(params);
      this.id = params['id'];
    });
    this.activatedRoute.queryParams.subscribe((qParams: any)=>{
      console.log(qParams);
    });
  }

}
