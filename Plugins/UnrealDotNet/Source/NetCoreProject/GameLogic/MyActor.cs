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

            var scale = new FVector
            {
                X = (float)Math.Sin(Time),
                Y = (float)Math.Cos(Time),
                Z = 1.0f
            };

            SetActorScale3D(scale);
        }

        public override void OnEndPlay()
        {
            base.OnEndPlay();
        }
    }
}