using System;

namespace dsa
{
    public class LinkedList
    {
        /*
        1 ==> 2 ==> 3 ==> ==> 4 ==> 5 ==> 6
                    ||                    ||
                     ======================

        Detect a cycle
        slow and fast started from head
        slow moves one step while the fast moves 2 steps, at some point, they'll both meet

        Complexity
        T(n) ==> O(n)
        S(n) ==> O(1)
        */
        static bool HasCycle(ListNode head)
        {
            if(head == null) return null; //edge case

            var slow = head;
            var fast = head;


            while(fast.next != null && fast.next.next != null)
            {
                //slow make one step
                slow = slow.next;

                //fast makes 2 step
                fast = fast.next.next;

                if(slow == fast) //if they both meet at this point
                    return true; //there is a cycle
            }

            return false; // if we gets here, there is no cycle
        }
    }
}