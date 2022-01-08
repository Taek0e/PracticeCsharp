using System;
using System.Threading.Tasks;
using System.Threading;

namespace CSpractice
{
    class Program
    {
        //void CheckGhost()
        //{
        //    int i = 0;  // 초기 값은 0
        //    foreach (var ghost in ghostObjectArray)  // foreach문을 이용해서 배열에 있는 유령옵젝들을 전부 체크.
        //    {
        //        Vector3 distanceVec = ghost.transform.position - transform.position; // 벡터3 distanceVec에는 내 위치에서 유령옵젝으로 향하는 벡터를 할당시킴.

        //        if (distanceVec.magnitude < rangeDistance)  // rangeDistance의 크기 보다 distanceVec의 크기가 작다면 실행.(벡터.magnitude는 벡터의 크기만 나타냄 즉, 스칼라로 바뀜)
        //        {
        //            Vector3 dirVec = distanceVec.normalized;  // 내적을 하기 위해 distanceVec를 방향벡터로 바꾸어줌 (벡터.normalized를 하면 벡터의 방향만 나타냄 즉, 방향벡터로 바뀜)

        //            if (Vector3.Dot(transform.up, dirVec) > Mathf.Cos(rangeAngle * Mathf.Deg2Rad)) // transform.up은 옵젝의 양의 y축 방향이다. (transform.up,transform.right,.. Vector.up,down,right 등.. 모두 크기가 1인 방향벡터이다.)
        //                i++;


        //            // 벡터.Dot(벡터1, 벡터2) 를 하면, 벡터1 벡터2의 내적한 값이 나온다. 

        //            // 두 벡터를 내적한 값 > cos세타 이므로, 두 벡터를 내적한 값이 더 크다면 감지된것으로 판단하고, i++을 해준다. 
        //        }
        //    }

        //    Debug.Log("감지된 유령의 수: " + i);
        //}
    }
}
