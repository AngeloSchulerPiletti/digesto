<script lang="ts">
  import { READING_EMAIL } from '$lib/modules/messages';
  import {
    ColumnMenu,
    ColumnMessages,
    ColumnRequest,
  } from '$lib/modules/columns';

  $: isReadingEmail = $READING_EMAIL != null;
</script>

<ColumnMenu />
<ColumnMessages active={!isReadingEmail} />
<ColumnRequest active={isReadingEmail} />
