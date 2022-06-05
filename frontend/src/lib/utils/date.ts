import dayjs from 'dayjs';
import relativeTime from 'dayjs/plugin/relativeTime.js';
import 'dayjs/locale/pt-br.js';
import { browser } from '$app/env';

export const getReadableDate = (date: Date) => {
  if (!browser) return;
  dayjs.extend(relativeTime);
  const readableDate = dayjs(date).locale('pt-br').fromNow();
  return readableDate;
};

export const getDateTime = (date: Date) => {
  const datetime = dayjs(date).format('DD/MM/YY à[s] hh:mm');
  return datetime;
};
