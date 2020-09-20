using System;

namespace Moist
{
	// Token: 0x02000010 RID: 16
	public class ParametersWithIV : ICipherParameters
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000045BC File Offset: 0x000027BC
		public ICipherParameters Parameters
		{
			get
			{
				return this.icipherParameters_0;
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000045C4 File Offset: 0x000027C4
		public ParametersWithIV(ICipherParameters parameters, byte[] iv)
		{
			Class40.gcO0h7LzslQIW();
			this..ctor(parameters, iv, 0, iv.Length);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00007848 File Offset: 0x00005A48
		public ParametersWithIV(ICipherParameters parameters, byte[] iv, int ivOff, int ivLen)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			if (parameters == null)
			{
				throw new ArgumentNullException("parameters");
			}
			if (iv == null)
			{
				throw new ArgumentNullException("iv");
			}
			this.icipherParameters_0 = parameters;
			this.byte_0 = new byte[ivLen];
			Array.Copy(iv, ivOff, this.byte_0, 0, ivLen);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000078A8 File Offset: 0x00005AA8
		public byte[] GetIV()
		{
			return (byte[])this.byte_0.Clone();
		}

		// Token: 0x04000031 RID: 49
		private readonly ICipherParameters icipherParameters_0;

		// Token: 0x04000032 RID: 50
		private readonly byte[] byte_0;
	}
}
