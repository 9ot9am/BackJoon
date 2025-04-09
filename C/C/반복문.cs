// using System.Diagnostics;
// using System.Diagnostics.CodeAnalysis;
//
// // int[] scores = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}; 
// //
// //
// // for (int i = 0; i < 10; i++) 
// // {
// //     int n = scores[i];
// //
// //     int sum = 0;
// //     for (int j = 0; j < 10; j++)
// //     {
// //         sum += scores[j];
// //         
// //     }
// // Console.WriteLine(sum);
// // }
//
// // int sum = 0;
// // int[] numbers = new int[5] {10, 20, 30, 40, 50};
// // for (int i = 0; i < 5; i++)
// // {
// //     sum += numbers[i];
// // }
// // Console.WriteLine(sum);
//
//
// // // 배열 선언
// // int[]scores = new int[5];
// // //데이터 변경
// // scores[0] = 70;
// // scores[1] = 80;
// // scores[2] = 90;
// // scores[3] = 100;        
// // scores[4] = 101;
// // //출력
// // for (int i = 0; i < 5; ++i)
// // {
// //     Console.WriteLine(scores[i]);
// // }
// //
// // //배열 사용 + 초기화 간략하
// // //선언 초기화
// // int [] scores2 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
// // //출력
// // for(int i =0; i < scores2.Length; ++i)
// // Console.WriteLine(scores2[i]);
//
// // foreach (데이터형식 변수 이름 in 이름){
// // // 반복하려는 코드
// // }
// //
// // //선언
// // int [] scores = new int [10];
// //
// // //데이터 변경
// // scores[0] = 0;
// // scores[1] = 0;
// // scores[2] = 0;
// // scores[3] = 0;
// // scores[4] = 0;
// //
// // //출력
//
// // int sum = 0;
// // int [] numbers = {10, 20, 30, 40, 50};
// // //각 숫자를 출력
// // foreach (int n in numbers)
// // {
// //     sum += n;
// // }
// //     Console.WriteLine(sum);
//
//
// // method
//
// // //메소드 내부로 전달할 매개 변수들의 목록
// // 한정자 반환_형식 메소드_이름(매개변수_목록)
// // {
// // //실행하고자 하는 코드들
// // return 반환할 데이터
// //     //반환할 데이터와 형식이 항상 일치해야함
//
//
// //num1과 num2를 받아서, 두 수의 곱을 반환
// int Multiple(int num1, int num2)
// {
// int result = num1*num2;
// return result;
// }
//
// int num1, num2;
// num1  = 3;
// num2 = 4;
// int x = num1 * num2;
//
// num1 = 5;
// num2 = 6;
// int y = num1 * num2;
//
// num1 = 3;
// num2 = 4;
// int z = num1 * num2;
//
// Console.Writeline($"x: {x}, y: {y}, z: {z}");
//
// public int Multiple(int num1, int num2)
//     {
//         int result = num1 * num2;
//         return result;
//     }
//
