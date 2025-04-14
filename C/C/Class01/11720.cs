using System.Data;
using System.Text;

using var reader = new StreamReader(Console.OpenStandardInput(), Encoding.Default, false, 65536);
using var writer = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, 65536);

    int t = int.Parse(reader.ReadLine());
    int[] numbers = new int[t];

    string num = reader.ReadLine();

    int sum = 0;
    foreach (char ch in num)
    {
        int digit = ch - '0';
        sum += digit;
    }
    writer.WriteLine(sum);
    