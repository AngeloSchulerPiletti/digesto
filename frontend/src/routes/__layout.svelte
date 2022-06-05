<script lang="ts">
  import '../sass/minireset.sass';
  import '../sass/global.sass';
</script>

<div id="app">
  <slot />
</div>

<style lang="sass">
  #app
    display: flex
    width: 100%
    height: 100%

  @media screen and (max-width: 768px)
    #app
      flex-direction: column
</style>
