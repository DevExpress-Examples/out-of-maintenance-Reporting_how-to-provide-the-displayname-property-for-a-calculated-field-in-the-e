Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner
' ...

Namespace ChangeDisplayNameForCalculatedField
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim rep As New XtraReport1()
			AddHandler rep.DesignerLoaded, AddressOf rep_DesignerLoaded
			rep.ShowDesignerDialog()
		End Sub

		Private Sub rep_DesignerLoaded(ByVal sender As Object, ByVal e As DesignerLoadedEventArgs)
			Dim svc As ITypeDescriptorFilterService = CType(e.DesignerHost.GetService(GetType(ITypeDescriptorFilterService)), ITypeDescriptorFilterService)
			Dim customSvc As New CustomTypeDescriptorFilterService(svc)
			e.DesignerHost.RemoveService(GetType(ITypeDescriptorFilterService))
			e.DesignerHost.AddService(GetType(ITypeDescriptorFilterService), customSvc)
		End Sub
	End Class

	Friend Class CustomTypeDescriptorFilterService
		Implements ITypeDescriptorFilterService
		Private svc As ITypeDescriptorFilterService
		Public Sub New(ByVal svc As ITypeDescriptorFilterService)
			Me.svc = svc
		End Sub

		#Region "ITypeDescriptorFilterService Members"
		Private Function FilterAttributes(ByVal component As IComponent, ByVal attributes As IDictionary) As Boolean Implements ITypeDescriptorFilterService.FilterAttributes
			Return svc.FilterAttributes(component, attributes)
		End Function
		Private Function FilterEvents(ByVal component As IComponent, ByVal events As IDictionary) As Boolean Implements ITypeDescriptorFilterService.FilterEvents
			Return svc.FilterEvents(component, events)
		End Function
		Private Function FilterProperties(ByVal component As IComponent, ByVal properties As IDictionary) As Boolean Implements ITypeDescriptorFilterService.FilterProperties
			Dim result As Boolean = svc.FilterProperties(component, properties)
			If TypeOf component Is CalculatedField Then
				Dim attributes() As Attribute = { BrowsableAttribute.Yes }
				properties("DisplayName") = TypeDescriptor.CreateProperty(GetType(CalculatedField), CType(properties("DisplayName"), PropertyDescriptor), attributes)
			End If
			Return result
		End Function
		#End Region
	End Class
End Namespace