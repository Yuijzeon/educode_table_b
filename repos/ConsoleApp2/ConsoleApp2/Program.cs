using System;
using System.IO;
using System.Text;
class TestRW
{
    public static void Main(String[] args)
    {
        // 使用'using' 自動做Flush()、Close()、Dispose(), 釋放tw資源.
        using (StreamWriter tw = new StreamWriter("D:/test.txt", true))  // 'true':新建或附加.
        {
            tw.WriteLine("The next line!");
            tw.Close();
        }
    }
}