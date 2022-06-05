<script lang="ts">
  export let hasBackground = false;
</script>

<div class="column-content" class:bg-white={hasBackground}>
  <slot />
</div>

<style lang="sass">
  .column-content
    display: flex
    flex-direction: column
    flex-grow: 1
    overflow-y: auto

    &.bg-white
      background-color: #fff
</style>
