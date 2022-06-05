<script lang="ts">
  import { RequestEmail, RequestTitle, RequestHeader } from '.';
  import type { EmailMessage } from '$lib/modules/messages';
  import { Card } from '$lib/components/card';

  export let message: EmailMessage;
</script>

<RequestHeader {message} />

<RequestTitle>Análise de documentos</RequestTitle>
<div class="placeholder-xl">
  <Card />
</div>

<RequestEmail content={message.content} />

<RequestTitle>Anexos</RequestTitle>
<div class="placeholder-sm">
  <Card />
</div>

<style lang="sass">
  .placeholder-sm
    height: 8rem
    
  .placeholder-xl
    height: 24rem
</style>
