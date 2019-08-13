## Screen-Lock
一个基础版本基于windows屏幕锁
主要用于windows锁屏,想用的同学可以根据此用例进行扩展
此用例某些功能未做实现, 想做的同学可以自行扩展
某些基于驱动级的保护功能没有释放代码,想要的可以联系本人(不免费开放)

##### 已实现功能
* 锁屏
* 解锁
* 锁屏后屏蔽alt+f4
* 锁屏后屏蔽任务管理器
* 锁屏后将进程标记为不稳定进程
* 锁屏后结束explorer.exe
* 锁屏后进程被杀死直接蓝屏
* 以上限制将会在解锁后恢复
* winxp 锁屏后保护进程不被任务管理器杀死
* 程序启动后提升文件权限,不能被当前用户删除

##### 开发测试环境:
* c#
* win7-32/win7-64/winxp
* SharpDevelop 5.1



##### 其他资料

- (windows系统提权漏洞)https://github.com/SecWiki/windows-kernel-exploits
  此插件可以通过一些常见的系统漏洞对程序进行提权
- (windows驱动级别保护)https://github.com/JKornev/hidden
  此插件可以通过驱动对进程/文件/目录等进行监控和拦截
- (一个有意思的锁屏插件)https://github.com/wmhilton/lock-screen
  这个仅为个人推荐