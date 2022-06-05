<script lang="ts">
  import { onMount } from 'svelte';
  import { goto } from '$app/navigation';

  export let url: string;

  onMount(() => goto(url));
</script>

<div class="redirect">
  <img class="logo" src="/digesto-icon.png" alt="" />
</div>

<style lang="sass">
  .redirect
    display: flex
    justify-content: center
    align-items: center
    width: 100%
    height: 100%

    .logo
      height: 6rem
      pointer-events: none
      user-select: none
      animation: blink 2s ease infinite alternate
      
  @keyframes blink
    from
      opacity: .25

    to
      opacity: 1
</style>
