using System;
using System.Collections.Generic;
using System.Text;
using UnrealEngine;

namespace GameLogic
{
    class HUD : ManageHUD
    {
        public HUD(IntPtr adress) : base(adress)
        {
        }

        public override void Tick(float DeltaSeconds)
        {
            base.Tick(DeltaSeconds);
        }

        public override void DrawHUD()
        {
            base.DrawHUD();
        }
    }
}
