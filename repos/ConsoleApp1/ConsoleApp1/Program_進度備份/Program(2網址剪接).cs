using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.IO;

namespace Examples.System.Net
{
    public class WebRequestGetExample
    {
        public static void Main()
        {
            int educodeNum = 1;
            string myAddress = "https://dict.variants.moe.edu.tw/variants/rbt/word_attribute.rbt?educode=A" + educodeNum.ToString("00000");
            Console.WriteLine("A" + educodeNum.ToString("00000") + "\t" + myAddress);
            Console.ReadKey();
/*
            //將要取得HTML原如碼的網頁放在WebRequest.Create(@”網址” )
            WebRequest myRequest = WebRequest.Create(@"https://dict.variants.moe.edu.tw/variants/rbt/word_attribute.rbt?educode=B00002");

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

            //等一秒
            Thread.Sleep(1000);
*/
        }
    }
}