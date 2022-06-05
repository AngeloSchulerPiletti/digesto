<script lang="ts">
  import { READING_EMAIL } from '$lib/modules/messages';
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
</script>

<Column fill>
  {#if $READING_EMAIL != null}
    <Topbar>
      <TopbarActions center>
        <Button><GraphIcon /> Enviar para cotação</Button>
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
    {#if $READING_EMAIL != null}
      <ColumnSection>
        <Request message={$READING_EMAIL} />
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
