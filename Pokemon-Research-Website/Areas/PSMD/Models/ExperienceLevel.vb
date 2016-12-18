Imports System.ComponentModel.DataAnnotations
Namespace Areas.PSMD.Models
    Public Class ExperienceLevel
        <Key> <Required> Public Property ID As Integer
        <Required> Public Property ExperienceTableNumber As Integer
        <Required> Public Property Level As Integer
        <Required> Public Property Exp As Integer
        <Required> Public Property AddedHP As Integer
        <Required> Public Property AddedAttack As Integer
        <Required> Public Property AddedSpAttack As Integer
        <Required> Public Property AddedDefense As Integer
        <Required> Public Property AddedSpDefense As Integer
        <Required> Public Property AddedSpeed As Integer
    End Class
End Namespace