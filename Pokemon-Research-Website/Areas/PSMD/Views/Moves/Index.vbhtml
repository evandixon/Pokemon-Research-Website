@ModelType IEnumerable(Of Pokemon_Research_Website.Areas.PSMD.Models.Move)
@Code
    ViewData("Title") = "Moves"
End Code

<h2>Moves</h2>

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
            @Html.DisplayNameFor(Function(model) model.Name)
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
    </tr>
Next

</table>
