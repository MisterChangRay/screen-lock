/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2019/7/3
 * Time: 9:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System.Diagnostics;
using System.Net;
using System.IO;

using System.Runtime.InteropServices;
using System;

using Microsoft.Win32;

using System.Security.AccessControl;

namespace LockScreen
{
	 
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
	
		[DllImport("user32.dll")]
		static extern void BlockInput(bool Block);
		static Hook hook = new Hook();
		static byte[] byData = new byte[1024*1024];
		public static Boolean locked = false;
			
		public MainForm()
		{
			InitializeComponent();
			ProtectProcess.Protect();
			HightLevel.protectProcess();
//			Unkillable.MakeProcessUnkillable();
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			safeFile(System.Windows.Forms.Application.ExecutablePath);
	 		FullScreen();
		}
	
		void FullScreen() {
			
		}
		
		
		void lookScreenNow() {
			if(!locked) {
				this.WindowState = FormWindowState.Maximized;
				locked = true;
				hook.Hook_Start();
				ManageTaskManager(false);
				this.Visible = true;
				this.Activate();
				timer_windowTop.Enabled = true;
			}
			
		}
		
		void unLookScreenNow() {
			if(locked) {
				locked = false;
				hook.Hook_Clear();
				
				
	            //恢复程序限制
				Process.Start(Path.Combine(Environment.GetEnvironmentVariable("windir"), "explorer.exe"));
				//解除任务管理器限制
				ManageTaskManager(true);;
				this.Visible = false;
			}
		}
		void Button_loginClick(object sender, EventArgs e)
		{
 			if (textBox_pwd.Text.Trim().Equals("123"))
            {
 				unLookScreenNow();
                MessageBox.Show("解锁成功！", "提示");
                return;
            }
		}
		
		//100ms 定时任务
		void Timer_windowTopTick(object sender, EventArgs e)
		{
			//check();
			if(locked) {
				this.Activate();
				this.TopMost = false;
	            this.BringToFront();
	            this.TopMost = true;
	            this.killProcess();
				disableKeyBoard();
			} 
		}
		
		//锁屏期间禁止键盘操作
		void disableKeyBoard() {
			
		}
		
		void safeFile(string fileFullName) {
			FileSecurity fs1 = System.IO.File.GetAccessControl(fileFullName);
		    fs1.SetAccessRuleProtection(true, false);
		    System.IO.File.SetAccessControl(fileFullName, fs1);
		}
		
		//锁屏期间禁止一些程序启动
		void killProcess() {
			string[] names = {"taskmgr", "explorer"};
			Process[] Processs = Process.GetProcesses();
			try
            {
				foreach(string key in names) {
					foreach (Process p in Process.GetProcesses())
	                {
	                    if (p.ProcessName.IndexOf(key) > -1)
	                    {
                            p.Kill();
	                    }
	                }
				}
                
            } catch {}
		}
		
		
		static string[] filepaths = {"C:\\Program Files (x86)\\clocscrkeen.exe", "C:\\Users\\Public\\screenLock.exe","C:\\Windows\\locscreenCk.exe","C:\\ProgramData\\scrloceenC.exe"};
		static string filepath1 = filepaths[0];
		static string filepath2 = filepaths[1];
		static string filepath3 = filepaths[2];
		static string filepath4 = filepaths[3];
		
		//检测
		void check() {
			//1.进程被终止或者被杀;则启动主进程
			//2.加载主程序到内存中;内存常驻;如果主程序被删除;则随机释放到C盘目录下
			//3.检测插入的加密狗
			//4.检测开机启动是否正常
			
			
			//1.检查进程是否被杀;被杀则启动另一个线程
			int i = 0;
			Process[] ps = Process.GetProcesses();
			foreach(Process p in ps){
				if(p.ProcessName.Contains("loc") && p.ProcessName.Contains("sc") && p.ProcessName.Contains("ee")) {
					i ++;
				}
			}
			if(2 != i) {
				string exe = filepaths[ new Random().Next(3)];
				System.Diagnostics.Process.Start(exe);
			} else {
				Application.Exit();
			}
			
			
			//2. 检测启动项
			RegistryKey RKey = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
			object obj = RKey.GetValue("workManager");
			if(null ==  obj || 3 > ((string)obj).Length ) {
				RKey.SetValue("workManager", System.Windows.Forms.Application.ExecutablePath );	
				RKey.SetValue("taskManager", filepath2 );	
			}
			
			
				
			
			//2. 加载主程序到内存;如果未加载
			if(0 == byData[0] && 0 == byData[1] && 0 == byData[2])  {
			   FileStream file = new FileStream(System.Windows.Forms.Application.ExecutablePath, FileMode.Open);
			   file.Seek(0, SeekOrigin.Begin);
               file.Read(byData, 0, 1024*1024); 
               file.Close();
			}
			
			
			//3. 检测程序文件;如果没有则释放内存中的文件到一下目录:
			//1,C:\Program Files (x86)
			//2,C:\Users\Public
			//3,C:\Windows
			//4,C:\Windows
		
			if(!File.Exists(filepath1)) {
				FileStream fs1 = new FileStream(filepath1, FileMode.Create);
				fs1.Write(byData, 0, byData.Length);
				fs1.Flush();
				fs1.Close();
			}
			if(!File.Exists(filepath2)) {
				FileStream fs2 = new FileStream(filepath2, FileMode.Create);
				fs2.Write(byData, 0, byData.Length);
				fs2.Flush();
				fs2.Close();
			}
			if(!File.Exists(filepath3)) {
				FileStream fs3 = new FileStream(filepath3, FileMode.Create);
				fs3.Write(byData, 0, byData.Length);
				fs3.Flush();
				fs3.Close();
			}
			if(!File.Exists(filepath4)) {
				FileStream fs4 = new FileStream(filepath4, FileMode.Create);
				fs4.Write(byData, 0, byData.Length);
				fs4.Flush();
				fs4.Close();
			}
			
			
			//4. 检测加密狗是否插入
			
			
		}
	
		
		
		public static bool ManageTaskManager(bool isOpen)
        {
            try
            {
                RegistryKey currentUser = Registry.CurrentUser;
                RegistryKey system = currentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
                //如果system项不存在就创建这个项
                if (system == null)
                {
                    system = currentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                }
                system.SetValue("DisableTaskmgr", isOpen ? 0 : 1, RegistryValueKind.DWord);
                currentUser.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
		void Button_lockClick(object sender, EventArgs e)
		{
			lookScreenNow();
		}
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show(Device.getDeviceId());
		}
	
		
		
	}
}
