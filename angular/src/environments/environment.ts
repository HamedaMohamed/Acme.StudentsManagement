 import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44376/',
  redirectUri: baseUrl,
  clientId: 'StudentsManagement_App',
  responseType: 'code',
  scope: 'offline_access StudentsManagement',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'StudentsManagement',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44376',
      rootNamespace: 'Acme.StudentsManagement',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
