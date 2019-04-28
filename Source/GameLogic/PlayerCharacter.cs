using System;
using System.Collections.Generic;
using System.Text;
using UnrealEngine;

namespace GameLogic
{
    class PlayerCharacter : ManageCharacter
    {
        [EditAnywhere] public float HealthMax { get; set; } = 100;
        [EditAnywhere] public float HealthPerSecond { get; set; }
        [EditAnywhere] public float EnergyMax { get; set; } = 100;
        [EditAnywhere] public float EnergyPerSecond { get; set; }
        [EditAnywhere] public float SatietyFoodPerSecond { get; set; }
        [EditAnywhere] public float SatietyWaterPerSecond { get; set; }
        [EditAnywhere] public float FatiguePerSecond { get; set; }
        
        [BlueprintReadOnly] public float Health { get; set; }
        [BlueprintReadOnly] public float Energy { get; set; }
        [BlueprintReadOnly] public float SatietyFood { get; set; }
        [BlueprintReadOnly] public float SatietyWater { get; set; }
        [BlueprintReadOnly] public float Fatigue { get; set; }
        [BlueprintReadOnly] public bool IsDeath { get; set; }

        public PlayerCharacter(IntPtr adress) : base(adress)
        {
            PrimaryActorTick.bCanEverTick = 1;
        }

        protected override void BeginPlay()
        {
            base.BeginPlay();
            
            Health = HealthMax;
            Energy = EnergyMax;
            SatietyFood = 1;
            SatietyWater = 1;
            Fatigue = 0;
        }

        public override void Tick(float dt)
        {
            base.Tick(dt);
            
            Ue.Log(GetController()?.GetType()?.FullName);

            if (IsDeath)
                return;

            Health          = Math.Max(0, Math.Min(Health       + HealthPerSecond       * dt, HealthMax));
            Energy          = Math.Max(0, Math.Min(Energy       + EnergyPerSecond       * dt, EnergyMax));
            SatietyFood     = Math.Max(0, Math.Min(SatietyFood  + SatietyFoodPerSecond  * dt, 1));
            SatietyWater    = Math.Max(0, Math.Min(SatietyWater + SatietyWaterPerSecond * dt, 1));
            Fatigue         = Math.Max(0, Math.Min(Fatigue      - FatiguePerSecond      * dt, 1));

            if (Health <= 0)
                Kill();
        }

        public void Kill()
        {
            if (IsDeath)
                return;

            IsDeath = true;
            Health = 0;
            Energy = 0;
        }
    }
}