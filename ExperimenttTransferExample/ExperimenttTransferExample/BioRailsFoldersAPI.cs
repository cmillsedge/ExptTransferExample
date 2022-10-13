using System;
using System.Globalization;
using System.Collections.Generic;
using System.Resources;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using BioRails.Core.Api;
using BioRails.Core.Client;
using BioRails.Core.Model;

namespace ExperimenttTransferExample
{
    public class BioRailsFoldersAPI
    {
        private Session _session;
        private string _url;
        public BioRailsFoldersAPI(Session session, string url)
        {
            _session = session;
            _url = url;
        }

        public Folder CreateFolder(string path)
        {
            string folderName = "DataFiles";
            Folder folder = new Folder(null, folderName, null, "this is a new folder", null, "Folder"); //Folder is the name of the element type for the folders under tasks
            try
            {
                FoldersApi foldersApi = new FoldersApi(_url);
                folder = foldersApi.FolderCreate(_session.SessionId, path, folder);
                Console.WriteLine(folder.Path);
                return folder;
            }
            catch (Exception ex)
            {
                return folder;
            }
        }

        public Folder CreateFile(string folderPath, string filePath)
        {
            Folder folder = null;
            string fileName = Path.GetFileName(filePath);
            try
            {
                FoldersApi foldersApi = new FoldersApi(_url);
                //string systempath = Environment.CurrentDirectory;
                string systempath = Application.StartupPath;
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    folder = foldersApi.FolderFile(sessionKey: _session.SessionId,
                                                   path: folderPath,
                                                   file: fs,
                                                   name: fileName,
                                                   elementTypeName: "File");
                }
                return folder;
            }
            catch (Exception ex)
            {
                return folder;
            }
        }
    }
}
