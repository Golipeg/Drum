using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMovement : MonoBehaviour
{
    [SerializeField] private HingeJoint _hingeJoint;
    [SerializeField] private Rigidbody _rigidbody;
    

    private void StopMotor(bool isActive)
    {
        _hingeJoint.useMotor = isActive;
        _rigidbody.isKinematic = !isActive;
    }

    private void ReverseMotor(bool isActive)
    {
        if (isActive)
        {
            var hingeJointMotor = _hingeJoint.motor;
            hingeJointMotor.targetVelocity = 50f;
            _hingeJoint.motor = hingeJointMotor;
        }
        else
        {
            var hingeJointMotor = _hingeJoint.motor;
            hingeJointMotor.targetVelocity = -50f;
            _hingeJoint.motor = hingeJointMotor;
        }
    }

    private void OnEnable()
    {
        GameEvents.Instance.OnEnableMotor += StopMotor;
        GameEvents.Instance.OnReverseMotor += ReverseMotor;
    }

    private void OnDisable()
    {
        GameEvents.Instance.OnEnableMotor -= StopMotor;
        GameEvents.Instance.OnReverseMotor -= ReverseMotor;
    }
}