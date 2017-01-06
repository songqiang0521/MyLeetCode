using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class AddTwoNumbersSolution
    {
        private Queue<int> numbers1;
        private Queue<int> numbers2;
        //private int[] numbers3;
        //private int[] numbers4;

        private int[] results;

        /// <summary>
        /// 获取节点个数
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        private int GetNodeCount(ListNode l)
        {
            int count = 1;
            while (l.next != null)
            {
                count++;
                l = l.next;
            }
            return count;
        }

        private Queue<int> GetNumbersFromListNode(ListNode l1)
        {
            ListNode tempNode = l1;
            int count = GetNodeCount(tempNode);
            Queue<int> numbers = new Queue<int>(count);

            for (int i = 0; i < count; i++)
            {
                numbers.Enqueue(tempNode.val);
                tempNode = tempNode.next;
            }
            return numbers;
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int count1 = GetNodeCount(l1);
            int count2 = GetNodeCount(l2);

            int count = Math.Max(count1, count2);

            if (count == 0)
            {
                return null;
            }
            numbers1 = GetNumbersFromListNode(l1);
            numbers2 = GetNumbersFromListNode(l2);

            for (int i = count1; i < count; i++)
            {
                numbers1.Enqueue(0);
            }
            for (int i = count2; i < count; i++)
            {
                numbers2.Enqueue(0);
            }


            results = new int[count + 1];

            for (int i = 0; i < count; i++)
            {
                int num = numbers1.Dequeue() + numbers2.Dequeue() + results[i];
                if (num > 9)
                {
                    results[i + 1] += 1;
                }
                results[i] = num % 10;
            }

            if (results[count] == 0)
            {
                return MakeListNodeByNumbers(results, count);
            }
            else
            {
                return MakeListNodeByNumbers(results, count + 1);
            }

        }

        private ListNode MakeListNodeByNumbers(int[] results, int count)
        {

            ListNode node = new ListNode(results[0]);
            int x = 1;

            ListNode tempNode = node;
            while (count > 1)
            {
                tempNode.next = new ListNode(results[x]);
                tempNode = tempNode.next;
                count--;
                x++;
            }

            return node;
        }

        private int GetLastNumber(int num)
        {
            return num % 10;
        }

    }

}
