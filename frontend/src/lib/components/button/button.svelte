<script lang="ts">
  export let icon = false,
    primary = false,
    textPrimary = false,
    textDanger = false,
    textSuccess = false;
</script>

<button
  class="button"
  class:icon
  class:primary
  class:text-primary={textPrimary}
  class:text-danger={textDanger}
  class:text-success={textSuccess}
  on:click
>
  <slot />
</button>

<style lang="sass">
  .button
    display: flex
    justify-content: center
    align-items: center
    gap: .5rem
    padding: .5rem .75rem
    color: #72767c
    background-color: transparent
    border: none
    border-radius: .5rem
    cursor: pointer
    transition: all .2s ease

    &:hover
      background-color: #efeff1

    :global(svg)
      width: 1.25rem
      height: 1.25rem

    &.icon
      width: 2.75rem
      height: 2.75rem
      padding: 0
      border-radius: 50%

      :global(svg)
        width: 1.5rem
        height: 1.5rem

    &.primary
      background-color: #206bc4
      color: #fff

      &:hover
        background-color: #1d60b0

    &.text-primary
      color: #206bc4

      &:hover
        background-color: rgba(#206bc4, .1)

    &.text-danger
      color: #f14668

      &:hover
        background-color: rgba(#f14668, .1)

    &.text-success
      color: #48c78e

      &:hover
        background-color: rgba(#48c78e, .1)

  :global(.topbar-actions .button.primary:first-child)
    margin-left: .25rem

  @media screen and (max-width: 768px)
    .button:not(.icon)
      width: max-content
</style>
