﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ErrorHandler testCar = new InitialErrorHandler();
            testCar.HandleRequest();
        }
    }
}