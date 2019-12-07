using System.Collections.Generic;
using SnakeSimple.Scripts.Components;
using UnityEngine;

namespace SnakeSimple.Scripts.GameObj {
    public class Snake:MonoBehaviour
    {
        
        public List<SnakeSegment> Body = new List<SnakeSegment> (256);

        public bool _isGrow;
        
        public void OnAddSegment()
        {
            _isGrow = true;
        }

        public void Move(SnakeDirection direction)
        {
            if (_isGrow)
            {
                var head = Instantiate(Body[0], transform);
                var vect = Body[0].transform.position;
                switch (direction)
                {
                    case SnakeDirection.Up:
                        head.transform.position = new Vector2(vect.x, vect.y + 1);
                        break;
                    case SnakeDirection.Right:
                        head.transform.position = new Vector2(vect.x+1, vect.y );
                        break;
                    case SnakeDirection.Down:
                        head.transform.position = new Vector2(vect.x, vect.y-1);
                        break;
                    case SnakeDirection.Left:
                        head.transform.position = new Vector2(vect.x-1, vect.y);
                        break;
                }
                Body.Insert(0, head);
                _isGrow = false;
            }
            else
            {
                for (int i = 1; i < Body.Count; i++)
                {
                    Body[i].transform.position = Body[i - 1].transform.position;
                }
                var head = Body[0];
                var vect = head.transform.position;
                switch (direction)
                {
                    case SnakeDirection.Up:
                        head.transform.position = new Vector2(vect.x, vect.y + 1);
                        break;
                    case SnakeDirection.Right:
                        head.transform.position = new Vector2(vect.x+1, vect.y );
                        break;
                    case SnakeDirection.Down:
                        head.transform.position = new Vector2(vect.x, vect.y-1);
                        break;
                    case SnakeDirection.Left:
                        head.transform.position = new Vector2(vect.x-1, vect.y);
                        break;
                }
            }
            
        }
        
        
    }
}