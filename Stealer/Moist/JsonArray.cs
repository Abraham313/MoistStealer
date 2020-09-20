using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Moist
{
	// Token: 0x0200003A RID: 58
	public class JsonArray : JsonValue, IList<JsonValue>, ICollection<JsonValue>, IEnumerable<JsonValue>, IEnumerable
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00004AF9 File Offset: 0x00002CF9
		public override int Count
		{
			get
			{
				return this.list_0.Count;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0000466D File Offset: 0x0000286D
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000032 RID: 50
		public sealed override JsonValue this[int index]
		{
			get
			{
				return this.list_0[index];
			}
			set
			{
				this.list_0[index] = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00004B15 File Offset: 0x00002D15
		public override JsonType JsonType
		{
			get
			{
				return JsonType.Array;
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00004B18 File Offset: 0x00002D18
		public JsonArray(params JsonValue[] items)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.list_0 = new List<JsonValue>();
			this.AddRange(items);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00004B37 File Offset: 0x00002D37
		public JsonArray(IEnumerable<JsonValue> items)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			if (items == null)
			{
				throw new ArgumentNullException("items");
			}
			this.list_0 = new List<JsonValue>(items);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00004B61 File Offset: 0x00002D61
		public void Add(JsonValue item)
		{
			if (item == null)
			{
				throw new ArgumentNullException("item");
			}
			this.list_0.Add(item);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00004B80 File Offset: 0x00002D80
		public void AddRange(IEnumerable<JsonValue> items)
		{
			if (items == null)
			{
				throw new ArgumentNullException("items");
			}
			this.list_0.AddRange(items);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00004B9F File Offset: 0x00002D9F
		public void AddRange(params JsonValue[] items)
		{
			if (items != null)
			{
				this.list_0.AddRange(items);
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00004BB3 File Offset: 0x00002DB3
		public void Clear()
		{
			this.list_0.Clear();
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00004BC0 File Offset: 0x00002DC0
		public bool Contains(JsonValue item)
		{
			return this.list_0.Contains(item);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00004BCE File Offset: 0x00002DCE
		public void CopyTo(JsonValue[] array, int arrayIndex)
		{
			this.list_0.CopyTo(array, arrayIndex);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000D844 File Offset: 0x0000BA44
		public int IndexOf(JsonValue item)
		{
			return this.list_0.IndexOf(item);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00004BDD File Offset: 0x00002DDD
		public void Insert(int index, JsonValue item)
		{
			this.list_0.Insert(index, item);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00004BEC File Offset: 0x00002DEC
		public bool Remove(JsonValue item)
		{
			return this.list_0.Remove(item);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00004BFA File Offset: 0x00002DFA
		public void RemoveAt(int index)
		{
			this.list_0.RemoveAt(index);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000D860 File Offset: 0x0000BA60
		public override void Save(Stream stream, bool parsing)
		{
			if (stream == null)
			{
				throw new ArgumentNullException("stream");
			}
			stream.WriteByte(91);
			for (int i = 0; i < this.list_0.Count; i++)
			{
				JsonValue jsonValue = this.list_0[i];
				if (jsonValue != null)
				{
					jsonValue.Save(stream, parsing);
				}
				else
				{
					stream.WriteByte(110);
					stream.WriteByte(117);
					stream.WriteByte(108);
					stream.WriteByte(108);
				}
				if (i < this.Count - 1)
				{
					stream.WriteByte(44);
					stream.WriteByte(32);
				}
			}
			stream.WriteByte(93);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000D900 File Offset: 0x0000BB00
		IEnumerator<JsonValue> IEnumerable<JsonValue>.GetEnumerator()
		{
			return this.list_0.GetEnumerator();
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000D920 File Offset: 0x0000BB20
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.list_0.GetEnumerator();
		}

		// Token: 0x040000C4 RID: 196
		private List<JsonValue> list_0;
	}
}
