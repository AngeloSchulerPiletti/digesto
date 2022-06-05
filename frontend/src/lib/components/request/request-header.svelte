<script lang="ts">
  import { getDateTime, getGravatarURL } from '$lib/utils';
  import type { EmailMessage } from '$lib/modules/messages';

  export let message: EmailMessage;
</script>

<header class="email-reader-header">
  <div class="email-data">
    <h1 class="email-title">Solicitação #{message.id}</h1>

    <div class="email-author">
      <figure class="email-author-avatar">
        <img src={getGravatarURL(message.author.email)} alt="" />
      </figure>
      <div class="email-author-info">
        <p><b>Cliente:</b> {message.author.name}</p>
        <p><b>Responsável:</b> Você</p>
      </div>
    </div>
  </div>
  <div class="email-data has-text-right">
    <div class="email-status">Em aberto</div>
    <p class="email-dates">
      <span>Recebido em {getDateTime(message.created_at)}</span>
      <span>Atualizado em {getDateTime(message.updated_at)}</span>
    </p>
  </div>
</header>

<style lang="sass">
  .email-reader-header
    display: flex
    justify-content: space-between
    padding: 3rem 0
    border-bottom: 1px solid #e6e7e9

  .email-data
    display: flex
    flex-direction: column
    gap: .5rem

    &.has-text-right
      align-items: flex-end
      text-align: right

  .email-title
    font-size: 1.25rem
    font-weight: 700

  .email-author
    display: flex
    align-items: center
    gap: .5rem

    &-avatar
      width: 3rem
      height: 3rem
      background-color: rgba(#000, .1)
      border-radius: 50%
      overflow: hidden

  .email-status
    width: fit-content
    padding: .25rem .5rem
    color: #206bc4
    text-transform: uppercase
    border: 1px solid #206bc4
    border-radius: .25rem

  .email-dates
    display: flex
    flex-direction: column
</style>
