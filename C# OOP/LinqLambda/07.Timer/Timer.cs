namespace _07.Timer
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class Timer
    {
        private DelegateMethod paramMethod;

        public Timer(int seconds)
        {
            this.Seconds = seconds;
        }

        public int Seconds { get; set; }

        public delegate void DelegateMethod(string method);


        public DelegateMethod ParamMethod
        {
            get { return this.paramMethod; }
            set { this.paramMethod = value; }
        }

        public void ExecuteMethod(string method)
        {
            ParamMethod(method);
            Thread.Sleep(Seconds * 1000);
        }
    }
}
