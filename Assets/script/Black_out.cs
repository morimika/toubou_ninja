using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Black_out : MonoBehaviour
{
    public Image PanelImage;
    [SerializeField] private float alphaSpeed;

    private bool isSceneChange;
    private bool isChangeEnd;
    private float alphaValue;
    private Color PanelColor;

    private void Awake()
    {
        isSceneChange = false;
        isChangeEnd = false;
        alphaValue = 0f;
        PanelColor = PanelImage.color;
    }

    private void Blackout()
    {
        if (other.gameObject.CompareTag("gameover"))
        {
            PanelImage.enabled = true;
            isSceneChange = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(isSceneChange)
        {
            alphaValue += alphaSpeed * Time.deltaTime;

            PanelImage.color = new Color(PanelColor.r, PanelColor.g, PanelColor.b, alphaValue);
            if(alphaValue>=1)
            {
                isSceneChange = false;
                isChangeEnd = true;
            }
        }
        if (isChangeEnd)
            SceneManager.LoadScene("start");
    }

public void EndGame()
    {
        Application.Quit();
    }

}
