using System;
using UnrealEngine;

namespace GameLogic
{
    public class MyHUD : AHUD
    {
        public MyHUD(IntPtr Adress) : base(Adress)
        {
        }

        public override void OnBeginPlay()
        {
            ULog("OnBeginPlay");
        }

        public override void OnTick(float DeltaTime)
        {
            ULog("Work!");
            base.OnTick(DeltaTime);
        }

        public override void OnEndPlay()
        {
            ULog("OnEndPlay");
        }
    }
}