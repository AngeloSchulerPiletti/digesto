import type { Document, ExtractedData } from '$lib/components/request';

const json = {
  MOTOR: 'M316058',
  PLACA: 'IWS2351',
  'ANO FABRICA\u00c7\u00c3O': '2015',
  'EXERC\u00cdCIO': '2022',
  'C\u00d3DIGO RENAVAM': '01058557499',
  'ANO MODELO': '2016',
  'POT\u00caNCIA/CILINDRADA': '154CV/1987',
  'PESO BRUTO TOTAL': '1.7',
  CMT: '1.7',
  'CPF/CNPJ': '521.787.490-20',
  'LOTA\u00c7\u00c3O': '05P',
  CARROCERIA: 'N\u00e3o APLICAVEL',
  'C\u00d3DIGO DE SEGURAN\u00c7A DO CLA': '46620376010',
  EIXOS: '2',
  CAT: '***',
  CAPACIDADE: '* *',
  LOCAL: 'ESTEIO RS',
  PARCELADO: '',
  DATA: '11/01/2022',
  'COTA \u00daNICA': '',
  'MARCA/MODELO/VERS\u00c3O': 'TOYOTA/COROLLA XEI20FLEX',
  'PLACA ANTERIOR/UF': '',
  'COR PREDOMINANTE': 'CINZA',
  CHASSI: '9BRBDWHE4G0274272',
  CATEGORIA: 'PARTICULAR',
  'COMBUST\u00cdVEL': 'ALCOOL/GASOLINA',
  'ESP\u00c9CIE TIPO': 'PASSAGEIRO AUTOMOVEL',
  'VALOR TOTAL (R$)': '',
  'REPASSE OBRIGAT\u00d3RIO AO FNS (R$)': '',
  NOME: 'JONE MARIO PILETTI',
  'N\u00daMERO DO CRV': '***',
  'CUSTO EFETIVO DO SEGURO (R$)': '*',
  'REPASSE OBRIGAT\u00d3RIO AO SENATRAN (R$)': '*',
  'CAT. TARIF': '*',
  'DATA DE QUITA\u00c7\u00c3O': '',
  'CUSTO DO BILHETE (R$)': '*',
  'VALOR DO IOF (R$)': '*',
  'DADOS DO SEGURO DPVAT': '',
  'OBSERVA\u00c7\u00d5ES DO VE\u00cdCULO': '',
};

export const extractedData: ExtractedData[] = Object.entries(json).map(
  ([label, value]) => ({ name: '', label, value }),
);

export const documents: Document[] = [
  {
    filename: 'unknown.pdf',
    url: 'https://scripts.doceazedo.com/CRLV_Digital_1517516133859BR0127.pdf',
    tags: ['Formulário'],
    fields: extractedData,
  },
];
