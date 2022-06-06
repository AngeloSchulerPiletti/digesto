<script lang="ts">
  import { READING_EMAIL } from '$lib/modules/messages';
  import {
    ColumnMenu,
    ColumnMessages,
    ColumnRequest,
  } from '$lib/modules/columns';
  import { Demo } from '$lib/modules/demo';
  import { Notifications } from '$lib/modules/notifications';

  $: isReadingEmail = $READING_EMAIL != null;
</script>

<ColumnMenu />
<ColumnMessages active={!isReadingEmail} />
<ColumnRequest active={isReadingEmail} />
<Notifications />
<Demo />
