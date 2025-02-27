using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

public partial class Class1
{
	[DllImport ("libc")]
	static extern void DoSomething (E nonBlittable);
}

public enum E {
	A, B, C,
}
