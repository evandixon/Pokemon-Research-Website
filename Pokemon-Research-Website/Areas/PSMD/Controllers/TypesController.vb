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
    Public Class TypesController
        Inherits System.Web.Mvc.Controller

        Private db As New DataContext

        ' GET: Types
        Function Index() As ActionResult
            Return View(db.Types.ToList())
        End Function

        ' GET: Types/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim pkmType As PkmType = db.Types.Find(id)
            If IsNothing(pkmType) Then
                Return HttpNotFound()
            End If
            Return View(New TypeDetailsViewModel(pkmType, db))
        End Function
    End Class
End Namespace
