
using UnityEngine;
using UnityEngine.SceneManagement;
namespace KID 
{
    public class SceneControl : MonoBehaviour
    {
        private string scene;
        public void LoadScene(string scene)
        {
            this.scene = scene;
            Invoke("DelayLoadScene", 1.2f);
        }

        private void DelayLoadScene()
        {
            SceneManager.LoadScene(scene);
        }

        public void Quit()
        {
            //延迟呼叫
            Invoke("DelatQuit", 1.2f);
        }

        private void DelayQuit()
        {
            Application.Quit();
        }
    }
}

