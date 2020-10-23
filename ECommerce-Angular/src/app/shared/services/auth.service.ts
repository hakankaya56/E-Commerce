import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Register } from 'src/app/register/model/Register';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
 
constructor(private httpClient: HttpClient) { }
baseUrl = environment.baseUrl + 'Auth/';

register(register: Register) {
  return this.httpClient.post(this.baseUrl + 'register', register);
}

}
