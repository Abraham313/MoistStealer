using System;

// Token: 0x0200000F RID: 15
internal sealed class Class7
{
	// Token: 0x0600003C RID: 60 RVA: 0x0000446C File Offset: 0x0000266C
	private Class7()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x0600003D RID: 61 RVA: 0x000044C8 File Offset: 0x000026C8
	internal static void smethod_0(uint uint_0, byte[] byte_0)
	{
		byte_0[0] = (byte)(uint_0 >> 24);
		byte_0[1] = (byte)(uint_0 >> 16);
		byte_0[2] = (byte)(uint_0 >> 8);
		byte_0[3] = (byte)uint_0;
	}

	// Token: 0x0600003E RID: 62 RVA: 0x000044E6 File Offset: 0x000026E6
	internal static void smethod_1(uint uint_0, byte[] byte_0, int int_0)
	{
		byte_0[int_0] = (byte)(uint_0 >> 24);
		byte_0[++int_0] = (byte)(uint_0 >> 16);
		byte_0[++int_0] = (byte)(uint_0 >> 8);
		byte_0[++int_0] = (byte)uint_0;
	}

	// Token: 0x0600003F RID: 63 RVA: 0x000076E8 File Offset: 0x000058E8
	internal static uint smethod_2(byte[] byte_0)
	{
		return (uint)((int)byte_0[0] << 24 | (int)byte_0[1] << 16 | (int)byte_0[2] << 8 | (int)byte_0[3]);
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00007710 File Offset: 0x00005910
	internal static uint smethod_3(byte[] byte_0, int int_0)
	{
		return (uint)((int)byte_0[int_0] << 24 | (int)byte_0[++int_0] << 16 | (int)byte_0[++int_0] << 8 | (int)byte_0[++int_0]);
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00007748 File Offset: 0x00005948
	internal static ulong smethod_4(byte[] byte_0)
	{
		uint num = Class7.smethod_2(byte_0);
		uint num2 = Class7.smethod_3(byte_0, 4);
		return (ulong)num << 32 | (ulong)num2;
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00007770 File Offset: 0x00005970
	internal static ulong smethod_5(byte[] byte_0, int int_0)
	{
		uint num = Class7.smethod_3(byte_0, int_0);
		uint num2 = Class7.smethod_3(byte_0, int_0 + 4);
		return (ulong)num << 32 | (ulong)num2;
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00004513 File Offset: 0x00002713
	internal static void smethod_6(ulong ulong_0, byte[] byte_0)
	{
		Class7.smethod_0((uint)(ulong_0 >> 32), byte_0);
		Class7.smethod_1((uint)ulong_0, byte_0, 4);
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00004529 File Offset: 0x00002729
	internal static void smethod_7(ulong ulong_0, byte[] byte_0, int int_0)
	{
		Class7.smethod_1((uint)(ulong_0 >> 32), byte_0, int_0);
		Class7.smethod_1((uint)ulong_0, byte_0, int_0 + 4);
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00004542 File Offset: 0x00002742
	internal static void smethod_8(uint uint_0, byte[] byte_0)
	{
		byte_0[0] = (byte)uint_0;
		byte_0[1] = (byte)(uint_0 >> 8);
		byte_0[2] = (byte)(uint_0 >> 16);
		byte_0[3] = (byte)(uint_0 >> 24);
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00004560 File Offset: 0x00002760
	internal static void smethod_9(uint uint_0, byte[] byte_0, int int_0)
	{
		byte_0[int_0] = (byte)uint_0;
		byte_0[++int_0] = (byte)(uint_0 >> 8);
		byte_0[++int_0] = (byte)(uint_0 >> 16);
		byte_0[++int_0] = (byte)(uint_0 >> 24);
	}

	// Token: 0x06000047 RID: 71 RVA: 0x0000779C File Offset: 0x0000599C
	internal static uint smethod_10(byte[] byte_0)
	{
		return (uint)((int)byte_0[0] | (int)byte_0[1] << 8 | (int)byte_0[2] << 16 | (int)byte_0[3] << 24);
	}

	// Token: 0x06000048 RID: 72 RVA: 0x000077C4 File Offset: 0x000059C4
	internal static uint smethod_11(byte[] byte_0, int int_0)
	{
		return (uint)((int)byte_0[int_0] | (int)byte_0[++int_0] << 8 | (int)byte_0[++int_0] << 16 | (int)byte_0[++int_0] << 24);
	}

	// Token: 0x06000049 RID: 73 RVA: 0x000077FC File Offset: 0x000059FC
	internal static ulong smethod_12(byte[] byte_0)
	{
		uint num = Class7.smethod_10(byte_0);
		return (ulong)Class7.smethod_11(byte_0, 4) << 32 | (ulong)num;
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00007820 File Offset: 0x00005A20
	internal static ulong smethod_13(byte[] byte_0, int int_0)
	{
		uint num = Class7.smethod_11(byte_0, int_0);
		return (ulong)Class7.smethod_11(byte_0, int_0 + 4) << 32 | (ulong)num;
	}

	// Token: 0x0600004B RID: 75 RVA: 0x0000458D File Offset: 0x0000278D
	internal static void smethod_14(ulong ulong_0, byte[] byte_0)
	{
		Class7.smethod_8((uint)ulong_0, byte_0);
		Class7.smethod_9((uint)(ulong_0 >> 32), byte_0, 4);
	}

	// Token: 0x0600004C RID: 76 RVA: 0x000045A3 File Offset: 0x000027A3
	internal static void smethod_15(ulong ulong_0, byte[] byte_0, int int_0)
	{
		Class7.smethod_9((uint)ulong_0, byte_0, int_0);
		Class7.smethod_9((uint)(ulong_0 >> 32), byte_0, int_0 + 4);
	}
}
