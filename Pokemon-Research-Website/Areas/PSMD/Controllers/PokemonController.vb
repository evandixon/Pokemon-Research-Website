Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Pokemon_Research_Website.Areas.PSMD.Models
Imports Pokemon_Research_Website.Areas.PSMD.Models.ViewModels

Namespace Areas.PSMD.Controllers
    Public Class PokemonController
        Inherits System.Web.Mvc.Controller

        Private db As New DataContext

        ' GET: Pokemons
        Function Index() As ActionResult
            Return View(db.Pokemon.ToList())
        End Function

        ' GET: Pokemons/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim pokemon As New PokemonDetailsViewModel(db.Pokemon.Find(id), db)
            If IsNothing(pokemon) Then
                Return HttpNotFound()
            End If
            Return View(pokemon)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
