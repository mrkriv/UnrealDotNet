using System;
using System.Drawing;
using UnrealEngine;

namespace GameLogic
{
    public class MyHUD : AHUD
    {
        private float Time;

        public MyHUD(IntPtr Adress) : base(Adress)
        {
        }

        public override void OnBeginPlay()
        {
            ULog("OnBeginPlay");
        }

        public override void OnTick(float DeltaTime)
        {
            Time += DeltaTime;

            if (Time > 1.0f)
            {
                ScreenDebugMessage("Ep ep ep", 1, Color.Crimson);
                Time -= 1;
            }
            else
                ScreenDebugMessage("Ep?", .1f);

            base.OnTick(DeltaTime);
        }

        public override void OnEndPlay()
        {
            ULog("OnEndPlay");
        }
    }
}