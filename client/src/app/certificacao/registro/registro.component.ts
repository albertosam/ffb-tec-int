import { Component, OnInit } from '@angular/core';
import { CertificacaoService } from '../certificacao.service';
import { Certificacao } from '../certificacao.type';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.css']
})
export class RegistroComponent implements OnInit {
  itens: Certificacao[];
  novo: Certificacao = {
    codigo: '',
    descricao: '',
    provedor: ''
  };

  constructor(private ceritificacaoService: CertificacaoService) { }

  ngOnInit(): void {
    this.loadAll();
  }

  loadAll() {
    this.ceritificacaoService.getAll().subscribe((res: []) => this.itens = res);
  }

  add(novo: any) {
    this.ceritificacaoService.add(novo).subscribe(res => {
      window.alert('sucesso');
    });
  }
}
