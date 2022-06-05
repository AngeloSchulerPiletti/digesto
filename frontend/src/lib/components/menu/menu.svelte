<script lang="ts">
  import type { MenuItems } from '.';

  export let items: MenuItems = [];
</script>

<div class="menu">
  <img src="/logo.png" alt="" class="menu-logo" />
  <div class="menu-links">
    {#each items as item}
      {#if typeof item === 'string'}
        <div class="menu-category">{item}</div>
      {:else}
        <a href={item.href} class="menu-link" class:active={item.active}>
          <svelte:component this={item.icon} />
          {item.label}
        </a>
      {/if}
    {/each}
  </div>
</div>

<style lang="sass">
  .menu
    display: flex
    flex-direction: column
    color: #fff

    &-logo
      align-self: center
      height: 6rem
      margin: 1.5rem 0
      pointer-events: none
      user-select: none

    &-links
      display: flex
      flex-direction: column

      .menu-category
        padding: .25rem 1rem
        text-transform: uppercase
        font-weight: 600
        font-size: .75rem
        opacity: .5

      .menu-link + .menu-category
        margin-top: 1rem

      .menu-link
        display: flex
        align-items: center
        padding: .5rem 1rem
        gap: .5rem
        color: rgba(#fff, .75)
        text-decoration: none
        transition: all .2s ease

        &.active,
        &:hover
          color: #fff

        &:hover
          background-color: rgba(#000, .1)

        :global(svg)
          width: 1.25rem
          height: 1.25rem
</style>
