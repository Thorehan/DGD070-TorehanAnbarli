//using Entitas;
//using UnityEngine;

//namespace MyGame.Features.PlayerHealth.Systems
//{
//    public class ChangePlayerHealthSystem : IExecuteSystem
//    {
//        readonly Contexts _contexts;

//        public ChangePlayerHealthSystem(Contexts contexts)
//        {
//            _contexts = contexts;
//        }

//        public void Execute()
//        {
//            var playerEntity = _contexts.game;

//            if (Input.GetKeyDown(KeyCode.D))
//            {
//                playerEntity.AddPlayerDamaged();
//            }
//            if (Input.GetKeyDown(KeyCode.H))
//            {
//                playerEntity.AddPlayerHealed();
//            }
//        }
//    }
//}