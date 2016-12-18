Imports System.Data.Entity
Namespace Areas.PSMD.Models
    Public Class DataContext
        Inherits Data.Entity.DbContext

        Public Property Pokemon As DbSet(Of Pokemon)
        Public Property Abilities As DbSet(Of Ability)
        Public Property Types As DbSet(Of PkmType)
        Public Property Experience As DbSet(Of ExperienceLevel)
        Public Property Moves As DbSet(Of Move)
        Public Property MoveMultiHits As DbSet(Of MoveMultiHit)
        Public Property LevelUp As DbSet(Of PokemonLevelUp)
        Public Property Items As DbSet(Of Item)
        Public Property GameStrings As DbSet(Of GameString)

        Public Sub New()
            MyBase.New("DefaultConnection")
        End Sub
    End Class
End Namespace