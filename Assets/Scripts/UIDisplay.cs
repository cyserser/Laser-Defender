using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIDisplay : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] Slider healthBar;
    [SerializeField] Health health;

    [Header("Score")]
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper scoreKeeper;

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    void Start()
    {
        healthBar.maxValue = health.GetHealth();
    }

    
    void Update()
    {
        healthBar.value = health.GetHealth();
        scoreText.text = scoreKeeper.GetScore().ToString("000000000");
    }
}
