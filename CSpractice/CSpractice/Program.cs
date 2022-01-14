using System;
using System.Threading.Tasks;
using System.Threading;

namespace CSpractice
{
    class Program
    {
        //Vector3 tran = new Vector3(2, 1, 0);
        //Quaternion rot = Quaternion.Euler(45, 0, 45);
        //Vector3 scal = new Vector3(3, 3, 3);

        //worldMat = Matrix4x4.TRS(tran, rot, scal);  
        //// TRS연산 함수를 호출하여 편리하게 TRS를 연산하는 방식.

        //worldMat = Matrix4x4.Translate(new Vector3(2, 1, 0)) * Matrix4x4.Rotate(rot)* Matrix4x4.Scale(new Vector3(3, 3, 3));
        //// TRS연산 이동행렬, 회전행렬, 크기변환행렬을 하나씩 만들어서 순서대로 곱해주는 방식.


        //Debug.Log("==== Make Matrix ====");
        //for (int i = 0; i< 4; i++)
        //{
        //    Debug.Log(worldMat.GetRow(i));
        //}

}
}
