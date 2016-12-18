Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Namespace Areas.PSMD.Models
    Public Class PokemonLevelUp
        <Key, Column(Order:=0)> <Required> Public Property PokemonID As Integer
        <Key, Column(Order:=1)> <Required> Public Property Level As Integer
        <Key, Column(Order:=2)> <Required> Public Property MoveID As Integer
    End Class
End Namespace