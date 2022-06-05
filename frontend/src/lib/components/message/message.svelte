<script lang="ts">
  import { getReadableDate } from '$lib/utils';

  export let author: string,
    date: Date,
    subject: string,
    unread = false,
    active = false;
</script>

<div class="message" on:click class:unread class:active>
  <div class="message-icons">
    {#if unread}
      <span class="new" />
    {/if}
  </div>
  <div class="message-info">
    <h1 class="message-author">
      {author} <span class="message-date">{getReadableDate(date) || ''}</span>
    </h1>
    <ul class="message-tags">
      <li>Proposta</li>
      <li>Seguro de Vida</li>
    </ul>
  </div>
</div>

<style lang="sass">
  .message
    display: flex
    padding: .75rem .5rem
    cursor: pointer
    transition: all .2s ease

    &:hover
      background-color: #e4e4e7 !important

    &.active
      background-color: #efeff1
      box-shadow: inset .25rem 0 0 0 #206bc4

    &-icons
      display: flex
      justify-content: center
      width: 1.25rem
      padding: .3rem 0

      .new
        display: block
        width: .5rem
        height: .5rem
        border-radius: 50%
        background-color: #206bc4

    &-info
      display: flex
      flex-direction: column
      gap: .25rem
      width: 100%
      line-height: 1.25

    &-author
      display: flex
      justify-content: space-between
      align-items: center
      width: 100%
      font-weight: 600

    &-date
      font-weight: 400
      color: #72767c

    &-tags
      display: flex
      gap: .25rem

      li
        padding: .1rem .25rem
        font-size: .7rem
        color: #206bc4
        text-transform: uppercase
        border: 1px solid #206bc4
        border-radius: .25rem

    &.unread
      .message-author
        font-weight: 800
</style>
