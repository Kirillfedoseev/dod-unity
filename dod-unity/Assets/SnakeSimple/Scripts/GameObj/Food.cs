using UnityEngine;
using UnityEngine.Events;

namespace SnakeSimple.Scripts.GameObj
{
    public class Food : MonoBehaviour
    {
        public UnityEvent OnEaten = new UnityEvent();

        private void OnTriggerEnter(Collider other)
        {
            if( other.tag.Equals("Player")) OnEaten.Invoke();
        }
    }
}