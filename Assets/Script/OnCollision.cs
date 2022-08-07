
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision : MonoBehaviour
    
{
    [SerializeField] ParticleSystem SuccessParticles;
    bool isTransitioning;
     void OnCollisionEnter(Collision Other)

    {
        if (isTransitioning)
        {
            return;
        }
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
        int NextSceneIndex = CurrentSceneIndex + 1;
        if(NextSceneIndex ==SceneManager.sceneCountInBuildSettings)
        {
            NextSceneIndex = 0;
        }
        SceneManager.LoadScene(NextSceneIndex);
    }
}
