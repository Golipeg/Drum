using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
   
   public void StartRotation(bool isActive)
   {
      
      GameEvents.Instance.OnEnableMotor?.Invoke(isActive);
   }

   public void StopRotation(bool isActive)
   {
      GameEvents.Instance.OnEnableMotor?.Invoke(isActive);
   }

   public void ReverseRotation(bool isActive)
   {
      Debug.Log("bool=" + isActive);
      GameEvents.Instance.OnReverseMotor?.Invoke(isActive);
   }

}
