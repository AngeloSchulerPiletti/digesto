<script lang="ts">
  import { fly } from 'svelte/transition';
  import { quintOut } from 'svelte/easing';
  import { NOTIFICATIONS } from '.';
</script>

<ul class="notifications">
  {#each $NOTIFICATIONS as message}
    <li
      transition:fly={{
        duration: 300,
        x: 32,
        opacity: 0,
        easing: quintOut,
      }}
    >
      {message}
    </li>
  {/each}
</ul>

<style lang="sass">
  .notifications
    position: fixed
    bottom: 1rem
    right: 1rem

    li
      padding: 1rem
      background-color: #48c78e
      color: #fff
      border-radius: .5rem
</style>
