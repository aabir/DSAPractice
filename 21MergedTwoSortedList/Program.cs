namespace _21MergedTwoSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode list1 = new ListNode(1);
            list1.next = new ListNode(3);
            list1.next.next = new ListNode(5);

            // Create the second sorted linked list: 2 -> 4 -> 6
            ListNode list2 = new ListNode(2);
            list2.next = new ListNode(4);
            list2.next.next = new ListNode(6);

            // Merge the two lists
            Solution solution = new Solution();
            ListNode mergedList = solution.MergeTwoLists(list1, list2);

            // Print the merged list
            Console.WriteLine("Merged List:");
            while (mergedList != null)
            {
                Console.Write(mergedList.val + " -> ");
                mergedList = mergedList.next;
            }
            Console.WriteLine("null");
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else 
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

            if(list1 != null)
            {
                current.next = list1;
            }
            else if (list2 != null)
            {
                current.next = list2;
            }
            return dummy.next;
        }
    }
}
