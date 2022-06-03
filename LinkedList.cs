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


        /*
            1 ==> 2 ==> 3 ==> ==> 4 ==> 5 ==> 6
                        ||                   ||
                        ======================

            Detect a cycle
            ==============
            Tortoise and hare started from head
            Tortoise moves one step while the hare moves 2 steps, at some point, they'll both meet

            Detect start of cycle
            =====================
            A new slow animal snail started its own jouney from head while tortoise continues its own jorney from point k
            Tortoise and snail will end up meeting at the entry point of the cycle

            Complexity
            ==========
            T(n) ==> O(n)
            S(n) ==> O(1)
        */
        ListNode StartOfCycle(ListNode head)
        {
            if(head == null) //edge case
            return null;

            var tortoise = head;
            var hare = head;

            while(hare.next != null && hare.next.next != null)
            {
                //move both forward
                hare = hare.next.next;
                tortoise = tortoise.next;

                //detect cycle
                if(slow == hare)
                {
                    //find where the cycle begins
                    var snail = head;
                    while(tortoise != snail)
                    {
                        tortoise = tortoise.next;
                        snail = snail.next;
                    }
                    return snail;
                }
            }
            return null; //return null if there is not cycle
        }
    }
}