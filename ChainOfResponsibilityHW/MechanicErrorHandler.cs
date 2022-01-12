namespace MyApp // Note: actual namespace depends on the project name.
{
    public class MechanicErrorHandler : ErrorHandler
    {

        public override void HandleRequest()
        {
            if (isHasError)
            {
                if (next != null)
                {
                    Console.WriteLine("You move on to car electrician test");
                    next.SetNext(new ElectricErrorHandler());
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