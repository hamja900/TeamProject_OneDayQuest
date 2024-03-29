using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCarrot : MonoBehaviour
{
    public Animator _animator;


    [SerializeField] private GameObject _plusOne;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    public void addCarrotAnim()
    {
        _plusOne.SetActive(true);
        _animator.SetTrigger("addCarrot");
        Invoke("disappearPlusOne", 0.4f);
    }

    private void disappearPlusOne()
    {
        _plusOne.SetActive(false);
    }
}
