using System;
using System.Collections.Generic;
using System.Text;
class Solution {
    static void Main(String[] args) {
    
        int Q = Convert.ToInt32(Console.ReadLine());
        StringBuilder text = new StringBuilder();
        Stack<string> history = new Stack<string>();

        for (int i = 0; i < Q; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int type = int.Parse(input[0]);

            switch (type)
            {
                case 1:
                    history.Push(text.ToString()); 
                    text.Append(input[1]);
                    break;

                case 2:
                    history.Push(text.ToString()); 
                    int k = int.Parse(input[1]);
                    text.Remove(text.Length - k, k);
                    break;

                case 3:
                   
                    int index = int.Parse(input[1]);
                    Console.WriteLine(text[index - 1]);
                    break;

                case 4:
                    
                    if (history.Count > 0)
                    {
                        text.Clear();
                        text.Append(history.Pop());
                    }
                    break;
            }
        }
    }
}
