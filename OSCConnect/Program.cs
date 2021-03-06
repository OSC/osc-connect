﻿using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using OSCConnect.Controllers;
using OSCConnect.Views;
using Microsoft.VisualBasic.ApplicationServices;

namespace OSCConnect
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AweSimMain2());
            App.Run(new ConnectMainForm(args));
        }
    }

    /// <summary>
    /// This inherits from the VB.Net WindowsFormsApplicationBase, which has single-instance funtionality.
    /// This allows me to keep the same application open and still get command line arguments when passed
    /// in to a new instance (which is how we will handle the URI scheme)
    /// </summary>
    internal class App : WindowsFormsApplicationBase
    {
        private static App _app;

        protected override bool OnStartup(StartupEventArgs eventArgs)
        {
            CommandLineController.SaveArgsToSettings(eventArgs.CommandLine);
            return base.OnStartup(eventArgs);
        }

        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
        {
            CommandLineController.SaveArgsToSettings(eventArgs.CommandLine);
            base.OnStartupNextInstance(eventArgs);
        }

        public App()
        {
            IsSingleInstance = true;
            EnableVisualStyles = true;
        }

        public static void Run(ConnectMainForm form)
        {
            _app = new App { MainForm = form };
            _app.StartupNextInstance += NextInstanceHandler;
            _app.Run(Environment.GetCommandLineArgs());
        }

        private static void NextInstanceHandler(object sender, StartupNextInstanceEventArgs e)
        {
            _app.MainForm.WindowState = FormWindowState.Normal;
            _app.MainForm.BringToFront();
        }
    }
}
