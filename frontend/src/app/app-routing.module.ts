import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { LoginComponent } from './pages/login/login.component';
import { ProfilComponent } from './pages/profil/profil.component';
import { RegisterComponent } from './pages/register/register.component';

const routes: Routes = [
  //redirect catre login daca  nu avem nimic pe pg principala
  {
    path: "", 
    redirectTo:"/login", 
    pathMatch:"full"
  },
  {
    path: 'login',
    component:LoginComponent
  },
  {
    path: 'register',
    component:RegisterComponent
  },
  {
    path: 'dashboard',
    component: DashboardComponent,
  },
  {
    path: 'profil/:id',
    component: ProfilComponent,
  },
]; //rute pt aplicatia noastra

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
