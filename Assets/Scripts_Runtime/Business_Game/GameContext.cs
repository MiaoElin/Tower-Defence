public class GameContext{
    public TempelateContext tempCon;
    
    public GameContext(){
    }
    public void Inject(TempelateContext tempCon){
        this.tempCon=tempCon;
    }
}