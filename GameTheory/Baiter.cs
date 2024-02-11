namespace Main
{
    // If the other bot retaliates twice it will comply before going back to retaliating
    class Baiter : Player {
        private int defectCount = 0;

        public override bool choice(bool oChoice) {

            if(!oChoice)
                defectCount++;


            if(defectCount >= 2) { // If there are two retaliations comply
                defectCount = 0;
                return true;
            }


            return false;
        }
    }
}