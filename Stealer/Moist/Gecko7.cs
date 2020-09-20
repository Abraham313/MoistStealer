using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Moist
{
	// Token: 0x02000033 RID: 51
	public class Gecko7
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000495F File Offset: 0x00002B5F
		public string EntrySalt { get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00004967 File Offset: 0x00002B67
		public string OID { get; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0000496F File Offset: 0x00002B6F
		public string Passwordcheck { get; }

		// Token: 0x060000FF RID: 255 RVA: 0x0000B510 File Offset: 0x00009710
		public Gecko7(string DataToParse)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			int num = int.Parse(DataToParse.Substring(2, 2), NumberStyles.HexNumber) * 2;
			this.EntrySalt = DataToParse.Substring(6, num);
			int num2 = DataToParse.Length - (6 + num + 36);
			this.OID = DataToParse.Substring(6 + num + 36, num2);
			this.Passwordcheck = DataToParse.Substring(6 + num + 4 + num2);
		}

		// Token: 0x040000A6 RID: 166
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly string string_0;

		// Token: 0x040000A7 RID: 167
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly string string_1;

		// Token: 0x040000A8 RID: 168
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly string string_2;
	}
}
