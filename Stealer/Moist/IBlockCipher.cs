using System;

namespace Moist
{
	// Token: 0x0200001A RID: 26
	public interface IBlockCipher
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000098 RID: 152
		string AlgorithmName { get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000099 RID: 153
		bool IsPartialBlockOkay { get; }

		// Token: 0x0600009A RID: 154
		void Init(bool forEncryption, ICipherParameters parameters);

		// Token: 0x0600009B RID: 155
		int GetBlockSize();

		// Token: 0x0600009C RID: 156
		int ProcessBlock(byte[] inBuf, int inOff, byte[] outBuf, int outOff);

		// Token: 0x0600009D RID: 157
		void Reset();
	}
}
