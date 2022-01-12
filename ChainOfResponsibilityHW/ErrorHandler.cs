namespace MyApp // Note: actual namespace depends on the project name.
{
    public abstract class ErrorHandler
    {
        protected ErrorHandler next;
        protected bool isHasError = new Random().NextDouble() >= 0.5;
        public void SetNext(ErrorHandler next)
        {
            this.next = next;
        }

        public abstract void HandleRequest();
    }
}