//using Entitas;
//using MyGame.Features.PlayerHealth.Systems;
//using UnityEngine;


//    public class PlayerHealthFeature : MonoBehaviour
//    {
//        private Entitas.Systems _systems;

//        void Start()
//        {
//            var contexts = Contexts.sharedInstance;

//            _systems = new Entitas.Systems()
//                .Add(new CreatePlayerHealthSystem(contexts))
//                .Add(new CheckPlayerHealthSystem(contexts))
//                .Add(new ChangePlayerHealthSystem(contexts));

//            _systems.Initialize();
//        }

//        void Update()
//        {
//            _systems.Execute();
//        }

//        void OnDestroy()
//        {
//            _systems.TearDown();
//        }
//    }
