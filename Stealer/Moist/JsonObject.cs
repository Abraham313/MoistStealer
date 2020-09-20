using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Moist
{
	// Token: 0x0200003C RID: 60
	public class JsonObject : JsonValue, IDictionary<string, JsonValue>, ICollection<KeyValuePair<string, JsonValue>>, IEnumerable<KeyValuePair<string, JsonValue>>, IEnumerable
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00004C08 File Offset: 0x00002E08
		public override int Count
		{
			get
			{
				return this.sortedDictionary_0.Count;
			}
		}

		// Token: 0x17000035 RID: 53
		public sealed override JsonValue this[string key]
		{
			get
			{
				return this.sortedDictionary_0[key];
			}
			set
			{
				this.sortedDictionary_0[key] = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00004C24 File Offset: 0x00002E24
		public override JsonType JsonType
		{
			get
			{
				return JsonType.Object;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00004C27 File Offset: 0x00002E27
		public ICollection<string> Keys
		{
			get
			{
				return this.sortedDictionary_0.Keys;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00004C34 File Offset: 0x00002E34
		public ICollection<JsonValue> Values
		{
			get
			{
				return this.sortedDictionary_0.Values;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0000466D File Offset: 0x0000286D
		bool ICollection<KeyValuePair<string, JsonValue>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00004C41 File Offset: 0x00002E41
		public JsonObject(params KeyValuePair<string, JsonValue>[] items)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.sortedDictionary_0 = new SortedDictionary<string, JsonValue>(StringComparer.Ordinal);
			if (items != null)
			{
				this.AddRange(items);
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00004C6B File Offset: 0x00002E6B
		public JsonObject(IEnumerable<KeyValuePair<string, JsonValue>> items)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			if (items == null)
			{
				throw new ArgumentNullException("items");
			}
			this.sortedDictionary_0 = new SortedDictionary<string, JsonValue>(StringComparer.Ordinal);
			this.AddRange(items);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000D994 File Offset: 0x0000BB94
		public IEnumerator<KeyValuePair<string, JsonValue>> GetEnumerator()
		{
			return this.sortedDictionary_0.GetEnumerator();
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000D9B4 File Offset: 0x0000BBB4
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.sortedDictionary_0.GetEnumerator();
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00004CA0 File Offset: 0x00002EA0
		public void Add(string key, JsonValue value)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this.sortedDictionary_0.Add(key, value);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00004CC0 File Offset: 0x00002EC0
		public void Add(KeyValuePair<string, JsonValue> pair)
		{
			this.Add(pair.Key, pair.Value);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000D9D4 File Offset: 0x0000BBD4
		public void AddRange(IEnumerable<KeyValuePair<string, JsonValue>> items)
		{
			if (items == null)
			{
				throw new ArgumentNullException("items");
			}
			foreach (KeyValuePair<string, JsonValue> keyValuePair in items)
			{
				this.sortedDictionary_0.Add(keyValuePair.Key, keyValuePair.Value);
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00004CD6 File Offset: 0x00002ED6
		public void AddRange(params KeyValuePair<string, JsonValue>[] items)
		{
			this.AddRange(items);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00004CDF File Offset: 0x00002EDF
		public void Clear()
		{
			this.sortedDictionary_0.Clear();
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00004CEC File Offset: 0x00002EEC
		bool ICollection<KeyValuePair<string, JsonValue>>.Contains(KeyValuePair<string, JsonValue> item)
		{
			return ((ICollection<KeyValuePair<string, JsonValue>>)this.sortedDictionary_0).Contains(item);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00004CFA File Offset: 0x00002EFA
		bool ICollection<KeyValuePair<string, JsonValue>>.Remove(KeyValuePair<string, JsonValue> item)
		{
			return ((ICollection<KeyValuePair<string, JsonValue>>)this.sortedDictionary_0).Remove(item);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00004D08 File Offset: 0x00002F08
		public override bool ContainsKey(string key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			return this.sortedDictionary_0.ContainsKey(key);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00004D27 File Offset: 0x00002F27
		public void CopyTo(KeyValuePair<string, JsonValue>[] array, int arrayIndex)
		{
			((ICollection<KeyValuePair<string, JsonValue>>)this.sortedDictionary_0).CopyTo(array, arrayIndex);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00004D36 File Offset: 0x00002F36
		public bool Remove(string key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			return this.sortedDictionary_0.Remove(key);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000DA40 File Offset: 0x0000BC40
		public override void Save(Stream stream, bool parsing)
		{
			if (stream == null)
			{
				throw new ArgumentNullException("stream");
			}
			stream.WriteByte(123);
			foreach (KeyValuePair<string, JsonValue> keyValuePair in this.sortedDictionary_0)
			{
				stream.WriteByte(34);
				byte[] bytes = Encoding.UTF8.GetBytes(base.EscapeString(keyValuePair.Key));
				stream.Write(bytes, 0, bytes.Length);
				stream.WriteByte(34);
				stream.WriteByte(44);
				stream.WriteByte(32);
				if (keyValuePair.Value == null)
				{
					stream.WriteByte(110);
					stream.WriteByte(117);
					stream.WriteByte(108);
					stream.WriteByte(108);
				}
				else
				{
					keyValuePair.Value.Save(stream, parsing);
				}
			}
			stream.WriteByte(125);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00004D55 File Offset: 0x00002F55
		public bool TryGetValue(string key, out JsonValue value)
		{
			return this.sortedDictionary_0.TryGetValue(key, out value);
		}

		// Token: 0x040000C5 RID: 197
		private SortedDictionary<string, JsonValue> sortedDictionary_0;
	}
}
