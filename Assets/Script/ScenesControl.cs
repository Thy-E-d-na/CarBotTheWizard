using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesControl : MonoBehaviour
{
    //[SerializeField] private GameObject _pnl;
    //[SerializeField] private float speed;

    private void Update()
    {
        //_pnl.transform.Rotate(Vector3.up * speed);
        //may change pos and rotate at the same time. like the Jet model
    }
    public void toSceneA()
    {
        SceneManager.LoadScene("ModeA");
    }
    public void toSceneB()
    {
        SceneManager.LoadScene("ModeB");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
