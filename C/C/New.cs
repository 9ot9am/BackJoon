// 문제
//     두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
//
//     입력
//     첫째 줄에 A와 B가 주어진다. (0 < A, B < 10)
//
// 출력
//     첫째 줄에 A+B를 출력한다.



//문자를 단어 단위로 쪼개고
//foreach를 이용해서 한 단어씩 접근할 수 있음 

//단어에 공백이 나오면 단어를 나누기..????
//그 단어들 묶어서 한 배열에 넣기

//그 배열을 반복문으로 돌려서

//그게 공백인지 아닌지 구분해서 출력하기





//----------------------

//2562
// //새로로 입력받기
// //9개의 수라고 정해져 있음
// //for을 돌리면서 9개의 수를 입력받고 동시에 비교하기??
// int max = 0;
// //i를 담을 변수를 밖에서 미리 선언하기 !! >>
// int num = 0;
// //최대값을 구하려면 비교할 값을 최소값을 만들기
// for (int i = 0; i < 9; i++)
// {
//     int a = int.Parse(Console.ReadLine());
//
//     if (max < a)
//     {
//         max = a;
//         num = i;
//     }
//     //i의 번호는 어떻게 꺼내지??
// }
//     Console.WriteLine(max);
//     Console.WriteLine(num+1);


//2741
//첫째 줄에 100,000보다 작거나 같은 자연수 N이 주어진다.

// using System.Text;
//
// int a = int.Parse(Console.ReadLine());
//
// StringBuilder sb = new StringBuilder();
//
// for (int i = 1; i <= a; i++)
// {
//     sb.AppendLine($"{i}"); // 자동으로 줄바꿈
// }
// Console.WriteLine(sb.ToString()); // 하나의 문자열로 합해줌


//2884
//원래 설정된 시간 45분 당기기
// (0 ≤ H ≤ 23, 0 ≤ M ≤ 59)

// int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//
// int h = input[0];
// int m = input[1];
//
//
//     if (m < 45)
//     {
//         m += 15;
//         h -= 1;
//         
//         if (h == 0)
//         {
//             h = 23;
//             m += 15;
//         }
//     }
//
// // h가 0이면서 분이 45보다 큰 것도 체크헤줘야 함..
//     else if (m >= 45)
//     {
//         m -= 45;
//     }
//
//     Console.WriteLine($"{h} {m}");



// int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//
// int h = input[0];
// int m = input[1];
//
// if (m >= 45)
// {
//     m -= 45;
// }
// else if (m < 45)
// {
//     m += 15;
//     
//     if (h == 0)
//     {
//         h =23;
//     }
//     else
//     {
//         h -= 1;
//     }
// }
//      Console.WriteLine($"{h} {m}");

// str.Min();
// str.Max();
// str.Sum();

//10871
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//
// int num = arr[0];
// int min = arr[1];
//
// int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//
// for (int i = 0; i < num; i++)
// {
//     if (numbers[i] < min)
//     {
//         Console.Write($"{numbers[i]} ");
//     }
// }
    

// int num = int.Parse(Console.ReadLine());
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int min = arr.Min();
// int max = arr.Max();
// Console.WriteLine($"{min} {max}");


//test case T

//


// int num = int.Parse(Console.ReadLine());    
// int [] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//
// int getMax(int[] arr)
// {
//     int max = -1000000;
//     int min = 1000000;
//     
//     for (int i = 0; i < num; i++)
//     {
//         if (arr[i] > max)
//         {
//             max = arr[i];
//         }
//
//         if (arr[i] < min)
//         {
//             min = arr[i];
//         }
//     }
//
//     return max;
// }
//
// Console.WriteLine($"{getMax(arr)}");

//10950
// int num = int.Parse(Console.ReadLine());
//
// for (int i = 0; i < num; i++)
// {
//     int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//     int a = arr[0];
//     int b = arr[1];
//     Console.WriteLine(a+b);
// }

//10951
//배열이 비어있으면 끝나게,, 
//조건문 추가...
// 선생님이 알려줌...
    


// while (true)
// {
//     string str = Console.ReadLine();
//     
//     if (string.IsNullOrEmpty(str))
//         break;
//     
//     string[] numbers = str.Split();
//     
//     int a = int.Parse(numbers[0]);
//     int b = int.Parse(numbers[1]);
//     
//     Console.WriteLine(a+b);
// }


