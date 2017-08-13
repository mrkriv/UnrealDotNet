using System;
using UnrealEngine;

namespace GameLogic
{
    public class MyManageActor : AActor
    {
        public MyManageActor(IntPtr Adress) : base(Adress)
        {
        }

        public void OnTick(float DeltaTime)
        {
            ULog(DeltaTime.ToString());
        }
    }
}