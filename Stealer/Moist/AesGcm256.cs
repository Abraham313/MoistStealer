using System;
using System.Text;

namespace Moist
{
	// Token: 0x0200001D RID: 29
	public static class AesGcm256
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x00009650 File Offset: 0x00007850
		public static string Decrypt(byte[] encryptedBytes, byte[] key, byte[] iv)
		{
			string text = string.Empty;
			string result;
			try
			{
				GcmBlockCipher gcmBlockCipher = new GcmBlockCipher(new AesFastEngine());
				AeadParameters parameters = new AeadParameters(new KeyParameter(key), 128, iv, null);
				gcmBlockCipher.Init(false, parameters);
				byte[] array = new byte[gcmBlockCipher.GetOutputSize(encryptedBytes.Length)];
				int outOff = gcmBlockCipher.ProcessBytes(encryptedBytes, 0, encryptedBytes.Length, array, 0);
				gcmBlockCipher.DoFinal(array, outOff);
				text = Encoding.UTF8.GetString(array).TrimEnd("\r\n\0".ToCharArray());
				result = text;
			}
			catch
			{
				result = text;
			}
			return result;
		}
	}
}
