using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumTest : MonoBehaviour
{
    public enum GameState { Ready = 2, Playing = 4, Pause = 5, GameOver = 3 };

    public GameState state;     //als je deze variable public wilt maken, moet de enum zelf ook public zijn

    //hiermee kan je bijvoorbeeld enemies een state geven (chasinng, running, ...) of een inventory met items waarbij de internal waarde het aantal is

    void Start()
    {
        state = GameState.Ready;
    }

    void Update()
    {
        switch (state)
        {
            case GameState.Ready:
                print("Ready");
                break;
             case GameState.Playing:
                print("Playing");
                break;
            case GameState.Pause:
                print("Paused");
                break;
            case GameState.GameOver:
                print("Game Over");
                break;
        }

        switch (state)
        {
            case GameState.Ready:
                print( (int)GameState.Ready ); //ja kan zo de internal value van een enum waarde opvragen (mbv TypeCasting)
                break;
             case GameState.Playing:
                print("Playing");
                break;
            case GameState.Pause:
                print("Paused");
                break;
            case GameState.GameOver:
                print("Game Over");
                break;
        }
    }
}
