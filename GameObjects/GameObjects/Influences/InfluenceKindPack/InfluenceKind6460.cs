﻿namespace GameObjects.Influences.InfluenceKindPack
{
    using GameObjects;
    using GameObjects.Influences;
    using System;

    internal class InfluenceKind6460 : InfluenceKind
    {
        private float increment;

        public override void ApplyInfluenceKind(Architecture architecture)
        {
            architecture.militaryPopulationRateIncrease += this.increment;
        }

        public override void PurifyInfluenceKind(Architecture architecture)
        {
            architecture.militaryPopulationRateIncrease -= this.increment;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.increment = float.Parse(parameter);
            }
            catch
            {
            }
        }

        public override double AIFacilityValue(Architecture a)
        {
            return this.increment * (a.HostileLine ? 2 : 1);
        }
    }
}

