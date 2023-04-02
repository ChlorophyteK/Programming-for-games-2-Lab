using UnityEngine;

[System.Serializable]

public class PlayerLives
{
    public int playerLives;
    public string playerName;

    public void update()
    {
        if (Input.GetKeyDown(KeyCode.T))
            {
            playerLives = playerLives + 1;
            }


        if (Input.GetKeyDown(KeyCode.Y))
            {
            playerLives = playerLives - 1;
            }
    }
}