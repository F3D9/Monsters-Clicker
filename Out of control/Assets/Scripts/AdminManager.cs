using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class AdminManager : MonoBehaviour
{
    //Score
    [Header("Score")]
    [SerializeField] TMP_Text score_text;
    public float Score;

    //ContDown
    [Header("ContDown")]
    [SerializeField] TMP_Text contdown;
    public float timer;

    //Police Helicopter
    [Header("Police")]
    public int policeHelicopterNumber;
    public float conditionPoliceH;
    [SerializeField] int scorePoliceH;
    [SerializeField] TMP_Text policeNumberText;

    //Militar Helicopter
    [Header("Militar")]
    public int militarHelicopterNumber;
    public float conditionMilitarH;
    [SerializeField] int scoreMilitarH;
    [SerializeField] TMP_Text militarNumberText;

    //AirCraft 
    [Header("AirCraft")]
    public int AirCraftNumber;
    public float conditionAirCraft;
    [SerializeField] int scoreAirCraft;
    [SerializeField] TMP_Text aircraftNumberText;

    //Airfeighter 
    [Header("Airfeighter")]
    public int AirfeighterNumber;
    public float conditionAirfeighter;
    [SerializeField] int scoreAirfeighter;
    [SerializeField] TMP_Text airfeighterNumberText;

    //Misil
    [Header("Misil")]
    public int MisilNumber;
    
    [SerializeField] TMP_Text misilNumberText;


    float timerPoliceHelicopter;
    float timerMilitarHelicopter;
    float timerAirCraft;
    float timerAirfeighter;

    [Header("Upgrades")]
    [Header("Seconds")]
    public int addScorePerSecond;
    [SerializeField] TMP_Text scorePerSecondText;
    float timerOneSecond;

    [Header("Click")]
    [SerializeField] GameObject prefabClick;
    public int ClickScore = 1;

    private void Start()
    {
        ClickScore = 1;
        addScorePerSecond = 0;
    }



    // Update is called once per frame
    void Update()
    {
        //Vuelve un entero al puntaje
        Score = (int)Score;

        //Score per second
        timerOneSecond += Time.deltaTime;
        if (timerOneSecond > 1) 
        {
            Score += addScorePerSecond;
            timerOneSecond = 0;
        }

        scorePerSecondText.text = addScorePerSecond.ToString() + "/s";

        //Click Score
        prefabClick.transform.GetChild(1).GetComponent<TMP_Text>().text = "+" + ClickScore.ToString();


        //ContDown
        timer -= Time.deltaTime;

        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        contdown.text = string.Format("{0:00}:{1:00}",minutes,seconds);

        //Police Helicopter
        timerPoliceHelicopter += Time.deltaTime;

        if (timerPoliceHelicopter > conditionPoliceH)
        {
            Score += scorePoliceH * policeHelicopterNumber;
            timerPoliceHelicopter = 0;
        }

        //Militar Helicopter
        timerMilitarHelicopter += Time.deltaTime;

        if (timerMilitarHelicopter > conditionMilitarH)
        {
            Score += scoreMilitarH * militarHelicopterNumber;
            timerMilitarHelicopter = 0;
        }

        //AirCraft 
        timerAirCraft += Time.deltaTime;

        if (timerAirCraft > conditionAirCraft)
        {
            Score += scoreAirCraft * AirCraftNumber;
            timerAirCraft = 0;
        }

        //Airfeighter
        timerAirfeighter += Time.deltaTime;

        if (timerAirfeighter > conditionAirfeighter)
        {
            Score += scoreAirfeighter * AirfeighterNumber;
            timerAirfeighter = 0;
        }

        //Show number of army in the shop page
        policeNumberText.text = "X" + policeHelicopterNumber.ToString();
        militarNumberText.text = "X" + militarHelicopterNumber.ToString();
        aircraftNumberText.text = "X" + AirCraftNumber.ToString();
        airfeighterNumberText.text = "X" + AirfeighterNumber.ToString();
        misilNumberText.text = "X" + MisilNumber.ToString();

        //Show Score in screen
        score_text.text = Score.ToString();
    }
}
