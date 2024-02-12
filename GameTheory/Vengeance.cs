namespace Main
{
    // Always complies until the other bot defects
    class Vengeance : Player {

        public Vengeance() {
            name = "Vengeance";
        }
        private Boolean revenge = false;

        public override bool choice(bool oChoice) {

            if(!oChoice)
                revenge = false;

            if(revenge)
                return false;

            return true;
        }
    }
}