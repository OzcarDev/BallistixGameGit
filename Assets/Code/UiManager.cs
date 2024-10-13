using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class UiManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    public void SelectScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void ShowWinner()
    {
        string winner = GameManager.Instance.Players[0].gameObject.name;
        text.text = winner;
    }
    
}
