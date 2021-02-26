using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);
            Console.WriteLine();

            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = { 0, 1, 0, 3, 12 };
            MoveZeroes(ar2);
            Console.WriteLine();

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5, indices);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes, the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 2;
            if (HappyNumber(n8) == true)
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }
            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        ///  Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>

        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                // Creating two sub arrays of each of the length 'n', one for the x's and the other is for y's
                int[] ynums = new int[n];
                int[] xnums = new int[n];
                // Splitting the input array of length 2n into two equal parts of length 'n' each by using index positions into the array's created in the previous step
                Array.Copy(nums, 0, xnums, 0, n);
                Array.Copy(nums, n, ynums, 0, n);
                if (n == 1)
                {
                    // In case of a each length value of '1', the final output array can be directly printed as below 
                    Console.WriteLine("[" + xnums[0] + "," + ynums[0] + "]");
                }
                else
                {
                    // For the input array of any other value of length, we traverse through the following loop to print all the values as per the requirement one 'x' value followed by one 'y' value
                    for (int c = 0; c < n; c++)
                    {
                        // For printing the first x, y pai we will use the below block of code
                        if (c == 0)
                        {
                            Console.Write("[" + xnums[c] + "," + ynums[c]);
                        }
                        // For the last element we print the end tag with a different loop
                        else if (c == n - 1)
                        {
                            Console.Write("," + xnums[c] + "," + ynums[c] + "]");
                        }
                        // This block is intended for other middle x, y pairs
                        else
                        {
                            Console.Write("," + xnums[c] + "," + ynums[c]);
                        }
                    }
                }
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }
        }

        //Question 2:
        /// <summary>
        /// Write a method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements. 
        /// You must do this in-place without making a copy of the array.
        /// Example:
        ///Input: [0,1,0,3,12]
        /// Output: [1,3,12,0,0]
        /// </summary>

        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                int pos = 0;
                for (int a = 0; a < ar2.Length; a++)
                {
                    if (ar2[a] != 0)
                    {
                        int temp = ar2[a];
                        ar2[a] = ar2[pos];
                        ar2[pos++] = temp;
                    }
                }
                for (int b = 0; b < ar2.Length; b++)
                {
                    if (b == 0)
                    {
                        Console.Write("[" + ar2[b]);
                    }
                    else if (b == ar2.Length - 1)
                    {
                        Console.Write("," + ar2[b] + "]");
                    }
                    else
                    {
                        Console.Write("," + ar2[b]);
                    }
                }
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }
        }


        //Question 3
        /// <summary>
        /// For an array of integers - nums
        ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        ///Print the number of cool pairs
        ///Example 1
        ///Input: nums = [1,2,3,1,1,3]
        ///Output: 4
        ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5) 
        ///Example 3:
        ///Input: nums = [1, 2, 3]
        ///Output: 0
        ///Constraints: time complexity should be O(n).
        /// </summary>

        private static void CoolPairs(int[] nums)
        {
            try
            {
                // For counting the final number of cool pairs we use this count variable
                int count = 0;
                // A dictionary is used for storing the values and its corresponding frequency by comparing it with the input array
                Dictionary<int, int> cp = new Dictionary<int, int>();
                // The for loop below checks for each element from the input array and if it exists in the dictionary it adds the count of the number, if not it adds the number to the dictionary
                for (int b = 0; b < nums.Length; b++)
                {
                    int element = nums[b];
                    if (cp.ContainsKey(element))
                    {
                        cp[element]++;
                    }
                    else
                    {
                        cp.Add(element, 1);
                    }
                }
                // Finally using the foreach loop we calculate the total number of cool pairs by adding the each calculated value to the variable count
                foreach (KeyValuePair<int, int> k in cp)
                {
                    count += k.Value * (k.Value - 1) / 2;
                }
                // Print the value of the count of cool pairs
                Console.WriteLine(count);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }
        }

        //Question 4:
        /// <summary>
        /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can print the answer in any order
        ///Example 1:
        ///Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        ///Example 2:
        ///Input: nums = [3,2,4], target = 6
        ///Output: [1,2]
        ///Example 3:
        ///Input: nums = [3,3], target = 6
        ///Output: [0,1]
        ///Constraints: Time complexity should be O(n)
        /// </summary>
        private static void TwoSum(int[] nums, int target)
        {
            try
            {
                // The 'f' variable is used to store the index value of the first value of the target value
                int f = 0;
                // The 's' variable is used to store the index value of the second value of the target value
                int s = 0;
                // This variable is used for accessing the position of values, whose sum will give the target value
                int c = 0;
                // Creating a dictionary to identify the first and second number whose sum gives the target number
                Dictionary<int, int> ts = new Dictionary<int, int>();
                // In this loop we go through each element of the array and if the number in the index of array is in dictionary we assign its index value to the 'f' variable 
                // The corresponding number which is used for searching the index of the input array is copied in the second variable 's'
                while (c < nums.Length)
                {
                    if (ts.ContainsKey(nums[c]))
                    {
                        f = ts[nums[c]];
                        s = c;
                        // We then print the found index positions of the first and the second number
                        Console.WriteLine("[" + f + "," + s + "]");
                    }
                    else
                    {
                        // If the values are not found in te dictionary, then we add the difference of the target value and the value in the index of the number in the input array as the key value and the number in the value
                        ts.Add(target - nums[c], c);
                    }
                    c++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }

        }

        //Question 5:
        /// <summary>
        /// Given a string s and an integer array indices of the same length.
        ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Print the shuffled string.
        ///Example 1
        ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        ///Output: "usfrocky"
        ///Explanation: As shown in the assignment document, “K” should be at index 6, “O” should be at index 4 and so on. “korfsucy” becomes “usfrocky”
        ///Example 2:
        ///Input: s = "USF", indices = [0,1,2]
        ///Output: "USF"
        ///Explanation: After shuffling, each character remains in its position.
        ///Example 3:
        ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        ///Output: "rocky"
        /// </summary>
        private static void RestoreString(string s, int[] indices)
        {
            try
            {
                // Create a dictionary to store the indices array as key values and the corresponding characters in the string as the corresponding values of the dictionary
                Dictionary<int, char> rs = new Dictionary<int, char>();
                for (int d = 0; d < indices.Length; d++)
                {
                    // Add each index value and the char value from the string into the dictionary
                    rs.Add(indices[d], s[d]);
                }
                // Copy the keys into a new variable for sorting them in ascending order
                var keyList = rs.Keys.ToList();
                keyList.Sort();
                // After sorting print the corresponding key values from the dictionary which prints the sorted characters of the string
                foreach (var key in keyList)
                {
                    Console.Write(rs[key]);
                }
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }
        }

        //Question 6
        /// <summary>
        /// Determine whether two give strings s1 and s2, are isomorphic.
        ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        ///No two characters may map to the same character but a character may map to itself.
        ///Example 1:
        ///Input:s1 = “bulls” s2 = “sunny” 
        ///Output : True
        ///Explanation: ‘b’ can be replaced with ‘s’ and similarly ‘u’ with ‘u’, ‘l’ with ‘n’ and ‘s’ with ‘y’.
        ///Example 2:
        ///Input: s1 = “usf” s2 = “add”
        ///Output : False
        ///Explanation: ‘u’ can be replaced with ‘a’, but ‘s’ and ‘f’ should be replaced with ‘d’ to produce s2, which is not possible. So False.
        ///Example 3:
        ///Input : s1 = “ab” s2 = “aa”
        ///Output: False
        /// </summary>
        private static bool Isomorphic(string s1, string s2)
        {
            try
            {
                // If the length of the two strings are different then we can directly say that they are not isomorphic
                if (s1.Length != s2.Length)
                {
                    return false;
                }
                // Create a dictionary to compare the similarity of the characters from both the input strings
                Dictionary<char, char> dict = new Dictionary<char, char>();
                // Use the loop to traverse through both the strings to compare the similarity of the strings
                for (int e = 0; e < s1.Length; e++)
                {
                    // Copy each character value from the strings to a new temporary characters 
                    char c1 = s1[e];
                    char c2 = s2[e];
                    // If the dictionary contains the key then we compare it with the corresponding value with the character at the same position from the second string
                    if (dict.ContainsKey(c1))
                    {
                        // If the dictionary value from first string doesn't match with the second string's character at the corresponding position then we retrun false 
                        if (dict[c1] != c2)
                        {
                            return false;
                        }
                    }
                    // If the dictionary does not contain the first string character at that corresponding position we add it to the dictionary
                    else
                    {
                        dict.Add(c1, c2);
                    }
                }
                // Create a hash set to store all the dictionary values or the frequency of the dictionary key's in it 
                HashSet<char> set = new HashSet<char>(dict.Values);
                // If the total count of the values in the hash set and the dictionary values are same then it is isomorphic and we return true
                if (set.Count == dict.Values.Count)
                {
                    return true;
                }
                // In all other cases we return false
                return false;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                throw;
            }
        }

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            try
            {
                // Create a new array for saving the id values of the students
                int[] key = new int[items.GetLength(0)];
                // Creating two arrays to save the values of each corresponding students
                int[] val1 = new int[items.GetLength(0)];
                int[] val2 = new int[items.GetLength(0)];
                // Creating two variables sum1 and sum2 to calculate the top 5 scores and average it 
                int sum1 = 0;
                int sum2 = 0;
                // Limiting the total count of scores for each student to 5 we create count1 and count2 varaibels
                int count1 = 0;
                int count2 = 0;
                // In case of any other values for validating the negative or non-numeric values we use a counter variable to make sure exactly 5 non-negative values are added to find the average
                int counter = 0;
                // Loop through the arrays and add all the student id's to the array named key
                for (int f = 0; f < items.GetLength(0); f++)
                {
                    key[f] = items[f, 0];
                }
                // From those identify the unique keys by using the distict method from Linq and save thsoe unique key values in an array 
                int[] unique = key.Distinct<int>().ToArray();
                // Each of the unique student id values are stored in two separate integer variables for comparison 
                int keyValue1 = unique[0];
                int keyValue2 = unique[1];
                // Traverse through the input 2D array and compare the student id's from input array with the unique id values and save the corresponding score values from 2D array to the created arrays of val1 and val2 
                for (int g = 0; g < items.GetLength(0); g++)
                {
                    // If the student id value from the input array matches with the one of the unique key values then add the corresponding score values to one of the arrays
                    if (items[g, 0] == keyValue1)
                    {
                        val1[count1] = items[g, 1];
                        count1++;
                    }
                    // If the student id value from the input array matches with the other unique key value then add the corresponding score values to other array
                    else if (items[g, 0] == keyValue2)
                    {
                        val2[count2] = items[g, 1];
                        count2++;
                    }
                }
                // Then sort both the arrays and reverse them to have them in descending order
                Array.Sort(val1);
                Array.Reverse(val1);
                Array.Sort(val2);
                Array.Reverse(val2);
                // Create a loop to traverse through both the arrays and add 5 non negative numbers for each student id
                for (int h = 0; h < items.GetLength(0); h++)
                {
                    if (val1[h] >= 0 && val1[h] <= 100 && val2[h] >= 0 && val2[h] <= 100 && counter < 5)
                    {
                        sum1 += val1[h];
                        sum2 += val2[h];
                        counter++;
                    }
                }
                // Finally print the student id and its corresponding average value by dividing its calculated sum value by 5 
                Console.WriteLine("[[" + unique[0] + "," + (sum1 / 5) + "],[" + unique[1] + "," + (sum2 / 5) + "]]");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }
        }

        //Question 8
        /// <summary>
        /// Write an algorithm to determine if a number n is happy.
        ///A happy number is a number defined by the following process:
        ///•	Starting with any positive integer, replace the number by the sum of the squares of its digits.
        ///•	Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        ///•	Those numbers for which this process ends in 1 are happy.
        ///Return true if n is a happy number, and false if not.
        ///Example 1:
        ///Input: n = 19
        ///Output: true
        ///Explanation:
        ///12 + 92 = 82
        ///82 + 22 = 68
        ///62 + 82 = 100
        ///12 + 02 + 02 = 1
        ///Example 2:
        ///Input: n = 2
        ///Output: false
        ///Constraints:
        ///1 <= n <= 231 - 1
        /// </summary>

        private static bool HappyNumber(int n)
        {
            try
            {
                // Create a list to store all the numbers that have been already checked for the sum of squared to be 1
                List<int> list = new List<int>();
                // Loop through the given input number to calculate the squares of sum of each digit in the number
                while (n > 0)
                {
                    // Declare a variable sum to calculate the sum of the squares of the digits of a number
                    int sum = 0;
                    // Convert the given input integer to a string to easily access all the individual digits of the number
                    string num = n.ToString();
                    // Converting the number to string traverse through the length of the string to cut off the number at each index, convert it back to integer and squaring it, adding it to the sum variable
                    for (int i = 0; i < num.Length; i++)
                    {
                        int temp = int.Parse(new string(num[i], 1));
                        sum += (temp * temp);
                    }
                    // From the above loop we get the sum of the squares of the digits of the input number in the variable sum
                    n = sum;
                    // If the sum of the squares of the digits is 1 then we return that the number is a happy number
                    if (sum == 1)
                    {
                        return true;
                    }
                    // While adding a number to the list, if it's already present in the list then we return false and say that the given number is not a happy number
                    foreach (int val in list)
                    {
                        if (val == n)
                        {
                            return false;
                        }
                    }
                    // We add the number into the list if it's not already present in the list and continue the while loop until the sum value is 1
                    list.Add(n);
                }
                return false;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                throw;
            }
        }

        //Question 9
        /// <summary>
        /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        /// If you cannot achieve any profit return 0.
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        /// Example 2:
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        ///Explanation: In this case, no transactions are done and the max profit = 0.
        ///Try to solve it in O(n) time complexity.
        /// </summary>

        private static int Stocks(int[] prices)
        {
            try
            {
                // Create a min and max variables for storing the stock with min and max price
                int min = 100;
                int max = 0;
                // Create a variable to store the position of the min variable so that the pos of max variable greater than the pos of min variable
                int pos = 0;
                // Declare a variable profit to calculate the difference between the max and min value of the share
                int profit = 0;
                // Traverse through the input array to calcuate the min and max values as well as the position of the min value of the shares given in the input array
                for (int j = 0; j < prices.Length; j++)
                {
                    if (prices[j] >= 0)
                    {
                        if (prices[j] < min)
                        {
                            min = prices[j];
                            pos = j;
                        }
                        // The max value should be always above the position of the min variable because we can sell a share only after buying it at the min value
                        if (prices[j] > max && j > pos)
                        {
                            max = prices[j];
                        }
                    }
                }
                // The profit value is calculate by the difference of the max and min value
                profit = max - min;
                // If the calculated profit value is greater than zero then return the corresponding profit value to the calling function
                if (profit > 0)
                {
                    return profit;
                }
                // Else in all other cases we return the profit values as 0
                return 0;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                throw;
            }
        }

        //Question 10
        /// <summary>
        /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        /// Print the number of unique ways. 
        /// Example 1:
        ///Input: n = 2
        ///Output: 2
        ///Explanation: There are two ways to climb to the top.
        ///1. 1 step + 1 step
        ///2. 2 steps
        ///Example 2:
        ///Input: n = 3
        ///Output: 3
        ///Explanation: There are three ways to climb to the top.
        ///1. 1 step + 1 step + 1 step
        ///2. 1 step + 2 steps
        ///3. 2 steps + 1 step
        ///Hint : Use the concept of Fibonacci series.
        /// </summary>

        private static void Stairs(int steps)
        {
            try
            {
                // Create an array result with the length of 'steps + 1' when the number of steps is given to the function as input
                int[] result = new int[steps + 1];
                // The possibilities of climbing no steps is in 1 way and 1 step is 1 way and 2 steps is in 2 ways. So we store them in the first three index places of the array
                result[0] = 1;
                result[1] = 1;
                result[2] = 2;
                // Traverse through the loop until the number of steps given as input to the function
                for (int k = 3; k <= steps; k++)
                {
                    // Initialize the value of the array with 0
                    result[k] = 0;
                    // Create another loop to make sure that the only number of steps are just 1 or 2
                    for (int l = 1; l <= 2 && (k - l) >= 0; l++)
                    {
                        // Now add the number of ways by adding the ways of all the numbers by calculating the corresponding 'k-l' value to the exisiting array position or the current step value
                        result[k] += result[k - l];
                    }
                }
                // Finally return the number of ways value stored for the final steps in the final steps position of the array 
                Console.WriteLine(result[steps]);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}