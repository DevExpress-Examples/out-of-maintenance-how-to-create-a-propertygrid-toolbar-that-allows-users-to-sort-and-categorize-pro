Imports Microsoft.VisualBasic
Imports System
Namespace Sample___Toolbar
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
			Me.commandBar = New DevExpress.XtraBars.Bar()
			Me.barButtonCategorized = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonAlphabetical = New DevExpress.XtraBars.BarButtonItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.propertyGridControl_Renamed = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.propertyGridControl_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager
			' 
			Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.commandBar})
			Me.barManager.DockControls.Add(Me.barDockControlTop)
			Me.barManager.DockControls.Add(Me.barDockControlBottom)
			Me.barManager.DockControls.Add(Me.barDockControlLeft)
			Me.barManager.DockControls.Add(Me.barDockControlRight)
			Me.barManager.Form = Me
			Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonCategorized, Me.barButtonAlphabetical})
			Me.barManager.MaxItemId = 2
			' 
			' commandBar
			' 
			Me.commandBar.BarName = "Tools"
			Me.commandBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top
			Me.commandBar.DockCol = 0
			Me.commandBar.DockRow = 0
			Me.commandBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.commandBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonCategorized), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonAlphabetical)})
			Me.commandBar.OptionsBar.AllowQuickCustomization = False
			Me.commandBar.OptionsBar.DisableCustomization = True
			Me.commandBar.OptionsBar.DrawDragBorder = False
			Me.commandBar.OptionsBar.UseWholeRow = True
			Me.commandBar.Text = "Tools"
			' 
			' barButtonCategorized
			' 
			Me.barButtonCategorized.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.barButtonCategorized.Caption = "Categorized"
			Me.barButtonCategorized.Id = 0
			Me.barButtonCategorized.Name = "barButtonCategorized"
			' 
			' barButtonAlphabetical
			' 
			Me.barButtonAlphabetical.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.barButtonAlphabetical.Caption = "Alphabetical"
			Me.barButtonAlphabetical.Id = 1
			Me.barButtonAlphabetical.Name = "barButtonAlphabetical"
			' 
			' propertyGridControl
			' 
			Me.propertyGridControl_Renamed.Dock = System.Windows.Forms.DockStyle.Fill
			Me.propertyGridControl_Renamed.Location = New System.Drawing.Point(0, 24)
			Me.propertyGridControl_Renamed.Name = "propertyGridControl"
			Me.propertyGridControl_Renamed.ServiceProvider = Nothing
			Me.propertyGridControl_Renamed.Size = New System.Drawing.Size(492, 242)
			Me.propertyGridControl_Renamed.TabIndex = 4
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(492, 266)
			Me.Controls.Add(Me.propertyGridControl_Renamed)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.propertyGridControl_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private barManager As DevExpress.XtraBars.BarManager
		Private commandBar As DevExpress.XtraBars.Bar
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private barButtonCategorized As DevExpress.XtraBars.BarButtonItem
		Private barButtonAlphabetical As DevExpress.XtraBars.BarButtonItem
		Private propertyGridControl_Renamed As DevExpress.XtraVerticalGrid.PropertyGridControl
	End Class
End Namespace

