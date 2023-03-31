using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    [SerializeField] private GameObject[] _models;

    private int _currSelected = 2;

    public void RemoveHP()
    {
        if (_currSelected < 0) return;

        _models[_currSelected].SetActive(false);
        _currSelected--;
    }

    public void AddHP()
    {
        if (_currSelected >= _models.Length) return;

        _currSelected++;
        _models[_currSelected].SetActive(true);
    }
}
