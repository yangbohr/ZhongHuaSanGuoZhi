﻿namespace GameObjects.ArchitectureDetail.EventEffect
{
    using GameObjects;
    using System;

    internal class EventEffect0 : EventEffectKind
    {
        private int increment;

        public override void ApplyEffectKind(Person person, Event e)
        {
            person.BaseStrength += increment;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.increment = int.Parse(parameter);
            }
            catch
            {
            }
        }
    }
}

