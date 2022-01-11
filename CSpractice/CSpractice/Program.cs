using System;
using System.Threading.Tasks;
using System.Threading;

namespace CSpractice
{
    class Program
    {
        // 태경이는 오늘 커밋함 ㅋㅋ ㄹㅇ ㅋㅋ

        //        유니티 꿀팁상식 : Vector3.right와 transform.right는 다르다.
        //Vector3는 월드를 기준으로 절대적인 오른쪽을 가르키고,
        //transform은 오브젝트를 기준으로 오른쪽을 가르킨다.


        //distVec = 내위치

        //_col 옵젝의 오른쪽 방향벡터와 distVec벡터를 외적한 z축의 값이 양수일때 실행.


        //- 벡터의 외적 오른손의 법칙
        //반시계 방향 - 엄지의 방향(화면에서 밖으로) - z값 : 양수 : 벽의 위에 부딪힘
        //시계 방향 - 엄지의 방향(밖에서 화면으로) - z값 : 음수 : 벽의 아래에 부딪힘

        //void UpOrDown(Collision2D _col)
        //{
        //    Vector3 distVec = transform.position - _col.transform.position;

        //    if (Vector3.Cross(_col.transform.right, distVec).z > 0)
        //    {
        //        Debug.Log("Up");
        //        return;
        //    }
        //    Debug.Log("Down");
        //}


    }
}
