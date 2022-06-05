<script lang="ts">
  export let dark = false,
    small = false,
    medium = false,
    fill = false,
    active = false;
</script>

<div class="column" class:dark class:small class:medium class:fill class:active>
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

  @media screen and (max-width: 1600px)
    .column
      &.small
        width: 14rem

      &.medium
        width: 20rem

  @media screen and (max-width: 768px)
    .column
      width: 100% !important
      border-right: none !important

      &.small
        height: 4rem

      &:not(.active)
        display: none
</style>
