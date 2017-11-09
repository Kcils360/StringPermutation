# StringPermutation

https://www.w3resource.com/csharp-exercises/recursion/csharp-recursion-exercise-11.php </br>
https://www.codeproject.com/Articles/37215/Permutations-in-C-Using-Recursion </br>

I used these two websites to find a working solution.  I understand the problem domain, but I don't have the math or code skills to figure this kind of stuff out on my own, so I will find a solution and understand what is happening.  Also, the fact that the number of solutions in N factorial means after about 5, it gets beyond my capabilities to physically grasp. So, as I understand the code to work, we start with 2 integers.  One is set to the starting position of the array (k) and the other is equal to the length of the array (m).  We start looping thru the array by increasing k by one. When k == m, we then loop thru the array in its current state and print each value.  At the end, k goes back to 0 and we call a switch function with switches the value of the array at k with the value of the array at i which will only increase with each print loop.  So we loop to get k  = m, print loop, switch values, loop to get k = m, print loop.  Cool!  </br>

Currently, I have a hard coded array with 4 letters, but I'm working on making it so a user can pick 1-26.
