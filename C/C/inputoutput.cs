// //변숙 값인 str을 console.ReadLine으로 입력 받기
// string str = Console.ReadLine(); 
// //string 변수 값인 numbers라는 이름의 문자열 배열에 str을 넣어주고 공백으로 쪼개주기
// string[]numbers = str.Split(" ");
// //numbers 문자열의 첫번째 두번째 세 번째 값을 long 값으로 넣어주기
// long A = long.Parse(numbers[0]);
// long B = long.Parse(numbers[1]);
// long C = long.Parse(numbers[2]); 
//
//
//
// Console.WriteLine((A + B)%C);
// Console.WriteLine((A %C) + (B %C) %C);
// Console.WriteLine((A*B)%C);
// Console.WriteLine(((A%C) * (B%C))%C);
//
//
//

// long n = long.Parse(Console.ReadLine());
// long m = long.Parse(Console.ReadLine());
//
// Console.WriteLine(n * (m%10));
// Console.WriteLine(n * ((m%100)/10));
// Console.WriteLine(n * (m / 100));
// Console.WriteLine(n * m);



// 첫째줄에 7 77 777 입력받기

// 7과 77 777로 정수값 나눠서 받기


// string str = (Console.ReadLine());
// string [] numbers = str.Split(' ');
//
// long a = long.Parse(numbers[0]);
// long b = long.Parse(numbers[1]);
// long c = long.Parse(numbers[2]);
//
// Console.WriteLine(a + b + c);
//
// string[] numbers2 = str.Split(" ");

// Console.WriteLine("|\\_/|");
// Console.WriteLine("|q p|   /}");
// Console.WriteLine("( 0 )\"\"\"\\");
// Console.WriteLine("|\"^\"`    |");
// Console.WriteLine("||_/=\\\\__|");


// string str = Console.ReadLine();
//
// string[] numbers = str.Split();
//
// int a = int.Parse(numbers[0]);
// int b = int.Parse(numbers[1]);
//
// if (a > b)
// {
//     Console.WriteLine(">");
// }
//
// if (a < b)
// {
//     Console.WriteLine("<");
// }
//
// if (a == b)
// {
//     Console.WriteLine("==");
// }


// int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
//
// string s;
// if (input[0] > input[1])
//     s = ">";
// else if (input[0] < input[1])
//     s = "<";
// else
// {
//     s = "==";
// }

// int Scores = int.Parse(Console.ReadLine());
//
// //변수를 한 번에 선언하고 Console.WriteLine은 한 번만 사용하기
// char grade; 
//
// if (Scores >= 90) // 입력값이 주어져있기 때문에 &&는 없어도 됨
// {
//     grade = 'A';
// }
//
// else if (80 <= Scores )
// {
//     grade = 'B';
// }
//
// else if (70 <= Scores )
// {
//     grade = 'C';
// }
//
// else if (60 <= Scores )
// {
//     grade = 'D';
// }
//
// else
// {
//     grade = 'F';
// }
//
// Console.WriteLine(grade);




//
//
// int input = int.Parse(Console.ReadLine());
// //연도가 4의 배수이면서 100의 배수가 아닐 때
// if (input%4 == 0 && input%100 != 0  )
// {
//     Console.WriteLine(1);
// }
//
// //또는 400의 배수일 때
// else if (input%400 == 0)
// {
//     Console.WriteLine(1);
// }
//
// //
// else
// {
//     Console.WriteLine(0);
// }


//두 정수 h와 m


// string str = (Console.ReadLine());
//
// string[] numbers = str.Split();
//
// int h = int.Parse(numbers[0]);
// int m = int.Parse(numbers[1]);
//
// m -= 45;
//
// if (m < 0)
// {
//     m += 60;
//     h -= 1;
// }
//
// if (h < 0)
// {
//     h = 23;
// }
//
// Console.WriteLine($"{h} {m}");



//시 분
//요리하는데 필요한 시간 0<= hours <=1000

