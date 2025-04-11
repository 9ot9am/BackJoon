// 19 -> 104
// 20 -> 204
// 21 -> 304
// 22 -> 404
// 23 -> 504
// 24 -> 604

// 25 -> 105
// 26 -> 205
// 27 -> 305
// 28 -> 405
// 29 -> 505
// 30 -> 605

// 12, 6
// w, h

// n
// 19 -> 1
// 19 = 6 + 6 + 6 + 1
// 1 = 19 % 6
// floor = n % h


// w = 12
// h = 6
// n = 19
// 19 -> 4
// room = 4 ???

// 17 - 1 / 6 = 2

// 18 - 1 / 6 = 2

// 19 - 1 / 6 = 3
// 20 - 1 / 6 = 3
// 21 - 1 / 6 = 3
// 22 - 1 / 6 = 3
// 23 - 1 / 6 = 3
// 24 - 1 / 6 = 3 + 1 = 4
// room = (n - 1) / h + 1

// 25 - 1 / 6 = 4


// floor = n % h
// room = (n - 1) / h + 1

// 305
// floor 0 room


/*
 * 2
   6 12 10
   30 50 72
 */
 
    // int caseCount = int.Parse(Console.ReadLine());
    //
    // for (int i = 0; i < caseCount; i++)
    // {
    //     string s = Console.ReadLine();
    //     int[] numbers = Array.ConvertAll(s.Split(' '), int.Parse);
    //     int h = numbers[0];
    //     int w = numbers[1];
    //     int n = numbers[2];
    //    
    //     int floor = n % h;
    //     if (floor == 0)
    //     {
    //         floor = h;
    //     }
    //     int room = (n - 1) / h + 1;
    //     if (room < 10)
    //     {
    //         Console.WriteLine($"{floor}0{room}");
    //     }
    //     else
    //     {
    //         Console.WriteLine($"{floor}{room}");
    //     }
    // }
    


    //int floor = n%h;
    //room = (n-1) / h +1;


    
    // int t = int.Parse(Console.ReadLine());
    //
    // for (int i = 0; i < t; i++)
    // {
    //     int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    //     
    //     int h = arr[0];
    //     int w = arr[1];
    //     int n = arr[2];
    //
    //     int floor = n % h;
    //     int room = ((n - 1) / h) + 1;
    //
    //     if (floor == 0)
    //     {
    //         floor = h;
    //     }
    //     
    //     if(room >= 10)
    //         Console.WriteLine($"{floor}{room}");
    //
    //     else
    //         Console.WriteLine($"{floor}0{room}");
    //     
    // }

    
    
    
    
    
    
    
    
    
    
    
    
    