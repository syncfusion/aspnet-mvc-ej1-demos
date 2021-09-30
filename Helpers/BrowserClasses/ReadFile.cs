#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.IO;

namespace MVCSampleBrowser.Helpers
{
    internal class ReadFileStreams
    {
        public List<String> GetFileData(string Path)
        {
            int i = 0;
            string MyStreamString = "";
            string[] StreamSplit;
            List<string> MyFileStream = new List<string>();
            MyFileStream.Add("");
            try
            {
                System.IO.StreamReader tr = new StreamReader(Path);

                while (tr.EndOfStream != true && i <= 5)
                {
                    string CheckStream = tr.ReadLine().ToString() + "\r\n";
                    if (CheckStream == null)
                    {
                        i = i + 1;
                    }
                    else
                    {
                        i = 0;
                    }

                    MyStreamString = CheckStream + MyStreamString + tr.ReadToEnd();

                }
                tr.Close();
                StreamSplit = MyStreamString.Split('\r');
                foreach (string CurStream in StreamSplit)
                {
                    MyFileStream.Add(CurStream.ToString());
                }
            }
            catch
            {
            }
            return MyFileStream;
        }
    }
}
