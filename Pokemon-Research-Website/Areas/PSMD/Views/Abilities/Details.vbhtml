@ModelType Pokemon_Research_Website.Areas.PSMD.Models.ViewModels.AbilityDetailsViewModel
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

    </dl>
</div>
<div>
    <h4>Pokemon with Ability 1</h4>
    @Html.Partial("_BasicPokemonTable", Model.PokemonWithAbility1)
</div>
<div>
    <h4>Pokemon with Ability 2</h4>
    @Html.Partial("_BasicPokemonTable", Model.PokemonWithAbility2)
</div>
<div>
    <h4>Pokemon with Hidden Ability</h4>
    @Html.Partial("_BasicPokemonTable", Model.PokemonWithHidden)
</div>
<p>
    @Html.ActionLink("Back to List", "Index")
</p>
