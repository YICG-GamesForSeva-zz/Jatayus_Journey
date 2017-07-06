using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuBehavior : MonoBehaviour
{
    public void triggerGame(int trig)
    {
        switch (trig)
        {
            case (0):
                SceneManager.LoadScene("GameDescription");
                break;
            case (1):
                Application.Quit(); 
                break;
            default:
                break;
        }
    }
}