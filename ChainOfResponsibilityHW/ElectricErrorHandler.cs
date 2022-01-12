namespace MyApp // Note: actual namespace depends on the project name.
{
    public class ElectricErrorHandler : ErrorHandler
    {

        public override void HandleRequest()
        {
            if (isHasError)
            {
                if (next != null)
                {
                    Console.WriteLine("You move on to expert test");
                    next.SetNext(new ExpertErrorHandler());
                    next.HandleRequest();
                }
            }

            if (!isHasError)
            {
                isHasError = false;
            }
        }
    }
}