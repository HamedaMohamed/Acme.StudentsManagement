import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ValidationErrorModule } from '@abp/ng.theme.lepton-x';
import { NgxPaginationModule } from 'ngx-pagination';
import { SharedModule } from '../shared/shared.module';
import { StudentRoutingModule } from './statistics-routing.module';
import { StatisticsComponent } from './statistics.component';
import { ChartModule } from '@abp/ng.components/chart.js';


@NgModule({
  declarations: [StatisticsComponent],
  imports: [
    CommonModule,
    StudentRoutingModule,
    SharedModule, NgxPaginationModule,
    ValidationErrorModule, ChartModule
  ]
})
export class StatistcsModule { }
