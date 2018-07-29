using System;
using System.IO;

namespace KeyAddon
{
    public class KeyVector
    {

        public bool wPressed;
        public bool aPressed;
        public bool sPressed;
        public bool dPressed;
        private int frameCount;
        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
        public KeyVector()
        {
            wPressed = false;
            aPressed = false;
            sPressed = false;
            dPressed = false;
            frameCount = 0;
        }

        public void CreateKeyOutputFile()
        {
            using (StreamWriter sw = new StreamWriter(_fileName))
            {
                sw.WriteLine("Frame W A S D");
            }
        }

        private string BoolToBinaryString(bool inBool)
        {
            return inBool ? "1" : "0";
        }

        public void WriteKeyOutputFile()
        {
            using (StreamWriter sw = File.AppendText(_fileName))
            {
                sw.WriteLine("{0} {1} {2} {3} {4}", frameCount.ToString(),
                    BoolToBinaryString(wPressed), BoolToBinaryString(aPressed),
                    BoolToBinaryString(sPressed), BoolToBinaryString(dPressed));
            }
            ++frameCount;
        }

    }

}
