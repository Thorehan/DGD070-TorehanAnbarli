//using Entitas;
//using UnityEngine;

//public class CheckPlayerHealthSystem : IExecuteSystem
//{
//    readonly GameContext _context;

//    public CheckPlayerHealthSystem(Contexts contexts)
//    {
//        _context = contexts.game;
//    }

//    public void Execute()
//    {
//        var playerEntities = _context;

//        foreach (var playerEntity in playerEntities)
//        {
//            if (playerEntity.hasPlayerDamaged)
//            {
//                playerEntity.ReplacePlayerHealth(Mathf.Max(0, playerEntity.playerHealth.Value - 10));
//                playerEntity.RemovePlayerDamaged();
//            }
//            else if (playerEntity.hasPlayerHealed)
//            {
//                playerEntity.ReplacePlayerHealth(Mathf.Min(100, playerEntity.playerHealth.Value + 10));
//                playerEntity.RemovePlayerHealed();
//            }
//        }
//    }
//}
