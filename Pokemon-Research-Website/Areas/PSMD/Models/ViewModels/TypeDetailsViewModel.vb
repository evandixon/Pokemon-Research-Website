Imports System.ComponentModel.DataAnnotations
Imports Pokemon_Research_Website.Areas.PSMD.Models.ListViewModels

Namespace Areas.PSMD.Models.ViewModels
    Public Class TypeDetailsViewModel
        <Display(Name:="ID")> Public Property ID As Integer

        <Display(Name:="ID (Hex)")> Public Property IDHex As String
        <Display(Name:="Name")> Public Property Name As String
        Public Property PokemonWithType As List(Of BasicPokemonListItem)
        Public Property MovesWithType As List(Of BasicMoveListItem)
        Public Sub New(Type As PkmType, Context As DataContext)
            ID = Type.ID
            Dim hex = Conversion.Hex(Type.ID).PadLeft(4, "0"c)
            IDHex = $"0x{hex}"
            Name = Type.Name

            PokemonWithType = New List(Of BasicPokemonListItem)
            For Each item In
                From p In Context.Pokemon
                Where p.Type1 = ID OrElse p.Type2 = ID
                Select New With {.ID = p.ID, .Name = p.Name}
                PokemonWithType.Add(New BasicPokemonListItem(item.ID, item.Name))
            Next

            MovesWithType = New List(Of BasicMoveListItem)
            For Each item In
                From m In Context.Moves
                Where m.TypeID = ID
                Select New With {.ID = m.ID, .Name = m.Name}
                MovesWithType.Add(New BasicMoveListItem(item.ID, item.Name))
            Next
        End Sub

    End Class
End Namespace