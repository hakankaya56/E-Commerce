import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  constructor(private modalService: NgbModal) { }

  ngOnInit() {
  }

  openLoginModal(loginContent) {
    this.modalService.open(loginContent, { centered: true });
  }

  openRegisterModal(registerContent) {
    this.modalService.open(registerContent, { centered: true });
  }
}
