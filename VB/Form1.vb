Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports System.Reflection

Namespace Sample___Toolbar
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			AddHandler Me.barButtonCategorized.DownChanged, AddressOf barButton_DownChanged
			AddHandler Me.barButtonAlphabetical.DownChanged, AddressOf barButton_DownChanged
			SetBarButtonToolTip(Me.barButtonAlphabetical, "Alphabetical")
			SetBarButtonToolTip(Me.barButtonCategorized, "Categorized")
			Me.barButtonCategorized.Glyph = ResourceImageHelper.CreateImageFromResources("Sample___Toolbar.Categorized.png", System.Reflection.Assembly.GetExecutingAssembly())
			Me.barButtonAlphabetical.Glyph = ResourceImageHelper.CreateImageFromResources("Sample___Toolbar.Alphabetical.png", System.Reflection.Assembly.GetExecutingAssembly())
			Me.ShowCategories = True
			PropertyGridControl.SelectedObject = PropertyGridControl
		End Sub
		Public Property ShowCategories() As Boolean
			Get
				Return Me.barButtonCategorized.Down
			End Get
			Set(ByVal value As Boolean)
				Me.barButtonCategorized.Down = value
			End Set
		End Property
		Public ReadOnly Property PropertyGridControl() As PropertyGridControl
			Get
				Return propertyGridControl_Renamed
			End Get
		End Property
		Private Sub barButton_DownChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			If e.Item.Equals(Me.barButtonCategorized) Then
				SetBarButtonDown(Me.barButtonAlphabetical, (Not Me.barButtonCategorized.Down))
			Else
				SetBarButtonDown(Me.barButtonCategorized, (Not Me.barButtonAlphabetical.Down))
			End If
			UpdatePropertyGrid()
		End Sub
		Private Shared Sub SetBarButtonToolTip(ByVal barButton As DevExpress.XtraBars.BarButtonItem, ByVal value As String)
			Dim superToolTip As New SuperToolTip()
			Dim toolTipTitleItem As New ToolTipTitleItem()
			toolTipTitleItem.Text = value
			superToolTip.Items.Add(toolTipTitleItem)
			barButton.SuperTip = superToolTip
		End Sub
		Private Sub SetBarButtonDown(ByVal barButton As BarButtonItem, ByVal value As Boolean)
			RemoveHandler barButton.DownChanged, AddressOf barButton_DownChanged
			barButton.Down = value
			AddHandler barButton.DownChanged, AddressOf barButton_DownChanged
		End Sub
		Private Sub UpdatePropertyGrid()
			Me.propertyGridControl_Renamed.OptionsView.ShowRootCategories = Me.barButtonCategorized.Down
		End Sub
	End Class
End Namespace