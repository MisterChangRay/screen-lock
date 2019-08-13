/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2019/7/9
 * Time: 12:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockScreen
{
	/// <summary>
	/// Description of Unkillable.
	/// </summary>
	public class Unkillable
	{
		[DllImport("ntdll.dll", SetLastError = true)]
	    private static extern void RtlSetProcessIsCritical(UInt32 v1, UInt32 v2, UInt32 v3);
	
	    public static void MakeProcessUnkillable()
	    {
	        Process.EnterDebugMode();
	        RtlSetProcessIsCritical(1, 0, 0);
	    }
	
	    public static void MakeProcessKillable()
	    {
	        RtlSetProcessIsCritical(0, 0, 0);
	    }
		public Unkillable()
		{
			
		}
	}
}
