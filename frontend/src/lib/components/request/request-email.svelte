<script lang="ts">
  import { Card } from '$lib/components/card';
  import { RequestTitle } from '.';

  export let content: string;
</script>

<RequestTitle>Mensagem</RequestTitle>
<div class="request-email">
  <Card>
    {@html content}
  </Card>
</div>
