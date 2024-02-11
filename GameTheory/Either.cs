namespace Main
{
    // Switches between complying and defecting each round
    class Either : Player {

        private int round = 0;

        public override bool choice(bool oChoice) {
            
            if((round % 2) == 0) {
                round++;
                return true;
            }
            round++;
            return false;
        }
    }
}