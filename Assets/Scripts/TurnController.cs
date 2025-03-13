using UnityEngine;

public class TurnController : MonoBehaviour
{
    public bool IsPlayerTurn = true;

    public PlayerActions player;

    /// <summary>
    /// On any side action, Run this function last to switch side
    /// </summary>
    public void ExecuteTurn()
    {
        IsPlayerTurn = !IsPlayerTurn;

        if(IsPlayerTurn)
        {
            //Enable Player Control
            player.EnableAction();
        }  
        else
        {
            player.EnableAction(false);

            //Execute Enemy Action
        }
    }
}
