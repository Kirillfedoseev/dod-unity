using Leopotam.Ecs;

namespace SnakeECS.Scripts.Components {
    sealed class ScoreChangeEvent : IEcsOneFrame {
        public int Amount;
    }
}