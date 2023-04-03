using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4
{
    class myStack
    {
        static Stack<Human> humansStack = new Stack<Human>();

        public static event EventHandler objectAllClear;


        static public void Push(Human human)
        {
            humansStack.Push(human);
        }
        static public void Clear()
        {
            humansStack.Clear();
            Human.ObjectsCount = 0;
            objectAllClear?.Invoke(null,null);
        }

        static public int Count()
        {
            return humansStack.Count();
        }

        public static Stack<Human> humanStack()
        {
            return humansStack;
        }

        public static Human FirstOrDefault(string selected)
        {
            return humansStack.FirstOrDefault(s => s.Name == selected);
        }

        public static Stack<Human> Pop(string selected)
        {
            int k = 0;
            Stack<Human> newStack = new Stack<Human>();
                foreach(Human human in humansStack.ToArray())
                {
                    if (human.Name != selected)
                    {
                        newStack.Push(humansStack.Pop());
                        k++;
                    }
                    else
                    {
                    humansStack.Pop();
                        for (int i = 0; i < k; i++)
                        {
                            humansStack.Push(newStack.Pop());
                        }
                    break;
                    }
                }
                Human.ObjectsCount--;
                return humansStack;
        }
    }
}
