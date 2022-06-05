<script lang="ts">
  export let dark = false,
    small = false,
    medium = false,
    fill = false;
</script>

<div class="column" class:dark class:small class:medium class:fill>
  <slot />
</div>

<style lang="sass">
  .column
    display: flex
    flex-direction: column
    flex-shrink: 0
    height: 100%

    &:not(:last-child)
      border-right: 1px solid #e6e7e9

    &.dark
      background-color: #1e293b
      border: none

    &.fill
      flex-grow: 1

    &.small
      width: 16rem

    &.medium
      width: 24rem
</style>
