using System;
using System.Reflection;

// Token: 0x0200006F RID: 111
internal class Class39
{
	// Token: 0x0600027B RID: 635 RVA: 0x00013324 File Offset: 0x00011524
	internal static void rlL0h7LLlOxGD(int typemdt)
	{
		Type type = Class39.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class39.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	// Token: 0x0600027C RID: 636 RVA: 0x0000446C File Offset: 0x0000266C
	public Class39()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x0600027D RID: 637 RVA: 0x000053DE File Offset: 0x000035DE
	// Note: this type is marked as 'beforefieldinit'.
	static Class39()
	{
		Class40.gcO0h7LzslQIW();
		Class39.module_0 = typeof(Class39).Assembly.ManifestModule;
	}

	// Token: 0x0400012A RID: 298
	internal static Module module_0;

	// Token: 0x02000070 RID: 112
	// (Invoke) Token: 0x0600027F RID: 639
	internal delegate void Delegate0(object o);
}
