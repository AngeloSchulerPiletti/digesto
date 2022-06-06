<script lang="ts">
  import { RequestDocuments, RequestEmail, RequestHeader } from '.';
  import type { Document } from '.';
  import type { EmailMessage } from '$lib/modules/messages';

  export let message: EmailMessage | null, documents: Document[];
</script>

<RequestHeader {message} />
<RequestDocuments {documents} />
<RequestEmail content={message?.content || ''} />
<div class="spacing" />

<style lang="sass">
  .spacing
    height: 3rem

  @media screen and (max-width: 1600px)
    .spacing
      height: 2rem

  @media screen and (max-width: 768px)
    .spacing
      height: 6rem

</style>
