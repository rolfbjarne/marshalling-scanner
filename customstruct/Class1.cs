using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

public partial class Class1
{
	[DllImport ("libc")]
	static extern void DoSomething (WithLayout arg);

	[DllImport ("libc")]
	static extern void DoSomething (WithoutLayout arg);
}

[StructLayout (LayoutKind.Sequential)]
public struct WithLayout {
	int A, B, C;
}

public struct WithoutLayout {
	int A, B, C;
}
