using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using World;
using System;

namespace World.Models
{
  public class Country
  {
    private string _code;
    private string _name;
    private string _continent;
    private string _region;
    private int _population;

    public Country(string code, string name, string continent, string region, int population)
    {
      _code = code;
      _name = name;
      _continent = continent;
      _region = region;
      _population = population;
    }

    public string GetCode()
    {
      return _code;
    }

    public string GetName()
    {
      return _name;
    }

    public string GetContinent()
    {
      return _continent;
    }

    public string GetRegion()
    {
      return _region;
    }

    public int GetPopulation()
    {
      return _population;
    }

    public static List<Country> GetAll()
    {
      List<Country> allCountries = new List<Country> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT Code, Name, Continent, Region, Population, Capital FROM Country;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while (rdr.Read())
      {
        string countryCode = rdr.GetString(0);
        string countryName = rdr.GetString(1);
        string countryContinent = rdr.GetString(2);
        string countryRegion = rdr.GetString(3);
        int countryPopulation = rdr.GetInt32(4);
        Country newCountry = new Country(countryCode, countryName, countryContinent, countryRegion, countryPopulation);
        allCountries.Add(newCountry);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allCountries;
    }

    public static List<Country> Filter(string codeInput, string nameInput, string continentInput, string regionInput, string minPopulation, string maxPopulation)
    {
      List<Country> filterCountries = new List<Country> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;

      if (minPopulation == "")
      {
        minPopulation = "(SELECT MIN(Population) FROM Country)";
      }
      if (maxPopulation == "")
      {
        maxPopulation = "(SELECT MAX(Population) FROM Country)";
      }

      cmd.CommandText = @"SELECT Code, Name, Continent, Region, Population FROM Country WHERE Code LIKE '%" + codeInput + "%' AND Name LIKE '%" + nameInput + "%' AND Continent LIKE '%" + continentInput + "%' AND Region LIKE '%" + regionInput + "%' AND Population BETWEEN " + minPopulation + " AND " + maxPopulation + ";";

      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while (rdr.Read())
      {
        string countryCode = rdr.GetString(0);
        string countryName = rdr.GetString(1);
        string countryContinent = rdr.GetString(2);
        string countryRegion = rdr.GetString(3);
        int countryPopulation = rdr.GetInt32(4);
        Country newCountry = new Country(countryCode, countryName, countryContinent, countryRegion, countryPopulation);
        filterCountries.Add(newCountry);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return filterCountries;
    }

    public static List<Country> RandomCountry()
    {
      List<Country> allCountries = new List<Country> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT Code, Name, Continent, Region, Population, Capital FROM Country ORDER BY RAND() LIMIT 1;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while (rdr.Read())
      {
        string countryCode = rdr.GetString(0);
        string countryName = rdr.GetString(1);
        string countryContinent = rdr.GetString(2);
        string countryRegion = rdr.GetString(3);
        int countryPopulation = rdr.GetInt32(4);
        Country newCountry = new Country(countryCode, countryName, countryContinent, countryRegion, countryPopulation);
        allCountries.Add(newCountry);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allCountries;
    }
  }
}
