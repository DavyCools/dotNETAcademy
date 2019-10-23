import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.scss']
})
export class ToolbarComponent implements OnInit {

  constructor(private router: Router) { }
    searchParam: string = "";

  ngOnInit() {
  }

  Search(){
    this.router.navigateByUrl(`producten/zoekresultaten/${this.searchParam}`);
  }

}
