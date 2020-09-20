using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Moist.Properties
{
	// Token: 0x02000068 RID: 104
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	internal class Resources
	{
		// Token: 0x06000275 RID: 629 RVA: 0x0000446C File Offset: 0x0000266C
		internal Resources()
		{
			Class40.gcO0h7LzslQIW();
			base..ctor();
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00013280 File Offset: 0x00011480
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager_0
		{
			get
			{
				if (Resources.resourceManager_0 == null)
				{
					ResourceManager resourceManager = new ResourceManager("Moist.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceManager_0 = resourceManager;
				}
				return Resources.resourceManager_0;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000277 RID: 631 RVA: 0x000132C0 File Offset: 0x000114C0
		// (set) Token: 0x06000278 RID: 632 RVA: 0x000053D6 File Offset: 0x000035D6
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo CultureInfo_0
		{
			get
			{
				return Resources.cultureInfo_0;
			}
			set
			{
				Resources.cultureInfo_0 = value;
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000132D4 File Offset: 0x000114D4
		internal static string smethod_0()
		{
			return Resources.ResourceManager_0.GetString("Domains", Resources.cultureInfo_0);
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600027A RID: 634 RVA: 0x000132F8 File Offset: 0x000114F8
		internal static byte[] DotNetZip
		{
			get
			{
				object @object = Resources.ResourceManager_0.GetObject("DotNetZip", Resources.cultureInfo_0);
				return (byte[])@object;
			}
		}

		// Token: 0x0400011C RID: 284
		private static ResourceManager resourceManager_0;

		// Token: 0x0400011D RID: 285
		private static CultureInfo cultureInfo_0;
	}
}
