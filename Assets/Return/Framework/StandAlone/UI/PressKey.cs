﻿using Return.UI;
using UnityEngine;
using UnityEngine.Events;

namespace Michsky.UI.Zone
{
    public class PressKey : CustomWindow
    {
        [Header("KEY")]
        [SerializeField]
        public KeyCode hotkey;
        public bool pressAnyKey;
        public bool invokeAtStart;

        [Header("KEY ACTION")]
        [SerializeField]
        public UnityEvent pressAction;

        void Start()
        {
            if(invokeAtStart == true)
                pressAction.Invoke();
        }

        void Update()
        {
            return;
            if(pressAnyKey == true)
            {
                if (Input.anyKeyDown)
                {
                    pressAction.Invoke();
                } 
            }

            else
            {
                if (Input.GetKeyDown(hotkey))
                {
                    pressAction.Invoke();
                } 
            }
        }
    }
}