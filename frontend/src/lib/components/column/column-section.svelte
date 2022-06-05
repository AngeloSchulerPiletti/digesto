<section class="column-section">
  <slot />
</section>

<style lang="sass">
  .column-section
    width: 100%
    max-width: 60rem
    margin: 0 auto

  @media screen and (max-width: 1600px)
    .column-section
      max-width: 48rem

  @media screen and (max-width: 768px)
    .column-section
      padding: 0 1rem
</style>
