Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Namespace Areas.PSMD.Models
    Public Class Pokemon
        <DatabaseGeneratedAttribute(DatabaseGeneratedOption.None), Key> <Required> <Display(Name:="ID")> Public Property ID As Integer
        <Required> <Display(Name:="Name")> Public Property Name As String
        <Required> <Display(Name:="Pokédex Number")> Public Property DexNumber As Integer
        <Required> <Display(Name:="Category")> Public Property Category As Integer
        <Required> <Display(Name:="ListNumber1")> Public Property ListNumber1 As Integer
        <Required> <Display(Name:="ListNumber2")> Public Property ListNumber2 As Integer
        <Required> <Display(Name:="Base HP")> Public Property BaseHP As Integer
        <Required> <Display(Name:="Base Attack")> Public Property BaseAttack As Integer
        <Required> <Display(Name:="Base Sp. Attack")> Public Property BaseSpAttack As Integer
        <Required> <Display(Name:="Base Defense")> Public Property BaseDefense As Integer
        <Required> <Display(Name:="Base Sp. Defense")> Public Property BaseSpDefense As Integer
        <Required> <Display(Name:="Base Speed")> Public Property BaseSpeed As Integer
        <Required> <Display(Name:="Evolves From")> Public Property EvolvesFromEntry As Integer
        <Required> <Display(Name:="Experience Table")> Public Property ExpTableNumber As Integer
        <Required> <Display(Name:="Ability 1")> Public Property Ability1 As Integer
        <Required> <Display(Name:="Ability 2")> Public Property Ability2 As Integer
        <Required> <Display(Name:="Hidden Ability")> Public Property AbilityHidden As Integer
        <Required> <Display(Name:="Type 1")> Public Property Type1 As Integer
        <Required> <Display(Name:="Type 2")> Public Property Type2 As Integer
        <Required> <Display(Name:="Is Mega Evolution")> Public Property IsMegaEvolution As Byte 'Maybe
        <Required> <Display(Name:="Min Evolve Level")> Public Property MinEvolveLevel As Byte
    End Class
End Namespace