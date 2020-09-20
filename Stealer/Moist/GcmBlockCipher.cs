using System;

namespace Moist
{
	// Token: 0x02000015 RID: 21
	public class GcmBlockCipher : IAeadBlockCipher
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00004620 File Offset: 0x00002820
		public virtual string AlgorithmName
		{
			get
			{
				return this.iblockCipher_0.AlgorithmName + "/GCM";
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00004637 File Offset: 0x00002837
		public GcmBlockCipher(IBlockCipher c)
		{
			Class40.gcO0h7LzslQIW();
			this..ctor(c, null);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00007EC4 File Offset: 0x000060C4
		public GcmBlockCipher(IBlockCipher c, IGcmMultiplier m)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			if (c.GetBlockSize() != 16)
			{
				throw new ArgumentException("cipher required with a block size of " + 16.ToString() + ".");
			}
			if (m == null)
			{
				m = new Tables8kGcmMultiplier();
			}
			this.iblockCipher_0 = c;
			this.igcmMultiplier_0 = m;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004646 File Offset: 0x00002846
		public virtual int GetBlockSize()
		{
			return 16;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00007F28 File Offset: 0x00006128
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
			this.bool_0 = forEncryption;
			this.byte_7 = null;
			if (parameters is AeadParameters)
			{
				AeadParameters aeadParameters = (AeadParameters)parameters;
				this.byte_1 = aeadParameters.GetNonce();
				this.byte_2 = aeadParameters.GetAssociatedText();
				int macSize = aeadParameters.MacSize;
				if (macSize < 96 || macSize > 128 || macSize % 8 != 0)
				{
					throw new ArgumentException("Invalid value for MAC size: " + macSize.ToString());
				}
				this.int_0 = macSize / 8;
				this.keyParameter_0 = aeadParameters.Key;
			}
			else
			{
				if (!(parameters is ParametersWithIV))
				{
					throw new ArgumentException("invalid parameters passed to GCM");
				}
				ParametersWithIV parametersWithIV = (ParametersWithIV)parameters;
				this.byte_1 = parametersWithIV.GetIV();
				this.byte_2 = null;
				this.int_0 = 16;
				this.keyParameter_0 = (KeyParameter)parametersWithIV.Parameters;
			}
			int num = forEncryption ? 16 : (16 + this.int_0);
			this.byte_6 = new byte[num];
			if (this.byte_1 == null || this.byte_1.Length < 1)
			{
				throw new ArgumentException("IV must be at least 1 byte");
			}
			if (this.byte_2 == null)
			{
				this.byte_2 = new byte[0];
			}
			this.iblockCipher_0.Init(true, this.keyParameter_0);
			this.byte_3 = new byte[16];
			this.iblockCipher_0.ProcessBlock(this.byte_3, 0, this.byte_3, 0);
			this.igcmMultiplier_0.Init(this.byte_3);
			this.byte_4 = this.method_3(this.byte_2);
			if (this.byte_1.Length == 12)
			{
				this.byte_5 = new byte[16];
				Array.Copy(this.byte_1, 0, this.byte_5, 0, this.byte_1.Length);
				this.byte_5[15] = 1;
			}
			else
			{
				this.byte_5 = this.method_3(this.byte_1);
				byte[] byte_ = new byte[16];
				GcmBlockCipher.smethod_0((ulong)((long)this.byte_1.Length * 8L), byte_, 8);
				Class8.smethod_9(this.byte_5, byte_);
				this.igcmMultiplier_0.MultiplyH(this.byte_5);
			}
			this.byte_8 = Arrays.Clone(this.byte_4);
			this.byte_9 = Arrays.Clone(this.byte_5);
			this.int_1 = 0;
			this.ulong_0 = 0UL;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00008188 File Offset: 0x00006388
		public virtual byte[] GetMac()
		{
			return Arrays.Clone(this.byte_7);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000081A4 File Offset: 0x000063A4
		public virtual int GetOutputSize(int len)
		{
			int result;
			if (this.bool_0)
			{
				result = len + this.int_1 + this.int_0;
			}
			else
			{
				result = len + this.int_1 - this.int_0;
			}
			return result;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000081DC File Offset: 0x000063DC
		public virtual int GetUpdateOutputSize(int len)
		{
			return (len + this.int_1) / 16 * 16;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000081FC File Offset: 0x000063FC
		public virtual int ProcessByte(byte input, byte[] output, int outOff)
		{
			return this.method_0(input, output, outOff);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00008214 File Offset: 0x00006414
		public virtual int ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
		{
			int num = 0;
			for (int num2 = 0; num2 != len; num2++)
			{
				byte[] array = this.byte_6;
				int num3 = this.int_1;
				this.int_1 = num3 + 1;
				array[num3] = input[inOff + num2];
				if (this.int_1 == this.byte_6.Length)
				{
					this.method_2(this.byte_6, 16, output, outOff + num);
					if (!this.bool_0)
					{
						Array.Copy(this.byte_6, 16, this.byte_6, 0, this.int_0);
					}
					this.int_1 = this.byte_6.Length - 16;
					num += 16;
				}
			}
			return num;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000082BC File Offset: 0x000064BC
		private int method_0(byte byte_10, byte[] byte_11, int int_2)
		{
			byte[] array = this.byte_6;
			int num = this.int_1;
			this.int_1 = num + 1;
			array[num] = byte_10;
			int result;
			if (this.int_1 == this.byte_6.Length)
			{
				this.method_2(this.byte_6, 16, byte_11, int_2);
				if (!this.bool_0)
				{
					Array.Copy(this.byte_6, 16, this.byte_6, 0, this.int_0);
				}
				this.int_1 = this.byte_6.Length - 16;
				result = 16;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00008344 File Offset: 0x00006544
		public int DoFinal(byte[] output, int outOff)
		{
			int num = this.int_1;
			if (!this.bool_0)
			{
				if (num < this.int_0)
				{
					throw new InvalidCipherTextException("data too short");
				}
				num -= this.int_0;
			}
			if (num > 0)
			{
				byte[] array = new byte[16];
				Array.Copy(this.byte_6, 0, array, 0, num);
				this.method_2(array, num, output, outOff);
			}
			byte[] byte_ = new byte[16];
			GcmBlockCipher.smethod_0((ulong)((long)this.byte_2.Length * 8L), byte_, 0);
			GcmBlockCipher.smethod_0(this.ulong_0 * 8UL, byte_, 8);
			Class8.smethod_9(this.byte_8, byte_);
			this.igcmMultiplier_0.MultiplyH(this.byte_8);
			byte[] array2 = new byte[16];
			this.iblockCipher_0.ProcessBlock(this.byte_5, 0, array2, 0);
			Class8.smethod_9(array2, this.byte_8);
			int num2 = num;
			this.byte_7 = new byte[this.int_0];
			Array.Copy(array2, 0, this.byte_7, 0, this.int_0);
			if (this.bool_0)
			{
				Array.Copy(this.byte_7, 0, output, outOff + this.int_1, this.int_0);
				num2 += this.int_0;
			}
			else
			{
				byte[] array3 = new byte[this.int_0];
				Array.Copy(this.byte_6, num, array3, 0, this.int_0);
				if (!Arrays.ConstantTimeAreEqual(this.byte_7, array3))
				{
					throw new InvalidCipherTextException("mac check in GCM failed");
				}
			}
			this.method_1(false);
			return num2;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000464A File Offset: 0x0000284A
		public virtual void Reset()
		{
			this.method_1(true);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000084CC File Offset: 0x000066CC
		private void method_1(bool bool_1)
		{
			this.byte_8 = Arrays.Clone(this.byte_4);
			this.byte_9 = Arrays.Clone(this.byte_5);
			this.int_1 = 0;
			this.ulong_0 = 0UL;
			if (this.byte_6 != null)
			{
				Array.Clear(this.byte_6, 0, this.byte_6.Length);
			}
			if (bool_1)
			{
				this.byte_7 = null;
			}
			this.iblockCipher_0.Reset();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00008548 File Offset: 0x00006748
		private void method_2(byte[] byte_10, int int_2, byte[] byte_11, int int_3)
		{
			int num = 15;
			for (;;)
			{
				bool flag;
				if (num >= 12)
				{
					byte[] array = this.byte_9;
					int num2 = num;
					byte b = array[num2] + 1;
					array[num2] = b;
					flag = (b == 0);
				}
				else
				{
					flag = false;
				}
				if (!flag)
				{
					break;
				}
				num--;
			}
			byte[] array2 = new byte[16];
			this.iblockCipher_0.ProcessBlock(this.byte_9, 0, array2, 0);
			byte[] array3;
			if (this.bool_0)
			{
				Array.Copy(GcmBlockCipher.byte_0, int_2, array2, int_2, 16 - int_2);
				array3 = array2;
			}
			else
			{
				array3 = byte_10;
			}
			for (int i = int_2 - 1; i >= 0; i--)
			{
				byte[] array4 = array2;
				int num3 = i;
				array4[num3] ^= byte_10[i];
				byte_11[int_3 + i] = array2[i];
			}
			Class8.smethod_9(this.byte_8, array3);
			this.igcmMultiplier_0.MultiplyH(this.byte_8);
			this.ulong_0 += (ulong)((long)int_2);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00008620 File Offset: 0x00006820
		private byte[] method_3(byte[] byte_10)
		{
			byte[] array = new byte[16];
			for (int i = 0; i < byte_10.Length; i += 16)
			{
				byte[] destinationArray = new byte[16];
				int length = Math.Min(byte_10.Length - i, 16);
				Array.Copy(byte_10, i, destinationArray, 0, length);
				Class8.smethod_9(array, destinationArray);
				this.igcmMultiplier_0.MultiplyH(array);
			}
			return array;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00004529 File Offset: 0x00002729
		private static void smethod_0(ulong ulong_1, byte[] byte_10, int int_2)
		{
			Class7.smethod_1((uint)(ulong_1 >> 32), byte_10, int_2);
			Class7.smethod_1((uint)ulong_1, byte_10, int_2 + 4);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00004653 File Offset: 0x00002853
		// Note: this type is marked as 'beforefieldinit'.
		static GcmBlockCipher()
		{
			Class40.gcO0h7LzslQIW();
			GcmBlockCipher.byte_0 = new byte[16];
		}

		// Token: 0x04000035 RID: 53
		private static readonly byte[] byte_0;

		// Token: 0x04000036 RID: 54
		private readonly IBlockCipher iblockCipher_0;

		// Token: 0x04000037 RID: 55
		private readonly IGcmMultiplier igcmMultiplier_0;

		// Token: 0x04000038 RID: 56
		private bool bool_0;

		// Token: 0x04000039 RID: 57
		private int int_0;

		// Token: 0x0400003A RID: 58
		private byte[] byte_1;

		// Token: 0x0400003B RID: 59
		private byte[] byte_2;

		// Token: 0x0400003C RID: 60
		private KeyParameter keyParameter_0;

		// Token: 0x0400003D RID: 61
		private byte[] byte_3;

		// Token: 0x0400003E RID: 62
		private byte[] byte_4;

		// Token: 0x0400003F RID: 63
		private byte[] byte_5;

		// Token: 0x04000040 RID: 64
		private byte[] byte_6;

		// Token: 0x04000041 RID: 65
		private byte[] byte_7;

		// Token: 0x04000042 RID: 66
		private byte[] byte_8;

		// Token: 0x04000043 RID: 67
		private byte[] byte_9;

		// Token: 0x04000044 RID: 68
		private int int_1;

		// Token: 0x04000045 RID: 69
		private ulong ulong_0;
	}
}
