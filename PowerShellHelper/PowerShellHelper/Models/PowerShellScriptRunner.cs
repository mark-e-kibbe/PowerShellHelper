using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace PowerShellHelper.Models
{
    /// <summary>
    /// Class for running powershell scripts
    /// </summary>
    internal class PowerShellScriptRunner
    {
        /// <summary>
        /// fileName pertaining to the scripts filename and extension
        /// <exampl>TestScript.ps1</exampl>
        /// </summary>
        private string fileName = "";

        /// <summary>
        /// Constructor that creates the powershell script
        /// </summary>
        /// <param name="scriptName">Script file name with file extension</param>
        public PowerShellScriptRunner(string scriptName)
        {
            fileName = scriptName;
        }
        
        /// <summary>
        /// Gets and return the complete file path from the projects Scripts folder
        /// </summary>
        /// <param name="scriptName">Script filename with file extension</param>
        /// <returns></returns>
        private string getCompletePath(string scriptName)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"Scripts\", scriptName);

            return path;
        }

        /// <summary>
        /// Executes the powershell script that needs to be ran
        /// </summary>
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
