using System;

namespace Practice__9
{
    class El
    {
        public int number { get; set; }
        public El next { get; private set; }

        private El(int number)
        {
            this.number = number;
            next = this;
        }
        private void Add(int number)
        {
            El newEl =  new El(number), el = this;
            while (el.next != this)
            {
                el = el.next;
            }

            newEl.next = el.next;
            el.next = newEl;
        }
        public static El MakeList(int capacity)
        {
            int number = 1;
            El el = new El(number);
            while (number <= capacity)
                el.Add(++number);

            return el;
        }
        public void Remove(int number)
        {
            El searchEl = Search(number), predEl = this;
            while (predEl.next != searchEl)
            {
                predEl = predEl.next;
            }

            predEl.next = searchEl.next;
        }
        public El Search(int number)
        {
            El el = this;
            while (el.number != number)
            {
                el = el.next;
                if (el == this)
                    throw new NullReferenceException("Элемент не найден.");
            }

            return el;
        }
        public override string ToString()
        {
            return this.number.ToString();
        }
        public void Print()
        {
            El el = this;
            while (el.next != this)
            {
                Console.Write(el.ToString() + " ");
                el = el.next;
            }
            Console.WriteLine();
        }
    }
}