// String str = Console.ReadLine();
// string [] numbers = str.Split();
// int h = int.Parse(numbers[0]);
// int m = int.Parse(numbers[1]);
//
// int minutes = int.Parse(Console.ReadLine());
//
// //0<= m <=1059
// m += minutes;
//
// //0 <= h <= 40,  0 <= m <= 39
// h = h + (m / 60);
// m = (m % 60);
//
// h %= 24;
//
// Console.WriteLine($"{h} {m}");

// 1 <= x <= 3 , 0 <= y <= 5  ,  1 <= x + y <= 8



// if (m >=60 && m<120)
// {
//     h += 1;
//     m -= 60;
//     if (h == 24 && m==0)
//     {
//         h = 0;
//         m = 0;
//     }
// }
//
// else if (m >= 120)
// {
//     h += 2;
//     m -= 120;
//     
//     if (h == 24 && m==0)
//     {
//         h = 0;
//         m = 0;
//     }
// }

// (0<=h<=23) ( 0<=m=<59) (0<=sec=<59)



// String str = Console.ReadLine();
// string[] numbers = str.Split(" ");
//
// //현재시각
// int h = int.Parse(numbers[0]);
// int m = int.Parse(numbers[1]);
// int sec = int.Parse(numbers[2]);
//
// //요리하는데 필요한 시간 초단위
// //(0<=seconds<=500,000)
// int seconds = int.Parse(Console.ReadLine());
//
// //(0<=sec<=500059)
// sec += seconds; // 현재 초에 총 걸리는 초시간 더하기
//
// m += sec/60; //초시간의 몫을 구해서 분에 더하기
// // 0<= sec <= 19
// sec %= 60; //-> 총 초시간을 60초로 나눠서 나머지값 구하기
//
// // 0<= m <=8334 + 59 
// h += (m /60); 
// m %= 60; //총 걸린 분 시간을 60분으로 나눠서 나눈값....나머지...
//
// h %= 24;
//
// Console.WriteLine($"{h} {m} {sec}");




 // string str = Console.ReadLine();
 // string[] Number = str.Split(" ");
 //
 // int a = int.Parse(Number[0]);
 // int b = int.Parse(Number[1]);
 // int c = int.Parse(Number[2]);
 //
 // int gold =0;
 //
 // //세 수가 모두 같은 경우
 // if (a == b && b==c && a == c )
 // {
 //     gold = 10000 + (a*1000);
 // }
 //
 // //같은 눈이 두 개가 나오는 경우
 // //
 //
 // //a
 // else if (a == b && b!=c)
 // {
 //     gold = 1000 + (a * 100);
 // }
 //
 // //b
 // else if (b == c && c!=a )
 // {
 //     gold = 1000 + (b * 100);
 //     
 // }
 // //c기 
 // else if (c == a && a!=b )
 // {
 //     gold = 1000 + (a * 100);
 //     
 // }
 //
 // //모두 다른 눈이 나오는 경우
 // else if (a != b && b != c && a != c)
 // {
 //     //a가 숫자가 가장 큰 경우
 //     if (a > b && a > c)
 //     {
 //         gold = a * 100;
 //     }
 //     else if (b > a && b > c)
 //     {
 //         gold = b * 100;
 //     }
 //     else if (c > a && c > b)
 //     {
 //         gold = c * 100;
 //     }
 // }
 // Console.WriteLine(gold);

//  string str = Console.ReadLine();
//
//  string[] numbers = str.Split(" ");
//  int a = int.Parse(numbers[0]);
//  int b = int.Parse(numbers[1]);
//
// Console.WriteLine(a+b);



// string str = Console.ReadLine();
// string[] numbers = str.Split(" ");
// int a = int.Parse(numbers[0]);
// int b = int.Parse(numbers[1]);
// int c = int.Parse(numbers[2]);
// int d = int.Parse(numbers[3]);
// int e = int.Parse(numbers[4]);
//
// int checkNum = ((a*a) + (b*b) + (c*c) + (d*d) + (e*e))%10;
//
// Console.WriteLine(checkNum);




