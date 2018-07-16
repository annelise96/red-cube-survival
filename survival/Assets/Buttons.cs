
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public Button restart, exit;

    void Start()
    {
        Button btn1 = restart.GetComponent<Button>();
        Button btn2 = exit.GetComponent<Button>();
        btn1.onClick.AddListener(Restart);
        btn2.onClick.AddListener(Exit);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Exit()
    {
        Application.Quit();
    }
}
