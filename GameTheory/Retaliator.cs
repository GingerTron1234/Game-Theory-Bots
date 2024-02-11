namespace Main
{
    // Starts off complying but will always defect when the opponent defects
    class Retaliator : Player {

        public override bool choice(bool oChoice) {
            
            if(!oChoice)
                return false;
            else
                return true;
        }
    }
}