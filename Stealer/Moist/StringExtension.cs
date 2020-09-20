using System;
using System.Globalization;
using System.Text;

namespace Moist
{
	// Token: 0x02000045 RID: 69
	public static class StringExtension
	{
		// Token: 0x060001F4 RID: 500 RVA: 0x00010058 File Offset: 0x0000E258
		public static T ForceTo<T>(this object @this)
		{
			return (T)((object)Convert.ChangeType(@this, typeof(T)));
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0001007C File Offset: 0x0000E27C
		public static string Remove(this string input, string strToRemove)
		{
			string result;
			if (input.IsNullOrEmpty())
			{
				result = null;
			}
			else
			{
				result = input.Replace(strToRemove, "");
			}
			return result;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000100A4 File Offset: 0x0000E2A4
		public static string Left(this string input, int minusRight = 1)
		{
			string result;
			if (input.IsNullOrEmpty() || input.Length <= minusRight)
			{
				result = null;
			}
			else
			{
				result = input.Substring(0, input.Length - minusRight);
			}
			return result;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000100E0 File Offset: 0x0000E2E0
		public static CultureInfo ToCultureInfo(this string culture, CultureInfo defaultCulture)
		{
			CultureInfo result;
			if (!culture.IsNullOrEmpty())
			{
				result = defaultCulture;
			}
			else
			{
				result = new CultureInfo(culture);
			}
			return result;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00010104 File Offset: 0x0000E304
		public static string ToCamelCasing(this string value)
		{
			string result;
			if (!string.IsNullOrEmpty(value))
			{
				result = value.Substring(0, 1).ToUpper() + value.Substring(1, value.Length - 1);
			}
			else
			{
				result = value;
			}
			return result;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00010144 File Offset: 0x0000E344
		public static double? ToDouble(this string value, string culture = "en-US")
		{
			double? result;
			try
			{
				result = new double?(double.Parse(value, new CultureInfo(culture)));
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00010184 File Offset: 0x0000E384
		public static bool? ToBoolean(this string value)
		{
			bool value2 = false;
			bool? result;
			if (bool.TryParse(value, out value2))
			{
				result = new bool?(value2);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000101B4 File Offset: 0x0000E3B4
		public static int? ToInt32(this string value)
		{
			int value2 = 0;
			int? result;
			if (int.TryParse(value, out value2))
			{
				result = new int?(value2);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000101E4 File Offset: 0x0000E3E4
		public static long? ToInt64(this string value)
		{
			long value2 = 0L;
			long? result;
			if (long.TryParse(value, out value2))
			{
				result = new long?(value2);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0001021C File Offset: 0x0000E41C
		public static string AddQueyString(this string url, string queryStringKey, string queryStringValue)
		{
			string text = (url.Split(new char[]
			{
				'?'
			}).Length <= 1) ? "?" : "&";
			return string.Concat(new string[]
			{
				url,
				text,
				queryStringKey,
				"=",
				queryStringValue
			});
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00010278 File Offset: 0x0000E478
		public static string FormatFirstLetterUpperCase(this string value, string culture = "en-US")
		{
			return CultureInfo.GetCultureInfo(culture).TextInfo.ToTitleCase(value);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00010298 File Offset: 0x0000E498
		public static string FillLeftWithZeros(this string value, int decimalDigits)
		{
			if (!string.IsNullOrEmpty(value))
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(value);
				string[] array = value.Split(new char[]
				{
					','
				});
				for (int i = array[array.Length - 1].Length; i < decimalDigits; i++)
				{
					stringBuilder.Append("0");
				}
				value = stringBuilder.ToString();
			}
			return value;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00010300 File Offset: 0x0000E500
		public static string FormatWithDecimalDigits(this string value, bool removeCurrencySymbol, bool returnZero, int? decimalDigits)
		{
			string result;
			if (value.IsNullOrEmpty())
			{
				result = value;
			}
			else
			{
				if (!value.IndexOf(",").Equals(-1))
				{
					string[] array = value.Split(new char[]
					{
						','
					});
					if (array.Length.Equals(2) && array[1].Length > 0)
					{
						value = array[0] + "," + array[1].Substring(0, (array[1].Length >= decimalDigits.Value) ? decimalDigits.Value : array[1].Length);
					}
				}
				if (decimalDigits == null)
				{
					result = value;
				}
				else
				{
					result = value.FillLeftWithZeros(decimalDigits.Value);
				}
			}
			return result;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000103C0 File Offset: 0x0000E5C0
		public static string FormatWithoutDecimalDigits(this string value, bool removeCurrencySymbol, bool returnZero, int? decimalDigits, CultureInfo culture)
		{
			if (removeCurrencySymbol)
			{
				value = value.Remove(culture.NumberFormat.CurrencySymbol).Trim();
			}
			return value;
		}
	}
}
