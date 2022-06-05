<script lang="ts">
  import { ChevronLeftIcon, HamburgerIcon } from '$lib/components/icons';
  import type { MenuItems } from '.';

  export let items: MenuItems = [],
    showMobileMenu = false,
    showBackButton = false,
    goBack: () => void;
</script>

<div class="menu" class:show-mobile-menu={showMobileMenu}>
  <div class="menu-button" class:hide={!showBackButton} on:click={goBack}>
    <ChevronLeftIcon />
  </div>
  <div class="menu-button" on:click={() => (showMobileMenu = true)}>
    <HamburgerIcon />
  </div>
  <img src="/logo.png" alt="" class="menu-logo" />
  <img src="/logo-alt.png" alt="" class="menu-logo-mobile" />
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
  <div class="menu-background" on:click={() => (showMobileMenu = false)} />
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

    &-logo-mobile
      display: none

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

    &-background
      position: fixed
      top: 0
      right: 0
      display: none
      width: calc(100% - 16rem)
      height: 100%
      background-color: rgba(#000, .5)
      transition: all .4s ease

    &-button
      display: none
      justify-content: center
      align-items: center
      width: 2rem
      height: 4rem
      margin-left: .5rem
      transition: all .3s ease

      &.hide
        margin-left: -2rem

      :global(svg)
        width: 2rem
        height: 2rem

  @media screen and (max-width: 768px)
    .menu
      flex-direction: row
      z-index: 1

      &-logo
        display: none

      &-logo-mobile
        display: block
        align-self: center
        height: 2.5rem
        margin: 0 1rem 0 auto

      &-button
        display: flex

      &-links
        position: fixed
        height: 100%
        padding: 1rem 0
        background-color: #1e293b
        transition: all .4s ease

      &-link
        width: 16rem

      &-background
        display: block

      &:not(.show-mobile-menu)
        .menu-links
          transform: translateX(-16rem)

        .menu-background
          width: 100%
          opacity: 0
          pointer-events: none
</style>
