using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebWeatherApi.Models;

namespace WebWeatherApi.DataAccess
{
    public class DataContext
    {
        private string connectionString = "Server=193.106.164.115;Port=3306;Database=mydb;Uid=michael;Pwd=IDKm4n0r4ng3S33msKind4SUS!;";

        public Place GetPlace(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("idIn", id);

                return connection.QueryFirstOrDefault<Place>("GetPlaceWithId", parameters, commandType: CommandType.StoredProcedure, commandTimeout: 10);
            }
        }


        public List<Place> GetAllPlaces()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                return connection.Query<Place>("GetAllPlaces", null, commandType: CommandType.StoredProcedure, commandTimeout: 10).ToList();
            }
        }
    }
}
