<script lang="ts">
  import { READING_EMAIL } from '$lib/modules/messages';
  import { page } from '$app/stores';
  import { Column } from '$lib/components/column';
  import { Menu } from '$lib/components/menu';
  import {
    AttachmentIcon,
    BoxIcon,
    CheckmarkOutlineIcon,
    ClockIcon,
    FolderIcon,
    GraphIcon,
    NotificationIcon,
    PenIcon,
    SendTiltedIcon,
    StarIcon,
    ReplicateIcon,
    TrashIcon,
    WarningIcon,
  } from '$lib/components/icons';
  import type { MenuItems } from '$lib/components/menu';

  const items: MenuItems = [
    'Solicitações',
    {
      label: 'Em aberto',
      href: '/app/requests',
      icon: StarIcon,
    },
    {
      label: 'Soneca',
      href: '/app/requests/snoozed',
      icon: NotificationIcon,
    },
    {
      label: 'Processando',
      href: '/app/requests/processing',
      icon: ClockIcon,
    },
    {
      label: 'Finalizadas',
      href: '/app/requests/done',
      icon: CheckmarkOutlineIcon,
    },
    'E-mail',
    {
      label: 'Caixa de entrada',
      href: '/app/inbox',
      icon: FolderIcon,
    },
    {
      label: 'Rascunhos',
      href: '/app/inbox/drafts',
      icon: PenIcon,
    },
    {
      label: 'Enviados',
      href: '/app/inbox/sent',
      icon: SendTiltedIcon,
    },
    {
      label: 'Arquivo',
      href: '/app/inbox/archive',
      icon: BoxIcon,
    },
    {
      label: 'Spam',
      href: '/app/inbox/spam',
      icon: WarningIcon,
    },
    {
      label: 'Lixeira',
      href: '/app/inbox/trash',
      icon: TrashIcon,
    },
    'Automação',
    {
      label: 'Documentos',
      href: '/app/documents',
      icon: AttachmentIcon,
    },
    {
      label: 'Modelos',
      href: '/app/templates',
      icon: ReplicateIcon,
    },
    {
      label: 'Ações',
      href: '/app/actions',
      icon: GraphIcon,
    },
  ].map((item) =>
    typeof item === 'string'
      ? item
      : { ...item, active: $page.url.pathname == item.href },
  );

  let showMobileMenu = false;
  $: isReadingEmail = $READING_EMAIL != null;
  const stopReadingEmail = () => ($READING_EMAIL = null);
</script>

<Column dark small active>
  <Menu
    {items}
    bind:showMobileMenu
    showBackButton={isReadingEmail}
    goBack={stopReadingEmail}
  />
</Column>
