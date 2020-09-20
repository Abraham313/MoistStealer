using System;
using System.Reflection;

// Token: 0x0200000E RID: 14
internal class Class1
{
	// Token: 0x0600001D RID: 29 RVA: 0x00002AB0 File Offset: 0x00000CB0
	internal static void MgTkQ4xxgCsu0(int typemdt)
	{
		Type type = Class1.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class1.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	// Token: 0x0600001E RID: 30 RVA: 0x0000223C File Offset: 0x0000043C
	public Class1()
	{
		Class2.ecUkQ4xzjKxn7();
		base..ctor();
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002354 File Offset: 0x00000554
	// Note: this type is marked as 'beforefieldinit'.
	static Class1()
	{
		Class2.ecUkQ4xzjKxn7();
		Class1.module_0 = typeof(Class1).Assembly.ManifestModule;
	}

	// Token: 0x04000010 RID: 16
	internal static Module module_0;

	// Token: 0x0200000F RID: 15
	// (Invoke) Token: 0x06000021 RID: 33
	internal delegate void Delegate0(object o);
}
