using System;

namespace Moist
{
	// Token: 0x02000038 RID: 56
	public static class IsNullExtension
	{
		// Token: 0x06000130 RID: 304 RVA: 0x00004AAF File Offset: 0x00002CAF
		public static bool IsNotNull<T>(this T data)
		{
			return data != null;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		public static string IsNull(this string value, string defaultValue)
		{
			string result;
			if (!string.IsNullOrEmpty(value))
			{
				result = value;
			}
			else
			{
				result = defaultValue;
			}
			return result;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00004ABA File Offset: 0x00002CBA
		public static bool IsNullOrEmpty(this string str)
		{
			return string.IsNullOrEmpty(str);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000CDE8 File Offset: 0x0000AFE8
		public static bool IsNull(this bool? value, bool def)
		{
			bool result;
			if (value != null)
			{
				result = value.Value;
			}
			else
			{
				result = def;
			}
			return result;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000CE0C File Offset: 0x0000B00C
		public static T IsNull<T>(this T value) where T : class
		{
			T result;
			if (value == null)
			{
				result = Activator.CreateInstance<T>();
			}
			else
			{
				result = value;
			}
			return result;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000CE30 File Offset: 0x0000B030
		public static T IsNull<T>(this T value, T def) where T : class
		{
			T result;
			if (value != null)
			{
				result = value;
			}
			else if (def == null)
			{
				result = Activator.CreateInstance<T>();
			}
			else
			{
				result = def;
			}
			return result;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000CE64 File Offset: 0x0000B064
		public static int IsNull(this int? value, int def)
		{
			int result;
			if (value != null)
			{
				result = value.Value;
			}
			else
			{
				result = def;
			}
			return result;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000CE88 File Offset: 0x0000B088
		public static long IsNull(this long? value, long def)
		{
			long result;
			if (value != null)
			{
				result = value.Value;
			}
			else
			{
				result = def;
			}
			return result;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000CEAC File Offset: 0x0000B0AC
		public static double IsNull(this double? value, double def)
		{
			double result;
			if (value != null)
			{
				result = value.Value;
			}
			else
			{
				result = def;
			}
			return result;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000CED0 File Offset: 0x0000B0D0
		public static DateTime IsNull(this DateTime? value, DateTime def)
		{
			DateTime result;
			if (value != null)
			{
				result = value.Value;
			}
			else
			{
				result = def;
			}
			return result;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000CEF4 File Offset: 0x0000B0F4
		public static Guid IsNull(this Guid? value, Guid def)
		{
			Guid result;
			if (value != null)
			{
				result = value.Value;
			}
			else
			{
				result = def;
			}
			return result;
		}
	}
}
