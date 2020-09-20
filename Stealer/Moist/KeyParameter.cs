using System;

namespace Moist
{
	// Token: 0x02000011 RID: 17
	public class KeyParameter : ICipherParameters
	{
		// Token: 0x06000051 RID: 81 RVA: 0x000045D7 File Offset: 0x000027D7
		public KeyParameter(byte[] key)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this.byte_0 = (byte[])key.Clone();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000078C8 File Offset: 0x00005AC8
		public KeyParameter(byte[] key, int keyOff, int keyLen)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			if (keyOff < 0 || keyOff > key.Length)
			{
				throw new ArgumentOutOfRangeException("keyOff");
			}
			if (keyLen < 0 || keyOff + keyLen > key.Length)
			{
				throw new ArgumentOutOfRangeException("keyLen");
			}
			this.byte_0 = new byte[keyLen];
			Array.Copy(key, keyOff, this.byte_0, 0, keyLen);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00007944 File Offset: 0x00005B44
		public byte[] GetKey()
		{
			return (byte[])this.byte_0.Clone();
		}

		// Token: 0x04000033 RID: 51
		private readonly byte[] byte_0;
	}
}
