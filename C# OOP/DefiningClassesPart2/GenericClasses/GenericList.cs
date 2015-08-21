namespace GenericClasses
{
    using System;
    public class GenericList<T> where T: IComparable
    {
        // Fields
        private const int InitialSize = 4;
        private T[] list;
        private int count = 0;

        // Constructors
        public GenericList()
        {
            this.list = new T[InitialSize];
        }
        public GenericList(int size)
        {
            this.list = new T[size];
        }

        // Properties
        public int Count
        {
            get { return this.count; }
        }

        // Indexer
        public T this[int index]
        {
            get { return this.list[index]; }
        }

        // Add Methods
        public void Add(T element)
        {
            if (this.count >= this.list.Length)
            {
                this.ResizeList();
            }
            this.list[count] = element;
            this.count++;
        }

        public void Add(T element, int index)
        {
            if (this.count >= this.list.Length)
            {
                this.ResizeList();
            }

            if (index < 0 || index > this.count)
            {
                throw new IndexOutOfRangeException("Index is outside bounds of the list");
            }


            T[] newList = new T[list.Length];

            for (int i = 0; i < index; i++)
            {
                newList[i] = list[i];
            }

            newList[index] = element;
            for (int i = index + 1; i <= this.count; i++)
            {
                newList[i] = list[i-1];
            }
            this.list = newList;
            this.count++;
        }

        // Remove Methods
        public void Remove(int index)
        {
            if (index < 0 || index > this.count)
            {
                throw new IndexOutOfRangeException("Index is outside bounds of the list");
            }

            T[] newList = new T[list.Length];

            for (int i = 0; i < index; i++)
            {
                newList[i] = list[i];
            }
            for (int i = index + 1; i < this.count; i++)
            {
                newList[i - 1] = list[i]; 
            }

            this.list = newList;
            this.count--;
        }

        // Clear the list
        public void Clear()
        {
            this.list = new T[this.list.Length];
            this.count = 0;
        }
        
        // Find element by value
        public T FindByValue(T value)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (value.Equals(this.list[i]))
                {
                    return this.list[i];
                }
            }
            throw new InvalidOperationException("There is no element with such value in the list");
        }

        // Double the length of the arr
        public void ResizeList()
        {
            T[] newList = new T[this.list.Length * 2];

            for (int i = 0; i < this.count; i++)
            {
                newList[i] = list[i];
            }

            this.list = newList;
        }

        // Min and Max methods
        public T Min()
        {
            T min = this.list[0];

            for (int i = 1; i < this.count; i++)
            {
                if(min.CompareTo(this.list[i]) > 0)
                {
                    min = this.list[i];
                }
            }

            return min;
        }

        public T Max()
        {
            T max = this.list[0];

            for (int i = 1; i < this.count; i++)
            {
                if (max.CompareTo(this.list[i]) < 0)
                {
                    max = this.list[i];
                }
            }

            return max;
        }

        // ToString override
        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < this.count; i++)
            {
                sb.Append(String.Format("{0} ", this.list[i]));
            }

            return sb.ToString();
        }
    }
}
