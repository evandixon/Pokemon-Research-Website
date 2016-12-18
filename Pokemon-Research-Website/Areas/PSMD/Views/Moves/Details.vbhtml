@ModelType Pokemon_Research_Website.Areas.PSMD.Models.ViewModels.MoveDetailsViewModel
@Code
    ViewData("Title") = Model.Name
End Code

<h2>@Html.DisplayFor(Function(model) model.Name)</h2>

<div>
    <h4>Details</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.ID)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.ID)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.IDHexBigEndian)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.IDHexBigEndian)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.IDHexLittleEndian)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.IDHexLittleEndian)
        </dd>
        

        <dt>
            @Html.DisplayNameFor(Function(model) model.TypeName)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.TypeName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TilesCount)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.TilesCount)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CutsCorners)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.CutsCorners)
        </dd>
        
        <dt>
            @Html.DisplayNameFor(Function(model) model.BaseDamage)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.BaseDamage)
        </dd>
        
        <dt>
            @Html.DisplayNameFor(Function(model) model.MaxDamage)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.MaxDamage)
        </dd>
        
        <dt>
            @Html.DisplayNameFor(Function(model) model.BasePP)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.BasePP)
        </dd>
        
        <dt>
            @Html.DisplayNameFor(Function(model) model.MaxPP)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.MaxPP)
        </dd>
        
        <dt>
            @Html.DisplayNameFor(Function(model) model.BaseAccuracy)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.BaseAccuracy)
        </dd>
        
        <dt>
            @Html.DisplayNameFor(Function(model) model.MaxAccuracy)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.MaxAccuracy)
        </dd>
        

    </dl>
</div>
<br />
<br />
@If Model.MultiHitData.HitCountMinimum > 1 Then
    @<div>
        <h4>Multi-Hit Details</h4>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                @Html.DisplayNameFor(Function(model) model.MultiHitData.RepeatUntilMiss)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.MultiHitData.RepeatUntilMiss)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.MultiHitData.HitCountMinimum)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.MultiHitData.HitCountMinimum)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.MultiHitData.HitCountMaximum)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.MultiHitData.HitCountMaximum)
            </dd>

            @If Model.MultiHitData.HitChance2 > 0 Then
                @<dt>
                    @Html.DisplayNameFor(Function(model) model.MultiHitData.HitChance2)
                </dt>
                @<dd>
                    @Html.DisplayFor(Function(model) model.MultiHitData.HitChance2)%
                </dd>
            End If

            @If Model.MultiHitData.HitChance3 > 0 Then
                @<dt>
                    @Html.DisplayNameFor(Function(model) model.MultiHitData.HitChance3)
                </dt>
                @<dd>
                    @Html.DisplayFor(Function(model) model.MultiHitData.HitChance3)%
                </dd>
            End If

            @If Model.MultiHitData.HitChance4 > 0 Then
                @<dt>
                    @Html.DisplayNameFor(Function(model) model.MultiHitData.HitChance4)
                </dt>
                @<dd>
                    @Html.DisplayFor(Function(model) model.MultiHitData.HitChance4)%
                </dd>
            End If

            @If Model.MultiHitData.HitChance5 > 0 Then
                @<dt>
                    @Html.DisplayNameFor(Function(model) model.MultiHitData.HitChance5)
                </dt>
                @<dd>
                    @Html.DisplayFor(Function(model) model.MultiHitData.HitChance5)%
                </dd>
            End If
        </dl>
    </div>
End If
<div>
    <h4>Pokemon through Level Up</h4>
    <Table Class="table">
        <tr>
    <th width = "10%" >
                ID (Decimal)
            </th>
            <th width = "10%" >
                ID (Hex, Big Endian)
            </th>
            <th width = "10%" >
                ID (Hex, Little Endian)
            </th>
            <th>
    Pokémon
            </th>
            <th>
    Level(s)
            </th>
        </tr>
@For Each Item In Model.PokemonLevelUp
    @<tr>
         <td>
             @Item.ID
         </td>
         <td>
             @Item.IDHexBigEndian
         </td>
         <td>
             @Item.IDHexLittleEndian
         </td>
         <td>
             @Html.ActionLink(Item.Name, "Details", "Pokemon", New With {.id = Item.ID}, Nothing)
         </td>
        <td>
            @String.Join(", ", Item.Levels)
        </td>
     </tr>
Next
    </table>
    
</div>
<p>
    @Html.ActionLink("Back to List", "Index")
</p>
