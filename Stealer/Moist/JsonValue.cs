using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;

namespace Moist
{
	// Token: 0x0200003F RID: 63
	public abstract class JsonValue : IEnumerable
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00004F58 File Offset: 0x00003158
		public virtual int Count
		{
			get
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600018D RID: 397
		public abstract JsonType JsonType { get; }

		// Token: 0x1700003E RID: 62
		public virtual JsonValue this[int index]
		{
			get
			{
				throw new InvalidOperationException();
			}
			set
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x1700003F RID: 63
		public virtual JsonValue this[string key]
		{
			get
			{
				throw new InvalidOperationException();
			}
			set
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000DD88 File Offset: 0x0000BF88
		public static JsonValue Load(Stream stream)
		{
			if (stream == null)
			{
				throw new ArgumentNullException("stream");
			}
			return JsonValue.Load(new StreamReader(stream, true));
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000DDB4 File Offset: 0x0000BFB4
		public static JsonValue Load(TextReader textReader)
		{
			if (textReader == null)
			{
				throw new ArgumentNullException("textReader");
			}
			return JsonValue.ToJsonValue<object>(new JavaScriptReader(textReader).Read());
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00004F5F File Offset: 0x0000315F
		private static IEnumerable<KeyValuePair<string, JsonValue>> smethod_0(IEnumerable<KeyValuePair<string, object>> ienumerable_0)
		{
			JsonValue.<ToJsonPairEnumerable>d__12 <ToJsonPairEnumerable>d__ = new JsonValue.<ToJsonPairEnumerable>d__12(-2);
			<ToJsonPairEnumerable>d__.<>3__kvpc = ienumerable_0;
			return <ToJsonPairEnumerable>d__;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00004F6F File Offset: 0x0000316F
		private static IEnumerable<JsonValue> smethod_1(IEnumerable ienumerable_0)
		{
			JsonValue.<ToJsonValueEnumerable>d__13 <ToJsonValueEnumerable>d__ = new JsonValue.<ToJsonValueEnumerable>d__13(-2);
			<ToJsonValueEnumerable>d__.<>3__arr = ienumerable_0;
			return <ToJsonValueEnumerable>d__;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000DDE4 File Offset: 0x0000BFE4
		public static JsonValue ToJsonValue<T>(T ret)
		{
			JsonValue result;
			T t;
			string value10;
			Uri value18;
			if (ret == null)
			{
				result = null;
			}
			else if ((t = ret) is bool)
			{
				result = new JsonPrimitive((bool)((object)t));
			}
			else if ((t = ret) is byte)
			{
				byte value = (byte)((object)t);
				result = new JsonPrimitive(value);
			}
			else if ((t = ret) is char)
			{
				char value2 = (char)((object)t);
				result = new JsonPrimitive(value2);
			}
			else if ((t = ret) is decimal)
			{
				decimal value3 = (decimal)((object)t);
				result = new JsonPrimitive(value3);
			}
			else if ((t = ret) is double)
			{
				double value4 = (double)((object)t);
				result = new JsonPrimitive(value4);
			}
			else if ((t = ret) is float)
			{
				float value5 = (float)((object)t);
				result = new JsonPrimitive(value5);
			}
			else if ((t = ret) is int)
			{
				int value6 = (int)((object)t);
				result = new JsonPrimitive(value6);
			}
			else if ((t = ret) is long)
			{
				long value7 = (long)((object)t);
				result = new JsonPrimitive(value7);
			}
			else if ((t = ret) is sbyte)
			{
				sbyte value8 = (sbyte)((object)t);
				result = new JsonPrimitive(value8);
			}
			else if ((t = ret) is short)
			{
				short value9 = (short)((object)t);
				result = new JsonPrimitive(value9);
			}
			else if ((value10 = (ret as string)) != null)
			{
				result = new JsonPrimitive(value10);
			}
			else if ((t = ret) is uint)
			{
				uint value11 = (uint)((object)t);
				result = new JsonPrimitive(value11);
			}
			else if ((t = ret) is ulong)
			{
				ulong value12 = (ulong)((object)t);
				result = new JsonPrimitive(value12);
			}
			else if ((t = ret) is ushort)
			{
				ushort value13 = (ushort)((object)t);
				result = new JsonPrimitive(value13);
			}
			else if ((t = ret) is DateTime)
			{
				DateTime value14 = (DateTime)((object)t);
				result = new JsonPrimitive(value14);
			}
			else if ((t = ret) is DateTimeOffset)
			{
				DateTimeOffset value15 = (DateTimeOffset)((object)t);
				result = new JsonPrimitive(value15);
			}
			else if ((t = ret) is Guid)
			{
				Guid value16 = (Guid)((object)t);
				result = new JsonPrimitive(value16);
			}
			else if ((t = ret) is TimeSpan)
			{
				TimeSpan value17 = (TimeSpan)((object)t);
				result = new JsonPrimitive(value17);
			}
			else if ((value18 = (ret as Uri)) != null)
			{
				result = new JsonPrimitive(value18);
			}
			else
			{
				IEnumerable<KeyValuePair<string, object>> enumerable = ret as IEnumerable<KeyValuePair<string, object>>;
				if (enumerable != null)
				{
					result = new JsonObject(JsonValue.smethod_0(enumerable));
				}
				else
				{
					IEnumerable enumerable2 = ret as IEnumerable;
					if (enumerable2 == null)
					{
						if (!(ret is IEnumerable))
						{
							PropertyInfo[] properties = ret.GetType().GetProperties();
							Dictionary<string, object> dictionary = new Dictionary<string, object>();
							PropertyInfo[] array = properties;
							foreach (PropertyInfo propertyInfo in array)
							{
								dictionary.Add(propertyInfo.Name, propertyInfo.GetValue(ret, null).IsNull("null"));
							}
							if (dictionary.Count > 0)
							{
								return new JsonObject(JsonValue.smethod_0(dictionary));
							}
						}
						throw new NotSupportedException(string.Format("Unexpected parser return type: {0}", ret.GetType()));
					}
					result = new JsonArray(JsonValue.smethod_1(enumerable2));
				}
			}
			return result;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000E224 File Offset: 0x0000C424
		public static JsonValue Parse(string jsonString)
		{
			if (jsonString == null)
			{
				throw new ArgumentNullException("jsonString");
			}
			return JsonValue.Load(new StringReader(jsonString));
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00004F58 File Offset: 0x00003158
		public virtual bool ContainsKey(string key)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00004F7F File Offset: 0x0000317F
		public virtual void Save(Stream stream, bool parsing)
		{
			if (stream == null)
			{
				throw new ArgumentNullException("stream");
			}
			this.Save(new StreamWriter(stream), parsing);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00004F9F File Offset: 0x0000319F
		public virtual void Save(TextWriter textWriter, bool parsing)
		{
			if (textWriter == null)
			{
				throw new ArgumentNullException("textWriter");
			}
			this.method_0(textWriter, parsing);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000E250 File Offset: 0x0000C450
		private void method_0(TextWriter textWriter_0, bool bool_0)
		{
			switch (this.JsonType)
			{
			case JsonType.String:
				if (bool_0)
				{
					textWriter_0.Write('"');
				}
				textWriter_0.Write(this.EscapeString(((JsonPrimitive)this).GetFormattedString()));
				if (bool_0)
				{
					textWriter_0.Write('"');
					return;
				}
				return;
			case JsonType.Object:
			{
				textWriter_0.Write('{');
				bool flag = false;
				foreach (KeyValuePair<string, JsonValue> keyValuePair in ((JsonObject)this))
				{
					if (flag)
					{
						textWriter_0.Write(", ");
					}
					textWriter_0.Write('"');
					textWriter_0.Write(this.EscapeString(keyValuePair.Key));
					textWriter_0.Write("\": ");
					if (keyValuePair.Value == null)
					{
						textWriter_0.Write("null");
					}
					else
					{
						keyValuePair.Value.method_0(textWriter_0, bool_0);
					}
					flag = true;
				}
				textWriter_0.Write('}');
				return;
			}
			case JsonType.Array:
			{
				textWriter_0.Write('[');
				bool flag2 = false;
				foreach (JsonValue jsonValue in ((IEnumerable<JsonValue>)((JsonArray)this)))
				{
					if (flag2)
					{
						textWriter_0.Write(", ");
					}
					if (jsonValue != null)
					{
						jsonValue.method_0(textWriter_0, bool_0);
					}
					else
					{
						textWriter_0.Write("null");
					}
					flag2 = true;
				}
				textWriter_0.Write(']');
				return;
			}
			case JsonType.Boolean:
				textWriter_0.Write(this ? "true" : "false");
				return;
			}
			textWriter_0.Write(((JsonPrimitive)this).GetFormattedString());
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000E418 File Offset: 0x0000C618
		public string ToString(bool saving = true)
		{
			StringWriter stringWriter = new StringWriter();
			this.Save(stringWriter, saving);
			return stringWriter.ToString();
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00004F58 File Offset: 0x00003158
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000E43C File Offset: 0x0000C63C
		private bool method_1(string string_0, int int_0)
		{
			char c = string_0[int_0];
			return c < ' ' || c == '"' || c == '\\' || (c >= '\ud800' && c <= '\udbff' && (int_0 == string_0.Length - 1 || string_0[int_0 + 1] < '\udc00' || string_0[int_0 + 1] > '\udfff')) || (c >= '\udc00' && c <= '\udfff' && (int_0 == 0 || string_0[int_0 - 1] < '\ud800' || string_0[int_0 - 1] > '\udbff')) || c == '\u2028' || c == '\u2029' || (c == '/' && int_0 > 0 && string_0[int_0 - 1] == '<');
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000E514 File Offset: 0x0000C714
		public string EscapeString(string src)
		{
			string result;
			if (src == null)
			{
				result = null;
			}
			else
			{
				for (int i = 0; i < src.Length; i++)
				{
					if (this.method_1(src, i))
					{
						StringBuilder stringBuilder = new StringBuilder();
						if (i > 0)
						{
							stringBuilder.Append(src, 0, i);
						}
						return this.method_2(stringBuilder, src, i);
					}
				}
				result = src;
			}
			return result;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000E570 File Offset: 0x0000C770
		private string method_2(StringBuilder stringBuilder_0, string string_0, int int_0)
		{
			int num = int_0;
			for (int i = int_0; i < string_0.Length; i++)
			{
				if (this.method_1(string_0, i))
				{
					stringBuilder_0.Append(string_0, num, i - num);
					char c = string_0[i];
					char c2 = c;
					if (c2 <= '"')
					{
						switch (c2)
						{
						case '\b':
							stringBuilder_0.Append("\\b");
							break;
						case '\t':
							stringBuilder_0.Append("\\t");
							break;
						case '\n':
							stringBuilder_0.Append("\\n");
							break;
						case '\v':
							goto IL_BF;
						case '\f':
							stringBuilder_0.Append("\\f");
							break;
						case '\r':
							stringBuilder_0.Append("\\r");
							break;
						default:
							if (c2 != '"')
							{
								goto IL_BF;
							}
							stringBuilder_0.Append("\\\"");
							break;
						}
					}
					else if (c2 != '/')
					{
						if (c2 != '\\')
						{
							goto IL_BF;
						}
						stringBuilder_0.Append("\\\\");
					}
					else
					{
						stringBuilder_0.Append("\\/");
					}
					IL_103:
					num = i + 1;
					goto IL_107;
					IL_BF:
					stringBuilder_0.Append("\\u");
					stringBuilder_0.Append(((int)string_0[i]).ToString("x04"));
					goto IL_103;
				}
				IL_107:;
			}
			stringBuilder_0.Append(string_0, num, string_0.Length - num);
			return stringBuilder_0.ToString();
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000E6B4 File Offset: 0x0000C8B4
		public static implicit operator JsonValue(bool value)
		{
			return new JsonPrimitive(value);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000E6CC File Offset: 0x0000C8CC
		public static implicit operator JsonValue(byte value)
		{
			return new JsonPrimitive(value);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000E6E4 File Offset: 0x0000C8E4
		public static implicit operator JsonValue(char value)
		{
			return new JsonPrimitive(value);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000E6FC File Offset: 0x0000C8FC
		public static implicit operator JsonValue(decimal value)
		{
			return new JsonPrimitive(value);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000E714 File Offset: 0x0000C914
		public static implicit operator JsonValue(double value)
		{
			return new JsonPrimitive(value);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000E72C File Offset: 0x0000C92C
		public static implicit operator JsonValue(float value)
		{
			return new JsonPrimitive(value);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000E744 File Offset: 0x0000C944
		public static implicit operator JsonValue(int value)
		{
			return new JsonPrimitive(value);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000E75C File Offset: 0x0000C95C
		public static implicit operator JsonValue(long value)
		{
			return new JsonPrimitive(value);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000E774 File Offset: 0x0000C974
		public static implicit operator JsonValue(sbyte value)
		{
			return new JsonPrimitive(value);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000E78C File Offset: 0x0000C98C
		public static implicit operator JsonValue(short value)
		{
			return new JsonPrimitive(value);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000E7A4 File Offset: 0x0000C9A4
		public static implicit operator JsonValue(string value)
		{
			return new JsonPrimitive(value);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000E7BC File Offset: 0x0000C9BC
		public static implicit operator JsonValue(uint value)
		{
			return new JsonPrimitive(value);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000E7D4 File Offset: 0x0000C9D4
		public static implicit operator JsonValue(ulong value)
		{
			return new JsonPrimitive(value);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000E7EC File Offset: 0x0000C9EC
		public static implicit operator JsonValue(ushort value)
		{
			return new JsonPrimitive(value);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000E804 File Offset: 0x0000CA04
		public static implicit operator JsonValue(DateTime value)
		{
			return new JsonPrimitive(value);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000E81C File Offset: 0x0000CA1C
		public static implicit operator JsonValue(DateTimeOffset value)
		{
			return new JsonPrimitive(value);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000E834 File Offset: 0x0000CA34
		public static implicit operator JsonValue(Guid value)
		{
			return new JsonPrimitive(value);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000E84C File Offset: 0x0000CA4C
		public static implicit operator JsonValue(TimeSpan value)
		{
			return new JsonPrimitive(value);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000E864 File Offset: 0x0000CA64
		public static implicit operator JsonValue(Uri value)
		{
			return new JsonPrimitive(value);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00004FBA File Offset: 0x000031BA
		public static implicit operator bool(JsonValue value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToBoolean(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000E87C File Offset: 0x0000CA7C
		public static implicit operator byte(JsonValue value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToByte(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000E8B4 File Offset: 0x0000CAB4
		public static implicit operator char(JsonValue value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToChar(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000E8EC File Offset: 0x0000CAEC
		public static implicit operator decimal(JsonValue value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToDecimal(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000E924 File Offset: 0x0000CB24
		public static implicit operator double(JsonValue value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToDouble(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000E95C File Offset: 0x0000CB5C
		public static implicit operator float(JsonValue value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToSingle(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000E994 File Offset: 0x0000CB94
		public static implicit operator int(JsonValue value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToInt32(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000E9CC File Offset: 0x0000CBCC
		public static implicit operator long(JsonValue value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToInt64(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000EA04 File Offset: 0x0000CC04
		public static implicit operator sbyte(JsonValue value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToSByte(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000EA3C File Offset: 0x0000CC3C
		public static implicit operator short(JsonValue value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToInt16(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000EA74 File Offset: 0x0000CC74
		public static implicit operator string(JsonValue value)
		{
			return (value != null) ? value.ToString(true) : null;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000EA90 File Offset: 0x0000CC90
		public static implicit operator uint(JsonValue value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToUInt32(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000EAC8 File Offset: 0x0000CCC8
		public static implicit operator ulong(JsonValue value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToUInt64(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000EB00 File Offset: 0x0000CD00
		public static implicit operator ushort(JsonValue value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToUInt16(((JsonPrimitive)value).Value, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000EB38 File Offset: 0x0000CD38
		public static implicit operator DateTime(JsonValue value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return (DateTime)((JsonPrimitive)value).Value;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000EB68 File Offset: 0x0000CD68
		public static implicit operator DateTimeOffset(JsonValue value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return (DateTimeOffset)((JsonPrimitive)value).Value;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000EB98 File Offset: 0x0000CD98
		public static implicit operator TimeSpan(JsonValue value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return (TimeSpan)((JsonPrimitive)value).Value;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000EBC8 File Offset: 0x0000CDC8
		public static implicit operator Guid(JsonValue value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return (Guid)((JsonPrimitive)value).Value;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
		public static implicit operator Uri(JsonValue value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return (Uri)((JsonPrimitive)value).Value;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000446C File Offset: 0x0000266C
		protected JsonValue()
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
		}
	}
}
