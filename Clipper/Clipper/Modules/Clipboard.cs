using System;
using System.Threading;
using System.Windows.Forms;

namespace Clipper.Modules
{
	// Token: 0x02000007 RID: 7
	internal sealed class Clipboard
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000025D8 File Offset: 0x000007D8
		public static string GetText()
		{
			string ReturnValue = string.Empty;
			try
			{
				Thread thread = new Thread(delegate()
				{
					ReturnValue = Clipboard.GetText();
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
				thread.Join();
			}
			catch
			{
			}
			return ReturnValue;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002638 File Offset: 0x00000838
		public static void SetText(string text)
		{
			Thread thread = new Thread(delegate()
			{
				try
				{
					Clipboard.SetText(text);
				}
				catch
				{
				}
			});
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			thread.Join();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000223C File Offset: 0x0000043C
		public Clipboard()
		{
			Class2.ecUkQ4xzjKxn7();
			base..ctor();
		}
	}
}
