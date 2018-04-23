Imports Microsoft.VisualBasic
Imports System
Namespace ChangeDisplayNameForCalculatedField
	Partial Public Class XtraReport1
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

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.nwindDataSet1 = New ChangeDisplayNameForCalculatedField.nwindDataSet()
			Me.productsTableAdapter = New ChangeDisplayNameForCalculatedField.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.OrderValue = New DevExpress.XtraReports.UI.CalculatedField()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrLabel1})
			Me.Detail.Height = 50
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageHeader
			' 
			Me.PageHeader.Height = 30
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageFooter
			' 
			Me.PageFooter.Height = 30
			Me.PageFooter.Name = "PageFooter"
			Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' OrderValue
			' 
			Me.OrderValue.DataMember = "Products"
			Me.OrderValue.DataSource = Me.nwindDataSet1
			Me.OrderValue.Expression = "[UnitPrice] * [UnitsOnOrder]"
			Me.OrderValue.Name = "OrderValue"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName", "")})
			Me.xrLabel1.Location = New System.Drawing.Point(0, 0)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel1.Size = New System.Drawing.Size(358, 42)
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.OrderValue", "")})
			Me.xrLabel2.Location = New System.Drawing.Point(442, 0)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel2.Size = New System.Drawing.Size(175, 42)
			Me.xrLabel2.Text = "xrLabel2"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter})
			Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.OrderValue})
			Me.DataAdapter = Me.productsTableAdapter
			Me.DataMember = "Products"
			Me.DataSource = Me.nwindDataSet1
			Me.Version = "9.1"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private nwindDataSet1 As nwindDataSet
		Private productsTableAdapter As ChangeDisplayNameForCalculatedField.nwindDataSetTableAdapters.ProductsTableAdapter
		Private OrderValue As DevExpress.XtraReports.UI.CalculatedField
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
