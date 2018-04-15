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
        private ElevatorDirection _direction;
        private UStaticMeshComponent _mesh;
        private UBoxComponent _collider;
        private int _bodyCount;
        private bool _isMove;
        private float _time;

        [EditAnywhere, DefaultValue(1.0f)]
        public float ActivateTime { get; set; }

        [EditAnywhere]
        public FVector EndPoint { get; set; }

        public Elevator(IntPtr adress) : base(adress)
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

            _mesh = new UStaticMeshComponent(this, "mesh");
            _mesh.RegisterComponent();

            _mesh.AttachToComponent(GetRootComponent(), transformRules, "");

            _collider = new UBoxComponent(this, "collider");
            _collider.RegisterComponent();
            _collider.SetBoxExtent(new FVector(250, 250, 100), false);
            _collider.SetHiddenInGame(false);

            _collider.OnComponentBeginOverlap += Collider_OnComponentBeginOverlap;
            _collider.OnComponentEndOverlap += Collider_OnComponentEndOverlap;

            _collider.AttachToComponent(_mesh, transformRules, "");
        }

        public override void Tick(float deltaSeconds)
        {
            ScreenDebugMessage(_bodyCount.ToString(), 0, Color.DodgerBlue);
            ScreenDebugMessage(_time.ToString(), 0, Color.Green);

            if (_isMove)
            {
                AddActorLocalOffset(new FVector(0, 0, deltaSeconds*100), true, new FHitResult(), ETeleportType.None);
            }
            else
            {
                if (_bodyCount != 0)
                {
                    _time += deltaSeconds;

                    if (_time >= ActivateTime)
                    {
                        _isMove = true;
                    }
                }
            }
        }

        private void Collider_OnComponentBeginOverlap(UPrimitiveComponent overlappedComponent, AActor otherActor, UPrimitiveComponent otherComp, int otherBodyIndex, bool bFromSweep, FHitResult sweepResult)
        {
            _bodyCount++;
        }

        private void Collider_OnComponentEndOverlap(UPrimitiveComponent overlappedComponent, AActor otherActor, UPrimitiveComponent otherComp, int otherBodyIndex)
        {
            _bodyCount--;

            if (_bodyCount == 0)
            {
                _time = 0;
            }
        }
    }
}