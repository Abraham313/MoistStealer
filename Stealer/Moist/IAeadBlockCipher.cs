using System;

namespace Moist
{
	// Token: 0x02000016 RID: 22
	public interface IAeadBlockCipher
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000077 RID: 119
		string AlgorithmName { get; }

		// Token: 0x06000078 RID: 120
		void Init(bool forEncryption, ICipherParameters parameters);

		// Token: 0x06000079 RID: 121
		int GetBlockSize();

		// Token: 0x0600007A RID: 122
		int ProcessByte(byte input, byte[] outBytes, int outOff);

		// Token: 0x0600007B RID: 123
		int ProcessBytes(byte[] inBytes, int inOff, int len, byte[] outBytes, int outOff);

		// Token: 0x0600007C RID: 124
		int DoFinal(byte[] outBytes, int outOff);

		// Token: 0x0600007D RID: 125
		byte[] GetMac();

		// Token: 0x0600007E RID: 126
		int GetUpdateOutputSize(int len);

		// Token: 0x0600007F RID: 127
		int GetOutputSize(int len);

		// Token: 0x06000080 RID: 128
		void Reset();
	}
}
