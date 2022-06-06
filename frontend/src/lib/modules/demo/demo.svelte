<script lang="ts">
  import { onMount } from 'svelte';
  import { MESSAGES } from '$lib/modules/messages';
  import { messages } from '$lib/fixtures/messages';

  const sleep = async (ms: number) =>
    new Promise((resolve) => setTimeout(resolve, ms));

  onMount(async () => {
    const message2 = {
      ...messages[0],
      id: '4A5D9',
      author: {
        email: 'verinhacosta@gmail.com',
        name: 'Vera Isadora Costa',
        created_at: new Date('2022-06-06T01:16:47.414Z'),
        updated_at: new Date('2022-06-06T01:16:47.414Z'),
      },
      read: false,
    };
    $MESSAGES = [message2, ...messages];

    await sleep(4000);
    const message3 = {
      ...messages[0],
      id: '3BC63',
      author: {
        email: 'josebb68@hotmail.com',
        name: 'José Benedito Barbosa',
        created_at: new Date(),
        updated_at: new Date(),
      },
      read: false,
    };
    $MESSAGES = [message3, ...$MESSAGES];
  });
</script>
