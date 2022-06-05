<script lang="ts">
  import { Card } from '$lib/components/card';
  import {
    RequestDocuments,
    RequestEmail,
    RequestTitle,
    RequestHeader,
  } from '.';
  import type { Document } from '.';
  import type { EmailMessage } from '$lib/modules/messages';

  export let message: EmailMessage, documents: Document[];
</script>

<RequestHeader {message} />
<RequestDocuments {documents} />
<RequestEmail content={message.content} />

<RequestTitle>Anexos</RequestTitle>
<div class="placeholder-sm">
  <Card />
</div>

<style lang="sass">
  .placeholder-sm
    height: 8rem
</style>
