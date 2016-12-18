@ModelType Pokemon_Research_Website.Areas.PSMD.Models.ViewModels.PokemonDetailsViewModel
@Code
    ViewData("Title") = Model.Name
End Code

<h2>@model.Name</h2>

<div>
    <h4>Details</h4>
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
            @Html.DisplayNameFor(Function(model) model.DexNumber)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DexNumber)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Category)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Category)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ListNumber1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ListNumber1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ListNumber2)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ListNumber2)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EvolvesFromName)
        </dt>

        <dd>
            @Html.ActionLink(Model.EvolvesFromName, "Details", New With {.id = Model.EvolvesFromEntryID})
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Ability1)
        </dt>

        <dd>
            @Html.ActionLink(Model.Ability1, "Details", "Abilities", New With {.id = Model.Ability1ID}, Nothing)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Ability2)
        </dt>

        <dd>
            @Html.ActionLink(Model.Ability2, "Details", "Abilities", New With {.id = Model.Ability2ID}, Nothing)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.AbilityHidden)
        </dt>

        <dd>
            @Html.ActionLink(Model.AbilityHidden, "Details", "Abilities", New With {.id = Model.AbilityHiddenID}, Nothing)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Type1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Type1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Type2)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Type2)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.IsMegaEvolution)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.IsMegaEvolution)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.MinEvolveLevel)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MinEvolveLevel)
        </dd>

    </dl>
</div>
<div>
    <h4>Moves (Level Up)</h4>
    <dl class="dl-horizontal">
@For Each item In Model.MovesLevelUp
    @<dt>
        @item.Level.ToString
    </dt>
    @<dd>
        @Html.ActionLink(item.MoveName, "Details", "Moves", New With {.id = item.MoveID}, Nothing)
    </dd>
Next
    </dl>
</div>
<div>
    <h4>Stats</h4>
    <table class="table">
        <tr>
            <th>Level</th>
            <th>Experience</th>
            <th>HP</th>
            <th>Attack</th>
            <th>Sp. Attack</th>
            <th>Defense</th>
            <th>Sp. Defense</th>
            <th>Speed</th>
        </tr>
        @For Each item In Model.StatLevelUp
            @<tr>
                 <td>
                     @((item.Level + 1).ToString)
                 </td>
                 <td>
                     @item.Exp
                 </td>
                 <td>
                     @($"{item.TotalHP} (+{item.AddedHP})")
                 </td>
                 <td>
                     @($"{item.TotalAttack} (+{item.AddedAttack})")
                 </td>
                 <td>
                     @($"{item.TotalSpAttack} (+{item.AddedSpAttack})")
                 </td>
                 <td>
                     @($"{item.TotalDefense} (+{item.AddedDefense})")
                 </td>
                 <td>
                     @($"{item.TotalSpDefense} (+{item.AddedSpDefense})")
                 </td>
                 <td>
                     @($"{item.TotalSpeed} (+{item.AddedSpeed})")
                 </td>
            </tr>
        Next
    </table>
</div>
<p>
    @Html.ActionLink("Back to List", "Index")
</p>
