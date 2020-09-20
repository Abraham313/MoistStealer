using System;
using System.IO;

namespace Moist
{
	// Token: 0x0200003B RID: 59
	public static class JsonExt
	{
		// Token: 0x0600015A RID: 346 RVA: 0x0000D940 File Offset: 0x0000BB40
		public static JsonValue FromJSON(this string json)
		{
			return JsonValue.Load(new StringReader(json));
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000D95C File Offset: 0x0000BB5C
		public static string ToJSON<T>(this T instance)
		{
			return JsonValue.ToJsonValue<T>(instance);
		}
	}
}
