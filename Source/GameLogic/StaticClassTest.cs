using System;
using UnrealEngine;

namespace GameLogic
{
    public class StaticClassTest
    {
        public static string MyTestMethod(string arguments)
        {
            try
            {
                Ue.ScreenDebugMessage($"epepeep");
                return $"The string have {arguments.Length} symbols!";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}