using System;
using UnrealEngine;

namespace GameLogic
{
    public class MyManageActor : AActor
    {
        public MyManageActor(IntPtr Adress) : base(Adress)
        {
        }

        public void Tick(float DeltaTime)
        {
            ULog("Hey!");
        }
    }
}