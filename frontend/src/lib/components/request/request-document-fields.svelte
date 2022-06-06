<script lang="ts">
  import type { ExtractedData } from '.';

  export let fields: ExtractedData[] = [];
</script>

<table class="request-document-fields">
  <tbody>
    {#each fields as field}
      <tr>
        <td><span class="label">{field.label}:</span></td>
        <td>
          <input type="text" name={field.name} value={field.value} />
        </td>
      </tr>
    {/each}
  </tbody>
</table>

<style lang="sass">
  .request-document-fields
    width: 100%

    td
      padding: .25rem 0

      &:first-child
        width: 1%
        white-space: nowrap
        padding-right: 1rem
        text-align: right

      .label
        display: block
        max-width: 12rem
        text-overflow: ellipsis
        white-space: nowrap
        overflow: hidden

    input
      width: 100%
      border: 1px solid #e6e7e9
      border-radius: .5rem
      padding: .5rem .75rem
      outline: none
      transition: all .1s ease

      &:focus
        border-color: #206bc4
        box-shadow: 0 0 0 2px rgba(#206bc4, .25)
</style>
