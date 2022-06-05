import MD5 from 'crypto-js/md5.js';

export const getGravatarURL = (email: string, size = 96) => {
  const hash = MD5(email);
  return `https://gravatar.com/avatar/${hash}?s=${size}&d=mp`;
};
