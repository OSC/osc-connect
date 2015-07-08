﻿using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace AweSimConnect.Controllers
{
    /// <summary>
    /// Static tools for getting file locations on disk.
    /// </summary>
    class FileController
    {
        public static string FILE_FOLDER = "AweSimFiles";
        public static string FILE_FOLDER_PATH = Path.Combine(Directory.GetCurrentDirectory(), FILE_FOLDER);

        public static void CreateAweSimFilesFolder()
        {
            try
            {
                Directory.CreateDirectory(FILE_FOLDER_PATH);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Creating Folder");
            }
        }

        public static bool DeployResourceToAweSimFilesFolder(byte[] resource, string fileName)
        {
            if (!IsResourceInstalledInAweSimFolder(fileName))
            {
                string path = Path.Combine(FILE_FOLDER_PATH, fileName);
                using (FileStream fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write))
                {
                    fs.Write(resource, 0, resource.Length);
                }
            }
            return true;
        }

        public static bool IsResourceInstalledInAweSimFolder(string fileName)
        {
            return ExistsOnPath(Path.Combine(FILE_FOLDER_PATH, fileName));
        }

        public static String FindExecutableInProgramFiles(String filename)
        {
            String programsPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            DirectoryInfo dirInfo = new DirectoryInfo(programsPath);
            FileInfo[] files = dirInfo.GetFiles(filename, SearchOption.AllDirectories);
            if (files.Length > 0)
            {
                return files[0].FullName.ToString();
            }
            else
                return "";
        }

        public static String SearchProgramFileFoldersForExecutableWithFolderPatternMatch(String fileName, String folderPattern)
        {
            String programsPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            DirectoryInfo dirInfo = new DirectoryInfo(programsPath);
            foreach (DirectoryInfo subDirInfo in dirInfo.GetDirectories())
            {
                bool contains = subDirInfo.FullName.ToString().IndexOf(folderPattern, StringComparison.CurrentCultureIgnoreCase) >= 0;
                if (contains) {
                    FileInfo[] files = subDirInfo.GetFiles(fileName, SearchOption.AllDirectories);
                    if (files.Length > 0) {
                        return files[0].FullName.ToString();
                    }
                }
            }
            if (!programsPath.Contains("x86"))
            {
                programsPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + " (x86)";
                try
                {
                    dirInfo = new DirectoryInfo(programsPath);
                    foreach (DirectoryInfo subDirInfo in dirInfo.GetDirectories())
                    {
                        bool contains = subDirInfo.FullName.ToString().IndexOf(folderPattern, StringComparison.CurrentCultureIgnoreCase) >= 0;
                        if (contains)
                        {
                            FileInfo[] files = subDirInfo.GetFiles(fileName, SearchOption.AllDirectories);
                            if (files.Length > 0)
                            {
                                return files[0].FullName.ToString();
                            }
                        }
                    }
                }
                catch
                {
                    
                }
                
            }
            return "";
        }

        public static bool IsProcessRunning(String processName) {
            Process[] pname = Process.GetProcessesByName(processName);
            return ((pname.Length != 0) ? true : false);
        }

        public static bool IsProcessRunning(int processID)
        {
            try
            {
                Process pname = Process.GetProcessById(processID);
                //This should always return true, exception is thrown if process not found
                return (pname != null);
            }
            catch (Exception)
            {
                return (false);
            }
        }
        
        public static bool ExistsOnPath(String fileName)
        {
            if (GetFullPath(fileName) != null)
            {
                return true;
            }
            return false;
        }

        public static String GetFullPath(String fileName)
        {
            if (File.Exists(fileName))
            {
                return Path.GetFullPath(fileName);
            }

            if (File.Exists(Path.Combine(FILE_FOLDER, fileName)))
            {
                return Path.GetFullPath(Path.Combine(FILE_FOLDER, fileName));
            }

            String values = Environment.GetEnvironmentVariable("Path");

            foreach (String path in values.Split(';'))
            {
                try
                {
                    String fullPath = Path.Combine(path.Trim(), fileName);
                    
                    if (File.Exists(fullPath))
                    {
                        return fullPath;
                    }
                }
                catch (Exception)
                {

                }
            }
            return null;
        }
    }
}
