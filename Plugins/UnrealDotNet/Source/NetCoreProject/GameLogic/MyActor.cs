using System;
using System.ComponentModel;
using UnrealEngine;

namespace GameLogic
{
    public class MyActor : ManageActor
    {
        private UBoxComponent Box;

        [EditAnywhere, DefaultValue(10.0f)]
        public float Speed { get; set; }

        public float Time { get; set; }

        public MyActor(IntPtr Adress) : base(Adress)
        {
        }

        protected override void BeginPlay()
        {
            try
            {
                PrimaryActorTick.bCanEverTick = 1;

                Box = new UBoxComponent(this, "Simple Child");
                Box.RegisterComponent();

                var transformRules = new FAttachmentTransformRules(
                    EAttachmentRule.SnapToTarget,
                    EAttachmentRule.SnapToTarget,
                    EAttachmentRule.SnapToTarget,
                    false
                );

                var root = GetRootComponent();
                var root_sm = root as UStaticMeshComponent;

                ScreenDebugMessage(root_sm?.GetFName() ?? "null");

                Box.AttachToComponent(root, transformRules, "");

                Box.SetCollisionProfileName("OverlapAll");
                Box.SetBoxExtent(new FVector(100, 100, 100), false);

                Box.OnComponentEndOverlap += Box_OnComponentEndOverlap;
            }
            catch (Exception e)
            {
                ULog_Error(e.ToString());
            }
        }

        private void Box_OnComponentEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor,
            UPrimitiveComponent OtherComp, int OtherBodyIndex)
        {
            ScreenDebugMessage($"{OtherActor} don't overlap {OverlappedComponent} now");
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

            SetActorRotation(rot, false);
        }
    }
}