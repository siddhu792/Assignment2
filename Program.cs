using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1:
            Console.WriteLine("Question 1");
            int[] nums1 = { 2, 5, 1, 3, 4, 7 };
            int[] nums2 = { 2, 1, 4, 7 };
            Intersection(nums1, nums2);
            Console.WriteLine("");

            //Q2 
            Console.WriteLine("Question 2");
            int[] nums = { 0, 1, 0, 3, 12 };
            Console.WriteLine("Enter the target number:");
            int target = Int32.Parse(Console.ReadLine());
            int pos = SearchInsert(nums, target);
            Console.WriteLine("Insert Position of the target is : {0}", pos);
            Console.WriteLine("");

            //Q3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 2, 3, 1, 1, 3 };
            int Lnum = LuckyNumber(ar3);
            if (Lnum == -1)
                Console.WriteLine("Given Array doesn't have any lucky Integer");
            else
                Console.WriteLine("Lucky Integer for given array {0}", Lnum);

            Console.WriteLine();

            //Q4
            Console.WriteLine("Question 4");
            Console.WriteLine("Enter the value for n:");
            int n = Int32.Parse(Console.ReadLine());
            int Ma = GenerateNums(n);
            Console.WriteLine("Maximun Element in the Generated Array is {0}", Ma);
            Console.WriteLine();

            //Q5

            Console.WriteLine("Question 5");
            List<List<string>> cities = new List<List<string>>();
            cities.Add(new List<string>() { "London", "New York" });
            cities.Add(new List<string>() { "New York", "Tampa" });
            cities.Add(new List<string>() { "Delhi", "London" });
            string Dcity = DestCity(cities);
            Console.WriteLine("Destination City for Given Route is : {0}", Dcity);

            Console.WriteLine();

            //Q6
            Console.WriteLine("Question 6");
            int[] Nums = { 2, 7, 11, 15 };
            int target_sum = 9;
            targetSum(Nums, target_sum);
            Console.WriteLine();

            //Q7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Q8
            Console.WriteLine("Question 8");
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int K = 3;
            RotateArray(arr, K);

            Console.WriteLine();

            //Q9
            Console.WriteLine("Question 9");
            int[] arr9 = { 5, 4, -1, 7, 8 };
            int Ms = MaximumSum(arr9);
            Console.WriteLine("Maximun Sum contiguous subarray {0}", Ms);
            Console.WriteLine();

            //10
            Console.WriteLine("Question 10");
            int[] costs = { 10, 15, 20 };
            int minCost = MinCostToClimb(costs);
            Console.WriteLine("Minium cost to climb the top stair {0}", minCost);
            Console.WriteLine();
        }

 


        /// <logic>
        /// i have used dictionaries to find whether there is common intersection between two arrays
        /// i will loop through the hash set to find whether element is present or not
        /// <selfReflection>
        /// i learnt how to use hashset

        public static void Intersection(int[] nums1, int[] nums2)
        {
            try
            {
                var list = new List<int>();
                var hash = new HashSet<int>();

                foreach (var num in nums1)
                    hash.Add(num);

                foreach (var num in nums2)
                {
                    if (hash.Contains(num) && !list.Contains(num))
                    {
                        list.Add(num);
                    }
                }
                foreach (var i in list)
                {
                    Console.Write(i + " ");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        /// <logic>
        /// i have used binary search to find whether element is present or not
        /// if element is present will return index of element, if it is not present we will return the nearest index
        /// <selfReflection>
        /// i learnt how to use while loop
        public static int SearchInsert(int[] nums, int target)
        {
            try
            {
                int left = 0;
                int right = nums.Length - 1;

                while (left <= right)
                {
                    int mid = (right + left) / 2;
                    if (nums[mid] < target) left = mid + 1;
                    else if (nums[mid] > target) right = mid - 1;
                    else return mid;
                }
                return left;
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <logic>
        /// i have used dictionaries to find most frequent element
        /// i will loop through the hash set to find whether element is present or not
        /// <selfReflection>
        /// i learnt how to use hashset

        private static int LuckyNumber(int[] nums)
        {
            try
            {
                var has1 = new Dictionary<int, int>();
                foreach (int i in nums)
                {
                    if (has1.ContainsKey(i))
                    {
                        has1[i] += 1;

                    }
                    else
                    {
                        has1[i] = 1;
                    }
                }

                int max = -1;
                foreach (var kv in has1)
                    if (kv.Key == kv.Value)
                        max = Math.Max(max, kv.Key);

                return max;
            }
            catch (Exception)
            {

                throw;
            }
        }



        /// <logic>
        /// i have used array to generate the sequence if element is divisible by 2 array[i] = array[x] where x=i/2
        /// we are using the previous value to calculate the present value
        /// <selfReflection>
        /// i have used Dyanmic Programming to solve this

        private static int GenerateNums(int n)
        {
            try
            {
                int[] array = new int[n + 2];
                array[0] = 0;
                array[1] = 1;
                if (n == 0)
                {
                    return 0;
                }

                for (int i = 2; i < n + 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        int x;
                        x = i / 2;
                        array[i] = array[x];
                    }
                    else
                    {
                        int z;
                        z = i / 2;
                        array[i] = array[z] + array[z + 1];
                    }
                }
                return array.Max();
            }
            catch (Exception)
            {

                throw;
            }

        }

        


        /// <logic>
        /// i have used dictionaries to find most frequent element
        /// i will loop through the hash set to find whether element is present or not
        /// <selfReflection>
        /// i learnt how to use hashset
        /// 
        public static string DestCity(List<List<string>> paths)
        {
            try
            {
                var origins = new HashSet<string>();
                var destinations = new HashSet<string>();
                for (int i = 0; i < paths.Count; i++)
                {
                    origins.Add(paths[i][0]);
                    destinations.Add(paths[i][1]);
                }
                string result = null;
                for (int i = 0; i < paths.Count; i++)
                {
                    if (!origins.Contains(paths[i][1]))
                    {
                        result = paths[i][1];
                    }
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

       

        /// <logic>
        /// i have used two pointers left and right where left=0 and right=array.Length
        /// i will loop through the nums to find the target using condition left<right
        /// <selfReflection>
        /// i learnt how to use pointers

        private static void targetSum(int[] nums, int target)
        {
            try
            {
                int left = 0;
                int x = 0;
                int y = 0;
                int right = nums.Length - 1;
                while (left < right)
                {
                    if (nums[left] + nums[right] == target)
                    {
                        x = left + 1;
                        y = right + 1;

                        break;

                    }
                    else if (nums[left] + nums[right] > target)
                    {
                        right = right - 1;
                    }
                    else
                    {
                        left = left + 1;
                    }




                }
                Console.Write(x + " " + y);


            }
            catch (Exception)
            {

                throw;
            }
        }

        
        /*
           Logic:
           Here i used  dictionary to store the values associated with each ID in the list as value,
           then i sorted the values for each key and used inbuilt LIst functions to extract first 5 elements
           and cacluated there Average.
           */

        private static void HighFive(int[,] items)
        {
            try
            {
                List<List<int>> ans = new List<List<int>>();
                Dictionary<int, List<int>> track = new Dictionary<int, List<int>>();
                for (int i = 0; i < items.GetLength(0); i++)
                {
                    if (!track.ContainsKey(items[i, 0]))
                    {
                        track.Add(items[i, 0], new List<int>());
                        track[items[i, 0]].Add(items[i, 1]);
                    }
                    else
                        track[items[i, 0]].Add(items[i, 1]);
                }

                foreach (var x in track)
                {
                    track[x.Key].Sort();
                    track[x.Key].Reverse();
                }

                foreach (var x in track)
                {
                    List<int> temp = new List<int>();
                    temp.Add(x.Key);
                    temp.Add((int)track[x.Key].GetRange(0, 5).AsQueryable().Sum() / 5);
                    ans.Add(temp);

                }

                foreach (var x in ans)
                {
                    Console.Write("[");
                    foreach (var j in x)
                        Console.Write(j + " ");
                    Console.Write("]");
                }
                Console.WriteLine();


            }
            catch (Exception)
            {

                throw;
            }
        }

       

        /// <logic>
        /// i have used array in question and swaping the index with first element to last last element until the total swaps are equal to k
        /// <selfreflection>
        /// 
        /// i learnt how to call the function by using call by reference

        private static void RotateArray(int[] arr, int n)
        {
            try
            {
                int length = arr.Length;
                n %= length;
                if (n == 0)
                    foreach (var k in arr)
                    {
                        Console.Write(k + " ");
                    }

                int count = 0;
                for (int i = 0; count < length; i++)
                {
                    int curInd = i;
                    int prev = arr[i];
                    do
                    {
                        int nextInd = (curInd + n) % length;
                        int temp = arr[nextInd];
                        arr[nextInd] = prev;
                        curInd = nextInd;
                        prev = temp;
                        count++;
                    } while (curInd != i);
                    foreach (var k in arr)
                    {
                        Console.Write(k + " ");
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        


        ///<logic>
        /// i have used two variables great and count where great is initilized to arr[0] and count to 0
        /// we loop through the array and compare max value between count and great
        /// <selfreflection>
        /// timecomplexity=O(N)
        /// spacecomplexity=O(1)


        private static int MaximumSum(int[] arr)
        {
            try
            {
                int great = arr[0];
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    count = Math.Max(arr[i], count + arr[i]);
                    great = Math.Max(count, great);



                }
                return great;
            }
            catch (Exception)
            {

                throw;
            }
        }

        

        ///<logic>
        /// i have used dynamic programming to solve this question where we make decision whether to take 1 step or 2 steps
        /// where we use to calculate dp[i] = costs[i] + Math.Min(dp[i - 1], dp[i - 2])
        /// at last we return Min(dp[n - 1], dp[n - 2])
        /// <selfreflection>
        /// timecomplexity=O(N)
        /// spacecomplexity=O(N)
        /// i learnt looping through the aarray

        private static int MinCostToClimb(int[] costs)
        {
            try
            {
                int n = costs.Length;
                int[] dp = new int[n];
                dp[0] = costs[0];
                dp[1] = costs[1];
                if (n == 1)
                {
                    return costs[0];
                }
                if (n == 2)
                {
                    return costs.Min();
                }

                for (int i = 2; i < n; i++)
                {
                    dp[i] = costs[i] + Math.Min(dp[i - 1], dp[i - 2]);
                }
                return Math.Min(dp[n - 1], dp[n - 2]);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}