// •아래처럼 각 층 별로 숫자를 매겨 나갈 경우에, 임의의 정수가 몇 층인지 출력해보기

    // 제곱 표현하기
    
    //1-15까지 입력을 받기
    //숫자가 1 2 4 8로 시작을 하면 각각 1층 2층 3층 4층 
    //2의 0승 2의1승 2의 2승 2의 3승
    //2에 0승이면 0+1이 층수 // 제곱근에 +1을 하는 것이 층수
    
    // int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    // int num = int.Parse(Console.ReadLine());
    // int floor = 0;
    // for (int i = 0; i < arr.Length; i++)
    // {
    //     if (arr[i] == 1)
    //     {
    //         floor = 1;
    //     }
    //     
    //     else if (arr[i] >= 2 && arr[i] < 4)
    //     {
    //         floor = 2;
    //     }
    //
    //     else if (arr[i] >= 4 && arr[i] < 8)
    //     {
    //         floor = 3;
    //     }
    //     
    //     else if (arr[i] >= 8 && arr[i] < 16)
    //     {
    //         floor = 4;
    //     }
    // }

    // int num = int.Parse(Console.ReadLine());
    //
    // switch (num)
    // {   
    //     case = 
    //     
    // }


    //제곱근 표현하기
    // int sqrt(int a, int b) //2 0 = 1
    // {
    //     for (int i = 0; i < b; i++)
    //     {
    //         a *= b;
    //     }
    //
    //     
    // }
    


    //---------------------------------
    // int num = int.Parse(Console.ReadLine());
    // //임의의 정수가 2가 몇 번 곱해졌는지 확인하기
    // if (num / 2 < 0)
    // {
    //     
    // }
    

    //-----------------------------
    //1 3 7 15의 경계값을 limit로 설정해서
    // 1은 2보다 작고 , 3은 4보다 작고, 7은 8보다 작음
    //이걸 활용해서 

    // int num = 5;
    // int floorLimit = 2;
    // for (int floor = 1; floor <= 10; ++floor, floorLimit *= 2)
    // {
    //     if (num < floorLimit)
    //     {
    //         Console.WriteLine(floor);
    //         break;
    //     }
    // }

    // ```C# ```