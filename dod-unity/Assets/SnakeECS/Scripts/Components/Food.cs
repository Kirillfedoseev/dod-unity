using Leopotam.Ecs;
using SnakeECS.Scripts.Systems;
using UnityEngine;

namespace SnakeECS.Scripts.Components
{
    sealed class Food : IEcsAutoReset
    {
        public Coords Coords;
        public Transform Transform;

        void IEcsAutoReset.Reset()
        {
            Transform = null;
        }
    }
}