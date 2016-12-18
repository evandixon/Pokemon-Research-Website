@ModelType Pokemon_Research_Website.Areas.PSMD.Models.ViewModels.TypeDetailsViewModel
@Code
    ViewData("Title") = Model.Name
End Code

<h2>@Model.Name</h2>

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
            @Html.DisplayNameFor(Function(model) model.IDHex)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.IDHex)
        </dd>

    </dl>
</div>
<div>
    <h4>Pokemon of Type</h4>
    @Html.Partial("_BasicPokemonTable", Model.PokemonWithType)
</div>
<div>
    <h4>Moves of Type</h4>
    @Html.Partial("_BasicMovesTable", Model.MovesWithType)
</div>
<p>
    @Html.ActionLink("Back to List", "Index")
</p>
