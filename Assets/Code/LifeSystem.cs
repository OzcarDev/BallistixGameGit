using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LifeSystem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Text;
    [SerializeField] private GameObject wall;
    [SerializeField] private int life = 15;

    private void Start()
    {
        SetUI(life);
    }

    private void SetUI(int num)
    {
        Text.text = num.ToString();
    }
    public void SetLife(int i)
    {
        life += i;
        SetUI(life);
        CheckLife();
    }

    private void CheckLife()
    {
        if (life <= 0)
        {
            SetUI(0);
            GameManager.Instance.RemovePlayer(this.gameObject.GetComponent<Character>());
            wall.SetActive(true);
            gameObject.SetActive(false);
        }
    }

}
