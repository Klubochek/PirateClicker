using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsScript : MonoBehaviour
{
    
    [SerializeField] public TMP_InputField inputField;
    [SerializeField] public AudioClip buttonClickAudio;
    [SerializeField] public AudioSource buttonFX;
    public string userName;
    public int qofPlayers;

    void Start()
    {

    }
    
    void Update()
    {

    }

    public void ButtonSound()
    {
        buttonFX.PlayOneShot(buttonClickAudio);
    }
    public void WindowActivator(GameObject windowToOpen)
    {
        windowToOpen.gameObject.SetActive(true);

    }

    public void BackToGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ToAchivment()
    {
        SceneManager.LoadScene(2);

    }
    public void ExitButton()
    {
        Application.Quit();
    }

    public void WindowDeActivator(GameObject windowToClose)
    {
        windowToClose.gameObject.SetActive(false);
    }

    public void StartGame() 
    {
        qofPlayers = PlayerPrefs.GetInt("qofPlayers");
        userName=inputField.text;
        print(userName);
        qofPlayers++;
        PlayerPrefs.SetString($"userName", userName);
        PlayerPrefs.SetInt("qofPlayers", qofPlayers);
        SceneManager.LoadScene(1);

    }

    public void ContinueGame() 
    {
        SceneManager.LoadScene(1);
    }
    public void BackToMainMenu() 
    {
        //PlayerPrefs.SetInt($"moneyof{userName}", Score.score);
        SceneManager.LoadScene(0);
    }
    public void DeleteData()
    {
        PlayerPrefs.DeleteAll();
    }
}