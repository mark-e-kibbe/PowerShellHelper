using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using System.Collections.ObjectModel;
using PowerShellHelper.Models;

namespace PowerShellHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRunScript_Click(object sender, EventArgs e)
        {
            PowerShellScriptRunner scriptRunner = new PowerShellScriptRunner("TestScript.ps1");
            scriptRunner.RunScript();
            //Get Powershell running with new assembly nuget pack
            //using (PowerShell shell = PowerShell.Create())
            //{
            //    string fileName = "TestScript.ps1";
            //    string path = Path.Combine(Environment.CurrentDirectory, @"Scripts\", fileName);

            //    //shell.AddCommand("Get-Content " + path + " | Invoke-Expression");
            //    shell.AddCommand("Get-Content").AddArgument(path);
            //    shell.AddCommand("Invoke-Expression");
            //    shell.Invoke();

            //    Console.WriteLine("TEST");
            //    // use "AddParameter" to add a single parameter to the last command/script on the pipeline.
            //    //shell.AddParameter("param1", "parameter 1 value!");

            //}

            //Execute a powershell script
            //string finalPath = "Get-Content " + path + " | Invoke-Expression";
            //System.Diagnostics.Process.Start("PowerShell.exe", finalPath);
        }
    }
}

