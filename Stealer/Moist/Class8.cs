using System;
using Moist;

// Token: 0x02000012 RID: 18
internal abstract class Class8
{
	// Token: 0x06000054 RID: 84 RVA: 0x00007964 File Offset: 0x00005B64
	internal static byte[] smethod_0()
	{
		byte[] array = new byte[16];
		array[0] = 128;
		return array;
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00007984 File Offset: 0x00005B84
	internal static uint[] smethod_1()
	{
		uint[] array = new uint[4];
		array[0] = 2147483648U;
		return array;
	}

	// Token: 0x06000056 RID: 86 RVA: 0x000079A4 File Offset: 0x00005BA4
	internal static uint[] smethod_2(byte[] byte_0)
	{
		return new uint[]
		{
			Class7.smethod_3(byte_0, 0),
			Class7.smethod_3(byte_0, 4),
			Class7.smethod_3(byte_0, 8),
			Class7.smethod_3(byte_0, 12)
		};
	}

	// Token: 0x06000057 RID: 87 RVA: 0x000079E4 File Offset: 0x00005BE4
	internal static void smethod_3(byte[] byte_0, byte[] byte_1)
	{
		byte[] array = Arrays.Clone(byte_0);
		byte[] array2 = new byte[16];
		for (int i = 0; i < 16; i++)
		{
			byte b = byte_1[i];
			for (int j = 7; j >= 0; j--)
			{
				if (((int)b & 1 << j) != 0)
				{
					Class8.smethod_9(array2, array);
				}
				bool flag = (array[15] & 1) > 0;
				Class8.smethod_6(array);
				if (flag)
				{
					byte[] array3 = array;
					int num = 0;
					array3[num] ^= 225;
				}
			}
		}
		Array.Copy(array2, 0, byte_0, 0, 16);
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00007A70 File Offset: 0x00005C70
	internal static void smethod_4(uint[] uint_0)
	{
		bool flag = (uint_0[3] & 1U) > 0U;
		Class8.smethod_7(uint_0);
		if (flag)
		{
			uint_0[0] ^= 3774873600U;
		}
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00007AA0 File Offset: 0x00005CA0
	internal static void smethod_5(uint[] uint_0)
	{
		uint num = uint_0[3];
		Class8.smethod_8(uint_0, 8);
		for (int i = 7; i >= 0; i--)
		{
			if (((ulong)num & (ulong)(1L << (i & 31))) > 0UL)
			{
				uint_0[0] ^= 3774873600U >> 7 - i;
			}
		}
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00007AF8 File Offset: 0x00005CF8
	internal static void smethod_6(byte[] byte_0)
	{
		int num = 0;
		byte b = 0;
		for (;;)
		{
			byte b2 = byte_0[num];
			byte_0[num] = (byte)(b2 >> 1 | (int)b);
			if (++num == 16)
			{
				break;
			}
			b = (byte)(b2 << 7);
		}
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00007B2C File Offset: 0x00005D2C
	internal static void smethod_7(uint[] uint_0)
	{
		int num = 0;
		uint num2 = 0U;
		for (;;)
		{
			uint num3 = uint_0[num];
			uint_0[num] = (num3 >> 1 | num2);
			if (++num == 4)
			{
				break;
			}
			num2 = num3 << 31;
		}
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00007B60 File Offset: 0x00005D60
	internal static void smethod_8(uint[] uint_0, int int_0)
	{
		int num = 0;
		uint num2 = 0U;
		for (;;)
		{
			uint num3 = uint_0[num];
			uint_0[num] = (num3 >> int_0 | num2);
			if (++num == 4)
			{
				break;
			}
			num2 = num3 << 32 - int_0;
		}
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00007B9C File Offset: 0x00005D9C
	internal static void smethod_9(byte[] byte_0, byte[] byte_1)
	{
		for (int i = 15; i >= 0; i--)
		{
			int num = i;
			byte_0[num] ^= byte_1[i];
		}
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00007BCC File Offset: 0x00005DCC
	internal static void smethod_10(uint[] uint_0, uint[] uint_1)
	{
		for (int i = 3; i >= 0; i--)
		{
			uint_0[i] ^= uint_1[i];
		}
	}

	// Token: 0x0600005F RID: 95 RVA: 0x0000446C File Offset: 0x0000266C
	protected Class8()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}
}
