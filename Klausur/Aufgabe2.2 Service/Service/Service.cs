﻿using Aufgabe2._2_Service.Interfaces;
using Aufgabe2._2_Service.Model;

namespace Aufgabe2._2_Service.Service
{
    public class Service : IService
    {
        public Result diff(Arguments arguments)
        {
            var result = arguments.Arg1 - arguments.Arg2;
           
            return new Result {Value = result};
        }
    }
}