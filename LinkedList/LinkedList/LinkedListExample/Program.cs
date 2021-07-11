using System;

namespace LinkedList
{
    class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    class Program
    {
        public static SinglyLinkedListNode reverse(SinglyLinkedListNode originalHead)
        {
            SinglyLinkedListNode inProcess = originalHead;
            SinglyLinkedListNode previous = null;

            while (inProcess != null)
            {
                //keep track of which one needs to be processed next.
                SinglyLinkedListNode next = inProcess.next;

                //reset the values of what you're currently working on.
                inProcess.next = previous;
                previous = inProcess;
                
                //Advance the loop.
                inProcess = next;
            }

            //Note: Return the previous, because at this point, current is null.
            return previous;

        }

        static void Main(string[] args)
        {
            //The values being passed in are meaningless, a mistake I initially made.
            var head = new SinglyLinkedListNode(15);
            var x = new SinglyLinkedListNode(41);
            var y = new SinglyLinkedListNode(36452);
            var z = new SinglyLinkedListNode(3);

            head.next = x;
            x.next = y;
            y.next = z;

            head = reverse(head);

            while (head!=null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }
        }
    }
}