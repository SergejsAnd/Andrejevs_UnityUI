using System.Collections;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreneChangerScript : MonoBehaviour
{
   public void LoadWithDelay(string name) {
        StartCoroutine(LoadSceneAfterDelay(name));
    }
    private IEnumerator LoadSceneAfterDelay(string name){
        yield return new WaitForSeconds(1.5f);
        // Ielâdç ainu pçc t''as nosaukuma
        SceneManager.LoadScene(name, LoadSceneMode.Single);

        // Ielâdç ainu pçc tâs indeksa
        //SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    public void QuitGame() {
        Application.Quit();
    }

}
