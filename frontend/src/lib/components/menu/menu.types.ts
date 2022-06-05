import type { SvelteComponent } from 'svelte';

export type MenuLink = {
  label: string;
  href: string;
  icon: typeof SvelteComponent;
  active?: boolean;
};

export type MenuItems = (MenuLink | string)[];
