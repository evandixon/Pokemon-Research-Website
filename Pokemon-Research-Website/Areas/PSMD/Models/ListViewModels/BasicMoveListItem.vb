Imports System.ComponentModel.DataAnnotations

Namespace Areas.PSMD.Models.ListViewModels
    Public Class BasicMoveListItem
        <Display(Name:="ID")> Public Property ID As Integer

        <Display(Name:="ID (Hex, Big Endian)")> Public Property IDHexBigEndian As String
        <Display(Name:="ID (Hex, Little Endian)")> Public Property IDHexLittleEndian As String
        <Display(Name:="Name")> Public Property Name As String
        Public Sub New(ID As Integer, Name As String)
            Me.ID = ID
            Dim hex = Conversion.Hex(ID).PadLeft(4, "0"c)
            IDHexBigEndian = $"0x{hex}"
            IDHexLittleEndian = $"{hex.Substring(2, 2)} {hex.Substring(0, 2)}"
            Me.Name = Name
        End Sub
    End Class
End Namespace