Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Namespace Areas.PSMD.Models
    Public Class MoveMultiHit
        <DatabaseGeneratedAttribute(DatabaseGeneratedOption.None), Key> <Required> Public Property ID As Integer
        <Required> <Display(Name:="Repeat Until First Miss")> Public Property RepeatUntilMiss As Boolean
        <Required> <Display(Name:="Minimum Hits")> Public Property HitCountMinimum As Integer
        <Required> <Display(Name:="Maximum Hits")> Public Property HitCountMaximum As Integer
        <Required> <Display(Name:="2nd Hit Chance")> Public Property HitChance2 As Integer
        <Required> <Display(Name:="3rd Hit Chance")> Public Property HitChance3 As Integer
        <Required> <Display(Name:="4th Hit Chance")> Public Property HitChance4 As Integer
        <Required> <Display(Name:="5th Hit Chance")> Public Property HitChance5 As Integer
    End Class
End Namespace