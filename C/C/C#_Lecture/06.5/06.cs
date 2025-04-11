// 1부터999까지의 임의의 정수 10개의 합을 구해서 출력해보기
//     •단, 1~9, 10~99, 100~999 까지의 수를 구분하여, 각각 더해서 출력 결과가 총 3개가 되도록 출력
//     ex)
// 20, 30, 40, 180, 200, 9, 6, 72, 109, 999
//     -> (9 + 6), (20 + 30 + 40 + 72), (180 + 200 + 109 + 999)
//     -> •15, 162, 1488
//     



    //int array를 입력 받고
    //그 값이 n <10 이면 실행하고 아니면 멈추기 n < 100 n <1000
    //그 안에서 더하기
    //Console.Write 로 각각 출력  
    
    // int [] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    //
    // int sum = 0;
    // int sumsec = 0;
    // int sumthir = 0;
    //
    // for (int i = 0; i < arr.Length; i++)
    // {
    //     if (arr[i] < 10)
    //     { 
    //         sum += arr[i];
    //     }        
    //     
    //     else if (arr[i] < 100)
    //     {
    //         sumsec += arr[i];
    //     }        
    //     
    //     else if (arr[i] < 1000)
    //     {
    //         sumthir += arr[i];
    //     }
    // }
    //
    // Console.Write($"{sum}, {sumsec}, {sumthir}");
    

    // 미니문제
    //컴퓨터는 위에서부터 아래로 순차적으로 계산하기 때문에
    //위에서 이미10 이하의 수들은 계산을 하고 내려왔기 때문에
    // 그 아래에 10보다 크다는 조건을 더 붙일 필요가 없다
    
    // int x = int.Parse(Console.ReadLine());
    //
    // if(x<10)
    //     Console.WriteLine("1자리 수");
    // else if (x < 100)
    //     Console.WriteLine("2자리수");
    // else if(x < 1000)
    //     Console.WriteLine("3자리 수");