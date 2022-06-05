<script lang="ts">
  import { getDateTime, getGravatarURL } from '$lib/utils';
  import type { EmailMessage } from '$lib/modules/messages';

  export let message: EmailMessage;
</script>

<header class="request-header">
  <div class="request-data">
    <h1 class="request-title">Solicitação #{message.id}</h1>

    <div class="request-author">
      <figure class="request-author-avatar">
        <img src={getGravatarURL(message.author.email)} alt="" />
      </figure>
      <div class="request-author-info">
        <p><b>Cliente:</b> {message.author.name}</p>
        <p><b>Responsável:</b> Você</p>
      </div>
    </div>
  </div>
  <div class="request-data has-text-right">
    <div class="request-status">Em aberto</div>
    <p class="request-dates">
      <span>Recebido em {getDateTime(message.created_at)}</span>
      <span>Atualizado em {getDateTime(message.updated_at)}</span>
    </p>
  </div>
</header>

<style lang="sass">
  .request-header
    display: flex
    justify-content: space-between
    padding: 3rem 0
    border-bottom: 1px solid #e6e7e9

  .request-data
    display: flex
    flex-direction: column
    gap: .5rem

    &.has-text-right
      align-items: flex-end
      text-align: right

  .request-title
    font-size: 1.25rem
    font-weight: 700

  .request-author
    display: flex
    align-items: center
    gap: .5rem

    &-avatar
      width: 3rem
      height: 3rem
      background-color: rgba(#000, .1)
      border-radius: 50%
      overflow: hidden

  .request-status
    width: fit-content
    padding: .25rem .5rem
    color: #206bc4
    text-transform: uppercase
    border: 1px solid #206bc4
    border-radius: .25rem

  .request-dates
    display: flex
    flex-direction: column

  @media screen and (max-width: 1600px)
    .request-header
      padding: 2rem 0

  @media screen and (max-width: 768px)
    .request-header
      position: relative
      flex-direction: column
      gap: 1rem

    .request-data.has-text-right
      align-items: flex-start
      text-align: left

    .request-status
      position: absolute
      top: 2rem
      right: 0
      font-size: .8rem
</style>
