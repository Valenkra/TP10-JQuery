using System.Data.SqlClient;
using Dapper;

public static class BD {
    private static string _connectionString = @"Server=localhost;
            DataBase=BDSeries; Trusted_Connection=True;";

    public static List<Actores> ObtenerActores(int IdSeries){
            List<Actores> _ObtenerActor = new List<Actores>();
            using(SqlConnection db = new SqlConnection(_connectionString) ){
                string SQL = "SELECT * FROM Actores WHERE IdSerie = @serie";
                _ObtenerActor =  db.Query<Actores>(SQL, new {serie = IdSeries}).ToList();
            }
            return _ObtenerActor;
        }
    
    public static List<Series> ObtenerSeries(){
        List<Series> _ObtenerSeries = new List<Series>();
        using(SqlConnection db = new SqlConnection(_connectionString) ){
            string SQL = "SELECT * FROM Series";
            _ObtenerSeries =  db.Query<Series>(SQL).ToList();
        }
        return _ObtenerSeries;
    }

    public static Series ObtenerSerie(int IdSerie){
        Series _ObtenerSerie = null;
        using(SqlConnection db = new SqlConnection(_connectionString) ){
            string SQL = "SELECT * FROM Series WHERE IdSerie = @serie";
            _ObtenerSerie =  db.QueryFirstOrDefault<Series>(SQL, new {serie = IdSerie});
        }
        return _ObtenerSerie;
    }

    public static List<Temporadas> ObtenerTemporadas(int IdSerie){
            List<Temporadas> _ObtenerTemp = new List<Temporadas>();
            using(SqlConnection db = new SqlConnection(_connectionString) ){
                string SQL = "SELECT * FROM Temporadas WHERE IdSerie = @serie";
                _ObtenerTemp =  db.Query<Temporadas>(SQL, new {serie = IdSerie}).ToList();
            }
            return _ObtenerTemp;
    }
}