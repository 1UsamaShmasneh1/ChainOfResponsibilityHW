namespace MyApp // Note: actual namespace depends on the project name.
{
    public class InitialErrorHandler : ErrorHandler
    {
        public override void HandleRequest()
        {
            if (isHasError)
            {
                if (next != null)
                {
                    Console.WriteLine("You move on to mechanic test");
                    next.SetNext(new MechanicErrorHandler());
                    next.HandleRequest();
                }
            }

            if (!isHasError)
            {
                Console.WriteLine("The car is ok");
            }
        }
    }
}