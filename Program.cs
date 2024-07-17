using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Chào bạn...Đây là Chúc GIang on the mic");
        Console.WriteLine("Đây là chương trình tính toán của Giang viết ra nè !!!");
        int a, b,Tong;
        Console.Write("\nNhập số a : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập số b");
        b = Convert.ToInt32(Console.ReadLine());
        Tong = a + b;
        Console.WriteLine("Tổng của hai số là" +Tong);

        int Hieu;
        Hieu = a - b;
        Console.WriteLine("Hiệu của hai số là :" + Hieu);

        int Tich;
        Tich = a * b;
        Console.WriteLine("Tích của hai số là :" + Tich);

        float Thuong;
        Thuong = a / b;
        Console.WriteLine("Thương của hai số là :" +Thuong);
    }
}