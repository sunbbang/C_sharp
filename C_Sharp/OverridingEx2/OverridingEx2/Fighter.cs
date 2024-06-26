using System;

namespace OverridingEx2
{
    internal class Fighter
    {
        public void forward()
        {
            Console.WriteLine("→");
        }
        public void backward()
        {
            Console.WriteLine("←");
        }
        public void jump()
        {
            Console.WriteLine("↑");
        }
        public void seat()
        {
            Console.WriteLine("↓");
        }
        public virtual void energy()
        {
            Console.WriteLine("⊃");
        }
        public virtual void kick()
        {
            Console.WriteLine("풍차돌리기!");
        }
    }
}
