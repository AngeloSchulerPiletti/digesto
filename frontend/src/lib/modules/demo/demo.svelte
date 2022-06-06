<script lang="ts">
  import { onMount } from 'svelte';
  import { MESSAGES } from '$lib/modules/messages';
  import { messages } from '$lib/fixtures/messages';

  const sleep = async (ms: number) =>
    new Promise((resolve) => setTimeout(resolve, ms));

  onMount(async () => {
    $MESSAGES = messages;

    await sleep(1500);
    const message2 = {
      ...messages[0],
      id: '4A5D9',
      author: { email: 'verinhacosta@gmail.com', name: 'Vera Isadora Costa' },
      read: false,
    };
    $MESSAGES = [message2, ...$MESSAGES];
  });
</script>
