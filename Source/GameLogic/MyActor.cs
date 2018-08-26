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

        public MyActor(IntPtr adress) : base(adress)
        {
        }

        public override void OnConstruction(FTransform transform)
        {
            PrimaryActorTick.bCanEverTick = 1;

            var _box = new UBoxComponent(this, "Simple Child");
            _box.RegisterComponent();

            _box.AttachToComponent(GetRootComponent(), FAttachmentTransformRules.SnapToTargetIncludingScale, "");

            _box.SetCollisionProfileName("OverlapAll");
            _box.SetBoxExtent(new FVector(100, 100, 100), false);
            _box.SetHiddenInGame(false);
        }

        protected override void BeginPlay()
        {
            //var box = (UBoxComponent)GetComponents().First(x => x.GetName() == "Simple Child");
            //box.OnComponentEndOverlap += Box_OnComponentEndOverlap;
        }

        private void Box_OnComponentEndOverlap(UPrimitiveComponent overComp, AActor otherActor, UPrimitiveComponent otherComp, int otherBodyIndex)
        {
            Ue.ScreenDebugMessage($"{otherActor} don't overlap {overComp} now");
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