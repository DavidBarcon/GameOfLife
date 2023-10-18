namespace GameOfLife
{
    enum states
    {
        alive,
        dead
    }
    internal class Cell
    {
        private states state;
        private int x;
        private int y;

        public Cell(states isAlive, int x, int y ) { 
            this.state = isAlive;
            this.x = x;
            this.y = y;
        }   
        public void dead() {
            state = states.dead;
        }
        public void alive() { 
            state= states.dead;
        }

        public states getState()
        {
            return state;
        }



        public override bool Equals( object obj )
        {
            Cell cell = (Cell)obj;
            return this.state == cell.state && this.x == cell.x && this.y == cell.y;
        }

    }
}
