using UnityEngine;
using UnityEngine.Events;

namespace SnakeSimple.Scripts.GameObj
{
    public class Obstacle : MonoBehaviour
    {

        public UnityEvent OnDeath;

        public void Awake()
        {
            //OnDeath = new UnityEvent();
        }

        public void OnTriggerEnter(Collider other)
        {
            if (other.transform.tag.Equals("Player")) OnDeath.Invoke();
        }
    }
}