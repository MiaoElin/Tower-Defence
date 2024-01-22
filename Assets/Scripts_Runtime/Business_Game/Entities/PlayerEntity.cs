using UnityEngine;
public class PlayerEntity{
    public int hp;
    public int maxHp;
    //不需要生成实例显示在屏幕，所以不用继承Monobehaviour
    public void Init(int hp){
        this.hp=hp;
        maxHp=hp;
    }

}