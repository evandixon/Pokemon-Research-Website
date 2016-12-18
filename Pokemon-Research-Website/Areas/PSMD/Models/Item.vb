Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Namespace Areas.PSMD.Models
    Public Class Item
        <DatabaseGeneratedAttribute(DatabaseGeneratedOption.None), Key> <Required> Public Property ID As Integer
        <Required> Public Property Name As String
        <Required> Public Property BuyPrice As Integer
        <Required> Public Property SellPrice As Integer
    End Class
End Namespace