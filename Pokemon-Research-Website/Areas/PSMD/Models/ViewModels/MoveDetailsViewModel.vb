Imports System.ComponentModel.DataAnnotations
Namespace Areas.PSMD.Models.ViewModels
    Public Class MoveDetailsViewModel
        Public Class PkmLevelUp
            <Display(Name:="ID")> Public Property ID As Integer

            <Display(Name:="ID (Hex, Big Endian)")> Public Property IDHexBigEndian As String
            <Display(Name:="ID (Hex, Little Endian)")> Public Property IDHexLittleEndian As String
            <Display(Name:="Name")> Public Property Name As String
            Public Property Levels As List(Of Integer)
            Public Sub New(ID As Integer, Name As String, Levels As IEnumerable(Of Integer))
                Me.ID = ID
                Dim hex = Conversion.Hex(ID).PadLeft(4, "0"c)
                IDHexBigEndian = $"0x{hex}"
                IDHexLittleEndian = $"{hex.Substring(2, 2)} {hex.Substring(0, 2)}"
                Me.Name = Name

                Me.Levels = New List(Of Integer)
                For Each item In Levels
                    Me.Levels.Add(item)
                Next
            End Sub
        End Class
        <Display(Name:="ID")> Public Property ID As Integer

        <Display(Name:="ID (Hex, Big Endian)")> Public Property IDHexBigEndian As String
        <Display(Name:="ID (Hex, Little Endian)")> Public Property IDHexLittleEndian As String
        <Display(Name:="Name")> Public Property Name As String
        Public Property PokemonLevelUp As List(Of PkmLevelUp)
        Public Property MultiHitData As MoveMultiHit
        Public Property EffectRate As Integer
        Public Property HPBellyChangeValue As Integer
        Public Property TrapFlag As Boolean
        Public Property StatusChange As Integer
        Public Property StatChangeIndex As Integer
        Public Property TypeChange As Integer
        Public Property TerrainChange As Integer
        <Display(Name:="Base Accuracy")> Public Property BaseAccuracy As Integer
        <Display(Name:="Max Accuracy")> Public Property MaxAccuracy As Integer
        Public Property SizeTypeMove As Integer
        Public Property TypeID As Integer
        <Display(Name:="Type")> Public Property TypeName As String
        Public Property Attribute As Integer
        <Display(Name:="Base Damage")> Public Property BaseDamage As Integer
        <Display(Name:="Max Damage")> Public Property MaxDamage As Integer
        <Display(Name:="Base PP")> Public Property BasePP As Integer
        <Display(Name:="Max PP")> Public Property MaxPP As Integer
        <Display(Name:="Cuts Corners")> Public Property CutsCorners As Boolean
        Public Property MoreTimeToAttack As Boolean
        <Display(Name:="Range (In Tiles)")> Public Property TilesCount As Integer
        Public Property Range As Integer
        Public Property Target As Integer
        Public Property PiercingAttack As Boolean
        Public Property SleepAttack As Boolean
        Public Property FaintAttack As Boolean
        Public Property NearbyDamage As Boolean
        Public Sub New(Move As Move, Context As DataContext)
            ID = Move.ID
            Dim hex = Conversion.Hex(Move.ID).PadLeft(4, "0"c)
            IDHexBigEndian = $"0x{hex}"
            IDHexLittleEndian = $"{hex.Substring(2, 2)} {hex.Substring(0, 2)}"
            Name = Move.Name

            PokemonLevelUp = New List(Of PkmLevelUp)
            For Each item In
                From l In Context.LevelUp
                Join p In Context.Pokemon On l.PokemonID Equals p.ID
                Where l.MoveID = Move.ID
                Order By l.PokemonID, l.Level
                Select New With {.PokemonID = l.PokemonID, .PokemonName = p.Name, .Level = l.Level}

                Dim q = (From p In PokemonLevelUp Where p.ID = item.PokemonID).FirstOrDefault
                If q Is Nothing Then
                    PokemonLevelUp.Add(New PkmLevelUp(item.PokemonID, item.PokemonName, {item.Level}))
                Else
                    If Not q.Levels.Contains(item.Level) Then
                        q.Levels.Add(item.Level)
                    End If
                End If
            Next

            MultiHitData = (From m In Context.MoveMultiHits Where m.ID = Move.HitCounterIndex).First

            With Move
                Me.EffectRate = .EffectRate
                Me.HPBellyChangeValue = .HPBellyChangeValue
                Me.TrapFlag = .TrapFlag
                Me.StatusChange = .StatusChange
                Me.StatChangeIndex = .StatChangeIndex
                Me.TypeChange = .TypeChange
                Me.TerrainChange = .TerrainChange
                Me.BaseAccuracy = .BaseAccuracy
                Me.MaxAccuracy = .MaxAccuracy
                Me.SizeTypeMove = .SizeTypeMove
                Me.TypeID = .TypeID
                Me.TypeName = (From t In Context.Types Where t.ID = .TypeID Select t.Name).First
                Me.Attribute = .Attribute
                Me.BaseDamage = .BaseDamage
                Me.MaxDamage = .MaxDamage
                Me.BasePP = .BasePP
                Me.MaxPP = .MaxPP
                Me.CutsCorners = .CutsCorners
                Me.MoreTimeToAttack = .MoreTimeToAttack
                Me.TilesCount = .TilesCount
                Me.Range = .Range
                Me.Target = .Target
                Me.PiercingAttack = .PiercingAttack
                Me.SleepAttack = .SleepAttack
                Me.FaintAttack = .FaintAttack
                Me.NearbyDamage = .NearbyDamage
            End With
        End Sub
    End Class
End Namespace