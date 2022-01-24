import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from 'src/app/interfaces/user';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
public text : string = '';
public isDisabled: boolean = false;
public user:User = {
  email: 'test@test.com',
  parola: '',
  nume: '',
};
public error: boolean | string = false;
constructor (private authService:AuthService, private router:Router) {}
 

  ngOnInit(): void {
    this.text = "Test test";
  }

  doLogin() : void {
    this.error = false;
    console.log("login click", this.user);
    if (this.validateEmail(this.user.email)) {
        //apelam serviciul de log-in
        this.authService.login(this.user).subscribe((response:any)=>{
          console.log(response);
          if (response && response.token) {
            localStorage.setItem('token', response.token);
            this.router.navigate(['/dashboard']);
          }
        })
    } else {
        this.error = "Email-ul nu este valid";
    }
  }

  validateEmail(email:string) {
    const re = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(String(email).toLowerCase());
  }

}
