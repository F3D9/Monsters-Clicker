using UnityEngine;
using UnityEngine.UI;

public class buyUpgrades : MonoBehaviour
{
    [SerializeField] GameObject admin;
    enum type
    {
        seconds1,
        click1,
        seconds2,
        click2,
        seconds3,
    }

    [SerializeField] type upgrade;
    [SerializeField] float price;
    

    public void buyUpgrade()
    {
        if (admin.GetComponent<AdminManager>().Score >= price)
        {
            switch (upgrade)
            {
                case type.seconds1:
                    admin.GetComponent<AdminManager>().addScorePerSecond = 2;
                    break;

                case type.click1:
                    admin.GetComponent<AdminManager>().ClickScore = 4;
                    break;

                case type.seconds2:
                    admin.GetComponent<AdminManager>().addScorePerSecond = 20;
                    break;

                case type.click2:
                    admin.GetComponent<AdminManager>().ClickScore = 10;
                    break;

                case type.seconds3:
                    admin.GetComponent<AdminManager>().addScorePerSecond = 100;
                    break;
            }

            transform.GetComponent<Button>().enabled = false;
            transform.GetComponent<Image>().color = new Color32(142, 64, 71, 255);
            admin.GetComponent<AdminManager>().Score -= price;

        }

    }

    private void Update()
    {
        if (transform.GetComponent<Button>().enabled)
        {
            if (admin.GetComponent<AdminManager>().Score >= price)
            {
                transform.GetComponent<Image>().color = new Color32(64, 142, 86, 255);
            }
            else
            {
                transform.GetComponent<Image>().color = Color.gray;
            }
        }
        
    }
}
