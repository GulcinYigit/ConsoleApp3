using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp3
{
    class Class1
    {

        public void Write(string filePath, string fileName, string strLog, bool isAppend = true)
        {

            try
            {
                StreamWriter logWriter = new StreamWriter(filePath + fileName, isAppend);
                logWriter.WriteLine(strLog);
                logWriter.Close();
                logWriter.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
