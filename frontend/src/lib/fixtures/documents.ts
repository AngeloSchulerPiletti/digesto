import type { Document, ExtractedData } from '$lib/components/request';

export const extractedData: ExtractedData[] = [
  {
    name: '',
    label: 'Nome do segurado(a)',
    value: 'Rosângela Gonçalves Drumond',
  },
  {
    name: '',
    label: 'CPF',
    value: '177.858.655-40',
  },
  {
    name: '',
    label: 'RG',
    value: '19.662.456-3',
  },
  {
    name: '',
    label: 'Data de nascimento',
    value: '08/03/1984',
  },
  {
    name: '',
    label: 'Data do acidente',
    value: '05/06/2022',
  },
  {
    name: '',
    label: 'Local do acidente',
    value: 'Autódromo de Interlagos, São Paulo - SP',
  },
  {
    name: '',
    label: 'Hora do acidente',
    value: '16:20',
  },
  {
    name: '',
    label: 'Acidente de trabalho',
    value: 'Não',
  },
  {
    name: '',
    label: 'Registro policial',
    value: 'Não',
  },
  {
    name: '',
    label: 'Descrição da ocorrência',
    value:
      'O conflito da psique inconsciente, corrobora a crescente influência da mídia prepara-nos para enfrentar situações atípicas decorrentes dos valores morais decorrentes de uma tradição normativa.',
  },
];

export const documents: Document[] = [
  {
    filename: 'document-example.pdf',
    url: 'https://scripts.doceazedo.com/document-example.pdf',
    tags: ['Formulário'],
    fields: extractedData,
  },
];
