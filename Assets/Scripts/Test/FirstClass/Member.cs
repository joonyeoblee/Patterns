using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Member : MonoBehaviour
{
    public string memberName;
    public int memberID;

    bool isLive = true;

    public Member(String memberName, int memberID)
    {
        this.memberName = memberName;
        this.memberID = memberID;
    }

    public bool IsLive()
    {
        return isLive;
    }
}