// while (true)
// {
//     string str = Console.ReadLine();
//     
//     string[] arr = str.Split();
//     int a = int.Parse(arr[0]);
//     int b = int.Parse(arr[1]);
//     int c = a + b;
//     if (c <= 0)
//         break;
//     Console.WriteLine(c);
// }

//캐릭터형 변수를 선언해서
//스트링은 배열이니까 첫번째 글자만 따오면 char
//int형 변수에 char를 넣으면 바로 int가 됨
//char가 int로 변하면서 아스키코드가 됨

// char input = Console.ReadLine()[0];
// int a = input;
// Console.Write(a);


// int a = int.Parse(Console.ReadLine());
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int sum = 0;
//
// for (int i = 0; i < a; i++)
// {
//     sum += arr[i];
// }
// Console.WriteLine(sum);


//1152번

    // string[] str = Console.ReadLine().Split();
    //
    // int count = 0;
    // for (int i = 0; i < str.Length; i++)
    // {
    //     //string의 첫 번쨰 공백을 확인하고 싶은데
    //     //str[0]만 확인해도 그 다음에도 공백이 있으면 어떡하지??
    //     //string[0]의 값이 null인지 아닌지 디버그해서 판단
    //     // string의 null은 "" 인 것임 
    //     if (str[i] == "")
    //         continue;
    //
    //     count += 1;
    // }
    // Console.WriteLine(count);
    //



// string s = Console.ReadLine()!;
// int count = 0;
// if (s[0] != ' ')
// {
//     count++;
// }
//
// for (int i = 1; i < s.Length; i++)
// {
//     if (s[i] != ' ' && s[i - 1] == ' ')
//     {
//         count++;
//     }
// }
// Console.WriteLine(count);



// string s = Console.ReadLine()!;
// int count = 0;
// if (s[s.Length - 1] != ' ')
// {
//     count++;
// }
//
// for (int i = 0; i < s.Length - 1; i++)
// {
//     if (s[i] != ' ' && s[i + 1] == ' ')
//     {
//         count++;
//     }
// }
// Console.WriteLine(count);



//     string s = Console.ReadLine()!;
//     int count = 0;
//     bool state = false;
//     foreach (char c in s)
// //for (int i = 0; i < s.Length; i++)
//     {
//         //char c = s[i];
//         if (c != ' ')
//         {
//             if (!state)
//             {
//                 state = true;
//                 count++;
//             }
//         }
//         else
//         {
//             state = false;
//         }
//     }
//     Console.WriteLine(count);




    // int score = int.Parse(Console.ReadLine());
    //
    // switch (score)
    // {
    //     case (90):
    //         Console.WriteLine($"{score}");
    //         break;
    //     default:
    //         Console.WriteLine($"anj");
    //         break;
    // }




    // int num = int.Parse(Console.ReadLine());
    //
    // if (num >= 90)
    // {
    //     Console.WriteLine("A학점");
    // }    
    //
    // else if (num > 79)
    // {
    //     Console.WriteLine("B학점");
    // }    
    //
    // else if (num > 69)
    // {
    //     Console.WriteLine("C학점");
    // }    
    //
    // else if (num > 59)
    // {
    //     Console.WriteLine("D학점");
    // }
    //
    // else
    // {
    //     Console.WriteLine("F학점");
    // }





    // int num = int.Parse(Console.ReadLine());
    //
    // if (num % 2 == 0)
    // {
    //     Console.WriteLine("짝수");
    // }
    //
    // else if (num % 2 != 0)
    // {
    //     Console.WriteLine("홀수");
    // }




    // int[] arar = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    // int a = arar[0];
    // int b = arar[1];
    //
    // if (a > b)
    // {
    //     Console.WriteLine($"{a}가 {b}보다 더 큽니다");
    // }
    // if (a < b)
    // {
    //     Console.WriteLine($"{b}가 {a}보다 더 큽니다");
    // }

    // int c = int.Parse(Console.ReadLine());
    // double f = 9.0 / 5 * c + 32;
    // Console.WriteLine(f);
    


//#5
    int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    
    int sum = 0;
    int average = 0;
    int cnt = 0;
    int lecture = 0;
    //합계는구할수있고
    //평균은 카운트세서 과목수 나누면 되는데
    //각각의 숫자는 어떻게 구하지????
    
    
    
    // for (int i = 0; i < numbers.Length; i++)
    // {
    //     lecture = numbers.Length;
    //     sum += numbers[i];
    //     cnt++; // 과목수
    // }
    // //
    // int result = (sum/cnt)
    //     
    
   
     