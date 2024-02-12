namespace Main
{
    abstract class Player {

        public string name = "undefined";
        public int points = 0;
        public abstract bool choice(bool oChoice);
    }
}