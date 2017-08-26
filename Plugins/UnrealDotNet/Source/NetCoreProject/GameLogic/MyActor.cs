using System;
using UnrealEngine;

namespace GameLogic
{
    public class MyActor : AActor
    {
        private float Time;

        public MyActor(IntPtr Adress) : base(Adress)
        {
        }

        public override void OnBeginPlay()
        {
            base.OnBeginPlay();
        }

        public override void OnTick(float DeltaTime)
        {
            Time += DeltaTime;

            var rot = new FRotator
            {
                Yaw = Time * 10,
                Pitch = 10,
                Roll = 15
            };

            var scale = new FVector
            {
                X = 2 + (float)Math.Sin(Time),
                Y = 2 + (float)Math.Cos(Time),
                Z = 2.0f
            };

            SetActorScale3D(scale);
            K2_SetActorRotation(rot, false);
        }

        public override void OnEndPlay()
        {
            base.OnEndPlay();
        }
    }
}