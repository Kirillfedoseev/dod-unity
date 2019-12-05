using SnakeSimple.Scripts.Components;
using SnakeSimple.Scripts.GameObj;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

namespace SnakeSimple.Scripts {
    sealed class GameController : MonoBehaviour {

        public Food Food;

        public Text Score;
        private int _score;
        
        public Snake Snake;

        public Obstacle[] Obstacles;
         
        [SerializeField] private Vector2 LBCorner = new Vector2(1, 1);
        
        [SerializeField] private Vector2 RUCorner = new Vector2(23, 14);


        public void Start()
        {
            _score = 0;
            IncreaseScore();
            Food.OnEaten.AddListener(RandomSpawnFood);
            Food.OnEaten.AddListener(IncreaseScore);
            Food.OnEaten.AddListener(Snake.OnAddSegment);
            
            Obstacles = FindObjectsOfType<Obstacle>();
            foreach (var obstacle in Obstacles)
            {
                obstacle.OnDeath.AddListener(OnDeath);
            }

            foreach (var segment in Snake.Body)
            {
                segment.OnStack.AddListener(OnDeath);
            }
            
            RandomSpawnFood();
        }

        


        private void OnDeath()
        {
            Debug.Log($"Your final score: {_score}");
            Application.Quit();
        }

        private void IncreaseScore()
        {
            Score.text = $"Score: {_score++}";
        }
        
        private void RandomSpawnFood()
        {
            Random rnd = new Random();
            int x = rnd.Next((int)LBCorner.x, (int)RUCorner.x);
            int y = rnd.Next((int)LBCorner.y, (int)RUCorner.y);
            Food.transform.position = new Vector2(x, y);
        }

    

    }
}