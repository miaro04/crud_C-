namespace PieceManagerSQLite.Models
{
    public class Piece
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Reference { get; set; }
        public decimal Prix { get; set; }
        public bool Disponibilite { get; set; }
    }
}
