

using System;
using System.Collections.Generic;
using System.Data;
using DashboardLiveChartsExamplo.Models;
using MySql.Data.MySqlClient;


namespace DashboardLiveChartsExample
{
    public class DatabaseServices

    { 
        
        private readonly string _connectionString;
        private string server;

        public DatabaseServices(string server, string database, string userId, string password)
        {
            _connectionString = $"Server={server};Database={database};Uid={userId};Pwd={password};";
        }

        public DatabaseServices(string server)
        {
            this.server = server;
        }

        public List<VendaMensal> ObterVendasMensais()
        {
            var vendas = new List<VendaMensal>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT Mes, Valor FROM VendasMensais ORDER BY FIELD(Mes, 'Jan', 'Fev', 'Mar', 'Abr', 'Mai', 'Jun', 'Jul', 'Ago', 'Set', 'Out', 'Nov', 'Dez')", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        vendas.Add(new VendaMensal
                        {
                            Mes = reader.GetString("Mes"),
                            Valor = reader.GetDecimal("Valor")
                        });
                    }
                }
            }

            return vendas;
        }

        public List<ParticipacaoMercado> ObterMarketShare()
        {
            var marketShare = new List<ParticipacaoMercado>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT Empresa, Percentual FROM MarketShare", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        marketShare.Add(new ParticipacaoMercado
                        {
                            Empresa = reader.GetString("Empresa"),
                            Percentual = reader.GetDecimal("Percentual")
                        });
                    }
                }
            }

            return marketShare;
        }

        public List<KPI> ObterKPIs()
        {
            var kpis = new List<KPI>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT Nome, Valor, Unidade FROM KPIs", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        kpis.Add(new KPI
                        {
                            Nome = reader.GetString("Nome"),
                            Valor = reader.GetDecimal("Valor"),
                            Unidade = reader.GetString("Unidade")
                        });
                    }
                }
            }

            return kpis;
        }
    }
}
             
    