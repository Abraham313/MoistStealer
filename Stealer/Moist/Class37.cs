using System;
using System.Threading;

// Token: 0x02000064 RID: 100
internal class Class37
{
	// Token: 0x06000260 RID: 608 RVA: 0x000130BC File Offset: 0x000112BC
	public static int smethod_0(string string_0)
	{
		new Thread(delegate()
		{
			Class26.smethod_0(string_0);
		}).Start();
		new Thread(delegate()
		{
			Class27.smethod_0(string_0);
		}).Start();
		new Thread(delegate()
		{
			Class28.smethod_0(string_0);
		}).Start();
		new Thread(delegate()
		{
			Class29.smethod_0(string_0);
		}).Start();
		new Thread(delegate()
		{
			Class30.smethod_0(string_0);
		}).Start();
		new Thread(delegate()
		{
			Class31.smethod_0(string_0);
		}).Start();
		new Thread(delegate()
		{
			Class32.smethod_0(string_0);
		}).Start();
		new Thread(delegate()
		{
			Class35.smethod_0(string_0);
		}).Start();
		new Thread(delegate()
		{
			Class36.smethod_0(string_0);
		}).Start();
		new Thread(delegate()
		{
			Class33.smethod_0(string_0);
		}).Start();
		new Thread(delegate()
		{
			Class34.smethod_0(string_0);
		}).Start();
		new Thread(delegate()
		{
			Class38.smethod_0(string_0);
		}).Start();
		return Class37.int_0;
	}

	// Token: 0x06000261 RID: 609 RVA: 0x0000446C File Offset: 0x0000266C
	public Class37()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x04000117 RID: 279
	public static int int_0;
}
