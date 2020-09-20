using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Moist
{
	// Token: 0x02000046 RID: 70
	public struct SZ
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000202 RID: 514 RVA: 0x000050EA File Offset: 0x000032EA
		// (set) Token: 0x06000203 RID: 515 RVA: 0x000050F2 File Offset: 0x000032F2
		public long Size { get; set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000204 RID: 516 RVA: 0x000050FB File Offset: 0x000032FB
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00005103 File Offset: 0x00003303
		public long Type { get; set; }

		// Token: 0x040000EE RID: 238
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private long long_0;

		// Token: 0x040000EF RID: 239
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private long long_1;
	}
}
