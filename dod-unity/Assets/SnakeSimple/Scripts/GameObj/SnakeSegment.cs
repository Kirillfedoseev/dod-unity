using UnityEngine;
using UnityEngine.Events;

namespace SnakeSimple.Scripts.Components {
    public sealed class SnakeSegment : MonoBehaviour
    {
        public UnityEvent OnStack;
       
        public void Awake()
        {
            //OnStack = new UnityEvent();
        }
        public void OnTriggerEnter(Collider other)
        {
            if(other.transform.tag.Equals("Player")) OnStack.Invoke();
        }
    }
}