using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField]public List<Character> Players;
    public UnityEvent GameOver;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void RemovePlayer(Character character)
    {
        Players.Remove(character);
        if (Players.Count == 1)
        {
            GameOver.Invoke();
        }
    }
}
