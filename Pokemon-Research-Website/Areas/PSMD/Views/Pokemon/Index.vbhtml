@ModelType IEnumerable(Of Pokemon_Research_Website.Areas.PSMD.Models.Pokemon)
@Code
ViewData("Title") = "Pokémon"
End Code

<h2>Pokémon</h2>

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
        <th width="60%">
            @Html.DisplayNameFor(Function(model) model.Name)
        </th>
        <th width="10%">
            @Html.DisplayNameFor(Function(model) model.DexNumber)
        </th>
    </tr>

@For Each item In Model
    Dim hex = Conversion.Hex(item.ID).PadLeft(4, "0"c)
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ID)
        </td>
        <td>
            @($"0x{hex}")
        </td>
        <td>
            @($"{hex.Substring(2, 2)} {hex.Substring(0, 2)}")
        </td>
        <td>
            @Html.ActionLink(item.Name, "Details", New With {.id = item.ID})
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DexNumber)
        </td>
    </tr>
Next

</table>
