using System;
using System.Net;
using System.IO;
using System.Threading;

namespace Examples.System.Net
{
    public class WebRequestGetExample
    {
        public static void Main()
        {
            int educodeNum = 961;
            while (educodeNum <= 25000) // 當 educodeNum 小於或等於 10 做迴圈裡的事
            {
                string myAddress = "https://dict.variants.moe.edu.tw/variants/rbt/word_attribute.rbt?educode=C" + educodeNum.ToString("00000");

                //將要取得HTML原如碼的網頁放在WebRequest.Create(@”網址” )
                WebRequest myRequest = WebRequest.Create(myAddress);

                //Method選擇GET
                myRequest.Method = "GET";

                //取得WebRequest的回覆
                WebResponse myResponse = myRequest.GetResponse();

                //Streamreader讀取回覆
                StreamReader sr = new StreamReader(myResponse.GetResponseStream());

                //將全文轉成string
                string myResult = sr.ReadToEnd();

                //關掉StreamReader
                sr.Close();

                //關掉WebResponse
                myResponse.Close();

                //減去頭尾不要的字元或數字, 並將結果轉為string. 計算方式見後記(2)
                string afterCut = myResult.Substring(3970, 1);

                string str = "C" + educodeNum.ToString("00000") + "\t" + afterCut;
               
                if (educodeNum % 2 == 1)
                {
                    Console.WriteLine(str);
                }
                else
                {
                    Console.WriteLine("\t\t\t" + str);
                }

                // 使用'using' 自動做Flush()、Close()、Dispose(), 釋放tw資源.
                using (StreamWriter sw = new StreamWriter("D:/Output.txt", true))  // 'true':新建或附加.
                {
                    sw.WriteLine(str);
                }

                educodeNum++;

                //Thread.Sleep(3000);
            }
        }
    }
}