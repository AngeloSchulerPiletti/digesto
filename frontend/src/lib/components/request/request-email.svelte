<script lang="ts">
  import { Card } from '$lib/components/card';
  import { PaperClipIcon } from '$lib/components/icons';
  import { RequestTitle } from '.';

  export let content: string;
</script>

<RequestTitle>Mensagem</RequestTitle>
<div class="request-email">
  <Card>
    {@html content}
  </Card>
</div>
<div class="request-attachments">
  <a href="/" target="_blank"><PaperClipIcon /> document-example.pdf</a>
  <a href="/" target="_blank"><PaperClipIcon /> assinatura.png</a>
</div>

<style lang="sass">
  .request-attachments
    display: flex
    gap: .5rem
    margin-top: 1rem

    a
      display: flex
      gap: .5rem
      align-items: center
      padding: .5rem .5rem
      color: #72767c
      text-decoration: none
      border: 1px solid #e6e7e9
      border-radius: .75rem
      background-color: #fff

      :global(svg)
        width: 1rem
        height: 1rem
</style>
