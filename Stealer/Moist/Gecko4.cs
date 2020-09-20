using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Moist
{
	// Token: 0x02000030 RID: 48
	public class Gecko4
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00004815 File Offset: 0x00002A15
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000481D File Offset: 0x00002A1D
		public Gecko2 ObjectType { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00004826 File Offset: 0x00002A26
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x0000482E File Offset: 0x00002A2E
		public byte[] ObjectData { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00004837 File Offset: 0x00002A37
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000483F File Offset: 0x00002A3F
		public int ObjectLength { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00004848 File Offset: 0x00002A48
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00004850 File Offset: 0x00002A50
		public List<Gecko4> Objects { get; set; }

		// Token: 0x060000DC RID: 220 RVA: 0x00004859 File Offset: 0x00002A59
		public Gecko4()
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.Objects = new List<Gecko4>();
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000B2B8 File Offset: 0x000094B8
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = new StringBuilder();
			Gecko2 objectType = this.ObjectType;
			Gecko2 gecko = objectType;
			switch (gecko)
			{
			case Gecko2.Integer:
			{
				byte[] objectData = this.ObjectData;
				foreach (byte b in objectData)
				{
					stringBuilder2.AppendFormat("{0:X2}", b);
				}
				stringBuilder.Append("\tINTEGER ").Append(stringBuilder2).AppendLine();
				break;
			}
			case Gecko2.BitString:
			case Gecko2.Null:
				break;
			case Gecko2.OctetString:
			{
				byte[] objectData2 = this.ObjectData;
				foreach (byte b2 in objectData2)
				{
					stringBuilder2.AppendFormat("{0:X2}", b2);
				}
				stringBuilder.Append("\tOCTETSTRING ").AppendLine(stringBuilder2.ToString());
				break;
			}
			case Gecko2.ObjectIdentifier:
			{
				byte[] objectData3 = this.ObjectData;
				foreach (byte b3 in objectData3)
				{
					stringBuilder2.AppendFormat("{0:X2}", b3);
				}
				stringBuilder.Append("\tOBJECTIDENTIFIER ").AppendLine(stringBuilder2.ToString());
				break;
			}
			default:
				if (gecko == Gecko2.Sequence)
				{
					stringBuilder.AppendLine("SEQUENCE {");
				}
				break;
			}
			foreach (Gecko4 gecko2 in this.Objects)
			{
				stringBuilder.Append(gecko2.ToString());
			}
			if (this.ObjectType == Gecko2.Sequence)
			{
				stringBuilder.AppendLine("}");
			}
			stringBuilder2.Remove(0, stringBuilder2.Length - 1);
			return stringBuilder.ToString();
		}

		// Token: 0x04000094 RID: 148
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Gecko2 gecko2_0;

		// Token: 0x04000095 RID: 149
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private byte[] byte_0;

		// Token: 0x04000096 RID: 150
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_0;

		// Token: 0x04000097 RID: 151
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private List<Gecko4> list_0;
	}
}
