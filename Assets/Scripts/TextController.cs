using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private Image portrait;

    private void OnEnable()
    {
        DialougeInteration.OnDialogueInteraction += UpdateUI;
    }
    
    private void OnDisable()
    {
        DialougeInteration.OnDialogueInteraction -= UpdateUI;
    }
    
    private void UpdateUI(IEnumerable<ConversationLine> conversation)
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
