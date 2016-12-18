Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Namespace Areas.PSMD.Models
    Public Class Move
        <DatabaseGeneratedAttribute(DatabaseGeneratedOption.None), Key> <Required> Public Property ID As Integer
        <Required> Public Property Name As String
        <Required> Public Property EffectRate As Integer
        <Required> Public Property HPBellyChangeValue As Integer
        <Required> Public Property TrapFlag As Boolean
        <Required> Public Property StatusChange As Integer
        <Required> Public Property StatChangeIndex As Integer
        <Required> Public Property TypeChange As Integer
        <Required> Public Property TerrainChange As Integer
        <Required> Public Property BaseAccuracy As Integer
        <Required> Public Property MaxAccuracy As Integer
        <Required> Public Property SizeTypeMove As Integer
        <Required> Public Property TypeID As Integer
        <Required> Public Property Attribute As Integer
        <Required> Public Property BaseDamage As Integer
        <Required> Public Property MaxDamage As Integer
        <Required> Public Property BasePP As Integer
        <Required> Public Property MaxPP As Integer
        <Required> Public Property CutsCorners As Boolean
        <Required> Public Property MoreTimeToAttack As Boolean
        <Required> Public Property TilesCount As Integer
        <Required> Public Property Range As Integer
        <Required> Public Property Target As Integer
        <Required> Public Property PiercingAttack As Boolean
        <Required> Public Property SleepAttack As Boolean
        <Required> Public Property FaintAttack As Boolean
        <Required> Public Property NearbyDamage As Boolean
        <Required> Public Property HitCounterIndex As Integer
    End Class
End Namespace