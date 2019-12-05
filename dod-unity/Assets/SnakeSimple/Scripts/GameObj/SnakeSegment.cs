using UnityEngine;
using UnityEngine.Events;

namespace SnakeSimple.Scripts.Components {
    public sealed class SnakeSegment : MonoBehaviour
    {
        public UnityEvent OnStack = new UnityEvent();

        public void OnCollisionEnter(Collision other)
        {
            if(other.transform.tag.Equals("Player")) OnStack.Invoke();
        }
    }
}