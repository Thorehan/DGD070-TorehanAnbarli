using Entitas;
using UnityEngine;

public class CheckPlayerHealthSystem : IExecuteSystem
{
    private readonly GameContext _context;

    public CheckPlayerHealthSystem(Contexts contexts)
    {
        _context = contexts.game;
    }

    public void Execute()
    {
        var entity = _context.GetGroup(GameMatcher.PlayerHealth).GetSingleEntity();
        if (entity == null) return;

        if (entity.isPlayerDamaged)
        {
            float newHealth = Mathf.Max(0, entity.playerHealth.Value - 10);
            Debug.Log($"Hasar alýndý! Yeni Can: {newHealth}");
            entity.ReplacePlayerHealth(newHealth);
            entity.isPlayerDamaged = false;
        }

        if (entity.isPlayerHealed)
        {
            float newHealth = Mathf.Min(100, entity.playerHealth.Value + 10);
            Debug.Log($"Ýyileþtirildi! Yeni Can: {newHealth}");
            entity.ReplacePlayerHealth(newHealth);
            entity.isPlayerHealed = false;
        }
    }
}
