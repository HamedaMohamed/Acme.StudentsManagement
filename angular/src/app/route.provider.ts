import { RoutesService, eLayoutType } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  { provide: APP_INITIALIZER, useFactory: configureRoutes, deps: [RoutesService], multi: true },
];

function configureRoutes(routes: RoutesService) {
  return () => {
    routes.add([
      {
        path: '/',
        name: 'Home',
        iconClass: 'fas fa-home',
        order: 1,
        layout: eLayoutType.application,
      },

      {
        path: '/student',
        name: 'Student',
        iconClass: 'fas fa-user',
        order:2,
        layout: eLayoutType.application,
      },
      {
        path: '/Reporting',
        name: 'Report',
        iconClass: 'fas fa-chart-line',
        order: 10,
        layout: eLayoutType.application,
      },
    ]);
  };
}
