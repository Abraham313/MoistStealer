using System;
using System.Runtime.InteropServices;

// Token: 0x0200000B RID: 11
internal class Class6
{
	// Token: 0x0600002A RID: 42 RVA: 0x00007288 File Offset: 0x00005488
	public static byte[] smethod_0(byte[] byte_0, byte[] byte_1 = null)
	{
		Class6.Struct0 @struct = default(Class6.Struct0);
		Class6.Struct0 struct2 = default(Class6.Struct0);
		Class6.Struct0 struct3 = default(Class6.Struct0);
		Class6.Struct1 struct4 = new Class6.Struct1
		{
			int_0 = Marshal.SizeOf(typeof(Class6.Struct1)),
			int_1 = 0,
			intptr_0 = IntPtr.Zero,
			string_0 = null
		};
		string empty = string.Empty;
		try
		{
			try
			{
				if (byte_0 == null)
				{
					byte_0 = new byte[0];
				}
				struct2.intptr_0 = Marshal.AllocHGlobal(byte_0.Length);
				struct2.int_0 = byte_0.Length;
				Marshal.Copy(byte_0, 0, struct2.intptr_0, byte_0.Length);
			}
			catch
			{
			}
			try
			{
				if (byte_1 == null)
				{
					byte_1 = new byte[0];
				}
				struct3.intptr_0 = Marshal.AllocHGlobal(byte_1.Length);
				struct3.int_0 = byte_1.Length;
				Marshal.Copy(byte_1, 0, struct3.intptr_0, byte_1.Length);
			}
			catch
			{
			}
			Class6.CryptUnprotectData(ref struct2, ref empty, ref struct3, IntPtr.Zero, ref struct4, 1, ref @struct);
			byte[] array = new byte[@struct.int_0];
			Marshal.Copy(@struct.intptr_0, array, 0, @struct.int_0);
			return array;
		}
		catch
		{
		}
		finally
		{
			if (@struct.intptr_0 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(@struct.intptr_0);
			}
			if (struct2.intptr_0 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(struct2.intptr_0);
			}
			if (struct3.intptr_0 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(struct3.intptr_0);
			}
		}
		return new byte[0];
	}

	// Token: 0x0600002B RID: 43
	[DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref Class6.Struct0 struct0_0, ref string string_0, ref Class6.Struct0 struct0_1, IntPtr intptr_0, ref Class6.Struct1 struct1_0, int int_0, ref Class6.Struct0 struct0_2);

	// Token: 0x0600002C RID: 44 RVA: 0x0000446C File Offset: 0x0000266C
	public Class6()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x0200000C RID: 12
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct Struct0
	{
		// Token: 0x0400002B RID: 43
		public int int_0;

		// Token: 0x0400002C RID: 44
		public IntPtr intptr_0;
	}

	// Token: 0x0200000D RID: 13
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct Struct1
	{
		// Token: 0x0400002D RID: 45
		public int int_0;

		// Token: 0x0400002E RID: 46
		public int int_1;

		// Token: 0x0400002F RID: 47
		public IntPtr intptr_0;

		// Token: 0x04000030 RID: 48
		public string string_0;
	}
}
