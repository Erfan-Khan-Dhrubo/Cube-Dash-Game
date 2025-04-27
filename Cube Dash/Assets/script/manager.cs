using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
   public void RestartGame()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
