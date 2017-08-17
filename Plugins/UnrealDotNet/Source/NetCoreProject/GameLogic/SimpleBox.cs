using System;
using UnrealEngine;

namespace GameLogic
{
    public class SimpleBox : AActor
    {
        private float v, a = 10000;

        public SimpleBox(IntPtr Adress) : base(Adress)
        {
        }

        public override void OnTick(float DeltaTime)
        {
            var rot = GetActorRotation();
            rot.Yaw = DeltaTime * v;
            v += a * DeltaTime;

            SetActorRotation(rot, false);

            ULog($"My rot Yaw: {rot.Yaw}");
        }
    }
}