using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Coffee.UIExtensions;

public class TestUIParticle : MonoBehaviour
{
    // 动态的生成obj 添加 UIParticle 组建
    public Transform transformParent;

    private UIParticle particle;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            CreatParticle();
        }
    }

    private void CreatParticle()
    {
        // 测试生成粒子的父级
        GameObject uIParticleObj = new GameObject("UIParticle");
        uIParticleObj.transform.SetParent(transformParent);

        // 生成粒子特效
        GameObject.Instantiate<GameObject>(Resources.Load<GameObject>("Pfefab/effec_test_1"), Vector3.zero, Quaternion.identity, uIParticleObj.transform);
        particle = uIParticleObj.AddComponent<UIParticle>();

        particle.Play();
        particle.scale = 1;
    }
}
