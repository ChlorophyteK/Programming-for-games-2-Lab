using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public PlayerLives so;
    public void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.K))
        {
            SaveManager.Save(so);
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            so = SaveManager.Load();
        }
    }

}