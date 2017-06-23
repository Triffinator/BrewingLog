using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;


namespace BrewingLog
{
    public static class Serial<T> where T : class
    {

        /**
         * @brief:                  Creates folder (if not present) and file in that folder.
         * 
         * @param:  T       other   Templated object for serialization. Must be marked [Serializable]
         * @param:  string  fileN   File Name, not including folder reference. "example/savename.extension" is enterred as "savename.extension"
         * @param:  string  folderN Folder Name, not including file reference. "example/" is enterred here.
         * 
         * @return: none
         */
        public static void Save(T other, string fileN, string folderN)
        {
            if (!System.IO.File.Exists(folderN))
            {
                System.IO.Directory.CreateDirectory(folderN);
            }

            Stream stream = null;
            try
            {
                IFormatter formatter = new BinaryFormatter();
                stream = new FileStream(folderN + fileN, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, other);
            }
            catch
            {
                // do nothing, just ignore any possible errors
            }
            finally
            {
                if (null != stream)
                    stream.Close();
            }
        }

        public static T Load(string fileN)
        {
            Stream stream = null;
            T other = null;
            try
            {
                IFormatter formatter = new BinaryFormatter();
                stream = new FileStream(fileN, FileMode.Open, FileAccess.Read, FileShare.None);
                other = (T)formatter.Deserialize(stream);
            }
            catch
            {
                // do nothing, just ignore any possible errors
            }
            finally
            {
                if (null != stream)
                    stream.Close();
            }
            return other;
        }
    }
}
