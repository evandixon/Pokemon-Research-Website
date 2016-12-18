Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Namespace Areas.PSMD.Models
    Public Class GameString
        Public Enum GameLanguage As Integer
            Japanese
            EnglishUs
            EnglishEu
            French
            Spanish
            Italian
            German
        End Enum
        <Key, Column(Order:=0)> <Required> Public Property ID As Integer
        <Key, Column(Order:=1)> <Required> Public Property Language As GameLanguage
        <Required> Public Property Filename As String
        <Required> Public Property Entry As String
    End Class
End Namespace