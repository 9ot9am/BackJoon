    
    //  별찍기 -2
    // 문제
    //  첫째 줄에는 별 1개, 둘째 줄에는 별 2개, N번째 줄에는 별 N개를 찍는 문제
    //
    //      하지만, 오른쪽을 기준으로 정렬한 별(예제 참고)을 출력하시오.
    //
    //      입력
    //      첫째 줄에 N(1 ≤ N ≤ 100)이 주어진다.
    //
    //      출력
    //      첫째 줄부터 N번째 줄까지 차례대로 별을 출력한다.
    
    
     // int n = int.Parse(Console.ReadLine());
     //
     //
     // int spaceCount = 3;
     // int starCount = 2;
     // string str = "";
     // string star = "";
     //
     // for (int i = 0; i < spaceCount; i++) 
     // {
     //     str += " ";
     // }
     //
     // for (int i = 0; i < starCount; i++)
     // {
     //     star += "*";
     // }
     //
     // Console.Write(str + star);

    //풀이

     // int n = int.Parse(Console.ReadLine());
     //
     // for (int k = 0; k < n; k++)
     // {
     //     
     //     int spaceCount = n - k - 1; // 4 3 2 1 0
     //     int starCount = k + 1; // 1 2 3 4 5
     //
     //     for (int i = 0; i < spaceCount; i++)
     //     {
     //         Console.Write(" ");
     //     }
     //
     //     for (int j = 0; j < starCount; j++)
     //     {
     //         Console.Write("*");
     //     }
     //     Console.WriteLine("");
     // }

    
     // int n = int.Parse(Console.ReadLine());
     //
     // for (int j = 0; j < n; j++)
     // {
     //     int spaceCount = n - 1 -j; //4 3 2 1 0
     //     int starCount = j+1;  //1 2 3 4 5
     //     
     //     for (int i = 0; i < spaceCount; i++)
     //     {
     //         string space = "";
     //         space += " ";
     //         Console.Write(space);
     //     }
     //
     //     for (int i = 0; i < starCount; i++)
     //     {
     //         string star = "";
     //         star += "*";
     //         Console.Write(star);
     //     }
     //     Console.WriteLine("");
     // }
     //
     // int [] number = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    










