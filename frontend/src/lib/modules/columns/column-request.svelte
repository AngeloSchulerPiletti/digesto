<script lang="ts">
  import { READING_EMAIL, MESSAGES } from '$lib/modules/messages';
  import { NOTIFICATIONS } from '$lib/modules/notifications';
  import {
    Column,
    ColumnContent,
    ColumnIllustration,
    ColumnSection,
  } from '$lib/components/column';
  import { TopbarActions, Topbar } from '$lib/components/topbar';
  import { Button } from '$lib/components/button';
  import { Request } from '$lib/components/request';
  import { MailWoman } from '$lib/components/illustrations';
  import {
    CheckmarkOutlineIcon,
    GraphIcon,
    MenuHorizontalIcon,
    NotificationIcon,
    TagIcon,
    TrashIcon,
    UserCheckmarkIcon,
  } from '$lib/components/icons';
  import { documents } from '$lib/fixtures/documents';

  export let active = false;

  const demoSend = () => {
    $MESSAGES.shift();
    $MESSAGES = $MESSAGES;
    $READING_EMAIL = null;
    $NOTIFICATIONS = ['Enviado com sucesso.'];
    setTimeout(() => ($NOTIFICATIONS = []), 3500);
  };
</script>

<Column fill {active}>
  {#if active}
    <Topbar>
      <TopbarActions center>
        <Button on:click={demoSend}><GraphIcon /> Enviar para cotação</Button>
        <Button><UserCheckmarkIcon /> Redesignar</Button>
        <Button><TagIcon /> Marcar</Button>
        <Button textPrimary><NotificationIcon /> Soneca</Button>
        <Button textDanger><TrashIcon /> Apagar</Button>
        <Button textSuccess><CheckmarkOutlineIcon /> Finalizar</Button>
        <Button><MenuHorizontalIcon /> Mais</Button>
      </TopbarActions>
    </Topbar>
  {/if}
  <ColumnContent>
    {#if active}
      <ColumnSection>
        <Request message={$READING_EMAIL} {documents} />
      </ColumnSection>
    {:else}
      <ColumnIllustration
        label="Escolha uma solicitação para começar a trabalhar."
      >
        <MailWoman />
      </ColumnIllustration>
    {/if}
  </ColumnContent>
</Column>
