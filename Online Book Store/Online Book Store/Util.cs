using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Store
{
    /// <summary>
    /// author Gorkem GOREN
    /// </summary>
    public static class Util
    {
        
        public static bool isValidEmail(string inputEmail)
        {
            // This Pattern is use to verify the email 
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);

            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        public static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public static string GetTime()
        {
            string time;
            time = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss ");
            return time;
        }
        public static void Export(string message)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "UserData|*.psv";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                
                using (FileStream fs = new FileStream(save.FileName, FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(message);
                }

            }
        }

    }
}