// int a = 100;
// int b=0;
// while(a>0)
// { a--;
//   b +=a;
// }
// Console.WriteLine(b);


//(1<= n=<9)



// int n = int.Parse(Console.ReadLine());
//
// for(int i =1; i<=9; i++)
// {
//   int output = (n*i);
//   
// Console.WriteLine($"{n} * {i} = {output}");
// }



// N(1 ≤ N ≤ 100)



// int n = int.Parse(Console.ReadLine());
// string str = "";
// for(int i=n; i>0; i--)
// {
//     str += "*";
//    
//     Console.WriteLine(str);
// }



// int a = int.Parse(Console.ReadLine());
// StringBuilder sb = new StringBuilder();
//
// for(int i = 1; i <= a; i++)
// {
//  sb.AppendLine(i.ToString());
// }
//  Console.WriteLine(sb.ToString());
    


//n은 수의 개수 , x 보다 작은 수 구하기

// int[] arr = new int[2];
// for (int i = 0; i < 2; i++)
// {
//   arr[i] = int.Parse(numbers[i]);
// }

//(1 ≤ N, X ≤ 10,000)
//첫째줄 n ,x


//정수 n개 로 이루어진 수열 A 정수X
//(1 <= n,x <= 10000)
//첫째 줄에 수열 a의 정수개수 n과 정수 x가 주어짐

// int [] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//
// int n = arr[0];
// int x = arr[1];
//
// //둘째 줄에 수열 a 입력받기
// int [] sec_arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//
// //n개의 개수만큼 수열 a를 만들기
//
// for(int i = 0; i < n; i++)
// {
//   if(sec_arr[i]<x)
//   {
//       Console.Write(sec_arr[i] + " ");
//   }
// }




// string a = Console.ReadLine();
//
// Console.WriteLine(a);
// string [] str =a.Split(" ");
// int b = int.Parse(str[0]);
//
// Console.WriteLine(b);
// Console.WriteLine(str);




// //배열 a의 정수개수 n / 정수 x 입력받기
// int [] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int n = arr[0];
// int x = arr[1];
//
// //수열 a 입력받기
// int [] arr02 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//
// //수열 a 배열로 나누기
// for(int i =0; i < n; i++)
// {
//  if(arr02[i]<x)
//  {
//   Console.Write(arr02[i] + " ");
//  }
// }
//
// //나눈 수열 x랑 비교해서 작은값 출력하기




// //테스트 케이스의 개수 T
//  int t = int.Parse(Console.ReadLine());
//
//  //t 개수의 두 수의 수열 주어짐
//  //첫번째 수열
//  int [] arr01 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//  int [] arr02 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//  int [] arr03 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//  int [] arr04 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//  int [] arr05 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//
//  //하나씩 빼기
//
//   int a = arr01[0];
//   int b = arr01[1];
//   int c = arr02[0];
//   int d = arr02[1];
//   int e = arr03[0];
//   int f = arr03[1];
//   int g = arr04[0];
//   int h = arr04[1];
//   int j = arr05[0];
//   int k = arr05[1];
//   Console.WriteLine(a+b);
//   Console.WriteLine(c+d);
//   Console.WriteLine(e+f);
//   Console.WriteLine(g+h);
//   Console.WriteLine(j+k);






//여러 개의 테스트 케이스 입력받기
//테스트 케이스의 개수 세기????




//입력이 있을 때 입력받기

// while(true)
// {
//     string str = Console.ReadLine();
//     string [] numbers = str.Split(" ");
//     
//     int a = int.Parse(numbers[0]);
//     int b = int.Parse(numbers[1]);
//     
//     Console.WriteLine(a+b);
//     
//     if (string.IsNullOrEmpty(str))
//     {
//     }
//     break;
//
// }

//여러개의 테스트 케이스 반복해서 입력 받기
// while(true)
// {
//  string str = Console.ReadLine();
//  
//  if(string.IsNullOrEmpty(str))
//   break;
//  
//  string [] numbers = str.Split();
//  int a = int.Parse(numbers[0]);
//  int b = int.Parse(numbers[1]);
//  
//  Console.WriteLine(a+b);
// }
//입력값이 없을 때 반복 멈추기



