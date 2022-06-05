import { writable } from 'svelte/store';
import type { EmailMessage } from '.';

export const READING_EMAIL = writable<EmailMessage | null>();
