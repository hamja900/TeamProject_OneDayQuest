using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCarrot : MonoBehaviour
{
    private Animator _animator;

    [SerializeField] private GameObject _plusOne;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    public void addCarrotAnim()
    { 
        _animator.SetTrigger("addCarrot");
    }
}
