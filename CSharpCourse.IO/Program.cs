using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We include this using statement!!!
using System.IO;

namespace CSharpCourse.IO
{
    class Program
    {

        private const string FILEPATH = "{Insert here the File Path}";
        private const string FOLDERPATH = "{Insert here the Folder Path}";

        static void Main(string[] args)
        {
            //Static class File, have a lot of utils methods when you work with io.
            if(File.Exists(FILEPATH))
            {
                //StreamReader allows read text files
                StreamReader textReader = new StreamReader(FILEPATH);

                //StreamWriter allows write text files
                StreamWriter textWriter = new StreamWriter(FILEPATH);

                //It's for files
                FileStream fileStream = new FileStream(FILEPATH, FileMode.OpenOrCreate);

                //REMEMBER!! Close your files...
                textReader.Close();
                textWriter.Close();
                fileStream.Close();
            }

            //Static class Directory, have a lot of utils when working with Folders
            foreach(string folderPath in Directory.GetDirectories(FOLDERPATH))
            {
                Console.WriteLine(folderPath);
            }

            //This class have all of info for your file
            FileInfo fileInfo = new FileInfo(FILEPATH);

            Console.WriteLine(fileInfo.CreationTime);
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.Extension);

                        
            Console.ReadKey();
        }
    }
}
