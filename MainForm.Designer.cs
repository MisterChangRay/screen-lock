/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2019/7/3
 * Time: 9:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LockScreen
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lable_pwd;
		private System.Windows.Forms.TextBox textBox_pwd;
		private System.Windows.Forms.Button button_login;
		private System.Windows.Forms.Timer timer_windowTop;
		private System.Windows.Forms.Button button_lock;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox_lock;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.lable_pwd = new System.Windows.Forms.Label();
			this.textBox_pwd = new System.Windows.Forms.TextBox();
			this.button_login = new System.Windows.Forms.Button();
			this.timer_windowTop = new System.Windows.Forms.Timer(this.components);
			this.button_lock = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox_lock = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox_lock.SuspendLayout();
			this.SuspendLayout();
			// 
			// lable_pwd
			// 
			this.lable_pwd.Location = new System.Drawing.Point(23, 76);
			this.lable_pwd.Name = "lable_pwd";
			this.lable_pwd.Size = new System.Drawing.Size(118, 73);
			this.lable_pwd.TabIndex = 0;
			this.lable_pwd.Text = "密码：";
			// 
			// textBox_pwd
			// 
			this.textBox_pwd.Location = new System.Drawing.Point(80, 76);
			this.textBox_pwd.Name = "textBox_pwd";
			this.textBox_pwd.Size = new System.Drawing.Size(231, 21);
			this.textBox_pwd.TabIndex = 1;
			this.textBox_pwd.Text = "123";
			// 
			// button_login
			// 
			this.button_login.Location = new System.Drawing.Point(62, 210);
			this.button_login.Name = "button_login";
			this.button_login.Size = new System.Drawing.Size(75, 23);
			this.button_login.TabIndex = 2;
			this.button_login.Text = "解锁";
			this.button_login.UseVisualStyleBackColor = true;
			this.button_login.Click += new System.EventHandler(this.Button_loginClick);
			// 
			// timer_windowTop
			// 
			this.timer_windowTop.Enabled = true;
			this.timer_windowTop.Tick += new System.EventHandler(this.Timer_windowTopTick);
			// 
			// button_lock
			// 
			this.button_lock.Location = new System.Drawing.Point(159, 210);
			this.button_lock.Name = "button_lock";
			this.button_lock.Size = new System.Drawing.Size(75, 23);
			this.button_lock.TabIndex = 3;
			this.button_lock.Text = "锁定";
			this.button_lock.UseVisualStyleBackColor = true;
			this.button_lock.Click += new System.EventHandler(this.Button_lockClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(39, 330);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 34);
			this.button1.TabIndex = 4;
			this.button1.Text = "获取机器码";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// groupBox_lock
			// 
			this.groupBox_lock.Controls.Add(this.textBox_pwd);
			this.groupBox_lock.Controls.Add(this.lable_pwd);
			this.groupBox_lock.Location = new System.Drawing.Point(39, 84);
			this.groupBox_lock.Name = "groupBox_lock";
			this.groupBox_lock.Size = new System.Drawing.Size(402, 210);
			this.groupBox_lock.TabIndex = 5;
			this.groupBox_lock.TabStop = false;
			this.groupBox_lock.Text = "锁屏";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(171, 330);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(122, 34);
			this.button2.TabIndex = 6;
			this.button2.Text = "进程保护";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(299, 330);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(122, 34);
			this.button3.TabIndex = 7;
			this.button3.Text = "文件保护";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 516);
			this.ControlBox = false;
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button_lock);
			this.Controls.Add(this.button_login);
			this.Controls.Add(this.groupBox_lock);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LockScreen";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox_lock.ResumeLayout(false);
			this.groupBox_lock.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}