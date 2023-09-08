namespace Code_of_the_Hexagon_Server
{
    class HexCoor
    {
        // Kodas ir hex idėja paimta iš:
        // https://www.redblobgames.com/grids/hexagons/
        // Naudinga detalė skaičiavimams: q + r + s == 0
        public int q { get; private set; }
        public int r { get; private set; }
        public int s { get; private set; }
        public HexCoor(int Q, int R, int S)
        {
            (q, r, s) = (Q, R, S);
        }
        public HexCoor(int col, int row)
        {
            q = col - (row - (row & 1)) / 2;
            r = row;
            s = -q - r;
        }
        public int GetCol()
        {
            return q + (r - (r & 1)) / 2;
        }
        public int GetRow()
        {
            return r;
        }
    }
}
