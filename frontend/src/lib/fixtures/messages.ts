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
      'Boa noite, tudo bem?<br /><br />Segue novamente o formulário solicitado preenchido. Como conversamos por telefone, reforço que aguardo seu retorno o mais rápido possível devido a delicadeza da situação. Me ponho a disposição caso precise de mais alguma informação ou documento relacionado ao processo. <b>Não se esqueça de passar um <a href="https://github.com/cure53/DOMPurify" target="_blank">DOMPurify</a> nessa mensagem aqui, viu?</b> ✨<br /><br />Agradeço mais uma vez.<br /><br />Att,<br />Lucas Fernandes',
    created_at: new Date('2022-06-04T06:22:50.887Z'),
    updated_at: new Date('2022-06-05T09:26:55.934Z'),
    read: false,
  },
];
