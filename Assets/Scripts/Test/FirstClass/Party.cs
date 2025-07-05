// using System.Collections;
// using System.Collections.Generic;
// using Unity.VisualScripting;
// using UnityEngine;
// using System.Linq;

// public class Party : MonoBehaviour
// {
//    static int MAX_MEMBER_COUNT = 4;
//    private List<Member> members; // Member

//    public Party()
//    {
//       members = new List<Member>();
//    }

//    private Party(List<Member> members)
//    {
//       this.members = members;
//    }

//    public List<Member> GetMembers()
//    {
//       return members;
//    }

//    /// <summary>
//    /// @return Party added member
//    /// </summary>
//    /// <param name="member"></param>
//    public Party AddMember(Member newMember)
//    {
//       if (exists(newMember)) throw new System.Exception("member already exists");

//       if (isFull()) throw new System.Exception("party is full");

//       List<Member> adding = new List<Member>();
//       adding.Add(newMember);
//       return new Party(adding);
//    }
//    public bool IsLive()
//    {
//       return members.Any(member => member.IsLive());
//    }

//    public bool exists(Member checkmember)
//    {
//       return members.Contains(checkmember);
//    }

//    public bool isFull()
//    {
//       return members.Count == MAX_MEMBER_COUNT;
//    }

// }
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Party : MonoBehaviour
{
   private static readonly int MAX_MEMBER_COUNT = 4; // 읽기 전용으로 설정
   private readonly List<Member> members; // 외부에서 접근 불가

   public Party()
   {
      members = new List<Member>();
   }

   public int MemberCount => members.Count; // 현재 멤버 수를 외부에서 조회할 수 있도록 속성 추가

   // 멤버 추가 메서드 (일급 컬렉션 패턴에 따라 내부 컬렉션에 대한 모든 변경 작업은 이 클래스 내에서 수행)
   public void AddMember(Member newMember)
   {
      if (exists(newMember)) throw new System.Exception("Member already exists in the party.");
      if (isFull()) throw new System.Exception("Party is full.");

      members.Add(newMember);
   }

   // 멤버가 존재하는지 확인
   public bool exists(Member checkmember)
   {
      return members.Contains(checkmember);
   }

   // 파티가 가득 찼는지 확인
   public bool isFull()
   {
      return members.Count >= MAX_MEMBER_COUNT;
   }

   // 파티에 생존한 멤버가 있는지 확인
   public bool IsLive()
   {
      return members.Any(member => member.IsLive());
   }

   // 외부에서 멤버 리스트를 조회하는 경우, 읽기 전용 리스트를 반환
   public IReadOnlyList<Member> GetMembers()
   {
      return members.AsReadOnly();
   }
}
