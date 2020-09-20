using System;

namespace Moist
{
	// Token: 0x02000014 RID: 20
	public class Tables8kGcmMultiplier : IGcmMultiplier
	{
		// Token: 0x06000062 RID: 98 RVA: 0x00007BF8 File Offset: 0x00005DF8
		public void Init(byte[] H)
		{
			this.uint_0[0] = new uint[16][];
			this.uint_0[1] = new uint[16][];
			this.uint_0[0][0] = new uint[4];
			this.uint_0[1][0] = new uint[4];
			this.uint_0[1][8] = Class8.smethod_2(H);
			for (int i = 4; i >= 1; i >>= 1)
			{
				uint[] array = (uint[])this.uint_0[1][i + i].Clone();
				Class8.smethod_4(array);
				this.uint_0[1][i] = array;
			}
			uint[] array2 = (uint[])this.uint_0[1][1].Clone();
			Class8.smethod_4(array2);
			this.uint_0[0][8] = array2;
			for (int j = 4; j >= 1; j >>= 1)
			{
				uint[] array3 = (uint[])this.uint_0[0][j + j].Clone();
				Class8.smethod_4(array3);
				this.uint_0[0][j] = array3;
			}
			int num = 0;
			for (;;)
			{
				for (int k = 2; k < 16; k += k)
				{
					for (int l = 1; l < k; l++)
					{
						uint[] array4 = (uint[])this.uint_0[num][k].Clone();
						Class8.smethod_10(array4, this.uint_0[num][l]);
						this.uint_0[num][k + l] = array4;
					}
				}
				if (++num == 32)
				{
					break;
				}
				if (num > 1)
				{
					this.uint_0[num] = new uint[16][];
					this.uint_0[num][0] = new uint[4];
					for (int m = 8; m > 0; m >>= 1)
					{
						uint[] array5 = (uint[])this.uint_0[num - 2][m].Clone();
						Class8.smethod_5(array5);
						this.uint_0[num][m] = array5;
					}
				}
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00007DD4 File Offset: 0x00005FD4
		public void MultiplyH(byte[] x)
		{
			uint[] array = new uint[4];
			for (int i = 15; i >= 0; i--)
			{
				uint[] array2 = this.uint_0[i + i][(int)(x[i] & 15)];
				array[0] ^= array2[0];
				array[1] ^= array2[1];
				array[2] ^= array2[2];
				array[3] ^= array2[3];
				array2 = this.uint_0[i + i + 1][(x[i] & 240) >> 4];
				array[0] ^= array2[0];
				array[1] ^= array2[1];
				array[2] ^= array2[2];
				array[3] ^= array2[3];
			}
			Class7.smethod_1(array[0], x, 0);
			Class7.smethod_1(array[1], x, 4);
			Class7.smethod_1(array[2], x, 8);
			Class7.smethod_1(array[3], x, 12);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004606 File Offset: 0x00002806
		public Tables8kGcmMultiplier()
		{
			Class40.gcO0h7LzslQIW();
			this.uint_0 = new uint[32][][];
			base..ctor();
		}

		// Token: 0x04000034 RID: 52
		private readonly uint[][][] uint_0;
	}
}
