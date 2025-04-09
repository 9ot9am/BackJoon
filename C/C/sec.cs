
// using System.Diagnostics;
// int totalSeconds = 3668; // 예제: 90061초를 변환해보기
//         
// int days = totalSeconds / 86400;  // 1일 = 86400초
// totalSeconds %= 86400;            // 하루(86400초) 단위 제거
//
// int hours = totalSeconds / 3600;  // 1시간 = 3600초
// totalSeconds %= 3600;             // 시간(3600초) 단위 제거
//
// int minutes = totalSeconds / 60;  // 1분 = 60초
// int seconds = totalSeconds % 60;  // 남은 초
//
// Console.WriteLine($"변환 결과: {days}일 {hours}시간 {minutes}분 {seconds}초");
//


// int a = 20;
// int b = 15;
// int c = 2;
// int d = 31;
//
// float average = (float)(a + b + c + d) / 4f;
//
// Console.WriteLine(a-average);
// Console.WriteLine(b-average);
// Console.WriteLine(c-average);
// Console.WriteLine(d-average);


//네 개의 임의의 정수 중에서, 가장 큰 수를 출력해보기

// int a = 20;
// int b = 49;
// int c = 371;
// int d = 15;
//
// int[] numbers = {a,b,c,d};
// int minValue = numbers.Min();
// int maxValue = numbers.Max();
// Console.WriteLine(minValue);
// Console.WriteLine(maxValue);









//
// if (a > b)
// {
//     if (a > c)
//     {
//         if (a > d)
//         {
//             Console.WriteLine(a);
//         }
//     }
// }
// else if (b > a)
// {
//     if (b > c)
//     {
//         if(b>)
//     }
// }

// 네 개의 정수
// int a = 20, b = 49, c = 371, d = 15;

// // 최댓값을 저장할 변수
// int max = a;
//
// // 각 값을 비교하며 최댓값 갱신
// if (b > max)
// {
//     max = b;
// }
//
// if (c > max)
// {
//     max = c;
// }
//
// if (d > max)
// {
//     max = d;
// }
//
// // 결과 출력
// Console.WriteLine("가장 큰 값: " + max);
//
// int min = a;
//
// if (b < min) ;
// {
//     min = b;
// }
//
// if (c < min) ;
// {
//     min = c;
// }
//
// if(d<min);
// {
//     min = d;
// }
//
// Console.WriteLine(min);


// int a = 0 // a를 먼저 선언해줘야 함

// if (Don / 500 > 0) // 값을 500으로 나눈 몫이 0보다 크다면
// {
//     a = Don / 500; // a는 500원으로 거스름돈 줄 개수 // a값만 구하기
// }
//
// if (Don % 500 > 0) // 값을 500으로 나눈 나머지 값이 0보다 크다면
// {
//     int b = Don / 100 ; // b는 100원으로 거슬러줘야 할 개수
//     
//     if (Don % 100 > 0) // 값을 100으로 나눈 나머지 값이 0보다 크다면
//     {
//         if (Don / 50 > 0) 
//         {
//             int c = Don / 50 ; // c는 50원으로 거슬러줘야 할 개수
//
//             if (Don % 50 > 0)
//             {
//                 int d = Don / 10 ;
//             }
//         }
//         
//     }
// }
//
// Console.Write(a);

// Console.Write("거스름돈을 입력하세요 (0 ~ 1000): ");
// int money = int.Parse(Console.ReadLine());
//
// // 각 동전 개수 계산
// int a = money / 500; // 500원 개수
// money %= 500;        // 500원 사용 후 남은 금액
//
// int b = money / 100; // 100원 개수
// money %= 100;        // 100원 사용 후 남은 금액
//
// int c = money / 10;  // 10원 개수
//
// // 결과 출력
// Console.WriteLine($"500원: {a}개, 100원: {b}개, 10원: {c}개");

// int x = 10;
// Console.WriteLine(x);
//
// int b = 20;
// Console.WriteLine(b);


// Console.Write("거스름돈을 입력하세요 (0 ~ 1000): ");
// int money = int.Parse(Console.ReadLine());

// string strNumber = "123";
// int Number = int.Parse(strNumber);
// Console.WriteLine(Number);








