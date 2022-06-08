using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class UnorderListClass
    {
        Node head;
        public void UnOrdered(string str)
        {
            string input = File.ReadAllText(@"D:\BridgeLabzFelloship\Algorithms-DS-Problems\AlgorithmPrograms\AlgorithmPrograms\StringInput.txt");
            string[] SearchWords = input.Split(' ');
            for (int i = 0; i < SearchWords.Length; i++)
            {
                Node node = new Node(SearchWords[i]);
                if (this.head == null)
                    this.head = node;
                else
                {
                    node.next = this.head;
                    this.head = node;
                }
            }
            Node temp = this.head;
            Node prev = null;
            int flag = 0;
            while (temp != null)
            {
                if (temp.data.Equals(str))
                {
                    prev.next = temp.next;
                    flag = 1;
                }
                prev = temp;
                temp = temp.next;
            }
            if (flag == 0)
            {
                Node node = new Node(str);
                node.next = this.head;
                this.head = node;
            }
            Console.WriteLine("List After searching word:");
            Node node1 = this.head;
            string[] array = new string[100];
            int j = 0;
            while (node1 != null)
            {
                array[j] = node1.data + " ";
                node1 = node1.next;
                j++;
            }
            string concat = string.Concat(array);
            Console.WriteLine(concat);
            File.WriteAllText(@"D:\BridgeLabzFelloship\Algorithms-DS-Problems\AlgorithmPrograms\AlgorithmPrograms\StringInput.txt", concat);
        }
    }
}
