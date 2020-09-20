using System;

namespace Moist
{
	// Token: 0x0200001E RID: 30
	public class AeadParameters : ICipherParameters
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00004740 File Offset: 0x00002940
		public virtual KeyParameter Key
		{
			get
			{
				return this.keyParameter_0;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00004748 File Offset: 0x00002948
		public virtual int MacSize
		{
			get
			{
				return this.int_0;
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004750 File Offset: 0x00002950
		public AeadParameters(KeyParameter key, int macSize, byte[] nonce, byte[] associatedText)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.keyParameter_0 = key;
			this.byte_1 = nonce;
			this.int_0 = macSize;
			this.byte_0 = associatedText;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000096EC File Offset: 0x000078EC
		public virtual byte[] GetAssociatedText()
		{
			return this.byte_0;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00009704 File Offset: 0x00007904
		public virtual byte[] GetNonce()
		{
			return this.byte_1;
		}

		// Token: 0x04000058 RID: 88
		private readonly byte[] byte_0;

		// Token: 0x04000059 RID: 89
		private readonly byte[] byte_1;

		// Token: 0x0400005A RID: 90
		private readonly KeyParameter keyParameter_0;

		// Token: 0x0400005B RID: 91
		private readonly int int_0;
	}
}
