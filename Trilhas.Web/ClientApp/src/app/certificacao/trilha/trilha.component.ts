import { Component, OnInit } from '@angular/core';
import { CertificacaoService } from '../certificacao.service';
import { TrilhaService } from '../trilha.service';
import { Trilha } from '../trilha.type';

@Component({
  selector: 'app-trilha',
  templateUrl: './trilha.component.html',
  styleUrls: ['./trilha.component.css']
})
export class TrilhaComponent implements OnInit {
  certificacoes: any[];
  trilha: Trilha;

  constructor(private certificacaoService: CertificacaoService,
    private trilhaService: TrilhaService) {
    certificacaoService.getAll().subscribe((res: any[]) => this.certificacoes = res);
    this.trilha = { certificacoes: [], descricao: '', ano: 0, notificar: false, ativo: false };
  }

  ngOnInit(): void {
  }

  addItem() {
    this.trilha.certificacoes.push({ certificacaoId: '', sequencia: '', trilhaId: '', certificacao: null });
  }

  add() {
    this.trilhaService.add(this.trilha).subscribe(res => window.alert('sucesso'));
  }

}
