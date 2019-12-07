using UnityEngine;
using UnityEngine.Events;

namespace SnakeSimple.Scripts.GameObj
{
    public class Food : MonoBehaviour
    {
        public UnityEvent OnEaten;

        public void Awake()
        {
            //OnEaten = new UnityEvent();
        }

        public void OnTriggerEnter(Collider other)
        {
            if( other.transform.tag.Equals("Player")) OnEaten.Invoke();
        }
    }
}