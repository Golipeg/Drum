using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[DefaultExecutionOrder(-5)]
public class GameEvents : MonoBehaviour
{
 public static GameEvents Instance;
 public Action<bool> OnEnableMotor;
 public Action<bool> OnReverseMotor;
 private void Awake()
 {
  if (Instance == null)
  {
   Instance = this;
  }
  else
  {
   Destroy(this);
   return;
  }
  DontDestroyOnLoad(this);
 }
}
