using System;
using UnrealEngine;

namespace GameLogic
{
    public class MyManageActor : AActor
    {
        public MyManageActor(IntPtr Adress) : base(Adress)
        {
        }

        public static string TestManageCall(IntPtr Adress)
        {
            var actor = new AActor(Adress);

            return "It work!";
        }
    }
}