﻿Imports System
Imports System.Linq
Imports System.Windows.Data
Imports System.Collections.Generic

Namespace EnumItemsSourceBehaviorExample.Common
	Public Class FilterStringConverter
		Implements IValueConverter

		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			If value Is Nothing Then
				Return Binding.DoNothing
			End If
			Return String.Format("[{0}] = '{1}'", parameter, value)
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function
	End Class
End Namespace
