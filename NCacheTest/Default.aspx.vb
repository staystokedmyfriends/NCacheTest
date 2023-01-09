Imports System.Net
Imports System.Web.Management
Imports Alachisoft.NCache.Web.Caching
Imports MS.Internal.Xml

Public Class _Default
	Inherits Page

	Public Enum EnumValue
		Value1 = 1
		Value2 = 2
	End Enum

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
	End Sub

	Protected Sub btnCacheWithOutEnum_Click(sender As Object, e As EventArgs)

		Dim NCacheCache As Cache = NCache.InitializeCache("demoCache2")

		Dim dt As New DataTable
		dt.Columns.Add("Name")
		dt.Columns.Add("Description")
		dt.Columns.Add("EnumeratedValue", (New Integer).GetType).DefaultValue = 1
		Dim row As DataRow = dt.NewRow()
		dt.Rows.Add(row)

		NCacheCache.Insert("Test1", dt)

		Dim dtCacheObject As Object = NCacheCache.Get("Test1")
		Dim CacheObjectType As String = dtCacheObject.GetType().ToString()

		txtLog.Text += $"{vbNewLine} btnCacheWithOutEnum_Click: {CacheObjectType}"

	End Sub

	Protected Sub btnCacheWithEnum_Click(sender As Object, e As EventArgs)

		Dim NCacheCache As Cache = NCache.InitializeCache("demoCache2")

		Dim dt As New DataTable
		dt.Columns.Add("Name")
		dt.Columns.Add("Description")
		dt.Columns.Add("EnumeratedValue", (New EnumValue).GetType).DefaultValue = EnumValue.Value1
		Dim row As DataRow = dt.NewRow()
		dt.Rows.Add(row)

		NCacheCache.Insert("Test2", dt)

		Dim dtCacheObject As Object = NCacheCache.Get("Test2")
		Dim CacheObjectType As String = dtCacheObject.GetType().ToString()

		txtLog.Text += $"{vbNewLine} btnCacheWithOutEnum_Click: {CacheObjectType}"

	End Sub

End Class