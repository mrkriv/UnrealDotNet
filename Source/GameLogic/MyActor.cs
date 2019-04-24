using System;
using System.ComponentModel;
using UnrealEngine;

namespace GameLogic
{
    public class MyActor : ManageActor
    {
        [EditAnywhere, DefaultValue(10.0f)]
        public float Speed { get; set; }
        public float Time { get; set; }

        private UBoxComponent _box;

        public MyActor(IntPtr adress) : base(adress)
        {
            PrimaryActorTick.bCanEverTick = 1;
        }

        protected override void BeginPlay()
        {
            _box = new UBoxComponent(this, "Simple Child");
            _box.RegisterComponent();

            _box.AttachToComponent(GetRootComponent(), FAttachmentTransformRules.SnapToTargetIncludingScale, "");

            _box.SetCollisionProfileName("OverlapAll");
            _box.SetBoxExtent(new FVector(100, 100, 100), false);
            _box.SetHiddenInGame(false);
            
            Ue.Log(NativePointer + "::OnConstruction()");
            Ue.Log(_box?.ToString() ?? "null");
            
            //var box = (UBoxComponent)GetComponents().First(x => x.GetName() == "Simple Child");
            _box.OnComponentBeginOverlap += BoxOnOnComponentBeginOverlap;
            _box.OnComponentEndOverlap += BoxOnComponentEndOverlap;
        }

        private void BoxOnOnComponentBeginOverlap(UPrimitiveComponent overComp, AActor otherActor, UPrimitiveComponent otherComp, int otherbodyindex, bool bfromsweep, FHitResult sweepresult)
        {
            Ue.ScreenDebugMessage($"BeginOverlap {otherActor} don't overlap {overComp} now");
        }

        private void BoxOnComponentEndOverlap(UPrimitiveComponent overComp, AActor otherActor, UPrimitiveComponent otherComp, int otherBodyIndex)
        {
            Ue.ScreenDebugMessage($"EndOverlap {otherActor} don't overlap {overComp} now");
        }

        public override void Tick(float deltaTime)
        {
            Time += deltaTime;

            var rot = new FRotator
            {
                Yaw = Time * Speed,
                Pitch = 0,
                Roll = 0
            };

            SetActorRotation(rot, ETeleportType.None);
        }
    }
}