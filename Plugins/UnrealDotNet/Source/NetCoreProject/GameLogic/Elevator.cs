using System;
using System.ComponentModel;
using System.Drawing;
using UnrealEngine;

namespace GameLogic
{
    public enum ElevatorDirection
    {
        Forward,
        Back,
    }

    public class Elevator : ManageActor
    {
        private ElevatorDirection Direction;
        private UStaticMeshComponent mesh;
        private UBoxComponent collider;
        private int bodyCount;
        private bool isMove;
        private float time;

        [EditAnywhere, DefaultValue(1.0f)]
        public float ActivateTime { get; set; }

        [EditAnywhere]
        public FVector EndPoint { get; set; }

        public Elevator(IntPtr Adress) : base(Adress)
        {
        }

        protected override void BeginPlay()
        {
            PrimaryActorTick.bCanEverTick = 1;

            var transformRules = new FAttachmentTransformRules(
                EAttachmentRule.SnapToTarget,
                EAttachmentRule.SnapToTarget,
                EAttachmentRule.SnapToTarget,
                false
            );

            mesh = new UStaticMeshComponent(this, "mesh");
            mesh.RegisterComponent();

            mesh.AttachToComponent(GetRootComponent(), transformRules, "");

            collider = new UBoxComponent(this, "collider");
            collider.RegisterComponent();
            collider.SetBoxExtent(new FVector(250, 250, 100), false);
            collider.SetHiddenInGame(false);

            collider.OnComponentBeginOverlap += Collider_OnComponentBeginOverlap;
            collider.OnComponentEndOverlap += Collider_OnComponentEndOverlap;

            collider.AttachToComponent(mesh, transformRules, "");
        }

        public override void Tick(float DeltaSeconds)
        {
            ScreenDebugMessage(bodyCount.ToString(), 0, Color.DodgerBlue);
            ScreenDebugMessage(time.ToString(), 0, Color.Green);

            if (isMove)
            {
                AddActorLocalOffset(new FVector(0, 0, DeltaSeconds*100), true, new FHitResult(), ETeleportType.None);
            }
            else
            {
                if (bodyCount != 0)
                {
                    time += DeltaSeconds;

                    if (time >= ActivateTime)
                    {
                        isMove = true;
                    }
                }
            }
        }

        private void Collider_OnComponentBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
        {
            bodyCount++;
        }

        private void Collider_OnComponentEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
        {
            bodyCount--;

            if (bodyCount == 0)
            {
                time = 0;
            }
        }
    }
}