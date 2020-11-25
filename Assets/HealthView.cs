using UnityEngine;
using UnityEngine.UI;

public class HealthView : MonoBehaviour
{
    private Text _myText;

    private HealthBehavior _healthBehavior;

    private void Awake()
    {
        _myText = GetComponent<Text>();

        _healthBehavior = FindObjectOfType<HealthBehavior>();
    }

    private void OnEnable()
    {
        _healthBehavior.HealtChange.AddListener(OnHealthChange);
    }

    private void OnDisable()
    {
        _healthBehavior.HealtChange.RemoveListener(OnHealthChange);
    }

    private void OnHealthChange(float health)
    {
        _myText.text = health.ToString();
    }
}
