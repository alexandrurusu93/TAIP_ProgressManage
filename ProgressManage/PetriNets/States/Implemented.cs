﻿namespace PetriNets.States
{
    public class Implemented : State
    {
        public Implemented()
        {
            Name = "Implemented";
        }

        public override void Handle(SprintEntity sprintEntity)
        {
            sprintEntity.State = new Implemented();
        }
    }
}
