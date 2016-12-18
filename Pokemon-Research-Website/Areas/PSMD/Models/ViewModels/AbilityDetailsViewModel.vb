Imports System.ComponentModel.DataAnnotations
Imports Pokemon_Research_Website.Areas.PSMD.Models.ListViewModels

Namespace Areas.PSMD.Models.ViewModels
    Public Class AbilityDetailsViewModel
        <Display(Name:="ID")> Public Property ID As Integer

        <Display(Name:="ID (Hex, Big Endian)")> Public Property IDHexBigEndian As String
        <Display(Name:="ID (Hex, Little Endian)")> Public Property IDHexLittleEndian As String
        <Display(Name:="Name")> Public Property Name As String
        Public Property PokemonWithAbility1 As List(Of BasicPokemonListItem)
        Public Property PokemonWithAbility2 As List(Of BasicPokemonListItem)
        Public Property PokemonWithHidden As List(Of BasicPokemonListItem)
        Public Sub New(Ability As Ability, Context As DataContext)
            ID = Ability.ID
            Dim hex = Conversion.Hex(Ability.ID).PadLeft(4, "0"c)
            IDHexBigEndian = $"0x{hex}"
            IDHexLittleEndian = $"{hex.Substring(2, 2)} {hex.Substring(0, 2)}"
            Name = Ability.Name


            PokemonWithAbility1 = New List(Of BasicPokemonListItem)
            PokemonWithAbility2 = New List(Of BasicPokemonListItem)
            PokemonWithHidden = New List(Of BasicPokemonListItem)
            For Each item In
                From p In Context.Pokemon
                Where p.Ability1 = ID Or p.Ability2 = ID Or p.AbilityHidden = ID
                Select p.ID, p.Name, p.Ability1, p.Ability2, p.AbilityHidden
                Dim p As New BasicPokemonListItem(item.ID, item.Name)
                If item.AbilityHidden = ID Then
                    PokemonWithHidden.Add(p)
                End If
                If item.Ability1 = ID Then
                    PokemonWithAbility1.Add(p)
                End If
                If item.Ability2 = ID Then
                    PokemonWithAbility2.Add(p)
                End If
            Next
        End Sub
    End Class
End Namespace