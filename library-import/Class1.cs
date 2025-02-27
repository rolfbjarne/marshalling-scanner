using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

[assembly: DisableRuntimeMarshalling ()]

public partial class Class1
{
	[LibraryImport ("libc")]
	public static partial void DoSomething (E nonBlittable);
}

public enum E {
	A, B, C,
}
