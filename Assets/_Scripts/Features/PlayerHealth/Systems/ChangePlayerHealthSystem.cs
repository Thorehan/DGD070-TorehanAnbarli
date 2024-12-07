using Entitas;
using UnityEngine;

public class ChangePlayerHealthSystem : IExecuteSystem
{
    private readonly GameContext _context;

    public ChangePlayerHealthSystem(Contexts contexts)
    {
        _context = contexts.game;
    }

    public void Execute()
    {
        var entity = _context.GetGroup(GameMatcher.PlayerHealth).GetSingleEntity();

        if (entity == null)
        {
            Debug.LogError("Player entity bulunamad�!");
            return;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (entity.playerHealth.Value > 0)
            {
                Debug.Log($"D tu�una bas�ld�. Can azalt�l�yor. �nceki Can: {entity.playerHealth.Value}");
                entity.isPlayerDamaged = true;
            }
            else
            {
                Debug.Log("Can zaten 0, daha fazla azalamaz.");
            }
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            if (entity.playerHealth.Value < 100)
            {
                Debug.Log($"H tu�una bas�ld�. Can art�r�l�yor. �nceki Can: {entity.playerHealth.Value}");
                entity.isPlayerHealed = true;
            }
            else
            {
                Debug.Log("Can zaten 100, daha fazla artamaz.");
            }
        }
    }
}
