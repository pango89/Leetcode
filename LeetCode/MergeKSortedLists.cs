using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class PQNode
    {
        public ListNode listNode;
        public int sourceListIndex;

        public PQNode(ListNode l, int i)
        {
            this.listNode = l;
            this.sourceListIndex = i;
        }
    }

    public class DuplicateKeyComparer<TKey> : IComparer<TKey> where TKey : IComparable
    {
        public int Compare(TKey x, TKey y)
        {
            int result = x.CompareTo(y);

            if (result == 0)
                return 1; // Handle equality as beeing greater
            else
                return result;
        }
    }

    public class MergeKSortedLists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            SortedList<int, LinkedList<PQNode>> pq = new SortedList<int, LinkedList<PQNode>>();
            ListNode output = null, lastPtr = null;

            for (int i = 0; i < lists.Length; i++)
            {
                ListNode temp = lists[i];
                if (lists[i] != null)
                    lists[i] = lists[i].next;

                if (temp != null)
                {
                    temp.next = null;
                    if (!pq.ContainsKey(temp.val))
                        pq[temp.val] = new LinkedList<PQNode>();
                    pq[temp.val].AddLast(new PQNode(temp, i));
                }
            }

            printPriorityQueue(pq);

            bool isFirstNodeSet = false;
            while (pq.Count > 0)
            {
                LinkedList<PQNode> minList = pq.Values[0]; // Get Front of Queue
                pq.RemoveAt(0); // Remove Front of Queue

                Console.WriteLine("Queue After Removing Front");
                printPriorityQueue(pq);
                while (minList.Count > 0)
                {
                    PQNode removedNode = minList.First.Value;
                    int sourceListIndexForRemovedNode = removedNode.sourceListIndex;
                    if (!isFirstNodeSet)
                    {
                        output = removedNode.listNode;
                        isFirstNodeSet = true;
                        lastPtr = output;
                        Console.WriteLine("Setting First Node in Output with Value {0}", removedNode.listNode.val);
                    }
                    else
                    {
                        lastPtr.next = removedNode.listNode;
                        lastPtr = lastPtr.next;
                        Console.WriteLine("Adding Value {0} to Output", removedNode.listNode.val);
                    }
                    minList.RemoveFirst();

                    // Get next element from removed node's source linked list
                    Console.WriteLine("Removed Node's source list index = {0}", sourceListIndexForRemovedNode);
                    ListNode head = lists[sourceListIndexForRemovedNode];
                    ListNode nextElement = head;
                    //Console.WriteLine("Removed Node's source list Head = {0}", head.val);

                    if (lists[sourceListIndexForRemovedNode] != null)
                        lists[sourceListIndexForRemovedNode] = lists[sourceListIndexForRemovedNode].next;

                    if (nextElement != null)
                    {
                        nextElement.next = null;
                        if (!pq.ContainsKey(nextElement.val))
                        {
                            Console.WriteLine("Adding Key {0} to Queue", nextElement.val);
                            pq.Add(nextElement.val, new LinkedList<PQNode>());
                        }

                        pq[nextElement.val].AddLast(new PQNode(nextElement, sourceListIndexForRemovedNode));

                        Console.WriteLine("Adding Value to Key {0}", nextElement.val);
                        printPriorityQueue(pq);

                    }
                }

                

                ListNode temp = output;
                Console.WriteLine("Output After one while loop iteration");

                while (temp != null)
                {
                    Console.Write(temp.val + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }

            return output;
        }

        private void printPriorityQueue(SortedList<int, LinkedList<PQNode>> pq)
        {
            if (pq.Count == 0)
            {
                Console.WriteLine("Empty Priority Queue");
                return;
            }

            for (int i = 0; i < pq.Count; i++)
            {
                Console.WriteLine("PQ Key : {0}", pq.Keys[i]);
                LinkedList<PQNode> temp = pq.Values[i];
                if (temp.Count == 0)
                {
                    Console.WriteLine("PQ Node Data: Empty List");
                }
                foreach (PQNode node in temp)
                {
                    Console.WriteLine("PQ Node Data: [ListNodeValue = {0}, sourceListIndex = {1}]", node.listNode.val, node.sourceListIndex);
                }
                Console.WriteLine();
            }
        }
    }
}

