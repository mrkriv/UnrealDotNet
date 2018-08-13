using System;
using System.ComponentModel;
using UnrealEngine;

namespace GameLogic
{
    public class MyActor : ManageActor
    {
        private UBoxComponent _box;

        [EditAnywhere, DefaultValue(10.0f)]
        public float Speed { get; set; }

        public float Time { get; set; }

        public MyActor(IntPtr adress) : base(adress)
        {
        }

        protected override void BeginPlay()
        {
            try
            {
                PrimaryActorTick.bCanEverTick = 1;

                _box = new UBoxComponent(this, "Simple Child");
                _box.RegisterComponent();

                var root = GetRootComponent();

                _box.AttachToComponent(root, FAttachmentTransformRules.SnapToTargetIncludingScale, "");

                _box.SetCollisionProfileName("OverlapAll");
                _box.SetBoxExtent(new FVector(100, 100, 100), false);
                
                _box.OnComponentEndOverlap += Box_OnComponentEndOverlap;
            }
            catch (Exception e)
            {
                Ue.LogError(e.ToString());
            }
        }

        private void Box_OnComponentEndOverlap(UPrimitiveComponent overlappedComponent, AActor otherActor,
            UPrimitiveComponent otherComp, int otherBodyIndex)
        {
            try
            {
                Ue.ScreenDebugMessage($"{otherActor} don't overlap {overlappedComponent} now");
            }
            catch (Exception e)
            {
                Ue.LogError(e.ToString());
            }
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

            SetActorRotation(rot, false);
        }
    }
}