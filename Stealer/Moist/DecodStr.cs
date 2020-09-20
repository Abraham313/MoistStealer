using System;
using System.IO;
using System.IO.Compression;

namespace Moist
{
	// Token: 0x02000004 RID: 4
	public static class DecodStr
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000055C4 File Offset: 0x000037C4
		public static string UnPack(string str)
		{
			byte[] array = Convert.FromBase64String(str);
			string result = string.Empty;
			if (array != null && array.Length != 0)
			{
				using (MemoryStream memoryStream = new MemoryStream(array))
				{
					using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
					{
						using (StreamReader streamReader = new StreamReader(gzipStream))
						{
							result = streamReader.ReadToEnd();
						}
					}
				}
			}
			return result;
		}
	}
}
