import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
public myForm!:FormGroup;

  constructor(private fromBuilder:FormBuilder) { }

  ngOnInit(): void {
    this.myForm = this.fromBuilder.group({
      email:['',[Validators.required, Validators.email]],
      nume:['', [Validators.required]],
      prenume:['', [Validators.required]],
      parola:['', [Validators.required, Validators.minLength(5)]],
    });
  }

  doRegister(){
    console.log(this.myForm);
    if (this.myForm.valid) {
      //apelam register 
    }
  }

}
