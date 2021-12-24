namespace ConsoleUI
{
    public struct CoordsStruct : ICoords
    {
        public int Latitude, Longitude;
        public CoordsStruct(int latitude, int longitude) => (Latitude, Longitude) = (latitude,longitude);
        public string View() { return string.Format("({0},{1})", this.Latitude, this.Longitude); }
    }
}
