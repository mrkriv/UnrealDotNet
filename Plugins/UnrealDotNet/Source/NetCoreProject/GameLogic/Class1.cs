using System;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace GameLogic
{
    public class MyManageActor : AActor
    {
        private float v, a = 50;

        public MyManageActor(IntPtr Adress) : base(Adress)
        {
        }

        public override void OnBeginPlay()
        {
            ULog("OnBeginPlay");
        }

        public override void OnTick(float DeltaTime)
        {
            var rot = GetActorRotation();
            rot.Yaw += DeltaTime * v;
            v += a * DeltaTime;

            SetActorRotation(rot, false);

            base.OnTick(DeltaTime);
        }

        public override void OnEndPlay()
        {
            ULog("OnEndPlay");
        }
    }
}
