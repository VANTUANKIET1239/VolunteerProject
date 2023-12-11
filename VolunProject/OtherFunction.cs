using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolunProject
{
    public class OtherFunction
    {
            public static byte[] PathImage2Byte(string path)
            {
                try
                {
                    string imagePath = path;
                    byte[] imageBytes = File.ReadAllBytes(imagePath);


                    return imageBytes;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                return null;
            }
    }
}
