// See https://aka.ms/new-console-template for more information
using LeetCode.Easy;
using LeetCode.Medium;

Console.WriteLine("Hello, World!");
ConsoleMain.ConsoleMain.Main();


namespace ConsoleMain
{
    class ConsoleMain
    {
        /// <summary>
        /// ConsoleAPP Ana Fonksiyon
        /// </summary>
        public static void Main()
        {
            Console.WriteLine($"Which Operation Do You Want To Proceed?" +
                $"{Environment.NewLine}1 - Binary Search" +
                $"{Environment.NewLine}2 - First Bad Version" +
                $"{Environment.NewLine}3 - Linked List Cycle" +
                $"{Environment.NewLine}4 - Squares Of A Sorted Array" +
                $"{Environment.NewLine}5 - Rotate Array" + $"{Environment.NewLine}6 - Move Zeroes" + $"{Environment.NewLine}7 - Two Sum 2" +
                $"{Environment.NewLine}8 - Reverse String" + $"{Environment.NewLine}9 - Reverse Words In A String III" + $"{Environment.NewLine}10 - Palindrome Number" +
                $"{Environment.NewLine}11 - Reverse Integer" + $"{Environment.NewLine}12 - Longest Substring Without Repeating Characters"
                );

            string? mainReply = Console.ReadLine();

            if (mainReply == "1")
                new Q704BinarySearch().Solution();
            else if (mainReply == "2")
                new Q278FirstBadVersion().Solution();
            else if (mainReply == "3")
                new Q141LinkedListCycle().Solution();
            else if (mainReply == "4")
                new Q977SquaresOfASortedArray().Solution();
            else if (mainReply == "5")
                new Q189RotateArray().Solution();
            else if (mainReply == "6")
                new Q238MoveZeroes().Solution();
            else if (mainReply == "7")
                new Q167TwoSum2().Solution();
            else if (mainReply == "8")
                new Q344ReverseString().Solution();
            else if (mainReply == "9")
                new Q557ReverseWordsInAStringIII().Solution();
            else if (mainReply == "10")
                new Q9PalindromeNumber().Solution();
            else if (mainReply == "11")
                new Q7ReverseInteger().Solution();
            else if (mainReply == "12")
                new Q3LongestSubstringWithoutRepeatingCharacters().Solution();
        }
    }
}