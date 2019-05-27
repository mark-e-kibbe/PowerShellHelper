using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace PowerShellHelper.Models
{
    internal class PowerShellScriptRunner
    {
        private string fileName = "";
        public PowerShellScriptRunner(string scriptName)
        {
            fileName = scriptName;
        }
        
        private string getCompletePath(string scriptName)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"Scripts\", scriptName);

            return path;
        }

        public void RunScript()
        {
            //Get Powershell running with new assembly nuget pack
            using (PowerShell shell = PowerShell.Create())
            {
                string scriptPathToRun = getCompletePath(fileName);
                shell.AddCommand("Get-Content").AddArgument(scriptPathToRun);
                shell.AddCommand("Invoke-Expression");
                shell.Invoke();
            }
        }
    }
}
