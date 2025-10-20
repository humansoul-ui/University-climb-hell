using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoveController : MonoBehaviour
{
    public static LoveController instance;
    [SerializeField] private Image _loveImage;
    [SerializeField ,Range(0.1f,5f)] private float _loveDrainSpeed = 1f;
    [SerializeField] private float _maxLoveAmount = 100f;
    [SerializeField] private Gradient _loveGradient;
    private float _currentLoveAmount;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    private void Start()
    {
        _currentLoveAmount = _maxLoveAmount;
        UpdateUI();
    }
    private void Update()
    {
        _currentLoveAmount -= Time.deltaTime * _loveDrainSpeed;
        UpdateUI();
    }
    private void UpdateUI()
    {
        _loveImage.fillAmount = (_currentLoveAmount / _maxLoveAmount);
        _loveImage.color = _loveGradient.Evaluate(_loveImage.fillAmount);
    }
    public void FillLove()
    {
        _currentLoveAmount = _maxLoveAmount;
        UpdateUI() ;
    }
}
