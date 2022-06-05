<script lang="ts">
  import { READING_EMAIL } from '.';
  import { Message } from '$lib/components/message';
  import type { EmailMessage } from '.';

  export let messages: EmailMessage[] = [];

  const openEmail = (message: EmailMessage, i: number) => {
    messages[i] = { ...messages[i], read: true };
    $READING_EMAIL = message;
    // TODO: mark as read on api
  };
</script>

{#each messages as msg, i}
  <Message
    author={msg.author.name}
    date={msg.created_at}
    subject={msg.subject}
    unread={!msg.read}
    active={$READING_EMAIL?.id == msg.id}
    on:click={() => openEmail(msg, i)}
  />
{/each}
