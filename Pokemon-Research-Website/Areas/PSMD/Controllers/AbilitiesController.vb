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
    Public Class AbilitiesController
        Inherits System.Web.Mvc.Controller

        Private db As New DataContext

        ' GET: Abilities
        Function Index() As ActionResult
            Return View(db.Abilities.ToList())
        End Function

        ' GET: Abilities/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim ability As Ability = db.Abilities.Find(id)
            If IsNothing(ability) Then
                Return HttpNotFound()
            End If
            Return View(New AbilityDetailsViewModel(ability, db))
        End Function

    End Class
End Namespace
