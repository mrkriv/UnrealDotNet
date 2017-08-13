using System;
using System.Runtime.InteropServices;
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
            var rot = GetActorRotation();
            rot.Yaw += DeltaTime * 60;

            SetActorRotation(rot, false);
        }
    }
}