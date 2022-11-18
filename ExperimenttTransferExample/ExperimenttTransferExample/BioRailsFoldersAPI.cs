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

        public FolderArray ListFolders(string path)
        {
            FolderArray folders = null;
            try
            {
                FoldersApi foldersApi = new FoldersApi(_url);
                folders = foldersApi.FolderList(_session.SessionId, path);
                return folders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                throw ex;
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
                throw ex;
            }
        }

        public FolderArray UpdateFolderState(string path, string stateName)
        {
            FolderArray result = null;
            try
            {
                //instantiate a folder API object
                FoldersApi foldersApi = new FoldersApi(_url);
                //create a list of strings for the tasks (folders) to change the state for
                List<string> paths = new List<string>();
                //Add a single path to the list
                paths.Add(path);
                //Add the path array and a state name to a cart object
                Cart cart = new Cart(paths,stateName);
                //call the Folder state method passing in the cart object
                result = foldersApi.FolderState(_session.SessionId, cart);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
