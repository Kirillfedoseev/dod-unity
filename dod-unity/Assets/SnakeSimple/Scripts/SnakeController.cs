using System.Collections;
using SnakeSimple.Scripts.GameObj;
using UnityEngine;

namespace SnakeSimple.Scripts
{
    public enum SnakeDirection {
        Up,
        Right,
        Down,
        Left
    }
    public class SnakeController : MonoBehaviour
    {
        private SnakeDirection _nextDirection;

        [SerializeField] private float speed = 2;
        
        public Snake Snake;
        // Start is called before the first frame update
        void Start()
        {
            _nextDirection = SnakeDirection.Up;
            StartCoroutine(NextStep());
        }

        private void Update()
        {
            var x = Input.GetAxis ("Horizontal");
            var y = Input.GetAxis ("Vertical");
            if (new Vector2 (x, y).sqrMagnitude > 0.01f) {
                SnakeDirection direction;
                if (Mathf.Abs (x) > Mathf.Abs (y))
                    direction = x > 0f ? SnakeDirection.Right : SnakeDirection.Left;
                else
                    direction = y > 0f ? SnakeDirection.Up : SnakeDirection.Down;
                _nextDirection = direction;
            }
        }

        private IEnumerator  NextStep()
        {
            while (true)
            {
                Snake.Move(_nextDirection);
                yield return new WaitForSeconds(1f/speed);
            }
        }
    }
}
