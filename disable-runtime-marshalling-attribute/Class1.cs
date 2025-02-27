using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

[assembly: DisableRuntimeMarshalling ()]

public class Class1
{
	[DllImport ("libc")]
	static extern void DoSomething (string nonBlittable);
}

