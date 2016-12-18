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
    Public Class MovesController
        Inherits System.Web.Mvc.Controller

        Private db As New DataContext

        ' GET: Moves
        Function Index() As ActionResult
            Return View(db.Moves.ToList())
        End Function

        ' GET: Moves/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim move As Move = db.Moves.Find(id)
            If IsNothing(move) Then
                Return HttpNotFound()
            End If
            Return View(New MoveDetailsViewModel(move, db))
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
