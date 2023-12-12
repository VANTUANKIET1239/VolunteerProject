﻿using System;
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
        public static class SessionManager
        {
            private static Dictionary<string, object> sessionValues = new Dictionary<string, object>();

            public static void SetSessionValue(string key, object value)
            {
                if (sessionValues.ContainsKey(key))
                {
                    sessionValues[key] = value;
                }
                else
                {
                    sessionValues.Add(key, value);
                }
            }

            public static T GetSessionValue<T>(string key)
            {
                if (sessionValues.ContainsKey(key) && sessionValues[key] is T)
                {
                    return (T)sessionValues[key];
                }

                return default(T);
            }

            public static bool ContainsKey(string key)
            {
                return sessionValues.ContainsKey(key);
            }
        }
        public class Gender
        {
            public bool genderValue { get; set; }
            public string genderDisplay { get; set; }
        }
    }
}
