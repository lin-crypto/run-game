using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate(this);
        }
    }

    //singleton implementation
    private static UIManager instance;
    public static UIManager Instance
    {
        get
        {
            if (instance == null)
                instance = new UIManager();

            return instance;
        }
    }

    protected UIManager()
    {
    }

    public float score = 0;


    public void ResetScore()
    {
        score = 0;
        UpdateScoreText();
    }

    public void SetScore(float value)
    {
        score = value;
        UpdateScoreText();
    }

    public void IncreaseScore(float value)
    {
        if (value > 1) TokenImageGO.GetComponent<Animation>().Play("TokenBounceCenter");
        score += value;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        ScoreText.text = score.ToString();
        ScoreTextOnGame.text = score.ToString();
    }

    public void SetStatus(string text)
    {
        StatusText.text = text;
    }

    public void Update() {
        if(GameManager.Instance.GameState != GameState.Start) TapTextGO.SetActive(false);
        else TapTextGO.SetActive(true);
    }

    public Text ScoreText, StatusText, ScoreTextOnGame;
    public GameObject TokenImageGO, TapTextGO;


}
