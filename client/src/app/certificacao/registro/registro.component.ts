import { Component, OnInit } from '@angular/core';
import { CertificacaoService } from '../certificacao.service';
import { Certificacao } from '../certificacao.type';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.css']
})
export class RegistroComponent implements OnInit {
  textFilter: string;
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

  clearNew() {
    this.novo = { codigo: '', descricao: '', provedor: '' };
  }

  add(novo: any) {
    this.ceritificacaoService.add(novo).subscribe(res => {
      this.clearNew();
      this.loadAll();
      window.alert('sucesso');
    });
  }

  update(id: string, obj: any) {
    this.ceritificacaoService.update(id, obj).subscribe(res => {
      this.loadAll();
      window.alert('sucesso');
    });
  }

  delete(id: string) {
    this.ceritificacaoService.delete(id).subscribe(res => {
      this.loadAll();
      window.alert('sucesso');
    });
  }
}
