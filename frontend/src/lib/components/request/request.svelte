<script lang="ts">
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
<div class="spacing" />

<style lang="sass">
  .spacing
    height: 3rem
</style>
