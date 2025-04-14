/*"OOXXOXXOOO"와 같은 OX퀴즈의 결과가 있다. O는 문제를 맞은 것이고, X는 문제를 틀린 것이다. 문제를 맞은 경우 그 문제의 점수는 그 문제까지 연속된 O의 개수가 된다. 예를 들어, 10번 문제의 점수는 3이 된다.

"OOXXOXXOOO"의 점수는 1+2+0+0+1+0+0+1+2+3 = 10점이다.

    OX퀴즈의 결과가 주어졌을 때, 점수를 구하는 프로그램을 작성하시오.

    입력
    첫째 줄에 테스트 케이스의 개수가 주어진다. 각 테스트 케이스는 한 줄로 이루어져 있고, 길이가 0보다 크고 80보다 작은 문자열이 주어진다. 문자열은 O와 X만으로 이루어져 있다.
*/


    using System.Data;
    using System.Text;
    
    using var reader = new StreamReader(Console.OpenStandardInput(), Encoding.Default, false, 65536);
    using var writer = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, 65536);

    int t = int.Parse(reader.ReadLine());

    string[] arr = new string[t];

    for (int i = 0; i < t; i++)
    {
        arr[i] = reader.ReadLine();
    }

    // int sum = 0;
    // int count = 0; // 이렇게 되면 전체 테스트 케이스에 공유가 되어서 점수가 누적됨
    
    for (int i = 0; i < arr.Length; i++)
    {
        int sum = 0;
        int count = 0;
        
        foreach (char ch in arr[i])
        {
            if (ch == 'O')
            {
                count++;
                sum += count;
            }
            else 
                count = 0;
        }
        writer.WriteLine(sum);
    }


    
    
