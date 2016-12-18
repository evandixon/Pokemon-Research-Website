Imports System.ComponentModel.DataAnnotations
Namespace Areas.PSMD.Models.ViewModels
    Public Class PokemonDetailsViewModel
        Public Class MoveLevelUp
            Public Property Level As Integer
            Public Property MoveID As Integer
            Public Property MoveName As String
        End Class
        Public Class ExpLevelUp
            Public Property Level As Integer
            Public Property Exp As Integer
            Public Property AddedHP As Integer
            Public Property AddedAttack As Integer
            Public Property AddedSpAttack As Integer
            Public Property AddedDefense As Integer
            Public Property AddedSpDefense As Integer
            Public Property AddedSpeed As Integer
            Public Property TotalHP As Integer
            Public Property TotalAttack As Integer
            Public Property TotalSpAttack As Integer
            Public Property TotalDefense As Integer
            Public Property TotalSpDefense As Integer
            Public Property TotalSpeed As Integer
        End Class
        <Display(Name:="ID")> Public Property ID As Integer

        <Display(Name:="ID (Hex, Big Endian)")> Public Property IDHexBigEndian As String
        <Display(Name:="ID (Hex, Little Endian)")> Public Property IDHexLittleEndian As String
        <Display(Name:="Name")> Public Property Name As String
        <Display(Name:="Pokédex Number")> Public Property DexNumber As Integer
        <Display(Name:="Category")> Public Property Category As Integer
        <Display(Name:="ListNumber1")> Public Property ListNumber1 As Integer
        <Display(Name:="ListNumber2")> Public Property ListNumber2 As Integer
        <Display(Name:="Base HP")> Public Property BaseHP As Integer
        <Display(Name:="Base Attack")> Public Property BaseAttack As Integer
        <Display(Name:="Base Sp. Attack")> Public Property BaseSpAttack As Integer
        <Display(Name:="Base Defense")> Public Property BaseDefense As Integer
        <Display(Name:="Base Sp. Defense")> Public Property BaseSpDefense As Integer
        <Display(Name:="Base Speed")> Public Property BaseSpeed As Integer
        Public Property EvolvesFromEntryID As Integer
        <Display(Name:="Evolves From")> Public Property EvolvesFromName As String
        Public Property Ability1ID As Integer
        Public Property Ability2ID As Integer
        Public Property AbilityHiddenID As Integer

        <Display(Name:="Ability 1")> Public Property Ability1 As String
        <Display(Name:="Ability 2")> Public Property Ability2 As String
        <Display(Name:="Hidden Ability")> Public Property AbilityHidden As String
        <Display(Name:="Type 1")> Public Property Type1 As String
        <Display(Name:="Type 2")> Public Property Type2 As String
        <Display(Name:="Is Mega Evolution")> Public Property IsMegaEvolution As Boolean
        <Display(Name:="Min Evolve Level")> Public Property MinEvolveLevel As Byte
        Public Property MovesLevelUp As List(Of MoveLevelUp)
        Public Property StatLevelUp As List(Of ExpLevelUp)
        Public Sub New(Pkm As Pokemon, Context As DataContext)
            ID = Pkm.ID
            Dim hex = Conversion.Hex(Pkm.ID).PadLeft(4, "0"c)
            IDHexBigEndian = $"0x{hex}"
            IDHexLittleEndian = $"{hex.Substring(2, 2)} {hex.Substring(0, 2)}"
            Name = Pkm.Name
            DexNumber = Pkm.DexNumber
            Category = Pkm.Category
            ListNumber1 = Pkm.ListNumber1
            ListNumber2 = Pkm.ListNumber2
            BaseHP = Pkm.BaseHP
            BaseAttack = Pkm.BaseAttack
            BaseSpAttack = Pkm.BaseSpAttack
            BaseDefense = Pkm.BaseDefense
            BaseSpDefense = Pkm.BaseSpDefense
            BaseSpeed = Pkm.BaseSpeed
            EvolvesFromEntryID = Pkm.EvolvesFromEntry
            EvolvesFromName = (From p In Context.Pokemon Where p.ID = EvolvesFromEntryID Select p.Name).First
            Ability1ID = Pkm.Ability1
            Ability1 = (From a In Context.Abilities Where a.ID = Pkm.Ability1 Select a.Name).First
            Ability2ID = Pkm.Ability2
            Ability2 = (From a In Context.Abilities Where a.ID = Pkm.Ability2 Select a.Name).First
            AbilityHidden = (From a In Context.Abilities Where a.ID = Pkm.AbilityHidden Select a.Name).First
            AbilityHiddenID = Pkm.AbilityHidden
            Type1 = (From t In Context.Types Where t.ID = Pkm.Type1 Select t.Name).First
            Type2 = (From t In Context.Types Where t.ID = Pkm.Type2 Select t.Name).First
            IsMegaEvolution = (Pkm.IsMegaEvolution > 0)
            MinEvolveLevel = Pkm.MinEvolveLevel

            MovesLevelUp = New List(Of MoveLevelUp)
            For Each item In
            From l In Context.LevelUp
            Join m In Context.Moves On l.MoveID Equals m.ID
            Where l.PokemonID = Pkm.ID
            Order By l.Level, m.Name
            Select New MoveLevelUp With {.Level = l.Level, .MoveID = m.ID, .MoveName = m.Name}
                MovesLevelUp.Add(item)
            Next

            StatLevelUp = New List(Of ExpLevelUp)
            Dim attack As Integer = BaseAttack
            Dim defense As Integer = BaseDefense
            Dim spAttack As Integer = BaseSpAttack
            Dim spDefense As Integer = BaseSpDefense
            Dim speed As Integer = BaseSpeed
            Dim hp As Integer = BaseHP
            For Each item In
                From e In Context.Experience
                Where e.ExperienceTableNumber = Pkm.ExpTableNumber
                Order By e.Level
                Dim s As New ExpLevelUp
                s.AddedAttack = item.AddedAttack
                s.AddedDefense = item.AddedDefense
                s.AddedHP = item.AddedHP
                s.AddedSpAttack = item.AddedSpAttack
                s.AddedSpDefense = item.AddedSpDefense
                s.AddedSpeed = item.AddedSpeed
                s.Exp = item.Exp
                s.Level = item.Level

                attack += item.AddedAttack
                defense += item.AddedDefense
                hp += item.AddedHP
                spAttack += item.AddedSpAttack
                spDefense += item.AddedSpDefense
                speed += item.AddedSpeed

                s.TotalAttack = attack
                s.TotalDefense = defense
                s.TotalHP = hp
                s.TotalSpAttack = spAttack
                s.TotalSpDefense = spDefense
                s.TotalSpeed = speed

                StatLevelUp.Add(s)
            Next
        End Sub
    End Class
End Namespace