using UnityEngine;
using TMPro;
using System;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        _remainingText.text = " " + seedsLeft;
        _plantedText.text = " " + seedsPlanted;

    }


}