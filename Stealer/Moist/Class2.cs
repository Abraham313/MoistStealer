using System;

// Token: 0x02000005 RID: 5
internal class Class2
{
	// Token: 0x06000006 RID: 6 RVA: 0x00005660 File Offset: 0x00003860
	public static string smethod_0()
	{
		string text = "acegikmoqsuwyBDFHJLNPRTVXZ";
		string text2 = "";
		Random random = new Random();
		int num = random.Next(0, text.Length);
		for (int i = 0; i < num; i++)
		{
			text2 += text[random.Next(10, text.Length)].ToString();
		}
		return text2;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000056C8 File Offset: 0x000038C8
	public static int smethod_1()
	{
		Random random = new Random();
		return random.Next(0, 10);
	}

	// Token: 0x06000008 RID: 8 RVA: 0x000056E8 File Offset: 0x000038E8
	public static int smethod_2()
	{
		Random random = new Random();
		return random.Next(11, 99);
	}

	// Token: 0x06000009 RID: 9 RVA: 0x0000446C File Offset: 0x0000266C
	public Class2()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}
}
