using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class Game : MonoBehaviour
    {
        public List<BaseObject> objects;

        private static Game _instance = null;

        public Game()
        {
            objects = new List<BaseObject>();
        }

        public static Game GetGame()
        {
            if (_instance == null)
                _instance = new Game();

            return _instance;
        }

        public void Awake()
        {
            DontDestroyOnLoad(this); //make Game persist trough scenes
        }

        public void Update()
        {
            for (int i = 0; i < objects.Count; i++)
                objects[i].Update();
        }
    }
}