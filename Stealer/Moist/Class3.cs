using System;
using System.Runtime.InteropServices;

// Token: 0x02000007 RID: 7
internal class Class3
{
	// Token: 0x06000010 RID: 16
	[DllImport("kernel32.dll", BestFitMapping = false, CharSet = CharSet.Unicode)]
	internal static extern IntPtr GetModuleHandle(string string_0);

	// Token: 0x06000011 RID: 17
	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_1, [MarshalAs(UnmanagedType.Bool)] ref bool bool_0);

	// Token: 0x06000012 RID: 18
	[DllImport("user32")]
	public static extern int PostMessage(IntPtr intptr_1, int int_0, IntPtr intptr_2, IntPtr intptr_3);

	// Token: 0x06000013 RID: 19
	[DllImport("user32", CharSet = CharSet.Unicode)]
	public static extern IntPtr FindWindow(string string_0, string string_1);

	// Token: 0x06000014 RID: 20
	[DllImport("user32", CharSet = CharSet.Unicode)]
	public static extern IntPtr FindWindowEx(IntPtr intptr_1, IntPtr intptr_2, string string_0, string string_1);

	// Token: 0x06000015 RID: 21
	[DllImport("kernel32.dll")]
	internal static extern IntPtr ZeroMemory(IntPtr intptr_1, IntPtr intptr_2);

	// Token: 0x06000016 RID: 22
	[DllImport("kernel32.dll")]
	internal unsafe static extern bool VirtualProtect(byte* pByte_0, int int_0, uint uint_0, out uint uint_1);

	// Token: 0x06000017 RID: 23 RVA: 0x0000446C File Offset: 0x0000266C
	public Class3()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00004479 File Offset: 0x00002679
	// Note: this type is marked as 'beforefieldinit'.
	static Class3()
	{
		Class40.gcO0h7LzslQIW();
		Class3.intptr_0 = new IntPtr(-3);
	}

	// Token: 0x0400001E RID: 30
	public static IntPtr intptr_0;
}
