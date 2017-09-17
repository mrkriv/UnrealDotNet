using System;
using System.ComponentModel;
using UnrealEngine;

namespace GameLogic
{
    public class MyActor : ManageActor
    {
        // private UBoxComponent Box;

        [EditAnywhere, DefaultValue(10.0f)]
        public float Speed { get; set; }
        
        public float Time { get; set; }

        public MyActor(IntPtr Adress) : base(Adress)
        {
        }

        protected override void BeginPlay()
        {
            //try
            //{
            PrimaryActorTick.bCanEverTick = 1;

          //  ScreenDebugMessage(GetRootComponent().GetWorldTransform().ToString());
            // Box = CreateOptionalDefaultSubobject_UBoxComponent("Test");

            CallFunction("TestBlueprintMethod", "Abadracedapa", 2.5f);

            ScreenDebugMessage(Speed.ToString());

            ScreenDebugMessage(GetNetMode().ToString());
            //}
            //catch (Exception e)
            //{
            //    ULog_Error(e.ToString());
            //}
        }

        public override void Tick(float DeltaTime)
        {
            Time += DeltaTime;

            var rot = new FRotator
            {
                Yaw = Time * Speed,
                Pitch = 0,
                Roll = 0
            };

            var scale = new FVector
            {
                X = 2 + (float)Math.Sin(Time),
                Y = 2 + (float)Math.Cos(Time),
                Z = 2.0f
            };

            //if (Box != null)
            //{
            //    ULog(Box.GetFName() + " " + scale);
            //    Box.SetRelativeScale3D(scale);
            //}
            //else
            //{
            //    ULog_Error("Box is null");
            //}

            SetActorRotation(rot, false);
        }
    }
}