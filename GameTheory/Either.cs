namespace Main
{
    class Either : Player {

        private int round = 0;

        public override bool choice(bool oChoice, bool first) {
            
            if((round % 2) == 0) {
                round++;
                return true;
            }
            round++;
            return false;
        }
    }
}