import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { RegistroComponent } from './registro/registro.component';



@NgModule({
  declarations: [RegistroComponent],
  imports: [
    CommonModule, FormsModule, RouterModule.forChild([
      { path: 'registrar', component: RegistroComponent }
    ])
  ]
})
export class CertificacaoModule { }
