<script lang="ts">
  import { Column, ColumnContent } from '$lib/components/column';
  import { TopbarActions, Topbar } from '$lib/components/topbar';
  import { Button } from '$lib/components/button';
  import { Messages } from '$lib/modules/messages';
  import {
    AddIcon,
    FilterIcon,
    RefreshIcon,
    SortDescendingIcon,
  } from '$lib/components/icons';
  import { messages } from '$lib/fixtures/messages';
</script>

<Column medium>
  <Topbar>
    <TopbarActions>
      <Button primary><AddIcon /> Nova</Button>
    </TopbarActions>
    <TopbarActions>
      <Button icon><RefreshIcon /></Button>
      <Button icon><FilterIcon /></Button>
      <Button icon><SortDescendingIcon /></Button>
    </TopbarActions>
  </Topbar>
  <ColumnContent hasBackground>
    <Messages {messages} />
  </ColumnContent>
</Column>
