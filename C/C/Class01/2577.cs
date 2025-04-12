// 세 개의 자연수 A, B, C가 주어질 때 A × B × C를 계산한 결과에 0부터 9까지 각각의 숫자가 몇 번씩 쓰였는지를 구하는 프로그램을 작성하시오.
//
//     예를 들어 A = 150, B = 266, C = 427 이라면 A × B × C = 150 × 266 × 427 = 17037300 이 되고, 계산한 결과 17037300 에는 0이 3번, 1이 1번, 3이 2번, 7이 2번 쓰였다.
//
//     입력
//     첫째 줄에 A, 둘째 줄에 B, 셋째 줄에 C가 주어진다. A, B, C는 모두 100보다 크거나 같고, 1,000보다 작은 자연수이다.
//
//     출력
//     첫째 줄에는 A × B × C의 결과에 0 이 몇 번 쓰였는지 출력한다. 마찬가지로 둘째 줄부터 열 번째 줄까지 A × B × C의 결과에 1부터 9까지의 숫자가 각각 몇 번 쓰였는지 차례로 한 줄에 하나씩 출력한다.

    // 1000000 < result < 997002999 

    // 세 개의 숫자를 입력받기
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    //입력 받은 숫자를 곱해서 스트링 문자열로 만들기
    string result = (a * b * c).ToString();
    //각 자리수들을 하나씩 확인하면서 카운트를 세기
    int[] count = new int[10];
    
    //string 각각의 배열 하나는 char임
    foreach (char ch in result)
    {
        switch (ch)
        {
            case '0' : count[0]++; break;
            case '1' : count[1]++; break;
            case '2' : count[2]++; break;
            case '3' : count[3]++; break;
            case '4' : count[4]++; break;
            case '5' : count[5]++; break;
            case '6' : count[6]++; break;
            case '7' : count[7]++; break;
            case '8' : count[8]++; break;
            case '9' : count[9]++; break;
        }
    }
    Console.WriteLine(count[0]);
    Console.WriteLine(count[1]);
    Console.WriteLine(count[2]);
    Console.WriteLine(count[3]);
    Console.WriteLine(count[4]);
    Console.WriteLine(count[5]);
    Console.WriteLine(count[6]);
    Console.WriteLine(count[7]);
    Console.WriteLine(count[8]);
    Console.WriteLine(count[9]);
    //내가 몰랐던 개념
    //foreach로 배열의 길이를 몰라도 배열의 처음부터 끝까지 순회할 수 있다
    // 이걸 활용해서 입력받은 스트링 배열을 하나씩 순회하면서 배열 하나씩 비교가 가능해짐
    // 캐릭터 하나를 돌 때 마다 int배열에 카운트를 하나씩 추가해서 몇 번 나왔는지 카운트가 가능
    










    //스트링 배열을 인트 배열로 어떻게 바꾸지????
    //int[] arr = new int[str.Length];
    
    // for (int i = 0; i < str.Length; i++)
    // {
    //     arr[i] = str[i] - '0';
    //
    //     
    // }


    // int[] arr = str.Select(c => c - '0').ToArray();
    //
    //     switch (arr[])
    //     {
    //         case 0:
    //             count++;
    //             Console.WriteLine(count);
    //             break;
    //     }




    // //스위치를 사용해서 int.Pasre(str[i]) 을 변수로 두고
    // //case마다 0 - 1 인지 판단해서 count를 올리고 그 count를 출력하기
    //
    // for (int i = 0; i < 10; i++)
    // {
    //     int num = i;
    //     
    //     switch (num)
    //     {
    //         case 0:
    //             
    //     }
    // }
    