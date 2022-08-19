Namespace SafeNative
	Public Module user32
		Public Sub mouse_event(ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
			RobotSupport.UnsafeNative.user32.mouse_event(dwFlags, dx, dy, cButtons, dwExtraInfo)
		End Sub
		Public Function SetCursorPos(ByVal x As Integer, ByVal y As Integer) As Integer
			Return RobotSupport.UnsafeNative.user32.SetCursorPos(x, y)
		End Function
	End Module
End Namespace