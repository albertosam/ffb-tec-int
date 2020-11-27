import { TestBed } from '@angular/core/testing';

import { CertificacaoService } from './certificacao.service';

describe('CertificacaoService', () => {
  let service: CertificacaoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CertificacaoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
