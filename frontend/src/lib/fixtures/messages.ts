import type { EmailMessage } from '$lib/modules/messages';

export const messages: EmailMessage[] = [
  {
    id: 'A79CA',
    author: {
      email: 'rosangela.fd@hotmail.com',
      name: 'Rosângela Drumond',
    },
    subject: 'Solicitação de seguro de Vida',
    content:
      'Boa noite, tudo bem?<br /><br />Segue novamente o formulário solicitado preenchido. Como conversamos por telefone, reforço que aguardo seu retorno o mais rápido possível devido a delicadeza da situação. Me ponho a disposição caso precise de mais alguma informação ou documento relacionado ao processo. Não se esqueça de passar um <a href="https://github.com/cure53/DOMPurify" target="_blank">DOMPurify</a> nessa mensagem aqui, viu? ✨<br /><br />Agradeço mais uma vez.<br /><br />Att,<br />Rosângela Drumond',
    created_at: new Date('2022-06-04T06:22:50.887Z'),
    updated_at: new Date('2022-06-05T09:26:55.934Z'),
    read: true,
  },
];

export const messageCRLV: EmailMessage = {
  id: '3BC63',
  author: {
    email: 'josebb68@hotmail.com',
    name: 'José Benedito Barbosa',
  },
  subject: '',
  content:
    'Lorem ipsum dolor sit amet consectetur, adipisicing elit. Nobis provident praesentium impedit, doloribus officiis velit facilis et expedita possimus, ex fuga id pariatur eos. Adipisci ex iusto molestiae sint deleniti.',
  created_at: new Date(),
  updated_at: new Date(),
  read: true,
};
