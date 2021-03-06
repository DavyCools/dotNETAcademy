import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { MsalService } from '../services/msal.service';
import { WinkelmandService } from '../services/winkelmand.service';

@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.scss']
})
export class ToolbarComponent implements OnInit {

  constructor(private router: Router,
              private msalService: MsalService,
              private winkelmandService: WinkelmandService) {
              this.winkelmandService.aantalItems.subscribe(aantal => {
              this.aantalItems = Number(aantal);
              });
  }

  searchParam: string = '';
  aantalItems: number = 0;
  UserId: string;

  ngOnInit() {
    if (this.msalService.isLoggedIn()) {
      this.GetUserObjectId();
      if (!this.msalService.isAdmin()) {
        this.winkelmandService.GetWinkelmand(this.UserId).subscribe( mand => {
          this.winkelmandService.ChangeAantal(mand.producten.length.toString());
        });
      }
    }
  }
  GetUserObjectId() {
    this.UserId = this.msalService.getUserObjectId();
  }

  Search() {
    this.router.navigateByUrl(`producten/zoekresultaten/${this.searchParam}`);
  }

  get userfirstname() {
    return this.msalService.getUserFirstName();
  }

  useremail() {
    const useremail = this.msalService.getUserEmail();
    return useremail;
  }

  login() {
    this.msalService.login();
  }

  signup() {
    this.msalService.signup();
  }

  logout() {
    this.msalService.logout();
  }

  isUserLoggedIn() {
    return this.msalService.isLoggedIn();
  }

  isAdmin() {
    return this.msalService.admin;
  }

}
