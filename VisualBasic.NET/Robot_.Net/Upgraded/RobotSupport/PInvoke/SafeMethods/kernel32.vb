Namespace SafeNative
	Public Module kernel32
		Public Sub Sleep(ByVal dwMilliseconds As Integer)
			RobotSupport.UnsafeNative.kernel32.Sleep(dwMilliseconds)
		End Sub
	End Module
End Namespace