using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace Moist
{
	// Token: 0x0200003D RID: 61
	public class JsonPrimitive : JsonValue
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00004D64 File Offset: 0x00002F64
		public object Value
		{
			get
			{
				return this.object_0;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000174 RID: 372 RVA: 0x0000DB34 File Offset: 0x0000BD34
		public override JsonType JsonType
		{
			get
			{
				JsonType result;
				if (this.object_0 == null)
				{
					result = JsonType.String;
				}
				else
				{
					TypeCode typeCode = Type.GetTypeCode(this.object_0.GetType());
					TypeCode typeCode2 = typeCode;
					switch (typeCode2)
					{
					case TypeCode.Object:
					case TypeCode.Char:
						goto IL_4C;
					case TypeCode.DBNull:
						break;
					case TypeCode.Boolean:
						return JsonType.Boolean;
					default:
						if (typeCode2 == TypeCode.DateTime || typeCode2 == TypeCode.String)
						{
							goto IL_4C;
						}
						break;
					}
					return JsonType.Number;
					IL_4C:
					result = JsonType.String;
				}
				return result;
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00004D6C File Offset: 0x00002F6C
		public JsonPrimitive(bool value)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.object_0 = value;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00004D85 File Offset: 0x00002F85
		public JsonPrimitive(byte value)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.object_0 = value;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00004D9E File Offset: 0x00002F9E
		public JsonPrimitive(char value)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.object_0 = value;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00004DB7 File Offset: 0x00002FB7
		public JsonPrimitive(decimal value)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.object_0 = value;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00004DD0 File Offset: 0x00002FD0
		public JsonPrimitive(double value)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.object_0 = value;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00004DE9 File Offset: 0x00002FE9
		public JsonPrimitive(float value)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.object_0 = value;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00004E02 File Offset: 0x00003002
		public JsonPrimitive(int value)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.object_0 = value;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00004E1B File Offset: 0x0000301B
		public JsonPrimitive(long value)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.object_0 = value;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00004E34 File Offset: 0x00003034
		public JsonPrimitive(sbyte value)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.object_0 = value;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00004E4D File Offset: 0x0000304D
		public JsonPrimitive(short value)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.object_0 = value;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00004E66 File Offset: 0x00003066
		public JsonPrimitive(string value)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.object_0 = value;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00004E7A File Offset: 0x0000307A
		public JsonPrimitive(DateTime value)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.object_0 = value;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00004E93 File Offset: 0x00003093
		public JsonPrimitive(uint value)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.object_0 = value;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00004EAC File Offset: 0x000030AC
		public JsonPrimitive(ulong value)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.object_0 = value;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00004EC5 File Offset: 0x000030C5
		public JsonPrimitive(ushort value)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.object_0 = value;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00004EDE File Offset: 0x000030DE
		public JsonPrimitive(DateTimeOffset value)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.object_0 = value;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00004EF7 File Offset: 0x000030F7
		public JsonPrimitive(Guid value)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.object_0 = value;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00004F10 File Offset: 0x00003110
		public JsonPrimitive(TimeSpan value)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.object_0 = value;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00004E66 File Offset: 0x00003066
		public JsonPrimitive(Uri value)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.object_0 = value;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00004E66 File Offset: 0x00003066
		public JsonPrimitive(object value)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.object_0 = value;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000DB90 File Offset: 0x0000BD90
		public override void Save(Stream stream, bool parsing)
		{
			JsonType jsonType = this.JsonType;
			JsonType jsonType2 = jsonType;
			if (jsonType2 != JsonType.String)
			{
				if (jsonType2 != JsonType.Boolean)
				{
					byte[] bytes = Encoding.UTF8.GetBytes(this.GetFormattedString());
					stream.Write(bytes, 0, bytes.Length);
				}
				else if ((bool)this.object_0)
				{
					stream.Write(JsonPrimitive.pwnrrNboZt, 0, 4);
				}
				else
				{
					stream.Write(JsonPrimitive.byte_0, 0, 5);
				}
			}
			else
			{
				stream.WriteByte(34);
				byte[] bytes2 = Encoding.UTF8.GetBytes(base.EscapeString(this.object_0.ToString()));
				stream.Write(bytes2, 0, bytes2.Length);
				stream.WriteByte(34);
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000DC30 File Offset: 0x0000BE30
		public string GetFormattedString()
		{
			JsonType jsonType = this.JsonType;
			JsonType jsonType2 = jsonType;
			string result;
			if (jsonType2 != JsonType.String)
			{
				if (jsonType2 != JsonType.Number)
				{
					throw new InvalidOperationException();
				}
				string text = (this.object_0 is float || this.object_0 is double) ? ((IFormattable)this.object_0).ToString("R", NumberFormatInfo.InvariantInfo) : ((IFormattable)this.object_0).ToString("G", NumberFormatInfo.InvariantInfo);
				if (text == "NaN" || text == "Infinity" || text == "-Infinity")
				{
					result = "\"" + text + "\"";
				}
				else
				{
					result = text;
				}
			}
			else if (this.object_0 is string || this.object_0 == null)
			{
				string text2 = this.object_0 as string;
				if (string.IsNullOrEmpty(text2))
				{
					result = "null";
				}
				else
				{
					result = text2.Trim(new char[]
					{
						'"'
					});
				}
			}
			else
			{
				if (!(this.object_0 is char))
				{
					string str = "GetFormattedString from value type ";
					Type type = this.object_0.GetType();
					throw new NotImplementedException(str + ((type != null) ? type.ToString() : null));
				}
				result = this.object_0.ToString();
			}
			return result;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00004F29 File Offset: 0x00003129
		// Note: this type is marked as 'beforefieldinit'.
		static JsonPrimitive()
		{
			Class40.gcO0h7LzslQIW();
			JsonPrimitive.pwnrrNboZt = Encoding.UTF8.GetBytes("true");
			JsonPrimitive.byte_0 = Encoding.UTF8.GetBytes("false");
		}

		// Token: 0x040000C6 RID: 198
		private object object_0;

		// Token: 0x040000C7 RID: 199
		private static readonly byte[] pwnrrNboZt;

		// Token: 0x040000C8 RID: 200
		private static readonly byte[] byte_0;
	}
}
