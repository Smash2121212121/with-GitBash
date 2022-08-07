
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision : MonoBehaviour
   
{
    void OnCollisionEnter(Collision Other)
    {
       switch (Other.gameObject.tag) 
        {
            case "Respawn":
                Debug.Log("respawn");
                break;
            case "Finish":
                NextLevel();
                break;
            default:
                ReloadLevel();
                break;
        }
    }
    void ReloadLevel()
    {
        int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentSceneIndex);
    }
    void NextLevel()
    {
        int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentSceneIndex + 1);
    }
}

