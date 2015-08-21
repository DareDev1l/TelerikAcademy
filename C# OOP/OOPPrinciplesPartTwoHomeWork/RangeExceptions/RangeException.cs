namespace RangeExceptions
{
    using System;
    public class RangeException<T> : Exception where T : IComparable
    {
        private T start;
        private T end;

        public RangeException(T start, T end) 
            : base(String.Format("Invalid Range Exception! Parameter should be in the range {0} - {1}", start, end))
        {
            this.Start = start;
            this.End = end;
        }

        public T Start
        {
            get { return this.start; }
            set { this.start = value; }
        }

        public T End
        {
            get { return this.end; }
            set { this.end = value; }
        }
    }
}
