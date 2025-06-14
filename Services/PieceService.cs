using System.Collections.Generic;
using System.Data.SQLite;
using PieceManagerSQLite.Models;

namespace PieceManagerSQLite.Services
{
    public class PieceService
    {
        private readonly string connectionString = "Data Source=pieces.db";

        public PieceService()
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();

            string tableCreation = @"CREATE TABLE IF NOT EXISTS pieces (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Nom TEXT NOT NULL,
                                        Reference TEXT NOT NULL,
                                        Prix REAL NOT NULL,
                                        Disponibilite INTEGER NOT NULL
                                     );";
            using var command = new SQLiteCommand(tableCreation, connection);
            command.ExecuteNonQuery();
        }

        public List<Piece> GetAll()
        {
            var list = new List<Piece>();
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM pieces";
            using var cmd = new SQLiteCommand(query, connection);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Piece
                {
                    Id = reader.GetInt32(0),
                    Nom = reader.GetString(1),
                    Reference = reader.GetString(2),
                    Prix = reader.GetDecimal(3),
                    Disponibilite = reader.GetInt32(4) == 1
                });
            }
            return list;
        }

        public void Add(Piece piece)
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO pieces (Nom, Reference, Prix, Disponibilite) VALUES (@Nom, @Ref, @Prix, @Disp)";
            using var cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@Nom", piece.Nom);
            cmd.Parameters.AddWithValue("@Ref", piece.Reference);
            cmd.Parameters.AddWithValue("@Prix", piece.Prix);
            cmd.Parameters.AddWithValue("@Disp", piece.Disponibilite ? 1 : 0);
            cmd.ExecuteNonQuery();
        }

        public void Update(Piece piece)
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();
            string query = "UPDATE pieces SET Nom=@Nom, Reference=@Ref, Prix=@Prix, Disponibilite=@Disp WHERE Id=@Id";
            using var cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@Nom", piece.Nom);
            cmd.Parameters.AddWithValue("@Ref", piece.Reference);
            cmd.Parameters.AddWithValue("@Prix", piece.Prix);
            cmd.Parameters.AddWithValue("@Disp", piece.Disponibilite ? 1 : 0);
            cmd.Parameters.AddWithValue("@Id", piece.Id);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();
            string query = "DELETE FROM pieces WHERE Id=@Id";
            using var cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
