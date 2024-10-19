using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvaMenu : MonoBehaviour
{

    [SerializeField] GameObject pageMenu, pageOptions, pageGames;

    private void Start()
    {
        Time.timeScale = 1;
        pageMenu.SetActive(true);
        pageGames.SetActive(false);
        pageOptions.SetActive(false);
    }

    public void loadNivel(int nivel)
    {
        SceneManager.LoadScene(nivel);
    }

    public void openPageMenu()
    {
        pageMenu.SetActive(true);
        pageGames.SetActive(false);
        pageOptions.SetActive(false);
    }

    public void openPageGanes()
    {
        pageMenu.SetActive(false);
        pageGames.SetActive(true);
        pageOptions.SetActive(false);
    }

    public void openPageOptions()
    {
        pageMenu.SetActive(false);
        pageGames.SetActive(false);
        pageOptions.SetActive(true);
    }

}
