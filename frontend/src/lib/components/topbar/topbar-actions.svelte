<script lang="ts">
  export let center = false;
</script>

<div class="topbar-actions" class:center>
  <slot />
</div>

<style lang="sass">
  .topbar-actions
    display: flex
    justify-content: center
    align-items: center

    &.center
      flex-grow: 1
</style>
