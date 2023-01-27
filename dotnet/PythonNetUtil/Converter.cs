using System.Reflection;

namespace PythonNetUtil;

public class Converter
{
	public static unsafe IntPtr PointerToIntPtr(Pointer p)
	{
		return (IntPtr)Pointer.Unbox(p);
	}
}
