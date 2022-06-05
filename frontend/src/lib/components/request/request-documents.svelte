<script lang="ts">
  import { Card } from '$lib/components/card';
  import { RequestDocumentFields, RequestTitle } from '.';
  import type { Document } from '.';

  export let documents: Document[] = [];
</script>

<RequestTitle>Análise de documentos</RequestTitle>
<ul class="request-documents">
  <li>
    <div class="column document">
      <Card>
        <iframe src="/document-example.pdf" title="" />
      </Card>
    </div>
    <div class="column data">
      {#each documents as document}
        <Card>
          <h1 class="file-name">
            {document.filename}
            <ul class="tags">
              {#each document.tags as tag}
                <li>{tag}</li>
              {/each}
            </ul>
          </h1>
          <RequestDocumentFields fields={document.fields} />
        </Card>
      {/each}
    </div>
  </li>
</ul>

<style lang="sass">
  .request-documents
    display: flex
    flex-direction: column

    li
      display: flex
      gap: .75rem

      .column.document
        :global(.card)
          display: flex
          padding: 0
          overflow: hidden

        iframe
          width: 20rem
          height: 100%
          min-height: 25rem
          border-radius: .5rem

      .column.data
        flex-grow: 1

        .file-name
          display: flex
          align-items: center
          gap: 1rem
          font-size: 1.25rem
          font-weight: 700
          margin-bottom: 1rem

          .tags
            display: flex
            gap: .25rem

            li
              padding: .1rem .25rem
              font-size: .7rem
              font-weight: 400
              color: #206bc4
              text-transform: uppercase
              border: 1px solid #206bc4
              border-radius: .25rem

  @media screen and (max-width: 768px)
    .request-documents li
      flex-direction: column

      .column.document iframe
        width: 100%
        height: 16rem
        min-height: unset
</style>
