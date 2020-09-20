using System;

namespace Moist
{
	// Token: 0x02000013 RID: 19
	public interface IGcmMultiplier
	{
		// Token: 0x06000060 RID: 96
		void Init(byte[] H);

		// Token: 0x06000061 RID: 97
		void MultiplyH(byte[] x);
	}
}
