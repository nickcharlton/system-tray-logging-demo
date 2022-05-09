using System;
using System.Drawing;
using System.Windows.Forms;

namespace SystemTrayLoggingDemo
{
    public class SystemTrayApplicationContext : ApplicationContext
    {
        private readonly NotifyIcon _trayIcon;

        public SystemTrayApplicationContext() 
        {
            _trayIcon = new NotifyIcon()
            {
                Icon = new Icon(SystemIcons.Application, 40, 40),
                ContextMenuStrip = new ContextMenuStrip()
                {
                    Items = {new ToolStripMenuItem("Exit", null, Exit)}
                },
                Visible = true
            };
        }

        private void Exit(object? sender, EventArgs e)
        {
            _trayIcon.Visible = false;
            Application.Exit();
        }
    }
}