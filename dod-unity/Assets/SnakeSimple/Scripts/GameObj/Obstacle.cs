using UnityEngine;
using UnityEngine.Events;

namespace SnakeSimple.Scripts.GameObj
{
    public class Obstacle : MonoBehaviour
    {

        public UnityEvent OnDeath = new UnityEvent();


        public void OnCollisionEnter(Collision other)
        {
            if (other.transform.tag.Equals("Player")) OnDeath.Invoke();
        }
    }
}