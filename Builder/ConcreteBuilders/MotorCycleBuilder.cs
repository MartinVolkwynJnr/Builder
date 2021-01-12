﻿using Builder.Builder;
using Builder.Enums;

namespace Builder.ConcreteBuilders
{
    class MotorCycleBuilder : VehicleBuilder
    {
        // Invoke base class constructor
        public MotorCycleBuilder()
            : base(VehicleType.MotorCycle)
        {
        }

        public override void BuildFrame()
        {
            Vehicle[PartType.Frame] = "MotorCycle Frame";
        }

        public override void BuildEngine()
        {
            Vehicle[PartType.Engine] = "500 cc";
        }

        public override void BuildWheels()
        {
            Vehicle[PartType.Wheel] = "2";
        }

        public override void BuildDoors()
        {
            Vehicle[PartType.Door] = "0";
        }
    }
}