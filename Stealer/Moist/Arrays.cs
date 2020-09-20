using System;
using System.Text;

namespace Moist
{
	// Token: 0x0200000E RID: 14
	public sealed class Arrays
	{
		// Token: 0x0600002D RID: 45 RVA: 0x0000446C File Offset: 0x0000266C
		private Arrays()
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00007444 File Offset: 0x00005644
		public static bool AreEqual(bool[] a, bool[] b)
		{
			return a == b || (a != null && b != null && Arrays.smethod_0(a, b));
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00007474 File Offset: 0x00005674
		public static bool AreEqual(char[] a, char[] b)
		{
			return a == b || (a != null && b != null && Arrays.smethod_1(a, b));
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000074A4 File Offset: 0x000056A4
		public static bool AreEqual(byte[] a, byte[] b)
		{
			return a == b || (a != null && b != null && Arrays.ByPvOxdyn(a, b));
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000044BF File Offset: 0x000026BF
		[Obsolete("Use 'AreEqual' method instead")]
		public static bool AreSame(byte[] a, byte[] b)
		{
			return Arrays.AreEqual(a, b);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000074D4 File Offset: 0x000056D4
		public static bool ConstantTimeAreEqual(byte[] a, byte[] b)
		{
			int i = a.Length;
			bool result;
			if (i != b.Length)
			{
				result = false;
			}
			else
			{
				int num = 0;
				while (i != 0)
				{
					i--;
					num |= (int)(a[i] ^ b[i]);
				}
				result = (num == 0);
			}
			return result;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00007514 File Offset: 0x00005714
		public static bool AreEqual(int[] a, int[] b)
		{
			return a == b || (a != null && b != null && Arrays.smethod_2(a, b));
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00007544 File Offset: 0x00005744
		private static bool smethod_0(bool[] bool_0, bool[] bool_1)
		{
			int i = bool_0.Length;
			bool result;
			if (i != bool_1.Length)
			{
				result = false;
			}
			else
			{
				while (i != 0)
				{
					i--;
					if (bool_0[i] != bool_1[i])
					{
						return false;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00007584 File Offset: 0x00005784
		private static bool smethod_1(char[] char_0, char[] char_1)
		{
			int i = char_0.Length;
			bool result;
			if (i != char_1.Length)
			{
				result = false;
			}
			else
			{
				while (i != 0)
				{
					i--;
					if (char_0[i] != char_1[i])
					{
						return false;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00007544 File Offset: 0x00005744
		private static bool ByPvOxdyn(byte[] byte_0, byte[] byte_1)
		{
			int i = byte_0.Length;
			bool result;
			if (i != byte_1.Length)
			{
				result = false;
			}
			else
			{
				while (i != 0)
				{
					i--;
					if (byte_0[i] != byte_1[i])
					{
						return false;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000075C4 File Offset: 0x000057C4
		private static bool smethod_2(int[] int_0, int[] int_1)
		{
			int i = int_0.Length;
			bool result;
			if (i != int_1.Length)
			{
				result = false;
			}
			else
			{
				while (i != 0)
				{
					i--;
					if (int_0[i] != int_1[i])
					{
						return false;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00007604 File Offset: 0x00005804
		public static string ToString(object[] a)
		{
			StringBuilder stringBuilder = new StringBuilder(91);
			if (a.Length != 0)
			{
				stringBuilder.Append(a[0]);
				for (int i = 1; i < a.Length; i++)
				{
					stringBuilder.Append(", ").Append(a[i]);
				}
			}
			stringBuilder.Append(']');
			return stringBuilder.ToString();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00007660 File Offset: 0x00005860
		public static int GetHashCode(byte[] data)
		{
			int result;
			if (data == null)
			{
				result = 0;
			}
			else
			{
				int num = data.Length;
				int num2 = num + 1;
				while (--num >= 0)
				{
					num2 *= 257;
					num2 ^= (int)data[num];
				}
				result = num2;
			}
			return result;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000076A0 File Offset: 0x000058A0
		public static byte[] Clone(byte[] data)
		{
			byte[] result;
			if (data != null)
			{
				result = (byte[])data.Clone();
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000076C4 File Offset: 0x000058C4
		public static int[] Clone(int[] data)
		{
			int[] result;
			if (data != null)
			{
				result = (int[])data.Clone();
			}
			else
			{
				result = null;
			}
			return result;
		}
	}
}
