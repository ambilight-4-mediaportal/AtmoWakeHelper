using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AtmoWakeHelper
{
    public partial class Form1 : Form
    {
        private static Boolean debugMode = false;

        public Form1()
        {
            InitializeComponent();

            //Start sleep/wake monitor
            monitorPowerState();

            if (isProgramRunning("atmowakehelper", 0) > 1)
            {
                try
                {
                    //Close if already running
                    atmoWakeNotifyIcon.Visible = false;
                    Environment.Exit(0);
                }
                catch { };
            }

            //No need to lookup COM port count as it only adds failure points
            int comPortCounter = 1;

            while (comPortCounter <31)
            {
                cbComPorts.Items.Add("COM" + comPortCounter);
                comPortCounter++;
            }

            //Set com port from user setting
            if (Properties.Settings.Default.comPort != "")
            {
                cbComPorts.Text = Properties.Settings.Default.comPort;
            }
            else
            {
                cbComPorts.SelectedIndex = 0;
            }
        }

        public static int isProgramRunning(string name, int runtime)
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.ToLower().Equals(name))
                {
                    runtime++;
                }
            }
            return runtime;
        }
        private void saveSettings()
        {
            Properties.Settings.Default.Save();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
            e.Cancel = true;
            atmoWakeNotifyIcon.Visible = true;
            this.Hide();
        }

        private void cbComPorts_TextChanged(object sender, EventArgs e)
        {
            cbComPorts.SelectionLength = 0;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                atmoWakeNotifyIcon.Visible = true;
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                if (Properties.Settings.Default.comPort != "")
                {
                    atmoWakeNotifyIcon.Visible = true;
                    this.Hide();
                }
                else
                {
                    atmoWakeNotifyIcon.Visible = false;
                }
            }
            cbComPorts.SelectionLength = 0;
        }

        private void atmoWakeNotifyIcon_Click(object sender, EventArgs e)
        {
                this.WindowState = FormWindowState.Normal;
                this.Show();
        }

        private void btnCloseToTray_Click(object sender, EventArgs e)
        {
            atmoWakeNotifyIcon.Visible = true;
            saveSettings();
            this.Hide();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.comPort != "")
            {
                cbComPorts.SelectionLength = 0;
                Visible = false;
                WindowState = FormWindowState.Minimized;
            }
        }

        private static void monitorPowerState()
        {
            SystemEvents.PowerModeChanged += OnPowerModeChanged;
        }
        private static void OnPowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            if (e.Mode.ToString().ToLower() == "resume")
            {
                string appUSBDeview = @"includes\USBDeview.exe";

                if (File.Exists(appUSBDeview))
                {
                    //Close Atmowin
                    try
                    {
                        Process[] proc = Process.GetProcessesByName("AtmoWinA");
                        proc[0].Kill();
                    }
                    catch (Exception eProcAtmoKill)
                    {
                        logger("Error while closing Atmowin:" + eProcAtmoKill.ToString());
                    }

                    //Disconnect COM port
                    logger("DISconnect " + Properties.Settings.Default.comPort);
                    startProcess(appUSBDeview, "/disable_by_drive " + Properties.Settings.Default.comPort);

                    //Connect COM port
                    logger("CONnect " + Properties.Settings.Default.comPort);
                    startProcess(appUSBDeview, "/enable_by_drive " + Properties.Settings.Default.comPort);

                    //Check if we have enabled Atmowin startup to run after resume
                    if (Properties.Settings.Default.enabledAtmowinStart == true)
                    {
                        //Start Atmowin
                        logger("Starting atmowin..");
                        startProcess("AtmoWinA.exe", "");
                    }
                }
                else
                {
                    MessageBox.Show("Missing needed programs, make sure you have copied the folder 'includes' from the downloaded archive");
                }
            }
        }
        private static void startProcess(string program, string arguments)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = program;
                startInfo.Arguments = arguments;
                Process proc = Process.Start(startInfo);
                proc.WaitForExit(10000);
            }
            catch (Exception eStartProcess)
            {
               
                logger("Error while starting process ( " + program + " ) : " + eStartProcess.ToString());
            }
            //sleep timer to avoid windows being to quick upon COM port unlocking
            Thread.Sleep(2500);
        }
        private static void logger(string logMessage)
        {
            if (debugMode == true)
            {
                MessageBox.Show(logMessage);
            }
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            try
            {
                atmoWakeNotifyIcon.Visible = false;
                Environment.Exit(0);
            }
            catch { };
        }
    }
}
