@ModelType IEnumerable(Of BasicPokemonListItem)

<table class="table">
    <tr>
        <th width="10%">
            ID (Decimal)
        </th>
        <th width="10%">
            ID (Hex, Big Endian)
        </th>
        <th width="10%">
            ID (Hex, Little Endian)
        </th>
        <th>
            Pokémon
        </th>
    </tr>
    @For Each item In Model
        @<tr>
            <td>
                @item.ID
            </td>
            <td>
                @item.IDHexBigEndian
            </td>
            <td>
                @item.IDHexLittleEndian
            </td>
            <td>
                @Html.ActionLink(item.Name, "Details", "Pokemon", New With {.id = item.ID}, Nothing)
            </td>
        </tr>
    Next
</table>