import { writable } from 'svelte/store';

export const NOTIFICATIONS = writable<string[]>([]);
