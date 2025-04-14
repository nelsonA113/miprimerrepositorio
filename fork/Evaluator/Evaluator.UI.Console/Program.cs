﻿using Evaluator.Logic;

try
{
    var resut2 = FunctionEvaluator.Evalute("4*5.5/(4+6)");
    var resut1 = FunctionEvaluator.Evalute("4*(5+6-(8/2^3)-7)-1");
    var resut3 = FunctionEvaluator.Evalute("9^(1/2)");
    Console.WriteLine(resut1);
    Console.WriteLine(resut2);
    Console.WriteLine(resut3);
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}