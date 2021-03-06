﻿@ModelType IEnumerable(Of Pokemon_Research_Website.Areas.PSMD.Models.PkmType)
@Code
    ViewData("Title") = "Types"
End Code

<h2>Types</h2>
<table class="table">
    <tr>
        <th width="10%">
            ID (Decimal)
        </th>
        <th width="10%">
            ID (Hex)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Name)
        </th>
    </tr>

@For Each item In Model
    Dim hex = Conversion.Hex(item.ID).PadLeft(2, "0"c)
    @<tr>
         <td>
             @Html.DisplayFor(Function(modelItem) item.ID)
         </td>
         <td>
             @($"0x{hex}")
         </td>
         <td>
             @Html.ActionLink(item.Name, "Details", New With {.id = item.ID})
         </td>
    </tr>
Next

</table>
