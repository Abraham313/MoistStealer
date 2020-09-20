using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Moist
{
	// Token: 0x02000042 RID: 66
	public struct ROW
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00005070 File Offset: 0x00003270
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00005078 File Offset: 0x00003278
		public long ID { get; set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00005081 File Offset: 0x00003281
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00005089 File Offset: 0x00003289
		public string[] RowData { get; set; }

		// Token: 0x040000DD RID: 221
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private long long_0;

		// Token: 0x040000DE RID: 222
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string[] string_0;
	}
}
