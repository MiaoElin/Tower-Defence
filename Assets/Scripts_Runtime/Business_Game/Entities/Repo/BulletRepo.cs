using System.Collections.Generic;
public class BulletRepo {
    Dictionary<int, BulletEntity> all;
    BulletEntity[] tempArray;
    public BulletRepo() {
        all = new Dictionary<int, BulletEntity>();
        tempArray = new BulletEntity[1000];
    }
    public void Add(BulletEntity bullet) {
        all.Add(bullet.id, bullet);
    }
    public void Remove() {
        int bulLen = TakeAll(out BulletEntity[] all_buls);
        for (int i = 0; i < bulLen; i++) {
            var bul = all_buls[i];
            if (bul.isDead) {
                all.Remove(bul.id);
                bul.TearDown();
            }
        }

    }
    public int TakeAll(out BulletEntity[] all_bullets) {
        if (all.Count > tempArray.Length) {
            tempArray = new BulletEntity[all.Count * 2];
        }
        all.Values.CopyTo(tempArray, 0);
        all_bullets = tempArray;
        return all.Count;
    }
}