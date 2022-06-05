<script lang="ts">
  export let label = '';
</script>

<section class="column-fullpage">
  <slot />
  <p>{label}</p>
</section>

<style lang="sass">
  .column-fullpage
    display: flex
    flex-direction: column
    justify-content: center
    align-items: center
    gap: 1rem
    width: 100%
    height: 100%

    p
      font-size: 1.25rem
      font-weight: 600
    
    :global(svg)
      height: 24rem
</style>
