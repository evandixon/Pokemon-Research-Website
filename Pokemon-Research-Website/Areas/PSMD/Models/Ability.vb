Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Namespace Areas.PSMD.Models
    Public Class Ability
        <DatabaseGenerated(DatabaseGeneratedOption.None), Key> <Required> Public Property ID As Integer
        <Required> Public Property Name As String
    End Class
End Namespace