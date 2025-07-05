using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Party party = new Party();
    Member newMember = new Member("aa", 0);
    Member member = new Member("test", 0);

    void Start()
    {
        // List<Member> members = party.GetMembers();
        Debug.Log(party.IsLive());

        party.AddMember(member);
        party.AddMember(newMember);

        Debug.Log(party.isFull());
        Debug.Log(party.IsLive());

        Debug.Log(party.exists(newMember));
    }

}
