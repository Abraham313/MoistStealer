using System;
using System.Runtime.InteropServices;

// Token: 0x02000027 RID: 39
internal class Class11
{
	// Token: 0x060000C1 RID: 193
	[DllImport("vaultcli.dll")]
	public static extern int VaultOpenVault(ref Guid guid_0, uint uint_0, ref IntPtr intptr_0);

	// Token: 0x060000C2 RID: 194
	[DllImport("vaultcli.dll")]
	public static extern int VaultCloseVault(ref IntPtr intptr_0);

	// Token: 0x060000C3 RID: 195
	[DllImport("vaultcli.dll")]
	public static extern int VaultFree(ref IntPtr intptr_0);

	// Token: 0x060000C4 RID: 196
	[DllImport("vaultcli.dll")]
	public static extern int VaultEnumerateVaults(int int_0, ref int int_1, ref IntPtr intptr_0);

	// Token: 0x060000C5 RID: 197
	[DllImport("vaultcli.dll")]
	public static extern int VaultEnumerateItems(IntPtr intptr_0, int int_0, ref int int_1, ref IntPtr intptr_1);

	// Token: 0x060000C6 RID: 198
	[DllImport("vaultcli.dll")]
	public static extern int VaultGetItem(IntPtr intptr_0, ref Guid guid_0, IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, int int_0, ref IntPtr intptr_5);

	// Token: 0x060000C7 RID: 199
	[DllImport("vaultcli.dll", EntryPoint = "VaultGetItem")]
	public static extern int VaultGetItem_1(IntPtr intptr_0, ref Guid guid_0, IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, int int_0, ref IntPtr intptr_4);

	// Token: 0x060000C8 RID: 200 RVA: 0x0000446C File Offset: 0x0000266C
	public Class11()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x02000028 RID: 40
	public enum Enum0
	{

	}

	// Token: 0x02000029 RID: 41
	public enum Enum1
	{

	}

	// Token: 0x0200002A RID: 42
	public struct Struct5
	{
		// Token: 0x04000074 RID: 116
		public Guid guid_0;

		// Token: 0x04000075 RID: 117
		public IntPtr intptr_0;

		// Token: 0x04000076 RID: 118
		public IntPtr intptr_1;

		// Token: 0x04000077 RID: 119
		public IntPtr intptr_2;

		// Token: 0x04000078 RID: 120
		public IntPtr intptr_3;

		// Token: 0x04000079 RID: 121
		public IntPtr intptr_4;

		// Token: 0x0400007A RID: 122
		public ulong ulong_0;

		// Token: 0x0400007B RID: 123
		public uint uint_0;

		// Token: 0x0400007C RID: 124
		public uint uint_1;

		// Token: 0x0400007D RID: 125
		public IntPtr intptr_5;
	}

	// Token: 0x0200002B RID: 43
	public struct Struct6
	{
		// Token: 0x0400007E RID: 126
		public Guid guid_0;

		// Token: 0x0400007F RID: 127
		public IntPtr intptr_0;

		// Token: 0x04000080 RID: 128
		public IntPtr intptr_1;

		// Token: 0x04000081 RID: 129
		public IntPtr intptr_2;

		// Token: 0x04000082 RID: 130
		public IntPtr intptr_3;

		// Token: 0x04000083 RID: 131
		public ulong ulong_0;

		// Token: 0x04000084 RID: 132
		public uint uint_0;

		// Token: 0x04000085 RID: 133
		public uint uint_1;

		// Token: 0x04000086 RID: 134
		public IntPtr intptr_4;
	}

	// Token: 0x0200002C RID: 44
	[StructLayout(LayoutKind.Explicit)]
	public struct Struct7
	{
		// Token: 0x04000087 RID: 135
		[FieldOffset(0)]
		public Class11.Enum1 enum1_0;

		// Token: 0x04000088 RID: 136
		[FieldOffset(8)]
		public Class11.Enum0 enum0_0;
	}
}
