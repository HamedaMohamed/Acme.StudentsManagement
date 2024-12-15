import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { StudentRoutingModule } from './student-routing.module';
import { StudentComponent } from './student.component';
import { SharedModule } from '../shared/shared.module';
import { NgxPaginationModule } from 'ngx-pagination';
import { ValidationErrorModule } from '@abp/ng.theme.lepton-x';


@NgModule({
  declarations: [
    StudentComponent
  ],
  imports: [
    CommonModule,
    StudentRoutingModule,
    SharedModule,NgxPaginationModule,
    ValidationErrorModule

  ]
})
export class StudentModule { }
