using static System.Console;
using System.Runtime.InteropServices;
using System.Text;
//bool t = true;
//int n;
//int y = 1;
//List<int> l = new List<int>();
//for(int i=1;i<=100;i++)
//{
//    l.Add(i);
//}
//Random rand=new Random();
//while (t)
//{
//    while (!l.Contains(y))
//    {
//        y = rand.Next(1, 100);
//    }
//    n=MessageBox(new IntPtr(0), $"Ваше число {y} или нет?", "Поиск числа", 3);
//    switch (n)
//    { 
//        case 6:
//            {
//                WriteLine("Ура победа!!!");
//                y=1;
//                break;
//            }
//        case 7:
//            {
//                l.Remove(y);
//                break;
//            }
//    }
//    if (n == 2)
//    {
//        break;
//    }

//}

//[DllImport("user32.dll", CharSet = CharSet.Unicode)]
//static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);


//StringBuilder r = new System.Text.StringBuilder();

//int i = FindWindow(null, "8577.jpg");
//int x = GetClassName(i, r, r.Capacity);
//MessageBox(new IntPtr(0), $"Ваше число или нет?", "Поиск числа", 3);
//Write(i);
//[DllImport("User32.Dll")]
// static extern int FindWindow(string lpClassName, string lpWindowName);

//[DllImport("User32.Dll")]
// static extern int GetClassName(int hwnd, StringBuilder lpClassName, int nMaxCount);
//[DllImport("user32.dll", CharSet = CharSet.Unicode)]
//static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

int hWnd = FindWindow(null, "Microsoft SQL Server Management Studio");
Console.WriteLine(hWnd);
if (hWnd > 0)
{
    Console.WriteLine("К счастью, окно найдено...");
    SetForegroundWindow(hWnd);
}
else
{
    Console.WriteLine("Окно не найдено!");
}
Console.ReadKey();

[DllImportAttribute("User32.dll")]
static extern int FindWindow(String ClassName, String WindowName);

[DllImportAttribute("User32.dll")]
static extern IntPtr SetForegroundWindow(int hWnd);


  

