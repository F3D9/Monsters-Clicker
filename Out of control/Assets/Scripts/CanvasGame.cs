using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasGame : MonoBehaviour
{
    //Shop
    [SerializeField] RectTransform panel;
    [SerializeField] float velocidad = 5;

    [SerializeField] GameObject victory, defeat, pause;

    

    private void Start()
    {
        Time.timeScale = 1;
        pause.SetActive(false);
        defeat.SetActive(false);
        victory.SetActive(false);
        GameObject.FindGameObjectWithTag("Boss").GetComponent<PolygonCollider2D>().enabled = true;
    }

    public void openCanva(int number)
    {
        LeanTween.moveX(panel, number, velocidad).setEase(LeanTweenType.easeInOutQuint);
        GameObject.FindGameObjectWithTag("Boss").GetComponent<PolygonCollider2D>().enabled = false;
    }

    public void closeAllCanvas()
    {
        LeanTween.moveX(panel, 1400, velocidad).setEase(LeanTweenType.easeInOutQuint);
        GameObject.FindGameObjectWithTag("Boss").GetComponent<PolygonCollider2D>().enabled = true;

    }

    public void pauseCanva()
    {
        if (pause.activeInHierarchy)
        {
            pause.SetActive(false);
            Time.timeScale = 1;
            GameObject.FindGameObjectWithTag("Boss").GetComponent<PolygonCollider2D>().enabled = true;
        }
        else
        {
            pause.SetActive(true);
            GameObject.FindGameObjectWithTag("Boss").GetComponent<PolygonCollider2D>().enabled = false;
            Time.timeScale = 0;
        }
    }


    private void Update()
    {
        if (!victory.activeInHierarchy) 
        { 
            if (GameObject.FindGameObjectWithTag("Admin").GetComponent<AdminManager>().timer <= 0)
            {
                pause.SetActive(false);
                defeat.SetActive(true);
                Time.timeScale = 0;
                GameObject.FindGameObjectWithTag("Boss").GetComponent<PolygonCollider2D>().enabled = false;
            }
        }
        
    }

    public void victoryCanva()
    {
        victory.SetActive(true);
        GameObject.FindGameObjectWithTag("Boss").GetComponent<PolygonCollider2D>().enabled = false;
        Time.timeScale = 0;
    }

    public void menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    

}
