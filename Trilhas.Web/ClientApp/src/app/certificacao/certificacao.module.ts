import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { RegistroComponent } from './registro/registro.component';
import { TrilhaComponent } from './trilha/trilha.component';

import { CoreModule } from '../core/core.module';

@NgModule({
  declarations: [RegistroComponent, TrilhaComponent],
  imports: [
    CommonModule, FormsModule, RouterModule.forChild([
      { path: 'registrar', component: RegistroComponent },
      { path: 'trilha', component: TrilhaComponent }
    ]), CoreModule
  ]
})
export class CertificacaoModule { }