//여러 개의 테스트 케이스 입력받기
// while(true)
// {
//   string str = Console.ReadLine();
//     if(string.IsNullOrEmpty(str))
//         break;
//   string []numbers = str.Split();
//   int a = int.Parse(numbers[0]);
//   int b = int.Parse(numbers[1]);
//     if(a+b>0)
//     {
//     Console.WriteLine(a+b);
//     }
//     else;
// }

//입력값이 null값은 반환하지 않기


//9개의 자연수 입력받기


 
  
// int [] arr = new int [9];
// int a = 0;
// int n = 0;
// for(int i = 0; i < 9; i++)
// {
//   arr[i] = int.Parse(Console.ReadLine());
//   if(arr[i] > a)
//   {
//     a += ( arr[i] - a );
//     n = i + 1;
//   }
// }
// Console.WriteLine(a);
// Console.WriteLine(n);
//    


// string 배열 만들기
// string str = Console.ReadLine();
// int i = int.Parse(Console.ReadLine());
// int n= (i-1);
// Console.WriteLine(str[n]);


//배열 하나씩 빼서 i 숫자 변수에 집어 넣기

// 배열 단어와 i 숫자 출력하기




//--------------------------------

//11720번
//첫째 줄에 숫자의 개수 1<= N <=100
//둘쨰 줄에 숫자 n개 
//입력으로 주어진 숫자n개의 합을 출력하기

//n개의 배열을 만들기
//string str = Console.ReadLine();

//int [] number = [int.Parse(Console.ReadLine())];

// int n = int.Parse(Console.ReadLine());
// //int [] number = new int [n];
//
// //그 배열에 둘째 줄에 주어진 숫자들을 넣기??????????
//
//  string str = Console.ReadLine();
// int [] arr = str.Select(c => c -'0').ToArray();
//  int sum = 0;
//
// for(int i = 0; i < n; i++)
// {
//  int num = int.Parse(arr[i]);
//  sum += num;
//  
// }
//  Console.WriteLine(sum);
//
// //그 배열을 하나씩 꺼내서 더하기


//11654번

//  char ch = Console.ReadLine()[0]; 
//  int aschi = ch;
// Console.WriteLine(aschi);

// Console.WriteLine("         ,r'\"7");
// Console.WriteLine("r`-_   ,'  ,/");
// Console.WriteLine(" \\. \". L_r'");
// Console.WriteLine("   `~\\/");
// Console.WriteLine("      |");
// Console.WriteLine("      |");

//10818

//n개의 정수

//주어진 정수들을 입력받고
//새로운 변수를 만들어서 크기 비교하기


// int n = int.Parse(Console.ReadLine());
//
// string str = Console.ReadLine();
// string[] arr = str.Split();
// int max =  -1000000; // 최대값도 제일 작은 값을 넣어줘야 함
// int min = 1000000; //최소값을 구하려면 최소값을 제일 큰 값을 넣어야 한다.
//
// //최대값 구하기
// for (int i = 0; i < n; i++)
// {
//     int num = int.Parse(arr[i]);
//     
//     if(num > max)
//     {
//         max = num;
//     }
//     if(num < min)
//     {
//         min = num;
//     }
// }
// Console.WriteLine($"{min} {max}");

//2675번
//첫째 줄에 테스트 케이스의 개수 T(1 ≤ T ≤ 1,000)
//각 테스트 케이스는 반복 횟수 R(1 ≤ R ≤ 8), 문자열 S가 공백으로 구분되어 주어진다.
// S의 길이는 적어도 1이며, 20글자를 넘지 않는다. 

//테스트 케이스의 개수 t

//r번 반복해 4 abc
// i 3
// aaaabbbbcccc 
// 새 문자열을 만들기



//3.새 문자열 p를 만들고 출력하기













