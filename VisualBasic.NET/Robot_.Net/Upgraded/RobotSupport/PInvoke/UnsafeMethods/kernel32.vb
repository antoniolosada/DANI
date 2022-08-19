Namespace UnsafeNative
	<System.Security.SuppressUnmanagedCodeSecurity> _
	 Public Module kernel32
		Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer)
	End Module
End Namespace