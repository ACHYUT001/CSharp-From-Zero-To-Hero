using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    public class CredentialsManager
    {
        private Dictionary<string,string> _credentialsFile = new Dictionary<string, string>();
        private readonly string _filepath;

        Encoding unicode = Encoding.Unicode;
        public CredentialsManager(string Credentialsfile)
        {
            _filepath = Credentialsfile;
            import(_filepath);
        }

        // TODO: load credentials and check for equality.
        public bool Login(Credentials credentials)
        {
            if(_credentialsFile.ContainsKey(credentials.Username))
            {
                if(credentials.Password == _credentialsFile[credentials.Username])
                    return true;
            }

            return false;
        }

        // TODO: store credentials in credentials file.
        public void Register(Credentials credentials)
        {
            _credentialsFile[credentials.Username] = credentials.Password;

            byte[] unicodeBytes = encodePassword(credentials.Password);
            using(StreamWriter fw = new StreamWriter(_filepath, true))
            {
                fw.Write($"{credentials.Username} : ");

                foreach(byte b in unicodeBytes)
                {
                    fw.Write(b);
                }

                fw.WriteLine();
                
            }
        }

        void import(string filepath)
        {
            string line = null;
            using(StreamReader fr = new StreamReader(filepath))
                {
                    while((line = fr.ReadLine()) != null)
                    {
                        var info = line.Split(':');
                        _credentialsFile[info[0]] = info[1];
                    }
                } 
        }


        byte[] encodePassword(string password)
        {
            var encodedpassword = unicode.GetBytes(password);
            return encodedpassword;
        }
    }
}
