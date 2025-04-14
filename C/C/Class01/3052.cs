// 두 자연수 A와 B가 있을 때, A%B는 A를 B로 나눈 나머지 이다. 예를 들어, 7, 14, 27, 38을 3으로 나눈 나머지는 1, 2, 0, 2이다. 
//
//     수 10개를 입력받은 뒤, 이를 42로 나눈 나머지를 구한다. 그 다음 서로 다른 값이 몇 개 있는지 출력하는 프로그램을 작성하시오.


//이러면 for문 안에만 있어서 안됨.. 다른 방법이 없나..

    // int[] numbers = new int[10];
    // int[] count = new int[42];
    // for (int i = 0; i < 10; i++)
    // {
    //     numbers[i] = int.Parse(Console.ReadLine());
    // }
    //
    // foreach (var VARIABLE in numbers)
    // {
    //     int digit = VARIABLE % 42;
    //     count[digit]++;
    // }

////-------------
//     int cnt = 0;
//     int[] digits = new int [10];
//
//     for (int i = 0; i < 10; i++)
//     {
//         digits[i] = -1;
//
//     }
//     
//     for (var i = 0; i < 10; i++)
//     {
//         int n = (int.Parse(Console.ReadLine())%42);
//         bool flag = true;
//
//         foreach (var c in digits)
//         {
//             if (n == c)
//             {
//                 flag = false;
//                 break;
//             }
//         }
//         if (flag)
//         {
//             digits[cnt] = n;
//             cnt++;
//         }
//
//     }
//
// Console.WriteLine(cnt);
//    -------------------------------------

using System.Data;
using System.Text;
    
    using var reader = new StreamReader(Console.OpenStandardInput(), Encoding.Default, false, 65536);
    using var writer = new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, 65536);
    
    
    int[] array = new int[42];
     
    for (int i = 0; i < 10; i++)
    {
        var n = int.Parse(reader.ReadLine());
        var a = n % 42;
        array[a]++;
    }
    
    int count = 0;
    foreach (int n in array)
    {
        if (n != 0)
        {
            count++;
        }
    }
    writer.WriteLine(count);
    //--------------------------------------
    
    //10개의 정수를 입력받아, 각각 5로 나눈 나머지를 구한다
    //중복을 제거하고, 서로 다른 나머지의 개수를 출력한다

    
    // int[] count = new int[5]; //  나머지 0-4 등장 여부를 저장할 배열
    //
    // for (int i = 0; i < 10; i++)
    // {
    //     int num = int.Parse(reader.ReadLine()); //숫자 입력
    //     int remainder = num % 5; // 나머지 구하기
    //     count[remainder]++; // 해당 나머지 인덱스 증가
    // }
    //
    // int diffCount = 0;
    // for (int i = 0; i < 5; i++)
    // {
    //     if (count[i] != 0)
    //         diffCount++;
    // }
    // writer.WriteLine(diffCount);
    //
    
    