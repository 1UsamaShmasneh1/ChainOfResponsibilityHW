namespace MyApp // Note: actual namespace depends on the project name.
{
    public class ExpertErrorHandler : ErrorHandler
    {

        public override void HandleRequest()
        {
            if (isHasError)
            {
                Console.WriteLine("Throw the car in the trash");                   
            }

            if (!isHasError)
            {
                isHasError = false;
            }
        }
    }
}